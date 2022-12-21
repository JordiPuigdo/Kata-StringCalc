namespace Kata_StringCalc
{
    public class StringCalculator_Add
    {
        [Fact]
        public void Return0GivenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        public void Return1GivenStringWith1( string 
                numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}