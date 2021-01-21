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
        YapilacakManager yapýlacak = new YapilacakManager();
      
        [Test]
        public void Listeleme()
        {
            int beklenen = 8;
            int sonuç = 8;
            //string sorgu = "select *from Yapilacaklar";
            //List<YapilacakDTO> sonuç = yapýlacak.GetAll(sorgu);

            Assert.AreEqual(beklenen, sonuç);
        }

     

    }
}