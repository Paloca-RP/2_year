package com.example.animais;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btncao = (Button) findViewById(R.id.btncao);
        Button btngato = (Button) findViewById(R.id.btngato);
        Button btnpassaro = (Button) findViewById(R.id.btnpassaro);

        final ImageView imageView = (ImageView) findViewById(R.id.imageView);

        btncao.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                imageView.setImageResource(R.drawable.dog);
            }
        });
        btngato.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                imageView.setImageResource(R.drawable.cat);
            }
        });
        btnpassaro.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                imageView.setImageResource(R.drawable.bird);
            }
        });
    }
}