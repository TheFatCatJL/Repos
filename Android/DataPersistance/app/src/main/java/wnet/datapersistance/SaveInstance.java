package wnet.datapersistance;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class SaveInstance extends AppCompatActivity {

    String address;
    int age;

    @Override
    public void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putString("Address", address);
        outState.putInt("Age", age);
    }

    void restoreInstance(Bundle state) {
        if (state != null) {
            address = state.getString("Address");
            age = state.getInt("Age");
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_save_instance);
        address = getString(R.string.address);
        age = Integer.parseInt(getString(R.string.age));
        restoreInstance(savedInstanceState);
        TextView tv1 = findViewById(R.id.textViewSI1);
        TextView tv2 = findViewById(R.id.textViewSI2);
        tv1.setText(address);
        tv2.setText(age+"");
    }
}
