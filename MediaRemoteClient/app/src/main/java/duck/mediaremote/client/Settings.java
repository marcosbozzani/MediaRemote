package duck.mediaremote.client;

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

    public void setServerName(String value) {
        data.edit().putString("serverName", value).apply();
    }
}
