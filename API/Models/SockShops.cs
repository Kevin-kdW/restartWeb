using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SockShops
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Sock> Socks { get; set; } = default!;
        public int SockId { get; set; }
    }
}