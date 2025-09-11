using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Checksum;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Crc16Tests : HashChecksumTestBase
    {
        private static readonly ushort[] Expected = new ushort[] {
            0xCCD4,
            0x288D,
            0xBBD6,
            0x7889,
            0xFA6E,
            0x4D4C,
            0x55BA,
            0xF168,
            0x1AE6,
            0x9D5F,
            0xF01A,
            0xBF56,
            0x656B,
            0x6B9B,
            0x629B,
            0x682F,
            0xB839,
            0xCC7D,
            0x3402,
            0x0430,
            0x0008,
            0x5B60,
            0x7E44,
            0xCD1B,
            0x3487,
        };

        [TestMethod]
        public void Crc16_ShouldMatch()
        {
            AssertChecksum(new Crc16(), Expected, nameof(Crc16));
        }
    }
}
