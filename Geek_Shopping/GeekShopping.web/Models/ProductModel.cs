namespace GeekShopping.web.Models
{
    public class ProductModel
    {
        public long id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
        public string CategoryName { get; set; }
        public string imageURL { get; set; }

        public string SubStringName () 
        {
            if (Name.Length < 20) return Name;
            return $"{Name.Substring (0, 19)} ...";
        }

        public string SubStringDescription()
        {
            if (Description.Length < 355) return Description;
            return $"{Description.Substring(0, 352)} ...";
        }

     
    }
}
