using FluentValidation;
using InvoiceManagement.Application.Invoices.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagement.Application.Invoices.Validators
{
    public class CreateInvoiceCommandValidator: AbstractValidator<CreateInvoiceCommand>
    {
        public CreateInvoiceCommandValidator()
        {
            RuleFor(V => V.AmountPaid).NotNull();
            RuleFor(V => V.Date).NotNull();
            RuleFor(V => V.From).NotEmpty().MinimumLength(3);
            RuleFor(v => v.To).NotEmpty().MinimumLength(3);
            RuleFor(v => v.InvoiceItems).SetValidator(new MustHaveInvoiceItemPropertyValidator());
        }
    }
}
