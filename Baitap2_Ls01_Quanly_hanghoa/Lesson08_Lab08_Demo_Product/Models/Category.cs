﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_Lab08_Demo_Product.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        // danh sách sản phẩm theo danh mục
        public ICollection<Product> Products { get; set; }
    }
}
