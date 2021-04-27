using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobAnnouncement.BLL.DTOs.Category;
using JobAnnouncement.BLL.DTOs.User;

namespace JobAnnouncement.BLL.DTOs.Job
{
    public class JobDTO: BaseDTO
    {
        public string Title { get; set; }
        public int VacancyCount { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public int JobNature { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}