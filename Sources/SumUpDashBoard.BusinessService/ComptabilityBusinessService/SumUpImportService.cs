using Microsoft.EntityFrameworkCore;
using SumUpDashBoard.BusinessModels.ComptabilityModels;
using SumUpDashBoard.DataAccess;
using System.Globalization;

namespace SumUpDashBoard.BusinessService.ComptabilityBusinessService
{

    public class SumUpImportService : ISumUpImportService
    {
        protected readonly ApplicationDbContext Context;


        public SumUpImportService(ApplicationDbContext context)
        {
            Context = context;
        }

        public List<SumUpTransactionModel> GetSumUpTransactions()
        {
            return Context.Set<SumUpTransactionModel>().ToList();
        }


        public List<SumUpTransactionModel> ImportSumUpTransaction(string csvContent)
        {
            csvContent = @"Date de la transaction,Code de la transaction,Type de transaction,Référence,Référence du paiement,employees.list.columns.status,Montant facturé débité,Montant facturé crédité,Devise de la carte,Montant de la transaction débité,Montant de la transaction crédité,Devise de la transaction,Taux de change,Frais,Solde disponible
27/01/2024 11:07,C94M4MY3GK,Paiement en ligne,URSSAFBOURGOGNE       DIJON           FR,,Approuvé,41.00,0.00,EUR,41.00,0.00,EUR,1.00,0.00,1474.56
24/01/2024 14:00,CO3ZJJVW44,Paiement POS,CERAM DECOR LYON      SAINT GENI      FR,,Approuvé,82.80,0.00,EUR,82.80,0.00,EUR,1.00,0.00,1515.56
15/01/2024 13:44,CDYJB4JVQR,Paiement entrant SumUp,PID 416160,,Entrant,0.00,31.20,EUR,0.00,31.20,EUR,1.00,0.00,1598.36
01/01/2024 11:27,CONELRNPYZ,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,145.00,EUR,0.00,145.00,EUR,1.00,0.00,1567.16
01/01/2024 01:07,CO77JG6KMP,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Vente Caroline,Approuvé,0.00,52.00,EUR,0.00,52.00,EUR,1.00,0.00,1422.16
06/12/2023 16:41,C9MZYX34K7,Paiement POS,CERAM DECOR L         SAINT GENI      FR,,Approuvé,55.52,0.00,EUR,55.52,0.00,EUR,1.00,0.00,1370.16
24/11/2023 17:12,CDBEJN6ZEV,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,34.00,EUR,0.00,34.00,EUR,1.00,0.00,1425.68
02/11/2023 13:33,COZNGX3NB3,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,105.00,EUR,0.00,105.00,EUR,1.00,0.00,1391.68
01/11/2023 00:49,COPNQYB3EP,Paiement en ligne,URSSAFBOURGOGNE       DIJON           FR,,Approuvé,58.00,0.00,EUR,58.00,0.00,EUR,1.00,0.00,1286.68
12/10/2023 21:15,C9YJ57Q3GQ,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,85.00,EUR,0.00,85.00,EUR,1.00,0.00,1344.68
06/10/2023 16:17,CD5XMVEQP3,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,100.00,EUR,0.00,100.00,EUR,1.00,0.00,1259.68
02/10/2023 16:47,CD27WRXWGL,Paiement POS,CERAM DECOR L         SAINT GENI      FR,,Approuvé,46.58,0.00,EUR,46.58,0.00,EUR,1.00,0.00,1159.68
18/09/2023 13:34,CO6GK7Z5RY,Paiement entrant SumUp,PID 354146,,Entrant,0.00,34.39,EUR,0.00,34.39,EUR,1.00,0.00,1206.26
17/09/2023 18:52,C9NEGW5BKL,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,163.00,EUR,0.00,163.00,EUR,1.00,0.00,1171.87
17/09/2023 13:35,COL2GWWW6Y,Paiement entrant SumUp,PID 353575,,Entrant,0.00,94.32,EUR,0.00,94.32,EUR,1.00,0.00,1008.87
12/09/2023 13:12,C96G2662WY,Virement entrant,M.OU MME CRETAINE DENIS FR7611006210070328099300184,,Approuvé,0.00,1.00,EUR,0.00,1.00,EUR,1.00,0.00,914.55
07/09/2023 13:39,CD6G2MGRZY,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,vente Sandrine,Approuvé,0.00,20.00,EUR,0.00,20.00,EUR,1.00,0.00,913.55
02/09/2023 14:31,CDNERWK3ML,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,plat tarte Debat,Approuvé,0.00,30.00,EUR,0.00,30.00,EUR,1.00,0.00,893.55
07/08/2023 17:08,COYJRQB4NV,Paiement POS,CERAM DECOR L         SAINT GENI      FR,,Approuvé,29.52,0.00,EUR,29.52,0.00,EUR,1.00,0.00,863.55
02/08/2023 12:52,CONEWQ5ERJ,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,vente Caroline passoire,Approuvé,0.00,35.00,EUR,0.00,35.00,EUR,1.00,0.00,893.07
02/08/2023 12:38,CD6GN7GW6G,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,vente Caroline,Approuvé,0.00,20.00,EUR,0.00,20.00,EUR,1.00,0.00,858.07
29/07/2023 14:14,C9Q6PZ6PZR,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Achat Caro passoire+ 5 repose cuillere,Approuvé,0.00,64.00,EUR,0.00,64.00,EUR,1.00,0.00,838.07
24/07/2023 19:16,C94M6E7G3Q,Virement sortant,Aurélien Cretaine FR7640618803520004050177127,Rmb Matière première ,Approuvé,93.24,0.00,EUR,93.24,0.00,EUR,1.00,0.00,774.07
24/07/2023 19:15,C9WM6K5XYP,Virement sortant,Aurélien Cretaine FR7640618803520004050177127,Rmb URSSAF,Approuvé,46.00,0.00,EUR,46.00,0.00,EUR,1.00,0.00,867.31
19/06/2023 14:21,CD273VBE5V,Virement entrant,M  CRETAINE AURELIEN FR7640618803520004050177127,Vente Sandrine salon -CHQ,Approuvé,0.00,85.00,EUR,0.00,85.00,EUR,1.00,0.00,913.31
10/06/2023 22:29,CO4MKM6YNZ,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,vente Sandrine coiffure,Approuvé,0.00,12.00,EUR,0.00,12.00,EUR,1.00,0.00,828.31
08/05/2023 15:22,CO6GYJ6GKV,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Vente marche Aiseray,Approuvé,0.00,55.00,EUR,0.00,55.00,EUR,1.00,0.00,816.31
08/05/2023 13:36,CD4M7WYNRJ,Paiement entrant SumUp,PID 287720,,Entrant,0.00,37.33,EUR,0.00,37.33,EUR,1.00,0.00,761.31
21/04/2023 13:30,COG45LQQGK,Paiement en ligne,URSSAFBOURGOGNE       DIJON           FR,,Approuvé,26.00,0.00,EUR,26.00,0.00,EUR,1.00,0.00,723.98
11/04/2023 23:00,CDJKKL7WEE,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Ventes Sandrine,Approuvé,0.00,125.00,EUR,0.00,125.00,EUR,1.00,0.00,749.98
11/04/2023 22:58,CD5XXKP6Z3,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Laurine Wadoux commande bols personnalise,Approuvé,0.00,55.00,EUR,0.00,55.00,EUR,1.00,0.00,624.98
25/03/2023 11:46,C94MWY365V,Paiement POS,CERAM DECOR L         SAINT GENI      FR,,Approuvé,31.97,0.00,EUR,31.97,0.00,EUR,1.00,0.00,569.98
21/02/2023 23:08,C9MLLN2L6D,Paiement en ligne,CERAM DECOR L         ST GENIS L      FR,,Approuvé,98.64,0.00,EUR,98.64,0.00,EUR,1.00,0.00,601.95
21/02/2023 11:25,CDKYQ4WNVO,Virement entrant,M  CRETAINE AURELIEN FR7640618803520004050177127,Ventes Sandrine Coiffure,Approuvé,0.00,203.00,EUR,0.00,203.00,EUR,1.00,0.00,700.59
26/01/2023 11:49,COLJBYZRQD,Paiement en ligne,URSSAFBOURGOGNE       DIJON           FR,,Approuvé,30.00,0.00,EUR,30.00,0.00,EUR,1.00,0.00,497.59
21/01/2023 12:13,CDVGXGNKED,Virement sortant,Aurélien Cretaine FR7640618803520004050177127,Remboursement MatPrem,Approuvé,57.93,0.00,EUR,57.93,0.00,EUR,1.00,0.00,527.59
28/12/2022 22:51,CO4X62MXVO,Virement sortant,Aurélien Cretaine FR7640618803520004050177127,erreur,Approuvé,154.00,0.00,EUR,154.00,0.00,EUR,1.00,0.00,585.52
28/12/2022 22:07,C9NL7QJQJO,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Remise de cheque,Approuvé,0.00,154.00,EUR,0.00,154.00,EUR,1.00,0.00,739.52
19/12/2022 15:41,C9Y3XPQQ6O,Virement entrant,Aurelien CRETAINE FR7640618803520004050177127,Deplacement de compte,Approuvé,0.00,551.13,EUR,0.00,551.13,EUR,1.00,0.00,585.52
19/12/2022 13:42,CDXWPR346O,Paiement entrant SumUp,PID 223230,,Entrant,0.00,34.39,EUR,0.00,34.39,EUR,1.00,0.00,34.39
";
            var result = new List<SumUpTransactionModel>();

            using (var reader = new StringReader(csvContent))
            {
                reader.ReadLine(); // Skip the header line
                reader.ReadLine(); // Skip the header line

                while (reader.Peek() != -1)
                {
                    var line = reader.ReadLine();
                    var columns = line.Split(',');

                    if (columns.Length != 15) // Ensure the line has the correct number of columns
                        continue;

                    if (Context.Set<SumUpTransactionModel>().Any(s => s.Code == columns[1]))
                        continue;

                    var record = new SumUpTransactionModel(columns[2], columns[5])
                    {
                        Date = DateTime.ParseExact(columns[0], "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                        Code = columns[1],
                        Reference = columns[3],
                        ReferencePaiement = columns[4],
                        MontantFactureDebit = decimal.Parse(columns[6], CultureInfo.InvariantCulture),
                        MontantFactureCredit = decimal.Parse(columns[7], CultureInfo.InvariantCulture),
                        Devise = columns[8],
                        MontantTransactionDebit = decimal.Parse(columns[9], CultureInfo.InvariantCulture),
                        MontantTransactionCredit = decimal.Parse(columns[10], CultureInfo.InvariantCulture),
                        DeviseTransaction = columns[11],
                        TauxChange = decimal.Parse(columns[12], CultureInfo.InvariantCulture),
                        TauxFrais = decimal.Parse(columns[13], CultureInfo.InvariantCulture),
                        Solde = decimal.Parse(columns[14], CultureInfo.InvariantCulture)
                    };

                    Context.Set<SumUpTransactionModel>().Add(record);
                    Context.SaveChanges();
                }
            }

            return result;
        }


        public async Task CreateNewTrimestre(Trimester trimester, int year, decimal? amountTaxe)
        {
            DateTime startDate;
            DateTime endDate;

            switch (trimester)
            {
                case Trimester.First:
                    startDate = new DateTime(year, 1, 1);
                    endDate = new DateTime(year, 3, 31);
                    break;
                case Trimester.Second:
                    startDate = new DateTime(year, 4, 1);
                    endDate = new DateTime(year, 6, 30);
                    break;
                case Trimester.Third:
                    startDate = new DateTime(year, 7, 1);
                    endDate = new DateTime(year, 9, 30);
                    break;
                case Trimester.Fourth:
                    startDate = new DateTime(year, 10, 1);
                    endDate = new DateTime(year, 12, 31);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(trimester), trimester, null);
            }

            List<SumUpTransactionModel> sumUpTransaction = await Context.Set<SumUpTransactionModel>()
                                                                        .Where(s => s.Date > startDate && s.Date < endDate && s.MontantFactureDebit == 0)
                                                                        .ToListAsync();

            UrsaffTrimesterModel ursaffTrimester = new()
            {
                Year = year,
                Trimester = trimester,
                IsPaid = amountTaxe.HasValue,
                ReportableAmount = sumUpTransaction.Sum(s => s.MontantTransactionCredit),
                Transactions = sumUpTransaction.Select(s => new TransactionModel()
                {
                    SumUpTransactionId = s.Id,
                }).ToList(),
            };
            if (amountTaxe.HasValue)
                ursaffTrimester.AmountTaxe = amountTaxe.Value;

            await Context.Set<UrsaffTrimesterModel>().AddAsync(ursaffTrimester);
            await Context.SaveChangesAsync();
        }

        public async Task<List<UrsaffTrimesterModel>> GetTrimester()
        {
            return await Context.Set<UrsaffTrimesterModel>().AsNoTracking()
                .Include(s => s.Transactions)
                .ToListAsync();
        }

    }
}