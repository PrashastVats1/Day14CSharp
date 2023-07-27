using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppVirtualProperty
{
    public class Emp
    {
        int id;
        public Emp()
        {
            id = -1;
        }
        public virtual int Id { get { return id; } set { id = value; }  }
    }
}
