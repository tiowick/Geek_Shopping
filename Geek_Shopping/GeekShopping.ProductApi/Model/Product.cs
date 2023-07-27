using GeekShopping.ProductApi.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductApi.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(600)]
        public String Description { get; set; }

        [Column("category_name")]
        [StringLength(500)]
        public string CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string imageURL { get; set; }


    }
}
