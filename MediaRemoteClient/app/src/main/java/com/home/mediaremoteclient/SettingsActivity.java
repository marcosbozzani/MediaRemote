package com.home.mediaremoteclient;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.home.mediaremoteclient.databinding.ActivitySettingsBinding;

public class SettingsActivity extends AppCompatActivity {

    private Settings settings;

    private ActivitySettingsBinding binding;
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySettingsBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        settings = new Settings(this);

        binding.txtServerName.setText(settings.getServerName());
        binding.txtBuild.setText(BuildConfig.BUILD_TIME);

        binding.btnSave.setOnClickListener(view -> {
            settings.setServerName(binding.txtServerName.getText().toString());
            Toast toast = Toast.makeText(this, "Saved", Toast.LENGTH_SHORT);
            toast.setGravity(Gravity.TOP, 0, 0);
            toast.show();
        });
    }
}