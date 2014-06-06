using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.Linq;






namespace Inova.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestInova
    {
        
       [TestMethod]
        public void Take()
        {
            //seleciona os primeiros n objetos de uma selecao
            int[] numeros = {5,4,1,3,9,8,6,7,2,0};
            var resultado = from num in numeros.Take(5) select num;
            int[] teste = { 5, 4, 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

       [TestMethod]
       public void Skip()
       {
           //ignora os primeiros n objetos de uma selecao
           int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
           var resultado = from num in numeros.Take(5).Skip(2) select num;
           int[] teste = { 1,3,9 };
           CollectionAssert.AreEqual(resultado.ToArray(), teste);
       }
    }
}
