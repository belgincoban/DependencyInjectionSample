using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
    public class SmsSenderService:IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine("Bilgilendirildi");
        }
    }
}
