using FC.CI.App;

namespace FC.CI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenSum_WhenPassingIntParameters_ThenEnsureReturnSumFromParameters()
        {
            var result = CustomMath.Somar(10, 10);
            
            Assert.Equal(20, result);
        }
    }
}