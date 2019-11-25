using MOD.PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Repository
{
    public interface IPaymentRepository
    {
        void AddPayment(Payment item);

        void UpdatePayment(Payment item);


    }
}
