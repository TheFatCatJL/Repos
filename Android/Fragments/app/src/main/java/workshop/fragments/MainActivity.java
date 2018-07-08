package workshop.fragments;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.mainmenu,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch(item.getItemId()) {
            case R.id.menuitem1:
                Intent ldintent = new Intent(this,ListingActivity.class);
                startActivity(ldintent);
                return true;
            case R.id.menuitem2:
                return true;
            case R.id.menuitem3:
                return true;
            case R.id.menuitem4:
                return true;
            case R.id.menuitem5:
                return true;
            case R.id.menuitem6:
                return true;
            default:
            return super.onOptionsItemSelected(item);
        }
    }
}
