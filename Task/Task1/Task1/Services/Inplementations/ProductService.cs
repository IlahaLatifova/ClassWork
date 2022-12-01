
using System;
using System.Xml.Linq;

internal class ProductService : IGeneralService, IProductService
{
    RestoranService RestoranService = new();
    public void Create(string restoranName, string productName, double price, double discount)
    {
        int index = -1;
        foreach (var restoran in RestoranService.Restorans)
        {
            if (restoranName == restoran.Name)
            {
                index = Array.IndexOf(RestoranService.Restorans, restoranName);
            }
        }
        if (index == -1)
            Console.WriteLine("There is no restoran with this name");
        else
        {
            Array.Resize(ref RestoranService.Restorans[index].Products, RestoranService.Restorans[index].Products.Length + 1);
            RestoranService.Restorans[index].Products[RestoranService.Restorans[index].Products.Length - 1] = new Product(productName, price, discount);
        }
    }


    public void Remove(string restoranName, string productName)
    {
        int index = -1;
        foreach (var restoran in RestoranService.Restorans)
        {
            if (restoranName == restoran.Name)
            {
                index = Array.IndexOf(RestoranService.Restorans, restoranName);
            }
        }
        if (index == -1)
            Console.WriteLine("There is no restoran with this name");
        else
        {
            foreach (var product in RestoranService.Restorans[index].Products)
            {
                if (product.Name == productName)
                {

                }
            }
        }
    }

    public void Update(string name, int id)
    {
        throw new NotImplementedException();
    }
    public void GetAllInRestoran()
    {
        throw new NotImplementedException();
    }

    public void GetByIdInRestoran()
    {
        throw new NotImplementedException();
    }
}

