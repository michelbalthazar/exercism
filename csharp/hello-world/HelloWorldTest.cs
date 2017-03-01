using NUnit.Framework;

[TestFixture]
public class HelloWorldTest
{
    public static void Main(){}

    [Test]
    public void Say_hi()
    {
        Assert.That(HelloWorld.Hello(), Is.EqualTo("Hello, World!"));
    }
}
