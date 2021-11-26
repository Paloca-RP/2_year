package com.example.lab5;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.text.DecimalFormat;

public class ResultActivity extends AppCompatActivity {
    public static final String ballance_ = "VALUE_MONTHS_TO_PAY";
    public static final String rate_ = "VALUE_TOTAL_WILL_PAY";
    public static final String payment_ = "VALUE_TOTAL_PAY_BACK";

    private double juros;
    private double total;
    private double NumMeses;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result);
        Result();

        Button button = findViewById(R.id.button2);
        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                finish();
            }
        });

        Button button2 = findViewById(R.id.button3);
        button2.setOnClickListener( v -> {
            Intent intent = new Intent(ResultActivity.this, AboutActivity.class);
            startActivity(intent);
        });
    }
    private void Result()
    {
        Bundle extras = getIntent().getExtras();
        if (extras == null) {
            return;
        }

        double ballance = extras.getDouble(ballance_);
        double rate = extras.getDouble(rate_);
        double mouth = extras.getDouble(payment_);

        DecimalFormat fmt = new DecimalFormat("0.00");

        juros = ballance *(rate/100);
        total = ballance + juros;
        NumMeses = total/mouth;

        TextView meses = (TextView)findViewById(R.id.view1);
        meses.setText(String.valueOf((fmt.format(NumMeses)+" meses")));

        TextView totalV = (TextView)findViewById(R.id.view2);
        totalV.setText(String.valueOf(juros) + "€");

        TextView mes = (TextView)findViewById(R.id.view3);
        mes.setText(String.valueOf(total) + "€");


    }
}
