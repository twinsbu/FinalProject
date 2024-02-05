using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Başarılıyı işleyeceğiz.
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)
        { 
            
        }

        //Mesaj vermek istemiyor olabiliriz aşağıdaki kodu yazarız, (parametresiz)
        public SuccessResult() : base(true)
        { 
            
        }
    }
}
