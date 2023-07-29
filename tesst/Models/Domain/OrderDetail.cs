using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tesst.Models.Domain
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("OrderID")]
        public Product Product { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }
        
    }
}
