using MOD.PaymentService.Context;
using MOD.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void AddPayment(Payment item)
        {
            try
            {
                _context.Payment.Add(item);
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
         
        }
        public void UpdatePayment(Payment item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
          
        }
    }
}
