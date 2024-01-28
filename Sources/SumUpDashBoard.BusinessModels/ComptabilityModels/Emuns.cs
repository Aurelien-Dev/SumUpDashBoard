namespace SumUpDashBoard.BusinessModels.ComptabilityModels
{

    public enum StatusTransaction
    {
        Inconnu,
        Approuve
    }

    public enum TypeTransaction
    {
        Inconnu,
        PaiementPOS,
        VirementEntrant,
        PaiementEnLigne
    }

    public enum Trimester
    {
        First,
        Second,
        Third,
        Fourth
    }
}
