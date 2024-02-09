// Öğrendiklerim
// string interpolation:  başına dolar işareti koyarak aktif bilgilerle döndürülmesini sağlar
//değer döndüren fonksiyonlar
//birden fazla değeri tutmamızı sağlayan bir yapıdır
//array listelerde dinamik bir şekilde ekleyip çıkarabiliyoruz. ama arraylerde onu yapamıyoruz
// contains: öyle bir elemanın olup olmadığının olup olmadığını sorgular ve true ya da false olrak döner
// listeler
// referans tipler: kendi oluşturduğumuz classlar, diziler, listeler, hashmap, interface
// dictionaru: key ve value şeklinde tutuluyor
//polimorfizm: çok biçimililik
//produt product = new Product() olaral oluşturduğum nesnenin başına Entity olarak da yazabilirsin
#region dictionary kullanımı

//Dictionary<string, double> urunFiyatlari =  new Dictionary<string, double>();
//urunFiyatlari.Add("Elma", 25);
//urunFiyatlari.Add("Armut", 35);
//urunFiyatlari.Add("Kiraz", 15);
//urunFiyatlari.Add("Karpuz", 5);

//foreach(KeyValuePair<string, double> eleman in urunFiyatlari)
//{
//    Console.WriteLine($"Ürün Adi: {eleman.Key}, Ürünün değeri:  {eleman.Value}");
//}

//Console.WriteLine($"Kiraz'ın Fiyatı : {urunFiyatlari["Kiraz"]}");

#endregion

// 1) bir sistemde ürün, kateori ve kullanıcı tabloları olsun veri tabanı olduğunu varsayalım ve işlemleri simüle edelim
// category, entity,products, user isimli cs ler oluşturdum ilk
// 2) Business isimli bir dosya oluşturdum
// 3)  bu işlemler MSSQL kullanıldığını varsayarak simüle ediniz
// 4) bu işlemleri alternatifi olan postreSQL operasyonlarını da yazınız
using Start1;
using Start1.Business;

Product product = new Product()
{
    Id = 1,
    Name = "MSI Laptop",
    Price = 35000,
    Stock = 100
};

Category category = new Category()
{
    Id = 1,
    Name = "technology",

};

User user = new User()
{
    Id = 1,
    Name = "ihsan",
    Email = "ihsan0144@gmail.com",
    Password = "123456789"
};
//Console.WriteLine(user.ToString());
//Console.WriteLine("*********************");
//Console.WriteLine(product.ToString());
//Console.WriteLine("**********************");
//Console.WriteLine(category.ToString());

//manager2ı çalışıtırrken ilk önce instance oluşuturlur


//postgre sql olduğunda tek tek değiştirmek yerien daha kolay yolla değişimi şu şekildedir:
ICategoryRepository sqlManager = new CategoryPostgreSqlManager();
sqlManager.Add(category);
Console.WriteLine("**************************");
sqlManager.Update(category);
Console.WriteLine("***************************");
sqlManager.Delete(category);
Console.WriteLine("***************************");
sqlManager.GetAll();


//abstract classların içerisinde ezilmemesi gereken metotlar olurken
//interface de yazdığın bütün mettoları kullanman gerekli

IProductRepository productRepository = new ProductMsSqlRepository();
productRepository.Add(product);
Console.WriteLine("**************************");
productRepository.Update(product);
Console.WriteLine("**************************");
productRepository.Delete(product);
Console.WriteLine("**************************");
productRepository.GetAll();
productRepository.GetByProductName();
productRepository.GetByStock();

//List<string> sehirler = new  List<string>()
//{
//    "Malatya",
//    "İstanbul",
//    "Ankara"
    
//};


