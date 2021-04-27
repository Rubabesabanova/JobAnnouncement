using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobAnnouncement.BLL.DTOs.Job;

namespace JobAnnouncement.BLL.DTOs.Category
{
    public class CategoryDTO: BaseDTO
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public List<JobDTO> Jobs { get; set; }
    }
}