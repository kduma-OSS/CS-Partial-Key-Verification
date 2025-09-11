using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Crc32Tests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x4468F884,
            0x3E46C445,
            0x3940AB60,
            0xFA52EEDA,
            0xF8051916,
            0xCF8732EA,
            0xCE3D2B17,
            0x9BD19F3A,
            0x0846CD3A,
            0x2A74C54B,
            0xCD49A93F,
            0xCAAFD2A4,
            0x2B272787,
            0xD752F6C6,
            0xAB152638,
            0x690327C1,
            0xE0EE7F01,
            0xFE07987A,
            0xD93D11F5,
            0xC0A60D0D,
            0x0A32AABA,
            0x877F446A,
            0xC84EA726,
            0xE963F3B7,
            0x94B313C3,
            0x00000000,
            0xD202EF8D,
        };

        [TestMethod]
        public void Crc32_ShouldMatch()
        {
            AssertHash(new Crc32(), Expected, nameof(Crc32));
        }
    }
}
