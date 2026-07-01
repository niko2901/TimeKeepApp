using System.ComponentModel.DataAnnotations;

namespace TimeKeepApp.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }
        public string TransactionName { get; set; } = string.Empty;
    }
}
