using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}