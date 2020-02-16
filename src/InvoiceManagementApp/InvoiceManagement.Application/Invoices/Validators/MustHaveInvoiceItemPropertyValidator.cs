using FluentValidation.Validators;
using InvoiceManagement.Application.Invoices.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceManagement.Application.Invoices.Validators
{
    internal class MustHaveInvoiceItemPropertyValidator : PropertyValidator
    {
        public MustHaveInvoiceItemPropertyValidator()
                : base("Property {PropertyName} should not be an empty list.")
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var list = context.PropertyValue as IList<InvoiceItemVm>;
            return list != null && list.Any();
        }
    }
}