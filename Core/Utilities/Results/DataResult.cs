using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Resul class
    //DataResulta diyoruz ki aslında sen bir resultsun.
    public class DataResult<T> : Result, IDataResult<T>
    {
        //DataResult döndürdüğümüz zaman T türünde bir data, işlemin sonucunu ve mesajını vericem.
        //base : yazdığımızda birdaha biz yazmıcaz demektir. 
        public DataResult(T data,bool success, string message):base(success,message)
        {
           Data = data;
        }

        //Mesaj göstermek istemiyorsak aşağıdaki kodu yazarız,
        public DataResult(T data, bool success):base(success)
        {
            Data = data; 
        }
        public T Data { get; }
    }
}
