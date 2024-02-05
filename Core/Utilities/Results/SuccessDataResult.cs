using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T> 
    {
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
            
        }

        //mesaj vermek istemiyorsa,
        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        //datayı defaul haliyle yani sadece mesaj olarak gösterebiliriz,
        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }

        //bu işlemin sonunda mesaj vermiyorum durum budur, (true, false)
        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
