using System.Security.Principal;

namespace Start1;

public class Product : Entity
{
 
    public int Price { get; set; }
    public int Stock { get; set; }

    //ben bunu product'ı direkt bastırmak istediğim zaman aşağıdaki kodu yazıyoru

    public override string ToString()
    {
        return $"Id: {Id}, Name :  {Name}, Değer : {Price} TL, Stok: {Stock}";
    }

}
