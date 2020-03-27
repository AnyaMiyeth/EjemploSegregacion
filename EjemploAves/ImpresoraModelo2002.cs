using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAves
{
    class ImpresoraModelo2002 : Impresora, IFotocopia,IEscaner
    {
        public void Escanear()
        {
            throw new NotImplementedException();
        }

        public void Fotocopiar()
        {
            throw new NotImplementedException();
        }

        public override void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
