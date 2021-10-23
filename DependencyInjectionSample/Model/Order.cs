using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Model
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage="İsim alanı boş bırakılamaz.")]
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
