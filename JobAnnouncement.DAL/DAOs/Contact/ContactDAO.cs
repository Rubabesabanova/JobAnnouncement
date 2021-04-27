using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobAnnouncement.DAL.DAOs.Contact
{
    [Table("Features")]
    public class ContactDAO: BaseDAO
    {
        [Required(ErrorMessage = "The field is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}