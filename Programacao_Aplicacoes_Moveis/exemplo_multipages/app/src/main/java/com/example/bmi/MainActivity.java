package com.example.bmi;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.activity_main, menu);
        return true;
    }
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_help) {
            Intent intent = new Intent(MainActivity.this, activity_help.class);
            startActivity(intent);
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btnCalculate = (Button) findViewById(R.id.btnCalculate);
        btnCalculate.setOnClickListener(v -> {
            EditText inputHeight = (EditText) findViewById(R.id.inputHeight);
            EditText inputWeight = (EditText) findViewById(R.id.inputWeight);

            try {
                double height = Double.parseDouble(inputHeight.getText().toString());
                double weight = Double.parseDouble(inputWeight.getText().toString());

                Intent intent = new Intent(MainActivity.this, activity_result.class);
                intent.putExtra(activity_result.VALUE_HEIGHT, height);
                intent.putExtra(activity_result.VALUE_WEIGHT, weight);
                startActivity(intent);
            } catch (Exception e) {
                Toast.makeText(MainActivity.this, R.string.toastInvalidInputs, Toast.LENGTH_SHORT).show();
            }
            //OU if(!inputHeight.getText().toString().equals("") && !inputWeight.getText().toString().equals(""))
        });
    }
}