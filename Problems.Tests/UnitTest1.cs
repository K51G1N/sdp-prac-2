using NUnit.Framework;
using Problems;
namespace Problems.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Program a = new Program();
            Assert.Pass(a.Prefix("hello"), Is.EqualTo("5,1:hello"));
        }
        [Test]
        public void Test2()
        {
            Program b = new Program();
            Assert.Pass(b.Prefix(""), Is.EqualTo("0,0:\"\""));
        }   
        [Test]
        public void Test3()
        {
            Program b = new Program();
            Assert.Pass(b.Prefix("what    ...  did you say?? "), Is.EqualTo("27,5:hello"));
        }
    }
}