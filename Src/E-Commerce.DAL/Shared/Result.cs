namespace E_Commerce.DAL.Shared;

public class Result
{
    public Error Error { get; }
    public bool IsSuccess { get; }

    public Result(Error error, bool isSuccess)
    {
        Error = error;
        IsSuccess = isSuccess;
    }

    public static Result Success() => new(Error.None, true);

    public static Result Failure(Error error) => new(error, false);

    public static Result<T> Success<T>(T value) => new(Error.None, true, value);

    public static Result<T> Failure<T>(Error error) => new(error, false, default!);
}