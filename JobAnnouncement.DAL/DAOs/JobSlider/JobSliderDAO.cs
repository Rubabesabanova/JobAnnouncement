using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobAnnouncement.DAL.DAOs.JobSlider
{
    [Table("JobSliders")]
    public class JobSliderDAO: BaseDAO
    {
        [Required(ErrorMessage = "The field is required")]
        public string Count { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Description { get; set; }
    }
}