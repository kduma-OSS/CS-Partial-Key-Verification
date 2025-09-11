using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Checksum;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class CrcCcittTests : HashChecksumTestBase
    {
        private static readonly ushort[] Expected = new ushort[] {
            0xE546,
            0x6F42,
            0xA8C0,
            0xD48F,
            0x20CF,
            0xAB65,
            0x7E5B,
            0x5556,
            0x4803,
            0x292D,
            0x0EB7,
            0x7C11,
            0xAB3C,
            0xC892,
            0x6371,
            0x0131,
            0xAF39,
            0x2C54,
            0x5333,
            0x20AC,
            0x4950,
            0x7279,
            0x36AF,
            0x89D8,
            0x5A2A,
            0xFFFF,
            0xE1F0,
        };

        [TestMethod]
        public void CrcCcitt_ShouldMatch()
        {
            AssertChecksum(new CrcCcitt(), Expected, nameof(CrcCcitt));
        }
    }
}
