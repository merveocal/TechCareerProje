namespace Start1.Business;
public class ProductPostgreSqlRepository : IProductRepository
{

    public void Add(Product product) //metot, sistem mutlaka eklem işilemini yapcak demektir burda ki noktalı virgül
    {
        Console.WriteLine("Ürünler tablosuna eklendi: (PostgreSQL)");
        Console.WriteLine(product);

    }
    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosuna güncellendi: (PostgreSQL)");
        Console.WriteLine(product);

    }

    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosuna silindi: (PostgreSQL)");
        Console.WriteLine(product);
    }
    public void GetAll()
    {
        Console.WriteLine("Ürünler listelendi : (PostgreSQL)");

    }

    public void GetByProductName() //implement ettikten sonra geldi. eğer ekleezsem kaltıldığım aldığım yer kızar
    {
        Console.WriteLine("Ürün ismine göre getirilsin : (PostgreSQL)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stoğa göre getirilsin : (PostgreSQL)");

    }
}
