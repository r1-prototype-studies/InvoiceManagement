using InvoiceManagement.Application.Invoices.ViewModels;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagement.Application.Invoices.Queries
{
    public class GetUserInvoicesQuery : IRequest<IList<InvoiceVm>>
    {
        public string User { get; set; }
    }

}
