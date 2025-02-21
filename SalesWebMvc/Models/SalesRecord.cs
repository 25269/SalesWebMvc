using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateOnly Date {  get; set; }
        public double Amount { get; set; }
        public SalesStatus Satus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateOnly date, double amount, SalesStatus satus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Satus = satus;
            Seller = seller;
        }
    }
}
