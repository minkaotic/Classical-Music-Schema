using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Classical_Music_Integration_Tests
{
    [TestFixture]
    public class MiceAreMiceTest
    {
        [Test]
        public void A_mouse_is_a_mouse()
        {
            string mouse1 = "mouse";
            string mouse2 = "mouse";

            Assert.That(mouse1, Is.EqualTo(mouse2));
        }
    }
}
