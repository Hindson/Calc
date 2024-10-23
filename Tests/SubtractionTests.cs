using ClassLibrary;

namespace Tests
{
    internal class SubtractionTests
    {
        private Subtraction _subtraction;

        [SetUp]
        public void Setup()
        {
            _subtraction = new Subtraction();
        }

        [Test]
        public void Subtract_Should_Return_Correct_Difference()
        {
            double result = _subtraction.Subtract(5, 6);

            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
