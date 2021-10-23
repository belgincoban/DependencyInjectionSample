using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
    public class DbService : IDbService
    {
        public void Add()
        {
            Console.WriteLine("added");
        }

        public void GetData()
        {
            Console.WriteLine("readed");
        }

        public void Update()
        {
            Console.WriteLine("updated");
        }
    }
}
