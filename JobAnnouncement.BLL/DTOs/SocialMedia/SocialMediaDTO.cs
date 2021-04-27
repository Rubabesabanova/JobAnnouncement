using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs.SocialMedia
{
    public class SocialMediaDTO: BaseDTO
    {
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Behance { get; set; }
        public string Youtube { get; set; }
        public string Twitter { get; set; }
    }
}