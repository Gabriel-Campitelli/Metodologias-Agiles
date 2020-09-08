using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlinGameKata
{
    [TestClass]
    public class Test
    {

        //Arrange 
        //Act
        //Assert

        [TestMethod]
        public void TirarNingunPino()
        {
            Juego j = new Juego();

            TirarNVeces(20, 0, j);

            Assert.AreEqual(0, j.Score());
        }

        [TestMethod]
        public void TirarUnPino()
        {
            Juego j = new Juego();

            TirarNVeces(20, 1, j);

            Assert.AreEqual(20, j.Score());
        }



        public void TirarNVeces(int veces,int valor, Juego j)
        {

            for (int i = 1; i <= veces; i++)
            {
                j.Tirar(valor);
            }

        }

        [TestMethod]
        public void TestUnSpare()
        {
            Juego j = new Juego();

            TirarNVeces(14, 4, j);
            TirarNVeces(1, 3, j);
            TirarNVeces(1, 7, j);
            TirarNVeces(4, 4, j);

            Assert.AreEqual(86, j.Score());
        }

        [TestMethod]
        public void TestUnStrike()
        {
            Juego j = new Juego();


            TirarNVeces(1, 10, j);
            TirarNVeces(2, 4, j);

            /*
            TirarNVeces(14, 4, j);
            TirarNVeces(1, 10, j);
            TirarNVeces(4, 4, j);
            */

            Assert.AreEqual(26, j.Score());
        }

    }
}
