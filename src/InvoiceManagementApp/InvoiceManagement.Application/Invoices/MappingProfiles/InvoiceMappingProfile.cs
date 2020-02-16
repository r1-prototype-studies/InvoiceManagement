using AutoMapper;
using InvoiceManagement.Application.Invoices.Commands;
using InvoiceManagement.Application.Invoices.ViewModels;
using InvoiceManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp.Application.Invoices.MappingProfiles
{
    public class InvoiceMappingProfile : Profile
    {
        public InvoiceMappingProfile()
        {
            CreateMap<Invoice, InvoiceVm>().ReverseMap();
            CreateMap<InvoiceItem, InvoiceItemVm>().ConstructUsing(i => new InvoiceItemVm
            {
                Id = i.Id,
                Item = i.Item,
                Quantity = i.Quantity,
                Rate = i.Rate
            }).ReverseMap();
            CreateMap<CreateInvoiceCommand, Invoice>();
        }
    }
}
