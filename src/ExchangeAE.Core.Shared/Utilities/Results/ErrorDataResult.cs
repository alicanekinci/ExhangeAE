namespace ExchangeAE.Core.Utilities.Results;
public class ErrorDataResult<T> : DataResult<T>
{
    public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
    {
    }

    public ErrorDataResult(T data, bool succeess) : base(data, false)
    {
    }
    public ErrorDataResult(string message) : base(default, false, message)
    {
    }

    public ErrorDataResult() : base(default, success: false)
    {
    }
}
