namespace Start1.Business;

public class ProductMsSqlRepository :IProductRepository
{
    public void Add(Product product) //metot, sistem mutlaka eklem işilemini yapcak demektir burda ki noktalı virgül
    {
        Console.WriteLine("Ürünler tablosuna eklendi: (MsSQL)");
        Console.WriteLine(product);

    }
    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosuna güncellendi: (MsSQL)");
        Console.WriteLine(product);

    }
    
    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosuna silindi: (MsSQL)");
        Console.WriteLine(product);
    }
    public void GetAll()
    {
        Console.WriteLine("Ürünler listelendi : (MsSQL)");

    }

    public void GetByProductName() //implement ettikten sonra geldi
    {
        Console.WriteLine("Ürün ismine göre getirilsin : (MsSQL)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stoğa göre getirilsin : (MsSQL)");

    }

}
