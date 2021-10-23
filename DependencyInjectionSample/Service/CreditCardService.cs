using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
    public class CreditCardService : ICreditCardService
    {
        public void CreditCardinfo()
        {
            Console.WriteLine("Kredi kartınıza ait bilgilerinizi doldurunuz.");
        }
    }
}
