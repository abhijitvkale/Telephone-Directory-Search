using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telephone_Directory_Search;
using System.Collections;


namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_append_enter_data()
        {
            ArrayList lst = new ArrayList();
            telephone t = new telephone();
            t.name = "test";

            t.tel = "123456";

            t.address = "asdfghjkl";
            t.occupation = "tets";


            t.ConnDate = "12/04/15";
            lst.Add(t);
            
            
            
            int actual = t.AppendText(lst);
            int expected = 0;
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void Test_search_data()
        {

            telephone t = new telephone();

            string actual = t.fetch_details("abhijith");
            string expected = "abhijith	123	cl	std	1345";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_search_data_exist()
        {

            telephone t = new telephone();

            
            string expected = "";
            string actual = "";
            try
            {
                actual = t.fetch_details("xxxx");
            }
            catch(ArgumentNullException)
            {
                return;
            }
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Test_delete_data()
        {
            ArrayList lst = new ArrayList();
            telephone t = new telephone();
            t.name = "test";

            t.tel = "133";

            t.address = "9440";
            t.occupation = "tets";


            t.ConnDate = "12/04/15";
            lst.Add(t);



            int actual = t.AppendText(lst);
            int expected = 0;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void test_edit_info()
        {
            Test_delete_data();
            Test_append_enter_data();
        }

    }
}
