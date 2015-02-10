using NUnit.Framework;

namespace Classical_Music_Unit_Tests
{
    [TestFixture]
    public class CatsAreCatsTest
    {
        [Test]
        public void A_cat_is_a_cat()
        {
            string cat1 = "cat";
            string cat2 = "cat";

            Assert.That(cat1, Is.EqualTo(cat2));
        }
    }
}
