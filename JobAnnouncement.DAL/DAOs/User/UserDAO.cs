using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JobAnnouncement.DAL.DAOs.Job;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace JobAnnouncement.DAL.DAOs.User
{
    [Table("Users")]
    public class UserDAO : BaseDAO
    {
            public UserDAO()
            {
                Jobs = new List<JobDAO>();
            }
            [MinLength(3, ErrorMessage = "Username must be at least 3 characters.")]
            [Required(ErrorMessage = "The field is required")]
            public string Username { get; set; }
            [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
            [Required(ErrorMessage = "The field is required")]
            public string Password { get; set; }
            [Required(ErrorMessage = "The field is required")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [DefaultValue(1)]
            public int Role { get; set; }
            public List<JobDAO> Jobs { get; set; }
       
    }
}