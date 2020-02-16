using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManagement.Application.Common.Interfaces;
using InvoiceManagement.Application.Invoices.Commands;
using InvoiceManagement.Application.Invoices.Queries;
using InvoiceManagement.Application.Invoices.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagementApp.Api.Controllers
{
    [Authorize]
    public class InvoicesController : ApiController
    {
        private ICurrentUserService _currentUserService;
        public InvoicesController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateInvoiceCommand command)
        {
            return await Mediator.Send(command);
        }

        public async Task<IList<InvoiceVm>> Get()
        {
            return await Mediator.Send(new GetUserInvoicesQuery { User = _currentUserService.UserId });
        }
    }
}