namespace SumUpDashBoard.BusinessModels.ComptabilityModels
{
    public class SumUpTransactionModel
    {
        public SumUpTransactionModel() { }
        public SumUpTransactionModel(string type, string status)
        {
            switch (type)
            {
                case "Paiement POS":
                    Type = TypeTransaction.PaiementPOS;
                    break;
                case "Virement entrant":
                    Type = TypeTransaction.VirementEntrant;
                    break;
                case "Paiement en ligne":
                    Type = TypeTransaction.PaiementEnLigne;
                    break;
                default:
                    Type = TypeTransaction.Inconnu;
                    break;
            }

            switch (status)
            {
                case "Approuvé":
                    Status = StatusTransaction.Approuve;
                    break;
                default:
                    Status = StatusTransaction.Inconnu;
                    break;
            }
        }

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; } = default!;
        public TypeTransaction Type { get; set; }
        public string Reference { get; set; } = default!;
        public string ReferencePaiement { get; set; } = default!;
        public StatusTransaction Status { get; set; }
        public decimal MontantFactureDebit { get; set; }
        public decimal MontantFactureCredit { get; set; }
        public string Devise { get; set; } = default!;
        public decimal MontantTransactionDebit { get; set; }
        public decimal MontantTransactionCredit { get; set; }
        public string DeviseTransaction { get; set; } = default!;
        public decimal TauxChange { get; set; }
        public decimal TauxFrais { get; set; }
        public decimal Solde { get; set; }

        public TransactionModel Transaction { get; set; } = default!;
    }
}
