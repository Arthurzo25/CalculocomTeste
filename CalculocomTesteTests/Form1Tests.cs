using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculocomTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculocomTeste.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        CalculocomTeste.Form1 f1 = new CalculocomTeste.Form1();
        [TestMethod()]
        public void ValidaValorTest()
        {
            string entrada = "a";
            Boolean respostaEsperada = false;
            Boolean resposta = f1.ValidaValor(entrada);
            Assert.AreEqual(respostaEsperada, resposta);
         
        }
        
    }
}