using NUnit.Framework;
using System;

namespace PhonePadTests
{
    [TestFixture]
    public class PhonePadTranslatorTests
    {
        [TestCase("33#", ExpectedResult = "E", TestName = "Test Single Letter E")]
        [TestCase("227*#", ExpectedResult = "B", TestName = "Test Single Letter B")]
        [TestCase("4433555 555666#", ExpectedResult = "HELLO", TestName = "Test Word HELLO")]
        [TestCase("8 88777444666*664#", ExpectedResult = "TURING", TestName = "Test Characters With Spaces And Multiple Keys")]
        [TestCase("9999666335555#", ExpectedResult = "ZOEJ", TestName = "Test Word ZOEJ")]
        [TestCase("222#", ExpectedResult = "C", TestName = "Test Single Letter C")]
        [TestCase("2 222#", ExpectedResult = "AC", TestName = "Test Letters AC With Space")]
        [TestCase("23#", ExpectedResult = "AD", TestName = "Test Letters AD")]
        [TestCase("0#", ExpectedResult = " ", TestName = "Test Space Character")]
        public string OldPhonePad_ShouldReturnExpectedResult(string input)
        {
            return PhonePadTranslator.OldPhonePad(input);
        }
    }
}
