using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the brand.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Please enter the name.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter the Year.")]
        public int Year { get; set; }
        public Byte[] Img { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }
        public bool IsRented { get; set; }
        public string RentedBy { get; set; }

    }
}
