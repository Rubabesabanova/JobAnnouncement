using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs.Testimonial
{
    public class TestimonialDTO: BaseDTO
    {
        public string Description { get; set; }
        public string Author { get; set; }
        public string Speciality { get; set; }
    }
}