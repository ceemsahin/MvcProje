using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş geçmeyeniziz")
                .MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi yapınız")
                .MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar SoyAdını Boş geçmeyeniziz")
                .MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi yapınız")
                .MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçmeyiniz");

            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Unvanını Boş geçmeyeniziz")
                .MinimumLength(2).WithMessage("Lütfen en az 3 karakter girişi yapınız")
                .MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız");
        }
    }
}
