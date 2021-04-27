using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs.JobSlider
{
    public class JobSliderDTO: BaseDTO
    {
        public string Count { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}