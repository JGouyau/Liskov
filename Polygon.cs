using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    abstract class  Polygon
    {
        internal double Area { get; set; } //Je l'ai mise parce que c'est demandé mais la je ne vois pas a quoi ca serts

        public abstract double GetArea();

    }
}
