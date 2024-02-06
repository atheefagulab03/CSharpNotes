using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    
    public class Class1
    {
        public void Canva(List<shape> shapes)
        {
            foreach(shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
