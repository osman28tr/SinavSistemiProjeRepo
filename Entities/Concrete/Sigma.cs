using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Sigma:IEntity
    {
        public int SigmaId { get; set; }
        public int Sigma1 { get; set; }
        public int Sigma2 { get; set; }
        public int Sigma3 { get; set; }
        public int Sigma4 { get; set; }
        public int Sigma5 { get; set; }
        public int Sigma6 { get; set; }
    }
}
