using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //mesaj vermek istemiyorsa,
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //datayı defaul haliyle yani sadece mesaj olarak gösterebiliriz,
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //bu işlemin sonunda mesaj vermiyorum durum budur, (true, false)
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
