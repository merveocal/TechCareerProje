namespace Start1.Business;

public interface IBaseEntityRepository<TEntity> //burda değişen tipe göre bir kod verir
{
    public void Add(TEntity entity); //metot, sistem mutlaka eklem işilemini yapcak demektir burda ki noktalı virgül
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
    public void GetAll();
}

