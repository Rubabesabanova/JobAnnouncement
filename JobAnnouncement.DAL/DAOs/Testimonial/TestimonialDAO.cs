using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobAnnouncement.DAL.DAOs.Testimonial
{
    [Table("Testimonials")]
    public class TestimonialDAO: BaseDAO
    {
        [Required(ErrorMessage = "The field is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Speciality { get; set; }
    }
}