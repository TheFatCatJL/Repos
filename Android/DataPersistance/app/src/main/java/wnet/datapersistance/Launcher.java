package wnet.datapersistance;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

public class Launcher extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_launcher);
        Toolbar myToolbar = (Toolbar) findViewById(R.id.mytoolbar);
        setSupportActionBar(myToolbar);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.actionbar, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.item1:
                Toast.makeText(Launcher.this,
                        "Moving to Shared preferences", Toast.LENGTH_SHORT).show();
                Intent spintent = new Intent(this, MainActivity.class);
                startActivity(spintent);
                return true;
            case R.id.item2:
                Toast.makeText(Launcher.this,
                        "Moving to ReadWrite", Toast.LENGTH_SHORT).show();
                Intent rwintent = new Intent(this, ReadWriteFile.class);
                startActivity(rwintent);
                return true;
            case R.id.item3:
                Toast.makeText(Launcher.this,
                        "Moving to NetworkActivity", Toast.LENGTH_SHORT).show();
                Intent nwintent = new Intent(this, MyNetworkActivity.class);
                startActivity(nwintent);
                return true;

            case R.id.item4:
                Toast.makeText(Launcher.this,
                        "Moving to Save Instance", Toast.LENGTH_SHORT).show();
                Intent siintent = new Intent(this, SaveInstance.class);
                startActivity(siintent);
                return true;

            default:
                return super.onOptionsItemSelected(item);
        }
    }

}
