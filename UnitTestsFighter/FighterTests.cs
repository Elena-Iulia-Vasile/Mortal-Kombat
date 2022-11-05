using Fighter;

namespace UnitTestsFighters
{
    public class FightersTests : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void FighterBasic_ConstructorThatInitialiseAndCreateClass()
        {
            // nu sunt sigur ca ai inteles ce sunt unit testele
            //Arrange
            var sut = new FighterBasic("Fighter");

            //Act
            var actual = sut.Name == "Fighter" && sut.Life == 100 && sut.Power == 80 && sut.HealthPoints == 80;

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Hit_HealthPointsShouldModify()
        {
            //Arrange


            //Act


            //Assert
        }

        [Fact]
        public void FighterJax_ConstructorThatInitialiseAndCreateObject()
        {
            //Arrange
            var sut = new Jax("Jax");

            //Act
            var actual = sut.Name == "Sonya" && sut.Life == 100 && sut.Power == 80 && sut.HealthPoints == 100;

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void FighterSonya_ConstructorThatInitialiseAndCreateObject()
        {
            //Arrange
            var sut = new FighterBasic("Sonya");

            //Act
            var actual = sut.Name == "Sonya" && sut.Life == 100 && sut.Power == 80 && sut.HealthPoints == 100;

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void FighterScorpion_ConstructorThatInitialiseAndCreateObject()
        {
            //Arrange
            var sut = new FighterBasic("Scorpion");

            //Act
            var actual = sut.Name == "Scorpion" && sut.Life == 100 && sut.Power == 100 && sut.HealthPoints == 99;

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void FighterWarrior_ConstructorThatInitialiseAndCreateObject()
        {
            //Arrange
            var sut = new FighterBasic("Warrior");

            //Act
            var actual = sut.Name == "Warrior" && sut.Life == 100 && sut.Power == 102 && sut.HealthPoints == 98;

            //Assert
            Assert.True(actual);
        }
    }
}