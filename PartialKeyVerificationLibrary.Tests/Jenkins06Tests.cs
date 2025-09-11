using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Jenkins06Tests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x79BAE5C0,
            0x78418BEB,
            0xBF354C34,
            0x833F8804,
            0x6179F6A9,
            0xDF10C827,
            0xF00B2B9F,
            0x8897B2F8,
            0x8A51B4DC,
            0x907ECA5C,
            0x6093B8E6,
            0x6CE48419,
            0xD591AEBE,
            0xD00E7434,
            0x4E54B522,
            0xD647F7E9,
            0xDD85B788,
            0xEB5B15C2,
            0xF428D814,
            0xA8C5928B,
            0xE8CCE291,
            0x795BC6CE,
            0xFAB9E268,
            0xD1C96808,
            0x2D0983FE,
        };

        [TestMethod]
        public void Jenkins06_ShouldMatch()
        {
            AssertHash(new Jenkins06(0), Expected, nameof(Jenkins06));
        }
    }
}
