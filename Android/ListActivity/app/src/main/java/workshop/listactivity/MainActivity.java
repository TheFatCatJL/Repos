package workshop.listactivity;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        getMenuInflater().inflate(R.menu.mainmenu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        switch (item.getItemId())
        {
            case R.id.list1:
                Intent intent1 = new Intent(this, Activity1.class);
                startActivity(intent1);
                return true;
            case R.id.list2:
                Intent intent2 = new Intent(this, Activity2.class);
                startActivity(intent2);
                return true;
            case R.id.list3:
                Intent intent3 = new Intent(this, Activity3.class);
                startActivity(intent3);
                return true;
            case R.id.list4:
                Intent intent4 = new Intent(this, Activity4.class);
                startActivity(intent4);
                return true;
            case R.id.newsactivity:
                Intent intent5 = new Intent(this, NewsActivity.class);
                startActivity(intent5);
                return true;
            case R.id.newsactivity2:
                Intent intent6 = new Intent(this, NewsActivity2.class);
                startActivity(intent6);
                return true;
            case R.id.empactivity:
                Intent intent7 = new Intent(this, EmployeeMain.class);
                startActivity(intent7);
                return true;
            case R.id.empactivity2:
                Intent intent8 = new Intent(this, EmployeeMain2.class);
                startActivity(intent8);
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

}
