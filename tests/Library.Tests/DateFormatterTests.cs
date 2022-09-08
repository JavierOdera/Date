namespace Library.Tests;
using TestDateFormat;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateFormatterTests()
    {
        string ExpectedDate = "2015-05-09";
        string Result = DateFormatter.ChangeFormat("09/05/2015");
        Assert.AreEqual(ExpectedDate,Result);
        
        
    }
    
    [Test]
    public void DateFormatterTests2()
    {
        string ExpectedDate = "09/05/2015";
        string Result = DateFormatter.ChangeFormat("09/05/2015");
        Assert.AreNotEqual(ExpectedDate,Result);
    }
    
    [Test]
    public void DateFormatterTests3()
    {
        string Result = DateFormatter.ChangeFormat("09/05/2015");
        Assert.IsEmpty(Result);
        Assert.IsNull(Result);
    }
}