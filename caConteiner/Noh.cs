using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caConteiner
{
    internal class Noh
    {
        public int info { get; set; }
        public Noh proximo { get; set; }

        public Noh anterior { get; set; }

        public Noh() { }    
        public Noh(int info)
        {
            this.info = info;
            this.proximo = null;
            this.anterior = null;
        }


    }
}
