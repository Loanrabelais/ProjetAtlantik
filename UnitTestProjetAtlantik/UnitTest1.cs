using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetAtlantik
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetLesTraverseesBateaux()
        {
            var apelleMethode = ProjetAtlantik.FormAfficherTraversee.getLesTraverseesBateaux(1, '10,07,2021');
        }
    }
}
