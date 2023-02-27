using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04_InterfaceSegregation
{
    internal interface IPayment
    {
        void PayUsingCreditCard();
        void PayUsingCash();
        void PayUsingDebitCard();
        void PayUsingSmartPhone();        
    }    
}
