using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumTaskBoard.WebFormsUI;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public  class ScrumTaskBoardWebFormsUITest
    {
        
       
        [TestMethod]
        public void Boşluk_Testi()
        {
            
            var ifade = "   enes     tunahan      çömez    ";
            var beklenen = "enes tunahan çömez";

            var gerçekleşen = Control.FazlaBoşluklarıSil(ifade);

            Assert.AreEqual(beklenen, gerçekleşen);
        }
    }
}
