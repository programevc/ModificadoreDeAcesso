using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseHerdada
{
    public class MinhaClasseProtegida
    {
        protected internal int idadeProtegida;

        void call()
        {
            idadeProtegida = 10;
        }
    }
}
