
    internal class Product : Base
    {
       
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidNameException("Exception:  This name format is not true!!!");
                }
            }
        }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public Product(string name,double price,double discountprice)
        {
            Name = name;
            Price = price;
            DiscountPrice = discountprice;
        }
    }
    

