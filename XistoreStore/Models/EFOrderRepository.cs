using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace XistoreStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private AplicationDbContext _context;
        public EFOrderRepository(AplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Order> Orders => _context.Orders
        .Include(o => o.Lines)
        .ThenInclude(i => i.Product);
        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(i => i.Product));
            if(order.OrderID==0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}
