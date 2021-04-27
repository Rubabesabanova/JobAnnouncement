using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JobAnnouncement.DAL.DAOs.Category;
using JobAnnouncement.DAL.DAOs.CategorySlider;
using JobAnnouncement.DAL.DAOs.Contact;
using JobAnnouncement.DAL.DAOs.Job;
using JobAnnouncement.DAL.DAOs.JobSlider;
using JobAnnouncement.DAL.DAOs.Menu;
using JobAnnouncement.DAL.DAOs.SocialMedia;
using JobAnnouncement.DAL.DAOs.Testimonial;
using JobAnnouncement.DAL.DAOs.User;

namespace JobAnnouncement.DAL.JobDbContext
{
    public class JobAnnouncementDbContext: DbContext
    {
        public JobAnnouncementDbContext(): base("Job") { }
        public virtual DbSet<UserDAO> Users { get; set; }
        public virtual DbSet<TestimonialDAO> Testimonials { get; set; }
        public virtual DbSet<SocialMediaDAO> SocialMedias { get; set; }
        public virtual DbSet<MenuDAO> Menus { get; set; }
        public virtual DbSet<JobSliderDAO> JobSliders { get; set; }
        public virtual DbSet<JobDAO> Jobs { get; set; }
        public virtual DbSet<ContactDAO> Contacts { get; set; }
        public virtual DbSet<CategoryDAO> Categories { get; set; }
        public virtual DbSet<CategorySliderDAO> CategorySliders { get; set; }
    }
}