package duck.mediaremote.client;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.Vibrator;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Objects;

import duck.mediaremote.client.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {

    private Settings settings;
    private Server server;
    private ActivityMainBinding binding;
    private Vibrator vibrator;
    private boolean useVibration;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());
        Objects.requireNonNull(getSupportActionBar()).hide();

        settings = new Settings(this);
        server = new Server(this);
        vibrator = (Vibrator) getSystemService(Context.VIBRATOR_SERVICE);
        useVibration = vibrator != null && settings.getUseButtonVibration();

        View[] buttons = new View[]{
                binding.btnPower,
                binding.btnOutput,
                binding.btnFullscreen,
                binding.btnSettings,
                //
                binding.btnRed,
                binding.btnGreen,
                binding.btnYellow,
                binding.btnBlue,
                //
                binding.btnPrevious,
                binding.btnNext,
                //
                binding.btnRewind,
                binding.btnPlay,
                binding.btnForward,
                //
                binding.btnVolumeDown,
                binding.btnVolumeUp,
                //
                binding.btnAudio,
                binding.btnAudioOff,
                binding.btnSubtitles,
                binding.btnSubtitlesOff
        };

        for (View button : buttons) {
            button.setOnClickListener(this::buttonClick);
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        findServer();
    }

    private void buttonClick(View view) {
        if (useVibration) {
            vibrator.cancel();
            vibrator.vibrate(settings.getVibrationIntensity());
        }
        if (view == binding.btnSettings) {
            final Intent intent = new Intent(this, SettingsActivity.class);
            startActivity(intent);
        } else {
            String action = view.getTag().toString();
            server.request(action, result -> {
                if (!result.ok()) {
                    findServer();
                }
            });
        }
    }

    private void findServer() {
        final String serverName = settings.getServerName();
        if (serverName.equals("")) {
            binding.txtInfo.setText(getString(R.string.open_settings_and_choose_a_server));
        } else {
            server.setHostname(serverName);
            binding.txtInfo.setText(String.format(getString(R.string.searching_server), serverName));

            server.find(result -> {
                runOnUiThread(() -> {
                    if (result.ok()) {
                        final String ip = result.value();
                        binding.txtInfo.setText(String.format(getString(R.string.server_found), serverName, ip));
                    } else {
                        binding.txtInfo.setText(String.format(getString(R.string.server_not_found), serverName));
                    }
                });
            });
        }
    }
}