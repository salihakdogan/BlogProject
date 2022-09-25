using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(x=>x.WriterName).MinimumLength(3).WithMessage("At least 3 characters must be entered.");
            RuleFor(x=>x.WriterName).MaximumLength(30).WithMessage("At maximum of 30 characters must be entered.");

            RuleFor(x=>x.WriterLastname).NotEmpty().WithMessage("Last name cannot be empty.");
            RuleFor(x=>x.WriterLastname).MinimumLength(3).WithMessage("At least 3 characters must be entered.");

            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail adress cannot be empty.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Incorrect mail type please be correct entered.");

            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Password cannot be empty.");
        }
    }
}
