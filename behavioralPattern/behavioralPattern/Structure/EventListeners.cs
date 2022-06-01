using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioralPattern.Structure
{
    internal interface EventListeners
    {
        public void update(Invoice data);
        public string phoneNumber { get; set; }
    }
}
