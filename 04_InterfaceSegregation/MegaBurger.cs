using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04_InterfaceSegregation
{
    internal class MegaBurger : IPayment, IRatingService, IOrder
    {
        public void PayUsingCreditCard()
        {
            throw new NotImplementedException();
        }

        public void PayUsingCash()
        {
            throw new NotImplementedException();
        }

        public void PayUsingDebitCard()
        {
            throw new NotImplementedException();
        }

        public void PayUsingSmartPhone()
        {
            throw new NotImplementedException();
        }

        public void CustomerRatingService()
        {
            throw new NotImplementedException();
        }

        public void TakePhoneOrder()
        {
            throw new NotImplementedException();
        }
    }    
}
