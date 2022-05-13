﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En Az 3 karakter Girişini Yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen En Az 3 karakter Girişini Yapınız");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın.");
        }
    }
}
