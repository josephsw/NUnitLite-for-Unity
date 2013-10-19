using UnityEngine;
using NUnit.Framework;

[TestFixture]
[Category("ObjectTest")]
public class ExampleTest3
{
    [Test]
    public void CanCombineTestsWithAndOperator()
    {
        Assert.That(21, Is.GreaterThan(40) & Is.LessThan(42));
    }
}
