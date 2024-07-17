using QueteRazor.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace QueteRazor.Repository
{
    public static class ExpenditureRepository
    {
        //Set values for Expenditures
        private static List<Expenditure> _expenditures = new List<Expenditure>()
        {
            new Expenditure()
            {
                ExpenditureId = 1,
                ExpenditureName = "Expenditure1",
                ExpenditureDate = Convert.ToDateTime("2024-07-06", CultureInfo.InvariantCulture), 
                ExpenditurePrice = 60.98,
            },
            new Expenditure() 
            {
                ExpenditureId = 2,
                ExpenditureName = "Expenditure2",
                ExpenditureDate = Convert.ToDateTime("2022-09-09", CultureInfo.InvariantCulture),
                ExpenditurePrice = 345.00,
            },
            new Expenditure() 
            {
                ExpenditureId = 3,
                ExpenditureName = "Expenditure3",
                ExpenditureDate = Convert.ToDateTime("1991-03-23", CultureInfo.InvariantCulture),
                ExpenditurePrice = 49.00,
            }
        };

        //Get list of Expenditures
        public static List<Expenditure> GetExpenditures() => _expenditures;


    }
}
