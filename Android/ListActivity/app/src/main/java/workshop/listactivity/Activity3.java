package workshop.listactivity;

import android.app.ListActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class Activity3 extends ListActivity {
    List<Student> students;
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
        getData();
        setListAdapter(new SimpleAdapter
                (this, students, android.R.layout.simple_list_item_2,
                        new String[]{"name", "age"},
                        new int[]{ android.R.id.text1, android.R.id.text2}));
    }

    @Override
    public void onListItemClick(ListView l, View v, int position, long id) {
        Student s = (Student) getListAdapter().getItem(position);
        Toast.makeText(getApplicationContext(), s.get("name") + " selected",
                Toast.LENGTH_LONG).show();
    }

}
