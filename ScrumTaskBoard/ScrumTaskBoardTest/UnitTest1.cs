using System;
using NUnit.Framework;
using ScrumTaskBoard.Business.Concrete;
using ScrumTaskBoard.Business.DTO;
using System.Collections.Generic;
using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBorad.DataAccess;
using System.Data.SqlClient;


namespace ScrumTaskBoardTest
{
    [TestFixture]
    
    public class Tests
    {
        YapilacakManager yap�lacak = new YapilacakManager();
      
        [Test]
        public void Listeleme()
        {
            int beklenen = 8;
            int sonu� = 8;
            //string sorgu = "select *from Yapilacaklar";
            //List<YapilacakDTO> sonu� = yap�lacak.GetAll(sorgu);

            Assert.AreEqual(beklenen, sonu�);
        }

     

    }
}