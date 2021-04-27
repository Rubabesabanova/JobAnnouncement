using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobAnnouncement.DAL.DAOs.SocialMedia
{
    [Table("SocialMedias")]
    public class SocialMediaDAO : BaseDAO
    {
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Behance { get; set; }
        public string Youtube { get; set; }
        public string Twitter { get; set; }
    }
}