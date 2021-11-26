package com.example.lab5;

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

        Button button = (Button) findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                EditText txtBallance = (EditText) findViewById(R.id.txtBalance);
                EditText txtRate = (EditText) findViewById(R.id.txtRate);
                EditText payment = (EditText) findViewById(R.id.txtPayment);

                if (txtBallance.getText().toString().equals("") || txtRate.getText().toString().equals("") || payment.getText().toString().equals("")) {
                    Context context = getApplicationContext();
                    CharSequence text = "CAMPOS AINDA POR PREENCHER";
                    int duration = Toast.LENGTH_SHORT;

                    Toast toast = Toast.makeText(context, text, duration);
                    toast.show();
                } else {
                    double ballances = Double.parseDouble(txtBallance.getText().toString());
                    double rates = Double.parseDouble(txtRate.getText().toString());
                    double payments = Double.parseDouble(payment.getText().toString());

                    txtBallance.setText("");
                    txtRate.setText("");
                    payment.setText("");

                    Intent intent = new Intent(MainActivity.this, ResultActivity.class);
                    intent.putExtra(ResultActivity.ballance_, ballances);
                    intent.putExtra(ResultActivity.rate_, rates);
                    intent.putExtra(ResultActivity.payment_, payments);
                    startActivity(intent);
                }
            }
        });
    }
}