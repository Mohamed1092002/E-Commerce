namespace E_Commerce.DAL.Shared;

public class Result<T> : Result
{
    public T? Value { get; }

    public Result(Error error, bool isSuccess, T value) : base(error, isSuccess)
    {
        Value = value;
    }
}