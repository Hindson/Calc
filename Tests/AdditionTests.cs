using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class AdditionTests
    {
        private Addition _addition;

        [SetUp]
        public void Setup()
        {
            _addition = new Addition();
        }

        [Test]
        public void Add_Should_Return_Correct_Sum()
        {
            double result = _addition.Add(5, 6);

            Assert.That(result, Is.EqualTo(11));
        }
    }
}
