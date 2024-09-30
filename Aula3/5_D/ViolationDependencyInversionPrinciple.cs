
namespace Aula3._5_D
{
    public class ViolationDependencyInversionPrinciple
    {
        //“Programe para uma interface e não para uma implementação.”
    }
    public class MeuContextSql
    {
        public void myConnection()
        {

        }
    }

    public class PasswordReminderViolation
    {
        private MeuContextSql dbConnection;

        public PasswordReminderViolation()
        {
            //responsavel por criar instancia = forte acoplamento
            this.dbConnection = new MeuContextSql();
        }

        // Faz alguma coisa
    }
}
