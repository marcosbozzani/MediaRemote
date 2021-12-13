package com.home.mediaremoteclient;

public class Result<T> {

    private final boolean _ok;
    private final T _value;
    private final String _message;
    private final Exception _exception;

    private Result(boolean ok, T value, String message, Exception exception) {
        this._ok = ok;
        this._value = value;
        this._message = message;
        this._exception = exception;
    }

    public static <T> Result<T> success(T value) {
        return new Result<T>(true, value, null, null);
    }

    public static <T> Result<T> fail(String message) {
        return fail(message, null);
    }

    public static <T> Result<T> fail(String message, Exception exception) {
        return new Result<T>(false, null, message, exception);
    }

    public boolean ok() {
        return _ok;
    }

    public T value() {
        return _value;
    }

    public String message() {
        return _message;
    }

    public Exception exception() {
        return _exception;
    }
}
