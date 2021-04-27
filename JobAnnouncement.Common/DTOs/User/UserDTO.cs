using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobAnnouncement.BLL.DTOs.Job;

namespace JobAnnouncement.BLL.DTOs.User
{
    public class UserDTO: BaseDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public List<JobDTO> Jobs { get; set; }
    }
}