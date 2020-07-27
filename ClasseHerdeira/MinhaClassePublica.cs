using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseHerdada
{
    public class MinhaClassePublica 
    {
        public int idadePublica;

        public void Call()
        {
            var interna = new MinhaClasseInterna();
            interna.idadeInterna = 10;
            
            var privada = new MinhaClassePrivada();

            var protegida = new MinhaClasseProtegida();
            protegida.idadeProtegida = 10;
            // idadeProtegida = 15;
        }
    }
}
