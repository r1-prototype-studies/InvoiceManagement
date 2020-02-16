using InvoiceManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagement.Domain.Entities
{
    public class InvoiceItem : AuditEntry
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public Invoice Invoice { get; set; }
    }
}
