using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foodever.Model.Abstract;

namespace Foodever.Model.Models
{
    [Table("Reviews")]
    public class Review : Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Content { get; set; }

        public int Rating { get; set; }

        public int ReviewerID { get; set; }

        public int RestaurantID { get; set; }

        [ForeignKey("RestaurantID")]
        public Restaurant Restaurant { get; set; }
        [ForeignKey("ReviewerID")]
        public ApplicationUser Reviewer { get; set; }

    }
}
