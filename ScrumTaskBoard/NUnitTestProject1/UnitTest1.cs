using System;
using System.Collections.Generic;
using NUnit.Framework;
using ScrumTaskBoard.Business.Concrete;
using ScrumTaskBoard.Business.DTO;
using System.Data.SqlClient;


namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        YapilacakManager yapilacak = new YapilacakManager();

        [Test]
        public void Test1()
        {
            //int sonu� = 8;
            //int beklenen = 8;
            try
            {
                string sorgu = "select *from Yapilacaklar";
                List<YapilacakDTO> sonu� = yapilacak.GetAll(sorgu);
                Assert.AreEqual(sonu�, sonu�);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
       
        }
    }
}