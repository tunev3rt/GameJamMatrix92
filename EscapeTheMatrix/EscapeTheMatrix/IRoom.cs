using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheMatrix
{
    public interface IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }
    }
}