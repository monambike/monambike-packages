namespace Monambike.Test
{
    [TestClass]
    public class MainUnitTest
    {
        [TestMethod]
        public void Main()
        {
            var test = Core.Models.Github.GetGithubRepositories();
        }
    }
}