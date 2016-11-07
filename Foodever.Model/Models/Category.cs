using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foodever.Model.Abstract;
namespace Foodever.Model.Models
{
    [Table("Categories")]
    public class Category : Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public virtual IEnumerable<Food> Foods { get; set; }

        public virtual IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
