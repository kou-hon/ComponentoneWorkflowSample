using HogeLib;

public class HogeClassTests
{
    [Fact]
    public void Something_Success()
    {
        var hoge = new HogeClass();
        int input = 42;
        int result = hoge.Something(input);
        Assert.Equal(input, result);
    }

    [Fact]
    public void Something_Success2()
    {
        var hoge = new HogeClass();
        int input = 10;
        int result = hoge.Something(input);
        Assert.Equal(input, result);
    }
}


