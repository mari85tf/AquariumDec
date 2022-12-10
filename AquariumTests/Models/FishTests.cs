using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquarium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Models.Tests
{
    [TestClass()]
    public class FishTests
    {
        private readonly Fish fish = new Fish() { Id = 1, Name = "Fish", Length = 10 };
        private readonly Fish nullName = new Fish() { Id = 1, Name = null, Length = 10 };
        private readonly Fish onecharName = new Fish() { Id = 1, Name = "F", Length = 10 };
        private readonly Fish negLength = new Fish() { Id = 1, Name = "Fish", Length = -10 };
        private readonly Fish nullLength = new Fish() { Id = 1, Name = "Fish", Length = null };

        [TestMethod()]
        public void ToStringTest()
        {
            string actual = fish.ToString();
            string expected = "Id: 1 Name: Fish Length: 10";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            fish.ValidateName();

            Assert.ThrowsException<ArgumentNullException>(() => nullName.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => onecharName.ValidateName());
        }

        [TestMethod()]
        public void ValidateLengthTest()
        {
            fish.ValidateLength();

            Assert.ThrowsException<ArgumentNullException>(() => nullLength.ValidateLength());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => negLength.ValidateLength());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            fish.Validate();

        }
    }
}