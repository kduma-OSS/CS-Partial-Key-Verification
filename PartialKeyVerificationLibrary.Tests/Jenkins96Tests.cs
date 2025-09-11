using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerificationLibrary.Verificator.Hash;

namespace PartialKeyVerificationLibrary.Tests
{
    [TestClass]
    public class Jenkins96Tests : HashChecksumTestBase
    {
        private static readonly uint[] Expected = new uint[] {
            0x4E3A8A95,
            0x3702E8CA,
            0x96850DA1,
            0xE26DD43F,
            0x0E0E726A,
            0xDCD2D1E8,
            0x3CECB20A,
            0xE014D735,
            0x720683F0,
            0xA4AE20CA,
            0xB862EAD5,
            0xE4370B5B,
            0xF6D46E5B,
            0x926C4AE9,
            0xAAC9A15D,
            0x11478544,
            0x5C87D361,
            0xCAD7F890,
            0x81BCE07F,
            0x41C50419,
            0x19482CBB,
            0x25D23225,
            0x83CD4AE0,
            0x6289948D,
            0x67009D95,
        };

        [TestMethod]
        public void Jenkins96_ShouldMatch()
        {
            AssertHash(new Jenkins96(), Expected, nameof(Jenkins96));
        }
    }
}
