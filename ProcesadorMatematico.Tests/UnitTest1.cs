using Microsoft.VisualStudio.TestTools.UnitTesting;
using HowToDoTesting;
namespace HowToDoTesting;

[TestClass]
public class UnitTest1
{

  [TestMethod]
  public void TestSuma()
  {
    //definimos las variables
    //arrange
    var operador1 = 10;
    var operador2 = 11;

    //ejecutamos la prueba
    //act
    var result = ProcesadorMatematico.Sumar(operador1, operador2);
   

    //comparamos resultados.
    //assert
    var valorEsperado = 21;
    Assert.AreEqual(valorEsperado, result);

  }
}