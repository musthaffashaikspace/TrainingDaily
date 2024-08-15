namespace MVCAPP.Models
{
    public class Category
    {
        public int Categoryid { get; set; }

        public string? CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
