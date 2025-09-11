using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Checksum;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Adler16Tests : HashChecksumTestBase
    {
        private static readonly ushort[] Expected = new ushort[] {
            0x4130,
            0x5BD2,
            0x7082,
            0xDA7C,
            0xE056,
            0xCE23,
            0x06EE,
            0x2A90,
            0x5A18,
            0x614E,
            0x451F,
            0x3B33,
            0xE642,
            0xF131,
            0x55DD,
            0x7978,
            0x1221,
            0xA944,
            0x1D1D,
            0x6E2F,
            0x150D,
            0x3FE5,
            0x62B6,
            0xF2D7,
            0x00B0,
        };

        [TestMethod]
        public void Adler16_ShouldMatch()
        {
            AssertChecksum(new Adler16(), Expected, nameof(Adler16));
        }
    }
}
