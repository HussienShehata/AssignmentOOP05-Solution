using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Q1
{
    internal class Circle : ICircle
    {
        public Double Radius { get; set; }
        public Double Area { get ; set; }
     

        public void DispalyShapeInfo()
        {
            
            Area = Math.Pow(Radius, 2)*3.14;
                Console.WriteLine($"Radius od Circle is {Radius} and the Area is {Area}");
        }


    }
}
