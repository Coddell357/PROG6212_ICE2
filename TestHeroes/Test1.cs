using Indexers_ICE2;

namespace TestHeroes
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestName()
        {
            Heroes hero = new Heroes("Wanda Maximoff", 30, "Chaos Magic", "Kids", "determined", "Older sister");
            Assert.AreEqual(hero[0], "Wanda Maximoff");
        }

        [TestMethod]
        public void TestAge()
        {
            Heroes hero = new Heroes("Black Widow", 33, "Skilled Assassin", "Sister", "Strong", "Spy");
            Assert.AreEqual(hero[1], 33);
        }

        [TestMethod]
        public void TestSuperPower()
        {
            Heroes hero = new Heroes("Loki", 27, "Sorcerer", "Love", "Funny", "Adopted Son");
            hero[2] = "Illusion";
            Assert.AreEqual(hero[2], "Illusion");
        }

        [TestMethod]
        public void TestPersonality()
        {
            Heroes hero = new Heroes("Spiderman", 23, "Web abilities", "Relationships", "Multi-task", "Orphan");
            Assert.AreEqual(hero["personality"], "Multi-task");
        }

        [TestMethod]
        public void TestBackground()
        {
            Heroes hero = new Heroes("Iron Man", 40, "SuperHuman Suit", "Hackers", "Intelligent", "Domestic Worker");
            hero[5] = "Father";
            Assert.AreEqual(hero["background"], "Father");
        }

    }
}
