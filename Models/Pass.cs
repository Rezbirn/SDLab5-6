using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLab5_6.Models
{
    internal class Pass
    {
        public readonly string Id;
        public readonly DateOnly Date;
        public Pass(string id, DateOnly date)
        {
            Id = id;
            Date = date;
        }
        public Pass()
        {
            Id = Guid.NewGuid().ToString();
            Date = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
