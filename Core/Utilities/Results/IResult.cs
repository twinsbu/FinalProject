using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    //Kullanıcıyı bilgilendirmek için mesaj vereceğiz.
    public interface IResult
    {
        bool Success { get; } //İşlem başarılı mı? Başarısız mı?
        string Message { get; } //Yapmaya çalıştığımız işlem başarılı ise True "Eklendi" False "Eklenemedi şu sebeten .." gibi.

    }
}
