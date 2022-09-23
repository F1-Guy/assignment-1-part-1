using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace assignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private readonly FootballPlayer goodPlayer = new() { Id = 1, Name = "Digna", Age = 22, ShirtNumber = 69 };

        [TestMethod()]
        public void ValidateNameTest()
        {
            FootballPlayer noname = new() { Id = 2, Name = "", Age = 50, ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => noname.ValidateName());

            FootballPlayer shortNamePlayer = new() { Id = 2, Name = "O", Age = 50, ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shortNamePlayer.ValidateName());

            FootballPlayer shortNamePlayer2 = new() { Id = 3, Name = "Ba", Age = 50, ShirtNumber = 50 };
            shortNamePlayer2.ValidateName();

            goodPlayer.ValidateName();
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            FootballPlayer babyPlayer = new() { Id = 4, Name = "Szymon", Age = 0, ShirtNumber = 50 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => babyPlayer.ValidateAge());

            FootballPlayer babyPlayer1 = new() { Id = 5, Name = "Maria", Age = 1, ShirtNumber = 50 };
            babyPlayer1.ValidateAge();

            goodPlayer.ValidateAge();
        }

        [TestMethod()]
        public void ValidateNoTest()
        {
            FootballPlayer wrongShirtNumberPlayer = new() { Id = 6, Name = "Szymon", Age = 50, ShirtNumber = -69 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => wrongShirtNumberPlayer.ValidateNo());

            FootballPlayer wrongShirtNumberPlayer2 = new() { Id = 7, Name = "Szymon", Age = 50, ShirtNumber = 2000 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => wrongShirtNumberPlayer2.ValidateNo());

            FootballPlayer edgeCasePlayer = new() { Id = 8, Name = "Szymon", Age = 50, ShirtNumber = 1 };
            edgeCasePlayer.ValidateNo();

            FootballPlayer edgeCasePlayer2 = new() { Id = 9, Name = "Szymon", Age = 50, ShirtNumber = 99 };
            edgeCasePlayer.ValidateNo();

            goodPlayer.ValidateAge();
        }
    }
}