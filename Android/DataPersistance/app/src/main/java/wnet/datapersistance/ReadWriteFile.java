package wnet.datapersistance;

import android.os.Bundle;
import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;

public class ReadWriteFile extends AppCompatActivity {

    EditText txt1, txt2;
    final String filename = "abc.txt";

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_read_write_file);
        txt1 = (EditText) findViewById(R.id.editText1);
        txt2 = (EditText) findViewById(R.id.editText2);
    }

    public void Write(View v) {
        String contents = txt1.getText().toString();
        try {

            //External Storage
            File file = Environment.getExternalStoragePublicDirectory(filename);
            FileOutputStream f = new FileOutputStream(file);
            //Internal storage
//            FileOutputStream f = openFileOutput(filename, Context.MODE_PRIVATE);
            PrintWriter w = new PrintWriter(f);
            w.println(contents);
            w.close();
            f.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void Read(View v) {
        StringBuilder buf = new StringBuilder();
        try {

            //External Storage
            File file = Environment.getExternalStoragePublicDirectory(filename);
            FileInputStream fis = new FileInputStream(file);
            //internal storage
//            FileInputStream fos = openFileInput(filename);

            BufferedReader r = new BufferedReader(new InputStreamReader(fis));
            String s;
            while ((s = r.readLine()) != null) {
                buf.append(s);
                buf.append("\r\n");
            }
            r.close();
            fis.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
        txt2.setText(buf.toString());
    }
}
