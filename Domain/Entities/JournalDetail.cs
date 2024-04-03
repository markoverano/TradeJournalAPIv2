using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class JournalDetail
    {
        public int JournalDetailId { get; set; }
        public int JournalId { get; set; }
        public decimal? EntryPrice { get; set; }
        public decimal? EntryClearingFee { get; set; }
        public decimal? EntryCommission { get; set; }
        public decimal? EntryVat { get; set; }
        public decimal? EntryTransFee { get; set; }
        public decimal? EntryGrossAmt { get; set; }
        public decimal? ExitPrice { get; set; }
        public decimal? ExitClearingFee { get; set; }
        public decimal? ExitCommission { get; set; }
        public decimal? ExitTransFee { get; set; }
        public decimal? ExitVat { get; set; }
        public decimal? ExitSalesTax { get; set; }
        public decimal? ExitGrossAmt { get; set; }
        public decimal? EntryChargeTotal { get; set; }
        public decimal? ExitChargeTotal { get; set; }
        public decimal? Profit { get; set; }
        public decimal? GainPercentage { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public string UpdatedById { get; set; }
        public string CreatedBy { get; set; }
    }
}
