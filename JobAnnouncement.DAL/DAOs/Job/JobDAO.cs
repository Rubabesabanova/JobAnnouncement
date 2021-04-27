using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using JobAnnouncement.DAL.DAOs.Category;
using JobAnnouncement.DAL.DAOs.User;

namespace JobAnnouncement.DAL.DAOs.Job
{
    [Table("Jobs")]
    public class JobDAO : BaseDAO
    {
        public string Title  { get; set; }
        [DefaultValue(1)]
        public int VacancyCount { get; set; }
        [DefaultValue(0)]
        public double Salary { get; set; }
        [DefaultValue("Remote")]
        public string Location { get; set; }
        [DefaultValue(1)]
        public int JobNature { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public UserDAO User { get; set; }
        public int CategoryId { get; set; }
        public CategoryDAO Category { get; set; }
    }
}