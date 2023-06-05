using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ValidationFlutter
{
    public class SendValidator :AbstractValidator<SendMessage>
    {
        public SendValidator() 
        {
         
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.Color).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.DateTime).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.filling).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.piece).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.Time).NotEmpty().WithMessage("Boş Geçilemeze");   
            RuleFor(x => x.description).NotEmpty().WithMessage("Boş Geçilemeze");   


        }

    }
}
