using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs.Contact
{
    public class ContactDTO: BaseDTO
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}