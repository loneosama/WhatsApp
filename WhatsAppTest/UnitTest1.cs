using System;
using System.Collections.Generic;
using Xunit;

namespace WhatsAppTest
{
    public class UnitTest1
    {
        [Fact]
        //just testing for xunit running or not
        public void Test1()
        {
            var list = new List<int>();
            list.Add(5);
            list.Add(10);
            Assert.Contains(5,list);
        }
        [Fact]
        public void Test2(){
            var list = new List<int>();
            list.Add(10);
            list.Add(5);
            Assert.DoesNotContain(15,list);
        }
    }
}
