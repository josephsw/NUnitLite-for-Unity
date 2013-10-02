using NUnit.Framework;


[TestFixture]
[Category("Cat3")]
public class ExampleTest3
{
    [Test]
    public void CanCombineTestsWithAndOperator()
    {
        Assert.That(21, Is.GreaterThan(40) & Is.LessThan(42));
    }
}
