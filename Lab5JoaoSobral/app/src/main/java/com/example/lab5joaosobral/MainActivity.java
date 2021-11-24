package com.example.lab5joaosobral;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        Button button = (Button) findViewById(R.id.calcular);
        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                EditText textBallance =(EditText)findViewById(R.id.textBallance);
                EditText textRate =(EditText)findViewById(R.id.textRate);
                EditText paymentMonth=(EditText)findViewById(R.id.paymentMonth);

                if (textBallance.getText().toString().equals("") || textRate.getText().toString().equals("") ||
                        paymentMonth.getText().toString().equals(""))
                {
                    Context context = getApplicationContext();
                    CharSequence text = "CAMPOS AINDA POR PREENCHER";
                    int duration = Toast.LENGTH_SHORT;

                    Toast toast = Toast.makeText(context, text, duration);
                    toast.show();
                }
                else
                {
                    double ballances = Double.parseDouble(textBallance.getText().toString());
                    double rates =  Double.parseDouble(textRate.getText().toString());
                    double payments =  Double.parseDouble(paymentMonth.getText().toString());

                    textBallance.setText("");
                    textRate.setText("");
                    paymentMonth.setText("");

                    Intent intent = new Intent(MainActivity.this, ResultActivity.class);
                    intent.putExtra(ResultActivity.VALUE_BALLANCE, ballances);
                    intent.putExtra(ResultActivity.VALUE_INTEREST_RATE, rates);
                    intent.putExtra(ResultActivity.VALUE_PAYMENT_PER_MONTH, payments);
                    startActivity(intent);
                }


            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu){
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }


    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.action_help) {
            Intent intent = new Intent(MainActivity.this, About.class);
            startActivity(intent);
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}