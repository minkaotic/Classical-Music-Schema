using NUnit.Framework;

namespace WalkingSkeleton.Tests
{
    [TestFixture]
    public class WalkingSkeletonTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            Assert.That(Api.Status(), Is.EqualTo("200"));
        }
    }

    public class Api
    {
        public static string Status()
        {
            return "200";
        }
    }
}
