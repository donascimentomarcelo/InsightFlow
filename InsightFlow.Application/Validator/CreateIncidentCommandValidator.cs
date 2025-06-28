using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Application.commands;
using FluentValidation;

namespace InsightFlow.Application.Validator
{
    public class CreateIncidentCommandValidator : AbstractValidator<CreateIncidentCommand>
    {
        public CreateIncidentCommandValidator()
        {
            RuleFor(command => command.Title)
                .NotEmpty().WithMessage("O título do incidente é obrigatório.")
                .MaximumLength(100).WithMessage("O título do incidente não pode exceder 100 caracteres.");

            RuleFor(command => command.Description)
                .NotEmpty().WithMessage("A descrição do incidente é obrigatória.")
                .MaximumLength(500).WithMessage("A descrição do incidente não pode exceder 500 caracteres.");
        }
    }
}