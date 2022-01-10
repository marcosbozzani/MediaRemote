package duck.mediaremote.client;

public interface Callback<T> {
    void execute(Result<T> result);
}
