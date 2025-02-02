using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Q1
{
    internal interface ICircle : IShape 
    {
        public Double Radius {  get; set; }
        public Double Area{ get; set; }
        public void DispalyShapeInfo();


        

        
    }
}
