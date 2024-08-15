namespace MVCAPP.Models
{
    public class Product
    {
        public int Productid { get; set; }

        public string? Productname { get; set; }

        public int? Categoryid { get; set; }

        public virtual Category? Category
        {
            get; set;
        }
    }
}
