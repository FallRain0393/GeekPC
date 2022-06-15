using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekPC.Models
{
    public class Item
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Категория")]
        public string Category { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Краткое описание")]
        public string Descr { get; set; }
        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(18)")]
        public decimal Price { get; set; }
        [Display(Name = "Дата публикации")]
        [DataType(DataType.Date)]
        public DateTime DatePublication { get; set; }
        public List<Image> Images { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
