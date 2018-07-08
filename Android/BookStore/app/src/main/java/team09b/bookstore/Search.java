package team09b.bookstore;

import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import java.util.ArrayList;

public class Search extends AppCompatActivity {

    SharedPreferences pref;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_search);
        pref = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
        final EditText searchstring = (EditText) findViewById(R.id.editTextSearch);
        final EditText pricestring = (EditText) findViewById(R.id.editTextPrice);
        Button searchbutton = (Button) findViewById(R.id.buttonSearch1);
        final Button pricebutton = (Button) findViewById(R.id.buttonSearch2);

        searchbutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String params = searchstring.getText().toString();
                SharedPreferences.Editor editor = pref.edit();
                editor.putString("pricepara", "");
                editor.putString("searchpara", params);
                editor.commit();
                Intent main = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(main);

            }
        });

        pricebutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String params = pricestring.getText().toString();
                SharedPreferences.Editor editor = pref.edit();
                editor.putString("searchpara", "");
                editor.putString("pricepara", params);
                editor.commit();
                Intent main = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(main);
            }
        });

    }

    private void gotoMain()
    {

    }


}
