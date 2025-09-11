using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class GeneralizedCrcTests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x84AF31A9,
            0xF40B009E,
            0x20ADBC2C,
            0x749A5039,
            0x78919AE6,
            0xCDEC0466,
            0x433225B2,
            0xB156887B,
            0xF279DB2A,
            0xDF08DD8C,
            0xE396B426,
            0xE3F49746,
            0xED841AB2,
            0xCDACB8A3,
            0xC35E74A9,
            0xF8ACC779,
            0x6A7B0112,
            0x364160C0,
            0x0E2A9825,
            0xE114B031,
            0x4E830889,
            0xAF6DE003,
            0x90345566,
            0x2C3B695F,
            0x44B048E1,
        };

        [TestMethod]
        public void GeneralizedCrc_ShouldMatch()
        {
            AssertHash(new GeneralizedCrc(), Expected, nameof(GeneralizedCrc));
        }
    }
}
