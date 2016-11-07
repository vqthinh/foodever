using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodever.Model.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string OpenTime { get; set; }

        public string CloseTime { get; set; }

        public int CategoryID { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }

        public string Content { get; set; }

        public bool IsPopular { get; set; }

        public double Rating { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public virtual IEnumerable<Food> Foods { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }

    }
}
