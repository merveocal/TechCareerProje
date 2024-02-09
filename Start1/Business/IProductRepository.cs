namespace Start1.Business;

public interface  IProductRepository :IBaseEntityRepository<Product>
{
    public void GetByProductName(); //adını ben koydum
    public void GetByStock(); 




}
