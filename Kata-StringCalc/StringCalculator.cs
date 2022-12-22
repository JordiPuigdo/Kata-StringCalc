namespace Kata_StringCalc
{
    public class StringCalculator
    {
        internal object Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var delimiters = new List<Char> { ',', '\n' };

            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');

                var newDelimeter = splitInput.First().Trim('/');

                numberString = String.Join('\n',splitInput.Skip(1));

                delimiters.Add(Convert.ToChar(newDelimeter));
            }

            var result = numberString.Split(delimiters.ToArray())
                    .Select(s => int.Parse(s))
                    .Sum();

            return result; 
        }
    }
}