package com.home.mediaremoteclient;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.home.mediaremoteclient.databinding.ActivityMainBinding;


public class MainActivity extends AppCompatActivity {

    private Settings settings;
    private Server server;
    private ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        settings = new Settings(this);
        server = new Server(this);

        binding.btnSeekBackward.setOnClickListener(this::buttonClick);
        binding.btnPlay.setOnClickListener(this::buttonClick);
        binding.btnSeekForward.setOnClickListener(this::buttonClick);
        binding.btnVolumeDown.setOnClickListener(this::buttonClick);
        binding.btnAudio.setOnClickListener(this::buttonClick);
        binding.btnVolumeUp.setOnClickListener(this::buttonClick);
        binding.btnSkipBackward.setOnClickListener(this::buttonClick);
        binding.btnSubtitle.setOnClickListener(this::buttonClick);
        binding.btnSkipForward.setOnClickListener(this::buttonClick);

        binding.btnSettings.setOnClickListener(view -> {
            final Intent intent = new Intent(this, SettingsActivity.class);
            startActivity(intent);
        });
    }

    @Override
    protected void onResume() {
        super.onResume();
        findServer();
    }

    private void buttonClick(View view) {
        String action = view.getTag().toString();
        //System.out.println(action);
        server.request(action, result -> {
            if (!result.ok()) {
                findServer();
            }
        });
    }

    private void findServer() {
        final String serverName = settings.getServerName();

        if (serverName.equals("")) {
            binding.txtInfo.setText("Go to settings and choose a server");
        } else {
            server.setHostname(serverName);
            binding.txtInfo.setText("Searching server " + serverName);

            server.find(result -> {
                runOnUiThread(() -> {
                    if (result.ok()) {
                        final String ip = result.value();
                        binding.txtInfo.setText("Server " + serverName + " found at " + ip);
                    } else {
                        binding.txtInfo.setText("Server " + serverName + " not found");
                    }
                });
            });
        }
    }
}