using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNet.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad yazmaq mecburidir")]
        [MaxLength(50)]
        [Display(Name="Ad")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Soyad yazmaq mecburidir")]
        [MaxLength(50, ErrorMessage ="Max 50 xarakterden ibaret olmalidir")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Yash yazmaq mecburidir")]
        [Range(18,50,ErrorMessage ="Yash 18-50 arasi olmalidir")]
        [Display(Name = "Yash")]

        public int Age { get; set; }

        [Required(ErrorMessage = "Telefon yazmaq mecburidir")]
        [StringLength(10)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
    }
}