namespace ExchangeAE.Core.Utilities.Results;

public class ErrorResult : Result
{
    public ErrorResult(bool succes, string message) : base(success: false, message)
    {
    }
    public ErrorResult(bool success) : base(false)
    {
    }
}
