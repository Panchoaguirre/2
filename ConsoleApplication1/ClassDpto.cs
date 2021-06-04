using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miclase2
{
    class ClassDpto
    {
        //los atributos
        public int numero;
        public string torre;
        public int piezas;
        public int baños;
        //los metodos
        
        public ClassDpto(int numero, string torre, int piezas, int baños)
        {
            this.numero = numero;
            this.torre = torre;
            this.piezas = piezas;
            this.baños = baños;

        }

        public ClassDpto()
        {
        }
        
        public void ModificarDpto(int n,string t, int p, int b)
        {
            this.numero = n;
            this.torre = t;
            this.piezas = p;
            this.baños = b;
        }
       
    
     }


    }
    
