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
        [InlineData("1,2,4", 7)]
        [InlineData("2,3,4", 9)]
        public void ReturnsSumGivenStringWithThreeCommaSeparatedNumbers(string
            numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]
        public void ReturnsSumGivenStringWithThreeCommaOrNewLineSeparatedNumbers(string
            numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]       
        public void ReturnsSumGivenStringWithCostumDelimeter(string
            numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-1,2", "Negative is not allowed : -1")]
        [InlineData("-1,-2", "Negative is not allowed : -1, -2")]
        public void ThrowsGivenNegativeInputs(string
            numbers, string expectedMessage)
        {
            Action action = () => _calculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, ex.Message);
        }


        [Theory]
        [InlineData("1,2,3000", 7)]
        [InlineData("2003,4", 9)]
        [InlineData("1000,2", 2)]
        public void ReturnsSumGivenStringIgnoringValuesOver1000(string
           numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


    }
}