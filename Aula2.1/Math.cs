
namespace Aula2._1
{
    public class Math
    {
        //1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...
        public List<int> Fibonacci()
        {
            int atLeast = 350;
            int calc = 1;
            var result = new List<int>();
            result.Add(0);

            while (calc < atLeast)
            {
                result.Add(calc);
                var last = result.Count();
                calc = result[last - 2] + result[last - 1];
            }

            return result;
        }

        public bool IsFibonacci(int numberToTest)
        {
            var sequence = Fibonacci();
            return sequence.Contains(numberToTest);
        }
    }
}
