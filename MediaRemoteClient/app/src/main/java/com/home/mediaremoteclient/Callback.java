package com.home.mediaremoteclient;

public interface Callback<T> {
    void execute(Result<T> result);
}
