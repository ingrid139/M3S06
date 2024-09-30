using System;

namespace Aula3._4_I
{
    public class ViolationInterfaceSegregationPrinciple
    {
        /*Uma classe não deve ser forçada a implementar interfaces 
            e métodos que não irão utilizar.*/
    }
    interface AvesViolation
    {
        int setLocalizacao(int longitude, int latitude);
        int setAltitude(int altitude);
    }

    public class PapagaioViolation : AvesViolation
    {
        public int setLocalizacao(int longitude, int latitude)
        {
            //Faz alguma coisa
            return 0;
        }

        public int setAltitude(int altitude)
        {
            //Faz alguma coisa  
            return 0;
        }

    }

    public class PinguimViolation : AvesViolation
    {
        public int setLocalizacao(int longitude, int latitude)
        {
            //Faz alguma coisa
            return 0;
        }

        // A Interface Aves está forçando a Classe Pinguim a implementar esse método.
        // Isso viola o príncipio ISP
        public int setAltitude(int altitude)
        {
            //Não faz nada...  Pinguins são aves que não voam!
            throw new NotImplementedException();
        }
    }
}

