using Aula1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Refatoracao
{
    public class Juncao
    {
        //Situação: O corpo do método é tão simples e claro quanto o seu nome.
        //Solução: Substituir a chamada ao método por seu corpo e remover o método.
        private int _numberOfLateDeliveries = 6; // Valor de exemplo

        //ANTES
        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        public bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }


        //DEPOIS
        public int GetRatingRefact()
        {
            return (_numberOfLateDeliveries > 5) ? 2 : 1;
        }

    }
}
