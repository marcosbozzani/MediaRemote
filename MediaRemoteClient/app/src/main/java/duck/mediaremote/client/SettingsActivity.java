package duck.mediaremote.client;

import android.os.Bundle;
import android.view.Gravity;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Objects;

import duck.mediaremote.client.databinding.ActivitySettingsBinding;

public class SettingsActivity extends AppCompatActivity {

    private Settings settings;
    private ActivitySettingsBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivitySettingsBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        Objects.requireNonNull(getSupportActionBar()).setTitle(getString(R.string.settings));

        settings = new Settings(this);

        binding.txtServerName.setText(settings.getServerName());
        binding.swtVibration.setChecked(settings.getUseButtonVibration());
        binding.txtBuild.setText(String.format("%s (%s)", BuildConfig.BUILD_TIME, BuildConfig.BUILD_TYPE));

        binding.btnSave.setOnClickListener(view -> {
            settings.setServerName(binding.txtServerName.getText().toString());
            settings.setUseButtonVibration(binding.swtVibration.isChecked());
            Toast toast = Toast.makeText(this, getString(R.string.settings_saved), Toast.LENGTH_SHORT);
            toast.setGravity(Gravity.TOP, 0, 0);
            toast.show();
        });
    }
}