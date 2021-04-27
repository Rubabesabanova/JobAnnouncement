using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobAnnouncement.DAL.DAOs
{
    public class BaseDAO
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(0)]
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}