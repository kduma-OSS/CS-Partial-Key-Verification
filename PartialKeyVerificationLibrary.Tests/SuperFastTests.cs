using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class SuperFastTests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0xA289C6D1,
            0x3DF1DCD6,
            0x9DB70BE5,
            0xE56B7B96,
            0x36C02AC5,
            0xE6AB59B9,
            0xF8E9A2A4,
            0x194BA196,
            0x3466B0E1,
            0x77077736,
            0xC46517ED,
            0x8A532003,
            0x7F790033,
            0x05476BDC,
            0xD4B0D2F3,
            0x4F39F726,
            0x379EDA05,
            0x1E7B89A7,
            0x21C860BD,
            0xC219F6F2,
            0xD34AA113,
            0xC77AACA7,
            0xDE252A2D,
            0x061AD379,
            0x18A47F49,
        };

        [TestMethod]
        public void SuperFast_ShouldMatch()
        {
            AssertHash(new SuperFast(), Expected, nameof(SuperFast));
        }
    }
}
