using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data=data;
        }
        //mesajı göndermek istemeyebilir,yeni constructor,ctor
        public DataResult(T data, bool success):base(success) 
        {
            Data = data;
        }
        public T Data { get; }
    }
}
