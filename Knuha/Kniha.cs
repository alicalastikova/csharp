using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Knuha
{
    internal class Kniha
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public bool PreDospelich { get; set; }

        public int Rokvzdania { get; set; }
    }
}
