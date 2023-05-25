﻿namespace ExchangeAE.Core.Utilities.Results;
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,success:true,message)
        {
        }

        public SuccessDataResult(T data):base(data,success:true)
        {
        }
        public SuccessDataResult(string message):base(default,true,message)
        {
        }
    }
