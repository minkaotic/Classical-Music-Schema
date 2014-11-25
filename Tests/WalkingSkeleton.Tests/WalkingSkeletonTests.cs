using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classical_Music_Schema;
using NUnit.Framework;

namespace WalkingSkeleton.Tests
{
    [TestFixture]
    public class WalkingSkeletonTests
    {
        [Test]
        public void It_should_return_a_status_code_of_200()
        {
            Assert.That(Api.StatusCode(), Is.EqualTo("200"));
        }
    }
}
