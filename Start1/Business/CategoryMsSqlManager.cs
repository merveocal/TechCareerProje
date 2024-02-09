using System.Data;

namespace Start1.Business;

public class CategoryMsSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Kategori MsSql veri tabanına eklendi");
        Console.WriteLine(category);
    }
    public void Update(Category category)
    {
        Console.WriteLine("Kategori MsSql veri tabanında güncellendi");
        Console.WriteLine(category);

    }
    public void Delete(Category category) 
    {
        Console.WriteLine("Kategori MsSql veri tabanında silindi");
        Console.WriteLine(category);
    }
    public void GetAll() //hiçbir şey dönmüyor sadec consol çıktısı veriyor
    {
        Console.WriteLine("Kategoriler listelendi(MsSql)");
    
    }

}


