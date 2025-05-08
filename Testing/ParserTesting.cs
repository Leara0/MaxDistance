using MainProgram;

namespace Testing;

public class ParserTesting
{
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            //var tacoParser = new Parse();

            //Act
            var actual = Parse.ParseCSV("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData(".071477,-84.296345,Taco Bell Alpharett...", -84.296345)]
        [InlineData(".047374,-84.223918,Taco Bell Alpharetta...", -84.223918)]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", -84.283254)]
        [InlineData("32.072974,-84.222921,Taco Bell Americu...", -84.222921)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", -85.826674)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", -86.503055)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...)]", -86.841402)]
        public void ParseLongitudeTest(string line, double expected)
        {
            
            var actual = Parse.ParseCSV(line).Location.Longitude;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData(".071477,-84.296345,Taco Bell Alpharett...", .071477)]
        [InlineData(".047374,-84.223918,Taco Bell Alpharetta...", .047374)]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", 34.039588)]
        [InlineData("32.072974,-84.222921,Taco Bell Americu...", 32.072974)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", 33.671982)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", 34.324462)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...)]", 34.992219)]
        public void ParseLatitudeTest(string line, double expected)
        {
            
            var actual = Parse.ParseCSV(line).Location.Latitude;
            Assert.Equal(actual, expected);
        }
    }