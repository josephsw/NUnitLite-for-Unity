using NUnit.Framework;


[TestFixture]
[Category("Cat2")]
public class ExampleTest2
{
    [Test]
    public void CanCombineTestsWithAndOperator()
    {
        Assert.That(39, Is.GreaterThan(40) & Is.LessThan(42));
    }
}
