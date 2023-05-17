using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedElements;
using SharedElements.Helpers;
using SharedElements.Services;
using Xunit;

namespace SharedElementsTests
{
    public class UserHelpersTests
    {
        [Fact]
        public void CheckIfDateIsPast_Valid()
        {
            //any date that is not past
            bool actual = UserHelpers.CheckIfDateIsValid(new DateTime(2023, 4, 5));

            Assert.True(actual);
        }

        [Theory]
        [InlineData("0001-03-28")]//bardzo wczesna data
        [InlineData("2023-03-27")]//wczesniejsza data
        public void CheckIfDateIsPast_Invalid(string date)
        {
            DateTime dateConverted = DateTime.Parse(date);
            bool actual = UserHelpers.CheckIfDateIsValid(dateConverted);

            Assert.False(actual);
        }

    }
}
