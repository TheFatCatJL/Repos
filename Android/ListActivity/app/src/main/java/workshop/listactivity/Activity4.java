package workshop.listactivity;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class Activity4 extends Activity implements OnItemClickListener {
    private List<Student> students;
    private void getData() {
        students = new ArrayList<Student>();
        students.add(new Student("Tan Ah Kow", 12, "Smart School"));
        students.add(new Student("Lim Ah Pin", 11, "Rich School"));
        students.add(new Student("Teo Wong Heng", 14, "Low School"));
        students.add(new Student("Ho Go Woo", 15, "River School"));
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.list);
        getData();
        ListView lv = (ListView) findViewById(R.id.listView1);
        lv.setAdapter(new SimpleAdapter
                (this, students, R.layout.row2, new String[]{"name", "age"},
                        new int[]{ R.id.text1, R.id.text2}));
        lv.setOnItemClickListener(this);
    }

    @Override
    public void onItemClick(AdapterView<?> av, View v, int position, long id) {
        Student s = (Student) av.getAdapter().getItem(position);
        Toast.makeText(getApplicationContext(), s.get("name") + " selected",
                Toast.LENGTH_LONG).show();
    }
}