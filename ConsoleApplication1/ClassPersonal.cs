using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miclase2
{ 
    class ClassPersonal
    {
        //los atributos
       
        public string nombres;
        public string apellidos;
        public int rut;
        public int edad;
        public int cargo;
        //los metodos
        // cargo 1 para aseo, 2 para supervisor
        public ClassPersonal(string nombres, string apellidos, int rut, int edad, int cargo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.rut = rut;
            this.edad = edad;
            this.cargo = cargo;
        }

        public ClassPersonal()
        {
        }
        public void ModificarPerso(string nom,string a,int r,int e, int c)
        {
            this.nombres = nom;
            this.apellidos = a;
            this.rut = r;
            this.edad = e;
            this.cargo = c;
        }
    }
}
