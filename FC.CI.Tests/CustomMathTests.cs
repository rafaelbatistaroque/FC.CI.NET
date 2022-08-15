using FC.CI.App;

namespace FC.CI.Tests
{
    public class CustomMathTests
    {
        [Fact]
        public void GivenSum_WhenPassingIntParameters_ThenEnsureReturnSumFromParameters()
        {
            var result = CustomMath.Somar(10, 10);
            
            Assert.Equal(20, result);
        }
        
        [Fact]
        public void GivenSub_WhenPassingIntParameters_ThenEnsureReturnSumFromParameters()
        {
            var result = CustomMath.Subtrair(20, 10);
            
            Assert.Equal(10, result);
        }
        
        [Fact]
        public void GivenSDMult_WhenPassingIntParameters_ThenEnsureReturnSumFromParameters()
        {
            var result = CustomMath.Multiplicar(20, 10);
            
            Assert.Equal(200, result);
        }
        
        [Fact]
        public void GivenSDiv_WhenPassingIntParameters_ThenEnsureReturnSumFromParameters()
        {
            var result = CustomMath.Dividir(20, 10);
            
            Assert.Equal(2, result);
        }
    }
}