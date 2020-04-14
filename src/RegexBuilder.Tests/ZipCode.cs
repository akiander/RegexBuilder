using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexBuilder.Tests
{
    [TestClass]
    public class ZipCode
    {
        [TestMethod()]
        public void ZipCodeTest()
        {
            var pattern = ""
                .WordBoundary()
                .Exactly(5,
                    p => p.Numeric()
                )
                .Optional(p => p
                    .Literal("-")
                    .Exactly(4, 
                        q => q.Numeric())
                    )
                .WordBoundary();

            Assert.IsTrue(Regex.IsMatch("04098-1234", pattern));
            Assert.IsTrue(Regex.IsMatch("04096", pattern));
            Assert.IsFalse(Regex.IsMatch("4096", pattern));
            Assert.IsFalse(Regex.IsMatch("z4096", pattern));
            Assert.IsFalse(Regex.IsMatch("abcde-3333", pattern));

        }

    }
}
