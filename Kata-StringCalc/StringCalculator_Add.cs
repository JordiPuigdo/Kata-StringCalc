namespace Kata_StringCalc
{
  
    public class StringCalculator_Add
    {
        private StringCalculator _calculator = new StringCalculator();

        [Fact]
        public void Return0GivenEmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("2,3", 5)]
        public void ReturnsSumGivenStringWithTwoCommaSeparatedNumbers( string 
                numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("1,2,4", 6)]
        [InlineData("2,3,4", 9)]
        public void ReturnsSumGivenStringWithThreeCommaSeparatedNumbers(string
        numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

    }
}