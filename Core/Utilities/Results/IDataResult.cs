using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //<T> hangi tip olduğu T tpiinde diyoruz.
    public interface IDataResult<T>:IResult
    {
        //T türünde bir data olacak.
        T Data {  get; }
    }
}
