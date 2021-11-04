package com.example.ex1;

import androidx.appcompat.app.AppCompatActivity;

import android.app.NotificationManager;
import android.content.Context;
import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.media.AudioManager;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
{
    private AudioManager mAudioManager;
    private boolean mModoSilencio;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //inicializar AudioManager
        mAudioManager = (AudioManager)getSystemService(AUDIO_SERVICE);
        adicionaEventoBotao();
        verificaEstadoRinger();
        alteraIconSonoro();
    }

    @Override
    protected void onResume()
    {
        super.onResume();
        //Obter o NotificationManager para verificar se temos permissão para alterar o ringermode
        NotificationManager notificationManager =
                (NotificationManager) this.getSystemService(Context.NOTIFICATION_SERVICE);
        /* Só necessitamos de pedir autorização no Android 6.0 Marshmallow ou superior e só se
         * realmente não tivermos permissões. */
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M && !notificationManager.isNotificationPolicyAccessGranted())
        {
            //Construímos o intent que nos permite aceder às permissões que temos de dar à app.
            Intent intent = new Intent(android.provider.Settings.ACTION_NOTIFICATION_POLICY_ACCESS_SETTINGS);
            //Lançamos a actividade com base no intent.
            startActivity(intent);
        }
    }

    /* Adiciona o listener ao botaoOnOff. Sempre que o botão for premido,
     * o código fornecido será executado. Isto é programação orientada a eventos. */
    private void adicionaEventoBotao()
    {
        Button botao = (Button)findViewById(R.id.botaoOnOff);
        botao.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v)
            {
                if(mModoSilencio)
                {
                    mAudioManager.setRingerMode(AudioManager.RINGER_MODE_NORMAL);
                    mModoSilencio = false;
                }
                else
                {
                    mAudioManager.setRingerMode(AudioManager.RINGER_MODE_SILENT);
                    mModoSilencio = true;
                }
                alteraIconSonoro();
            }
        });
    }

    /* Este método afeta ao atributo <b>mModoSilencio</b> o valor <i>true</i> se o ringer
estiver
 * em modo silencio ou em vibração e <i>false</i> se estiver em modo normal. */
    private void verificaEstadoRinger() {
        //obter o estado do ringer
        int estado = mAudioManager.getRingerMode();
        //comparar com as constantes de classe pré-definidas
        if(estado == AudioManager.RINGER_MODE_NORMAL) {
            mModoSilencio = false;
        } else {
            mModoSilencio = true;
        }
    }
    /* Este método é responsável por colocar o icon correto mediante o estado do ringer */
    private void alteraIconSonoro()
    {
        //Obter referencia para controlo ImageView do ecrã
        ImageView imgView = findViewById(R.id.imagemSom);
        //Obter referencia para controlo TextView do ecrã
        TextView txtView = findViewById(R.id.textoModoSom);
        //Referencia que irá guardar a nova imagem a ser mostrada no controlo imgView
        Drawable img;
        //String para guardar o texto a colocar na textview
        String s;
        //Alterar a imagem e texto mostrados conforme o modo atual.
        if(mModoSilencio)
        {
            imgView.setImageResource(R.drawable.no_sound);
            txtView.setText(R.string.texto_som_silencioso);
        }
        else
        {
            imgView.setImageResource(R.drawable.full_sound);
            txtView.setText(R.string.texto_som_normal);
        }
    }
}