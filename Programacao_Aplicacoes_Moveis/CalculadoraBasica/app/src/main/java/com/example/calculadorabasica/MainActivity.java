package com.example.calculadorabasica;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private EditText num1;
    private EditText num2;
    private EditText res;
    private double valor1;
    private double valor2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        num1 = (EditText) findViewById(R.id.TextNum1);
        num2 = (EditText) findViewById(R.id.TextNum2);
        res = (EditText) findViewById(R.id.TextResult);
        res.setFocusable(false);
////////////////////////////////////////////////////////
        //btnSoma
        Button btnSoma = (Button) findViewById(R.id.btnSoma);
        btnSoma.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                if(MainActivity.this.updateValores()){
                    res.setText((String.valueOF(valor1 + valor2)));
                }
            }
        });
        //btnSub
        Button btnSub = (Button) findViewById(R.id.btnSub);
        btnSub.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                if(MainActivity.this.updateValores()){
                    res.setText((String.valueOF(valor1 - valor2)));
                }
            }
        });
        //btnMulti
        Button btnMulti = (Button) findViewById(R.id.btnMulti);
        btnMulti.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                if(MainActivity.this.updateValores()){
                    res.setText((String.valueOF(valor1 * valor2)));
                }
            }
        });
        //btnDiv
        Button btnDiv = (Button) findViewById(R.id.btnDiv);
        btnDiv.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                if(MainActivity.this.updateValores()){
                    if(valor2 == 0.0 || valor1 == 0.0){
                      // res.setText("Erro! Divisão por Zero!!");
                        res.setText("");
                        Toast.makeText(context:MainActivity.this, text:"Erro! divisão por zero!!", Toast.LENGTH_SHORT).show();
                    } else {
                        res.setText((String.valueOF(valor1 / valor2)));
                    }
                }
            }
        });
////////////////////////////////////////////////////////

        private boolean updateValores() {
            try {
                valor1 = Double.parseDouble(num1.getText().toString());
                valor2 = Double.parseDouble(num2.getText().toString());
                return true;
            } catch (Exception ex) {
                //res.setText(ex.getMessage());
                res.setText();
                Toast.makeText(context:MainActivity.this, ex.Message(), Toast.LENGTH_SHORT).show();
                return false;
            }
        }
    }
}