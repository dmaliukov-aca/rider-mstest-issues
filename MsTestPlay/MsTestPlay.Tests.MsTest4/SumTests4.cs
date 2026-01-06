[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.ClassLevel)]

namespace MsTestPlay.Tests.MsTest4;

[TestClass]
public class SumTests4
{
    [TestMethod]
    [DataRow(1,2,3)]
    [DataRow(2,2,3)]
    public void Sum4_ShouldProduceCorrectResult(int a, int b, int expected)
    {
        var fact = Operations.Add(a,b);
        Assert.AreEqual(expected, fact);    
    }
}