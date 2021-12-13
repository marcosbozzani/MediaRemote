package com.home.mediaremoteclient;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;

public class Settings {

    private final SharedPreferences data;

    public Settings(Context context) {
        data = context.getSharedPreferences("com.home.mediaremoteclient.Settings", Context.MODE_PRIVATE);
    }

    public String getServerName() {
        return data.getString("serverName", "");
    }

    public void setServerName(String value) {
        data.edit().putString("serverName", value).apply();
    }
}
