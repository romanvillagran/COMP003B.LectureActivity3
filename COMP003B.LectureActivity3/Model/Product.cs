using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity3.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0.01, 10000)]
        public decimal Price { get; set; }

        [Required]
        public string Catagory { get; set; }
    }
}
