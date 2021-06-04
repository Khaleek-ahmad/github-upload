using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Model
{
    public class Product: IEntity
    {
        [Key]
        public Guid  Id { get; set; }

        [Column(TypeName="varchar(500)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public decimal Price { get; set; }        
    }
}
