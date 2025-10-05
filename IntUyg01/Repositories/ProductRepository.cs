using IntUyg01.Models;

namespace IntUyg01.Repositories
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>
        {
            new Product() {Id=1,Name="Kalem",Price=10, Description="Kalem açıklama", IsActive=true },
            new Product() {Id=2,Name="Defter",Price=15, Description="Defter açıklama", IsActive=true },
            new Product() {Id=3,Name="Silgi",Price=20, Description="Silgi açıklama", IsActive=false },
            new Product() {Id=4,Name="Kitap",Price=30, Description="Kitap açıklama", IsActive=false },
            new Product() {Id=5,Name="Boya",Price=25, Description="Boya açıklama", IsActive=false }
        };

        public List<Product> GetList()
        {
            return products.ToList();
        }

        public Product GetById(int id)
        {
            var product = products.Where(s => s.Id == id).FirstOrDefault();
            return product;
        }
        
    }
    
}
