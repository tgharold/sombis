using sombis.Core;
using Xunit;

namespace sombis.Tests
{
    public class GeneratorTests
    {
        private readonly Generator _sut;

        public GeneratorTests()
        {
            _sut = new Generator();
        }
        
        [Fact]
        public void Calculates_a_single_MBI()
        {
            var result = _sut.CreateRandomMbi();
            Assert.NotNull(result);
        }
        
        [Fact]
        public void MBI_is_length_11()
        {                         
            var result = _sut.CreateRandomMbi();
            Assert.Equal(11, result.Length);
        }
    }
}
