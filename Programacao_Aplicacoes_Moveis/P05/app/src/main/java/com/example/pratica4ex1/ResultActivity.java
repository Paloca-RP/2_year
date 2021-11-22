package com.example.pratica4ex1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.TextView;

public class ResultActivity extends AppCompatActivity {

    private double imc;

    public static final String VALUE_HEIGHT = "VALUE_HEIGHT";
    public static final String VALUE_WEIGHT = "VALUE_WEIGHT";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        Bundle extras = getIntent().getExtras();
        if(extras == null)
            return;

        TextView labelWeightResponse = (TextView) findViewById(R.id.labelWeightResponse);
        TextView textResult = (TextView) findViewById(R.id.textResult);
        double height = extras.getDouble(VALUE_HEIGHT);
        double weight = extras.getDouble(VALUE_WEIGHT);
        imc = (weight) / (height * height);
        textResult.setText(String.format("%.2f", imc));

        String texto;
        int cor;
        if (imc < 18.5)
        {
            texto = getResources().getString(R.string.labelUnderWeight);
            cor = getResources().getColor(R.color.labelunderweight);
        }
        else if( imc < 25 )
        {
            texto = getResources().getString(R.string.labelNormalWeight);
            cor = getResources().getColor(R.color.labelnormalweight);
        }
        else
        {
            texto = getResources().getString(R.string.labelOverWeight);
            cor = getResources().getColor(R.color.labeloverweight);
        }

        labelWeightResponse.setText(texto);
        labelWeightResponse.setBackgroundColor(cor);
        Button btnRepeat = (Button) findViewById(R.id.btnRepeat);
        btnRepeat.setOnClickListener(v -> {
            finish();
        });
    }
    private void enviarSMS()
    {
        Intent intent = new Intent(Intent.ACTION_SENDTO);
        intent.setData(Uri.parse("sms:"));
        intent.putExtra(Intent.EXTRA_TEXT, String.format("My BMI result is %.2f", imc));
        startActivity(intent);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.result, menu);
        return true;
    }
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_help) {
            Intent intent = new Intent(ResultActivity.this, HelpActivity.class);startActivity(intent);
            return true;
        } else if (id == R.id.action_send_sms) {
            enviarSMS();
            return true;
            /* Adicione também “getSupportActionBar().setDisplayHomeAsUpEnabled(true);” ao seu método onCreate */
        } else if (id == android.R.id.home) {
            finish();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }
}