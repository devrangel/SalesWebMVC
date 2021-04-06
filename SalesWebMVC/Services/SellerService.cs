using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
    }
}
