using System;
using System.Collections.Generic;

namespace WorkOrderApp.Shared.Models
{
    public partial class WorkOrder
    {
        public Guid OrderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int? EstimatedHours { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
