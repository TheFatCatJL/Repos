package calculator.cal;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;


public class MainActivity extends AppCompatActivity {

    Button button0 , button1 , button2 , button3 , button4 , button5 , button6 ,
            button7 , button8 , button9 , buttonAdd , buttonSub , buttonDivision ,
            buttonMul , button10 , buttonC , buttonEqual ;

    EditText edt1 ;
    float mValueOne=0;
    float mValueTwo=0;

    boolean mAddition , mSubtract ,mMultiplication ,mDivision ;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        button0 = findViewById(R.id.ButtonZero);
        button1 = findViewById(R.id.Button1);
        button2 = findViewById(R.id.Button2);
        button3 = findViewById(R.id.Button3);
        button4 = findViewById(R.id.Button4);
        button5 = findViewById(R.id.Button5);
        button6 = findViewById(R.id.Button6);
        button7 = findViewById(R.id.Button7);
        button8 = findViewById(R.id.Button8);
        button9 = findViewById(R.id.Button9);
        button10 = findViewById(R.id.ButtonDot);
        buttonAdd = findViewById(R.id.ButtonPlus);
        buttonSub = findViewById(R.id.ButtonMinus);
        buttonMul = findViewById(R.id.ButtonMul);
        buttonDivision = findViewById(R.id.ButtonDiv);
        buttonC = findViewById(R.id.ButtonClear);
        buttonEqual = findViewById(R.id.ButtonEqual);
        edt1 = findViewById(R.id.CalDisplay);

        button0.setOnClickListener(Button0Listener);
        button1.setOnClickListener(Button1Listener);
        button2.setOnClickListener(Button2Listener);
        button3.setOnClickListener(Button3Listener);
        button4.setOnClickListener(Button4Listener);
        button5.setOnClickListener(Button5Listener);
        button6.setOnClickListener(Button6Listener);
        button7.setOnClickListener(Button7Listener);
        button8.setOnClickListener(Button8Listener);
        button9.setOnClickListener(Button9Listener);
        button10.setOnClickListener(ButtonDotListener);
        buttonAdd.setOnClickListener(ButtonAddListener);
        buttonSub.setOnClickListener(ButtonMinusListener);
        buttonMul.setOnClickListener(ButtonMulListener);
        buttonDivision.setOnClickListener((ButtonDivListener));
        buttonEqual.setOnClickListener(ButtonEqualListener);
        buttonC.setOnClickListener(ButtonClearListener);
    }

    private void reseterror()
    {
        if(edt1.getText().toString().isEmpty())
            return;

        if(edt1.getText().toString().contentEquals("-Error-"))
            edt1.setText(null);
    }

    private void edtparser (String parsing)
    {
        String settext;

        if (edt1.getText().toString().isEmpty()) {
            settext = parsing;
        }
        else if(edt1.getText().toString().contains(".") && parsing == ".") {
            return;
        }
        else if(!edt1.getText().toString().contains(".") && parsing == ".") {
            settext = edt1.getText().toString() + parsing;
        }
        else if(Float.parseFloat(edt1.getText().toString())!=0) {
            settext = edt1.getText().toString() + parsing;
        }
        else {
            settext = parsing;
        }
        edt1.setText(settext);
    }

    private View.OnClickListener Button1Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("1");
        }
    };




    private View.OnClickListener Button2Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("2");
        }
    };

    private View.OnClickListener Button3Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("3");
        }
    };

    private View.OnClickListener Button4Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("4");
        }
    };

    private View.OnClickListener Button5Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("5");
        }
    };

    private View.OnClickListener Button6Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("6");
        }
    };

    private View.OnClickListener Button7Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("7");
        }
    };

    private View.OnClickListener Button8Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("8");
        }
    };

    private View.OnClickListener Button9Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser("9");
        }
    };

    private View.OnClickListener Button0Listener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            reseterror();
            edtparser("0");
        }
    };

    private View.OnClickListener ButtonDotListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            reseterror();
            edtparser(".");
        }
    };

    private void ResetOperations()
    {
        mAddition = false;
        mSubtract = false;
        mDivision = false;
        mMultiplication = false;
    }

    private void setOperations(String ops)
    {
        if (ops == "add")
        {
            ResetOperations();
            mAddition = true;
        }
        if (ops == "aub")
        {
            ResetOperations();
            mSubtract = true;
        }
        if (ops == "mul")
        {
            ResetOperations();
            mMultiplication = true;
        }
        if (ops == "div")
        {
            ResetOperations();
            mDivision = true;
        }
    }



    private View.OnClickListener ButtonAddListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            if (edt1 == null){
                edt1.setText(null);
                setOperations("add");
            }

            else {
                mValueOne = Float.parseFloat(edt1.getText().toString());
                setOperations("add");
                edt1.setText(null);
            }
        }
    };
    private View.OnClickListener ButtonMinusListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if (edt1 == null){
                edt1.setText(null);
                setOperations("sub");
            }

            else {
                mValueOne = Float.parseFloat(edt1.getText().toString());
                setOperations("sub");
                edt1.setText(null);
            }
        }
    };

    private View.OnClickListener ButtonMulListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if (edt1 == null){
                edt1.setText(null);
                setOperations("mul");
            }

            else {
                mValueOne = Float.parseFloat(edt1.getText().toString());
                setOperations("mul");
                edt1.setText(null);
            }

        }
    };

    private View.OnClickListener ButtonDivListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if (edt1 == null){
                edt1.setText(null);
                setOperations("div");
            }

            else {
                mValueOne = Float.parseFloat(edt1.getText().toString());
                setOperations("div");
                edt1.setText(null);
            }
        }
    };


    private View.OnClickListener ButtonEqualListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            if(edt1.getText().toString().isEmpty())
            {
                edt1.setText("-Error-");
                mValueOne = 0;
                mValueTwo = 0;
                ResetOperations();
                return;
            }

            mValueTwo = Float.parseFloat(edt1.getText().toString());

            if (mAddition == true){

                edt1.setText(mValueOne + mValueTwo +"");
                mAddition=false;
            }


            if (mSubtract == true){
                edt1.setText(mValueOne - mValueTwo+"");
                mSubtract=false;
            }

            if (mMultiplication == true){
                edt1.setText(mValueOne * mValueTwo+"");
                mMultiplication=false;
            }

            if (mDivision == true){
                edt1.setText(mValueOne / mValueTwo+"");
                mDivision=false;
            }
        }
    };


    private View.OnClickListener ButtonClearListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            edt1.setText("0");
            mValueOne = 0;
            ResetOperations();
        }
    };



}
