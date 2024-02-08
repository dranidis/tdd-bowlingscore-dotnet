namespace BowlingScore

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] { 0 }, 0)]
        [DataRow(new int[] { 3 }, 3)]
        [DataRow(new int[] { 3, 3 }, 6)]
        [DataRow(new int[] { 3, 3, 3}, 9)]
        [DataRow(new int[] { 3, 7, 3}, 16)]
        [DataRow(new int[] { 10, 0, 3 }, 16)]
        [DataRow(new int[] { 3, 7, 3, 3}, 19)]
        // [DataRow(new int[] { 10, 0, 3, 3 }, 22)]
        public void TestRunningScore(int[] rolls, int expectedCurrentScore)
        {
            // ACT
            int actualCurrentScore = BowlingScore.getRunningScore(rolls);

            // ASSERT
            Assert.AreEqual(expectedCurrentScore, actualCurrentScore);
        }
    }
}