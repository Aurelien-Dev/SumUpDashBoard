namespace SumUpDashBoard.BusinessModels.ComptabilityModels
{
    public class UrsaffTrimesterModel
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public Trimester Trimester { get; set; }
        public List<TransactionModel> Transactions { get; set; } = default!;

        public decimal ReportableAmount { get; set; }
        public decimal? AmountTaxe { get; set; }
        public bool IsPaid { get; set; }
    }
}
