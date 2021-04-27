using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using JobAnnouncement.DAL.DAOs.Job;

namespace JobAnnouncement.DAL.DAOs.Category
{
    [Table("Categories")]
    public class CategoryDAO : BaseDAO
    {
        public CategoryDAO()
        {
            Jobs = new List<JobDAO>();
        }
        public string Title { get; set; }
        [MaxLength(20)]
        public string Icon { get; set; }
        public List<JobDAO> Jobs { get; set; }
    }
}