package duck.mediaremote.client;

import android.annotation.SuppressLint;
import android.content.Context;
import android.content.SharedPreferences;

public class Settings {

    private final SharedPreferences data;

    public Settings(Context context) {
        data = context.getSharedPreferences("duck.mediaremote.client.Settings", Context.MODE_PRIVATE);
    }

    public String getServerName() {
        return data.getString("serverName", "");
    }

    @SuppressLint("ApplySharedPref")
    public void setServerName(String value) {
        data.edit().putString("serverName", value).commit();
    }

    public boolean getUseButtonVibration() {
        return data.getBoolean("useButtonVibration", false);
    }

    @SuppressLint("ApplySharedPref")
    public void setUseButtonVibration(boolean state) {
        data.edit().putBoolean("useButtonVibration", state).commit();
    }

    public int getVibrationIntensity() {
        return data.getInt("vibrationIntensity", 12);
    }

    @SuppressLint("ApplySharedPref")
    public void setVibrationIntensity(int intensity) {
        data.edit().putInt("vibrationIntensity", intensity).commit();
    }
}
