using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Web_Development_Activity2.Models
{
    public class ProductModel
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Cost")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("What you get...")]
        public string Description { get; set; }
    }
}
