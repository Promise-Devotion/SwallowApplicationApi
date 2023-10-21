using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwallowApplicationApi.Models
{
    [Table("t_bill")]
    public class BillModel
    {
        [Key] [Column("bill_id")] public int BillId { get; set; }
        [Column("create_time")] public DateTime CreateTime { get; set; }
        [Column("bill_name")] public string? BillName { get; set; }
        [Column("bill_amount")] public Decimal BillAmount { get; set; }
        [Column("bill_status")] public int Status { get; set; }
    }
}
