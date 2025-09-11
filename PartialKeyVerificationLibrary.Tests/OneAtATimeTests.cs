using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class OneAtATimeTests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x73BB4ACD,
            0x221F04F8,
            0x0A730847,
            0xA2B030DB,
            0x17127FCD,
            0x0115FC98,
            0x7CBCEDE0,
            0x11CE1DC6,
            0x52886AF4,
            0x9D1A1EDE,
            0xA6280C45,
            0x70F920D1,
            0x6D374710,
            0x96E08018,
            0xF64F9351,
            0x93C3807B,
            0xDAEB684D,
            0x01C0BA9D,
            0x8F6E3AC0,
            0x151CF580,
            0xFBDC5B7B,
            0x06CA2A84,
            0xFE5B0099,
            0x986D1C65,
            0x02038F11,
            0x00000000,
            0x00000000,
        };

        [TestMethod]
        public void OneAtATime_ShouldMatch()
        {
            AssertHash(new OneAtATime(), Expected, nameof(OneAtATime));
        }
    }
}
