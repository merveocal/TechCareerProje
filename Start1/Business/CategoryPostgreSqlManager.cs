﻿namespace Start1.Business;
public class CategoryPostgreSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Kategori PstgreSql veri tabanına eklendi");
        Console.WriteLine(category);
    }
    public void Update(Category category)
    {
        Console.WriteLine("Kategori PostgreSql veri tabanında güncellendi");
        Console.WriteLine(category);

    }
    public void Delete(Category category)
    {
        Console.WriteLine("Kategori PostgreSql veri tabanında silindi");
        Console.WriteLine(category);
    }
    public void GetAll() //hiçbir şey dönmüyor sadec consol çıktısı veriyor
    {
        Console.WriteLine("Kategoriler listelendi(PostgreSql)");

    }
   // bunşarın hepsini bir base class' bağlayabiliriz
   
}




