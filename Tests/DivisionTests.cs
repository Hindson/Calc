using ClassLibrary;

namespace Tests
{
    public class Tests
    {
        private Division _division;

        [SetUp]
        public void Setup()
        {
            _division = new Division();
        }

        [Test]
        public void DivideShouldReturnCorrectQuotient()
        {
            double result = _division.Divide(10, 2);
                        
            Assert.That(result, Is.EqualTo(5));
        }
    }
}