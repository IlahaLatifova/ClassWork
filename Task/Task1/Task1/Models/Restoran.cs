
    internal class Restoran:Base
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
        public Product[] Products = { };
}

