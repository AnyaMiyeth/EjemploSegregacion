using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAves
{
    public class Aguila : Aves
    {
    
        public override void Cantar()
        {
            throw new NotImplementedException();
        }

        public override void Comer()
        {

            volar();
        }

        public void volar()
        {
            throw new NotImplementedException();
        }
    }
}
