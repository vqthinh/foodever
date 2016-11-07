using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foodever.Model.Abstract;

namespace Foodever.Model.Models
{
    [Table("Foods")]
    public class Food : Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; } 

        public string Image { get; set; }

        public string CategoryID { get; set; }

        public string Content { get; set; }

        public string RestaurantID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }

    }
}
