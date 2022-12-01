
    internal interface IProductService
    {
    public void Create(string restoranName,string productName,double price,double discount );
    public void Remove(string restoranName, string productName);
    public void GetAllInRestoran();
    public void GetByIdInRestoran();
    }

