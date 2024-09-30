
namespace Aula3._3_L
{
    public class LiskovSubstitutionPrinciple
    {
        //Barbara Liskov 
        //Uma classe derivada deve ser substituível por sua classe base.
        //Passando parâmetro tanto a classe pai como a classe derivada, o código deve continuar funcionando

        public void ImpremeClassesAeB()
        {
            var objeto1 = new A();
            ImprimeNome(objeto1);

            var objeto2 = new B();
            ImprimeNome(objeto2);
        }
        
        public string ImprimeNome(A objeto)
        {
            return objeto.GetNome();
        }
    }

    public class A
    {
        public string GetNome()
        {
            return "Meu nome é A";
        }
    }

    public class B : A
    {
        public string GetNome()
        {
            return "Meu nome é B";
        }
    }
}
