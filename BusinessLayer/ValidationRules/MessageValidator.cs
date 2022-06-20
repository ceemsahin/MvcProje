using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {

            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail Adresini Boş Geçmeyiniz").EmailAddress().WithMessage("Geçerli bir e mail adresi giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş geçmeyeniz")
                 .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız")
                 .MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Açıklamayı boş geçmeyiniz").MinimumLength(10).WithMessage("Lütfen en az 10 karakter giriniz.");



        }

    }
}
