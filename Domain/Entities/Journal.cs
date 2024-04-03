using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Journal
    {
        public int Id { get; set; }
        public string StockCode { get; set; }
        public DateTime JournalDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? EntryReason { get; set; }
        public string? ExitReason { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set;}
        public DateTime LastModifiedTime { get; set;}
        public string UpdatedById { get; set;}
        public string CreatedBy { get; set;}

        public ICollection<JournalDetail>? JournalDetails { get; set; }
    }
}
