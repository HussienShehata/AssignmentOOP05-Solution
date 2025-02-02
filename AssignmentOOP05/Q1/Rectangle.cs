using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Q1
{
    internal class Rectangle : IRectangle
    {
        public double Length { get  ; set ; }
        public double Width { get; set; }
        public double Area { get ; set ; }

        public void DispalyShapeInfo()
        {
            Area = Length * Width;
            Console.WriteLine($"Dimensions of Rectangle is Length : {Length} and Width : {Width}\nArea of Rectangle : {Area}");
        }
    }
}
