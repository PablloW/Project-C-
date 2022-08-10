using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Fashion");
            Department d2 = new Department(2, "Computers");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Eletronics");
            Department d5 = new Department(4, "Automobiles");

            Seller s1 = new Seller(1, "Karoline Borges", "karolineborgesmota@gmail.com", new DateTime(1999, 9, 16), 1500.0, d1);
            Seller s2 = new Seller(2, "Pablo Wendrey", "pabllowendrey@gmail.com", new DateTime(1991, 4, 17), 2500.0, d2);
            Seller s3 = new Seller(3, "Angeline Borges", "angelineborgesmota@gmail.com", new DateTime(2017, 7, 26), 1500.0, d4);
            Seller s4 = new Seller(4, "Ana Cecilia", "anacecilia@gmail.com", new DateTime(2022, 5, 2), 500.0, d4);
            Seller s5 = new Seller(5, "Ana Rita", "anarita@gmail.com", new DateTime(1969, 5, 23), 5800.0, d3);
            Seller s6 = new Seller(6, "Raimundo Marinho", "raimundomarinho@gmail.com", new DateTime(1964, 8, 31), 3200.0, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 07, 5), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 07, 5), 1000.0, SaleStatus.Billed, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 07, 6), 21000.0, SaleStatus.Billed, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 07, 7), 100.0, SaleStatus.Billed, s5);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 07, 8), 110.0, SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 07, 8), 500.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 07, 8), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 07, 9), 2000.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 07, 10), 15000.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 07, 10), 16000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 07, 10), 900.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 07, 10), 200.0, SaleStatus.Billed, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 07, 10), 570.0, SaleStatus.Billed, s2);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 07, 10), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2022, 07, 10), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 08, 1), 31000.0, SaleStatus.Billed, s5);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 08, 2), 1000.0, SaleStatus.Billed, s6);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 08, 3), 140.0, SaleStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 08, 4), 1400.0, SaleStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2022, 08, 4), 2800.0, SaleStatus.Billed, s3);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2022, 08, 4), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2022, 08, 10), 30000.0, SaleStatus.Billed, s5);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2022, 08, 10), 1650.0, SaleStatus.Billed, s6);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2022, 08, 10), 105.0, SaleStatus.Billed, s1);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2022, 08, 10), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2022, 08, 25), 11230.0, SaleStatus.Billed, s3);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2022, 08, 25), 1900.0, SaleStatus.Billed, s4);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2022, 08, 26), 11200.0, SaleStatus.Billed, s5);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2022, 08, 28), 11600.0, SaleStatus.Billed, s6);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2022, 08, 28), 1000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
