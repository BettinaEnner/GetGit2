using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGit
{
    internal class Square : Shape
    {
        private int side;
        public Square(int a) 
        {
            this.side = a;
        }
        public override int GetArea()
            {
                return this.side * this.side;
            }
    }

}
