namespace Aula1
{
    public class Variaveis
    {
        public void Examples()
        {
            // Nome descritivo que indica claramente o propósito da variável
            int totalScore = 0;

            // Evitando abreviações confusas
            string customerAddress = "123 Main St";

            // Seguindo a convenção camelCase para variáveis locais em C#
            int numberOfStudents = 25;

            // Encontrando um equilíbrio entre clareza e brevidade
            string firstName = "John";
            string lastName = "Doe";
        }
    }
    // Seguindo a convenção PascalCase para classes
    public class StudentRecord
    {
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }

    // Evitando redundância no nome da variável
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    // Em vez de:
    // public string CarMake { get; set; }
    // public string CarModel { get; set; }
}
