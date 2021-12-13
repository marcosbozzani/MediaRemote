package com.home.mediaremoteclient;

import android.content.Context;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.net.UnknownHostException;
import java.util.Properties;

import jcifs.Address;
import jcifs.CIFSContext;
import jcifs.CIFSException;
import jcifs.config.PropertyConfiguration;
import jcifs.context.BaseContext;

public class Server {

    private String ip;
    private String hostname;
    private RequestQueue queue;

    public Server(Context context) {
        queue = Volley.newRequestQueue(context);
    }

    public void setHostname(String hostname) {
        this.hostname = hostname;
    }

    public String getHostname() {
        return this.hostname;
    }

    public void find(Callback<String> callback) {
        new Thread(() -> {
            final BaseContext context;
            try {
                context = new BaseContext(new PropertyConfiguration(new Properties()));
            } catch (CIFSException e) {
                e.printStackTrace();
                callback.execute(Result.fail("Context creation error"));
                return;
            }

            final Address address;
            try {
                address = context.getNameServiceClient().getByName(hostname);
                ip = address.toInetAddress().toString().substring(1);
            } catch (UnknownHostException e) {
                e.printStackTrace();
                callback.execute(Result.fail("Unknown host error"));
                return;
            }

            callback.execute(Result.success(ip));
        }).start();
    }

    public void request(String action, Callback<String> callback) {
        String url = "http://" + ip + ":9696/" + action;

        StringRequest stringRequest = new StringRequest(Request.Method.GET, url,
                response -> callback.execute(Result.success(response)),
                error -> callback.execute(Result.fail("request error: " + action, error))
        );

        queue.add(stringRequest);
    }
}
