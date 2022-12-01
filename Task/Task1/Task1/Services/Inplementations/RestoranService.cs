
internal class RestoranService:IGeneralService, IRestoranService
{
        public static Restoran[] Restorans = { };

    public void Create(string name)
    {
        int count = 0;
        foreach (var restoran in RestoranService.Restorans)
        { 
            if (restoran.Name != name)
            {
                count++;
            }           
            if (count == Restorans.Length-1)
            {
                Array.Resize(ref Restorans, Restorans.Length + 1);
                Restorans[Restorans.Length - 1] = restoran;
            }
        }
    }


    public void Remove(string name)
    {
        for (int i = 0 ; i < RestoranService.Restorans.Length; i++)
        {
            if (Restorans[i].Name == name)
            {
                name = Restorans[Restorans.Length - 1].Name;
                Restorans[Restorans.Length - 1].Name = Restorans[i].Name;
                Restorans[i].Name = name;
                Array.Resize(ref Restorans, Restorans.Length - 1);
                break;
            }
        }
    }

    public void Update(string name,int id)
    {
        foreach (var restoran in RestoranService.Restorans)
        {
            if(restoran.Id == id)
            {
                restoran.Name = name;
            }
        }
    }
    public void GetAll()
    {
        foreach (var restoran in RestoranService.Restorans)
        {
            Console.WriteLine($"Restoran name: {restoran.Name}\nRestoran Id: {restoran.Id};");
        }
    }

    public void GetById(int id)
    {
        foreach (var restoran in RestoranService.Restorans)
        {
           if(restoran.Id == id)
            {
                Console.WriteLine($"Restoran name: {restoran.Name}\nRestoran Id: {restoran.Id};");
            }
        }
    }
}

