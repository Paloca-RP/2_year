package com.example.lab5joaosobral;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.text.DecimalFormat;

public class ResultActivity extends AppCompatActivity {
    public static final String VALUE_BALLANCE = "VALUE_MONTHS_TO_PAY";
    public static final String VALUE_INTEREST_RATE = "VALUE_TOTAL_WILL_PAY";
    public static final String VALUE_PAYMENT_PER_MONTH = "VALUE_TOTAL_PAY_BACK";

    private double totalJuros;
    private double valorTotal;
    private double numeroMeses;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result);
        mostraResultados();

        Button button = findViewById(R.id.btnRepetir);
        button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                finish();
            }
        });
    }

    private void mostraResultados()
    {
        Bundle extras = getIntent().getExtras();
        if (extras == null) {
            return;
        }

        double ballance= extras.getDouble(VALUE_BALLANCE);
        double rate = extras.getDouble(VALUE_INTEREST_RATE);
        double porMouth = extras.getDouble(VALUE_PAYMENT_PER_MONTH);

        DecimalFormat fmt = new DecimalFormat("0.00");

        totalJuros = ballance *(rate/100);
        valorTotal = ballance + totalJuros;
        numeroMeses = valorTotal/porMouth;

        TextView meses = (TextView)findViewById(R.id.numeroMeses);
        meses.setText(String.valueOf((fmt.format(numeroMeses)+"meses")));

        TextView total = (TextView)findViewById(R.id.totalJuros);
        total.setText(String.valueOf(totalJuros) + "€");

        TextView mes = (TextView)findViewById(R.id.valorASerPago);
        mes.setText(String.valueOf(valorTotal) + "€");


    }
}