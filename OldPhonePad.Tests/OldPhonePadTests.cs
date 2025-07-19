using Xunit;

namespace OldPhonePad.Tests
{
    public class OldPhonePadTests
    {
        [Theory]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]

        [InlineData("", "")]
        [InlineData("*#", "")]
        [InlineData("22 2#", "BA")]
        public void ParseInput_WorksCorrectly(string input, string expected)
        {
            var result = OldPhonePad.OldPhonePadLogic.ParseInput(input);
            Assert.Equal(expected, result);
        }
    }
}
