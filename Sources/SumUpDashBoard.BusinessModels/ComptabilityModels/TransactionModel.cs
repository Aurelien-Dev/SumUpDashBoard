namespace SumUpDashBoard.BusinessModels.ComptabilityModels
{
    public class TransactionModel
    {
        public Guid Id { get; set; }
        public Guid SumUpTransactionId { get; set; }
        public Guid TrimesterId { get; set; }

        public SumUpTransactionModel SumUpTransaction { get; set; } = default!;
        public UrsaffTrimesterModel Trimester { get; set; } = default!;

    }
}