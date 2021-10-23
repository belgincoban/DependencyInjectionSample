using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Service
{
   public interface IDbService
    {
        void GetData();
        void Add();
        void Update();
    }
}
