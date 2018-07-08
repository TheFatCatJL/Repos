package calculator.cal;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class Launcher extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_launcher);

        Button CalLauncherButton = findViewById(R.id.buttonCalLauncher);
        CalLauncherButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(Launcher.this,
                        "Moving to calculator", Toast.LENGTH_SHORT).show();
                Intent CalculatorIntent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(CalculatorIntent);
            }
        });
    }
}
