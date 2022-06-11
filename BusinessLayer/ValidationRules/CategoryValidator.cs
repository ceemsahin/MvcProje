using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
 public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategory Adını Boş geçmeyenizi")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız")
                .MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayınız");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçmeyiniz");


        }
      


    }
}
