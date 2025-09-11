using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Fnv1ATests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x6FDD4F52,
            0xCA36ACAF,
            0x9A4162D4,
            0xEE12A6D9,
            0xF8737FB4,
            0x9F9731FB,
            0x6B905AFB,
            0x90D0C569,
            0x70581647,
            0x19B8B736,
            0x92EDD3AE,
            0x673F1FFE,
            0x580266C3,
            0xCB5EA2B1,
            0xCD868602,
            0x73369F21,
            0x0AFFE987,
            0x1D1981B0,
            0xBEA7FBCA,
            0x4F8D4AF8,
            0xF1ABF536,
            0x029C6608,
            0xE2A2CB8D,
            0x08F54DCE,
            0xE0F78DFF,
        };

        [TestMethod]
        public void Fnv1A_ShouldMatch()
        {
            AssertHash(new Fnv1A(), Expected, nameof(Fnv1A));
        }
    }
}
