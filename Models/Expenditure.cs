namespace QueteRazor.Models
{
    public class Expenditure
    {
        public int ExpenditureId { get; set; }
        public string ExpenditureName { get; set; } = string.Empty;
        public DateTime ExpenditureDate { get; set; }
        public double ExpenditurePrice { get; set; }
    }
}
