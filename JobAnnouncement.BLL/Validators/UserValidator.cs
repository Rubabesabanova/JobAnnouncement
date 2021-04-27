using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using JobAnnouncement.BLL.DTOs.User;

namespace JobAnnouncement.BLL.Validators
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}