namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        new info("Media", 47365478, "kmutt",  324343245);

        Assert.Equal(info.end(), "end");


    }


        [Fact]
    public void Test2()
    {
               double[] wee = { 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
               double[] Sum = Money.money(1665.75);
               Assert.Equal(Sum, wee);
    }
}
