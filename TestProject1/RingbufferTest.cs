namespace TestProject1;

[TestFixture]
public class RingbufferTests
{
    [Test]
    public void TestAddAndRemove()
    {
        var buffer = new Ringbuffer<int>(3);
        buffer.Add(1);
        buffer.Add(2);
        buffer.Add(3);
        Assert.That(buffer.Remove(), Is.EqualTo(1));
        Assert.That(buffer.Remove(), Is.EqualTo(2));
        Assert.That(buffer.Remove(), Is.EqualTo(3));
    }
}