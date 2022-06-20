using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçmeyiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş geçmeyeniz")
             .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız")
             .MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Açıklamayı boş geçmeyiniz").MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");

        }


    }
}
