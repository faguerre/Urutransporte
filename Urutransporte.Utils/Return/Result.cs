using System;

namespace Urutransporte.Utils
{
    public class Result<T> where T:class
    {
        public T ResultObject {get; set;}
        public string Message {get; set;}
        public Result () {
            this.ResultObject = null;
            this.Message = "";
        }
    }
}
