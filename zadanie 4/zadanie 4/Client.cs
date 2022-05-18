using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Client
    {
        public Client()
        {
            Orders = new List<Order>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}