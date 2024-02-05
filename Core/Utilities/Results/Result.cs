using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Çıplak class kalmasın kuralımız bu!
    //Interface ile bağlamamız (implement interface) gerekiyor!
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//this(success) kodu ile aşağıdaki bool succes te çalışacak! 
        {
           Message = message;
        }

        public Result(bool success ) //Eklendi diye mesaj vermesin sadece başarılı olduğunu görelim diye constroctor
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
