using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAnnouncement.BLL.DTOs.Menu
{
    public class MenuDTO: BaseDTO
    {
        public bool IsVisible { get; set; }
        public int OrderBy { get; set; }
    }
}