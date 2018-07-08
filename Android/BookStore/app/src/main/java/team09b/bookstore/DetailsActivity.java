package team09b.bookstore;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v4.content.ContextCompat;
import android.support.v4.graphics.drawable.DrawableCompat;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import org.json.JSONObject;

import java.net.URI;
import java.net.URL;
import java.util.List;

public class DetailsActivity extends Activity {

    final static int []view = {R.id.editText1, R.id.editText2, R.id.editText3, R.id.editText4, R.id.editText5, R.id.editText6, R.id.editText7, R.id.editText8};
    final static String []key = {"BookID", "Title", "CategoryID", "ISBN", "Author", "Stock", "Price", "BookDiscount"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);
        String item = getIntent().getExtras().getString("Id");
        new AsyncTask<String, Void, Book>() {
            @Override
            protected Book doInBackground(String... params) {
                return Book.getBook(params[0]);
            }
            @Override
            protected void onPostExecute(Book result) {
                for (int i=0; i<view.length; i++) {
                    EditText t = (EditText) findViewById(view[i]);
                    t.setText(result.get(key[i]));
                }
                String name = "i"+result.get("ISBN");
                Context c = getApplicationContext();
                int i = c.getResources().getIdentifier(name, "drawable", c.getPackageName());
                Drawable res = ContextCompat.getDrawable(c,i);
                ImageView image = (ImageView) findViewById(R.id.imageView);
                image.setImageDrawable(res);

            }
        }.execute(item);

        Button b = (Button) findViewById(R.id.button);
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Book b = new Book();
                for (int i=0; i<view.length; i++) {
                    EditText t = (EditText) findViewById(view[i]);
                    b.put(key[i], t.getText().toString());
                }
                new AsyncTask<Book, Void, Void>() {
                    @Override
                    protected Void doInBackground(Book... params) {
                        Book.updateBook(params[0]);
                        return null;
                    }
                    @Override
                    protected void onPostExecute(Void result) {
                        finish();
                    }
                }.execute(b);
            }
        });
    }

}