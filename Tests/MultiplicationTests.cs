using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class MultiplicationTests
    {
        private Multiplication _multiplication;

        [SetUp]
        public void Setup()
        {
            _multiplication = new Multiplication();
        }

        [Test]
        public void Multiply_Should_Return_Correct_Product()
        {
            double result = _multiplication.Multiply(5, 6);

            Assert.That(result, Is.EqualTo(30));
        }
    }
}
