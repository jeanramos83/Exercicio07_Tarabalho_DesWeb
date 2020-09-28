using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Trabalho01_DesWeb.Models;

namespace Trabalho01_DesWeb.Validations
{
    public class PacienteValidator : AbstractValidator<DadosPacientes>
    {
        public PacienteValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("ID do paciente é obrigagatório!")
                                .NotNull().WithMessage("ID do paciente é obrigatório!");
        
        
            RuleFor(p => p.nome).NotEmpty().WithMessage("Nome do paciente é obrigagatório!")
                              .NotNull().WithMessage("Nome do paciente é obrigatório!");
         }
    }
}
