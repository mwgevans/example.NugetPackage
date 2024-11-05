namespace example.NugetPackage.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // basics 1
            var sut = new Class1();

            var theValue = "Hello!";
            var result = sut.Echo(theValue);

            Assert.Equal(theValue, result);

        }
        [Fact]
        public void Test2()
        {
            // basics 1
            var sut = new Class1();

            var theValue = "Hello!";
            var result = sut.Echo1(theValue);

            Assert.Equal(theValue, result);

        }
    }
}