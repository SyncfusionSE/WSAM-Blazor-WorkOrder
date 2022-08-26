using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkOrderApp.Shared.Models
{
    public class WorkOrder
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid OrderId { get; set; } = Guid.NewGuid();
        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        [MaxLength(50)] 
        public string Status { get; set; } = "Pending";
        public int? EstimatedHours { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
