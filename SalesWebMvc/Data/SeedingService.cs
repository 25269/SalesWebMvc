using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if ( _context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "TV");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", DateOnly.Parse("2000-12-12") , 1000.00, d1);

            SalesRecord sr1 = new SalesRecord(1, DateOnly.Parse("12/02/2025"), 100.00, SalesStatus.Billed ,s1);

            _context.Department.AddRange(d1);

            _context.Seller.AddRange(s1);

            _context.SalesRecord.AddRange(sr1);

            _context.SaveChanges();

        }
    }
}
