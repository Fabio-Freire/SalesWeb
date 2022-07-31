using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Services
{
    public class SellerServices
    {
        private readonly SalesWebContext _context;

        
        public SellerServices(SalesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
