using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeKeepApp.Models
{
    public class TimekeepingTransaction
    {
        [Key]
        public int TimeKeepingTransactionId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage="Please select an Employee.")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee? Employee { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select action type.")]
        public int TransactionTypeId { get; set; }

        [ForeignKey(nameof(TransactionTypeId))]
        public virtual TransactionType? TransactionType { get; set; }

        public DateTime TransactionDateTime { get; set; } = DateTime.Now;
    }
}
