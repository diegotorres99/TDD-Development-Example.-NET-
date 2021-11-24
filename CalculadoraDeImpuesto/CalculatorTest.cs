using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
namespace CalculadoraDeImpuesto
{
    /*
     ** Obtener IVA apartir del monto de una reserva.
     **  Obtener el impuesto estal sobre hospedaje a partir del monto de una reserva
     **   Obtener el monto total de la reserva (con impuesto incluidos)
             Impuestos a considerar : iva, ish.
             %iva = 0.16
             %ish = 0.03
             monto reserva = 1550.00   
     */
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Triple A, red Design
            //1- Arrange
            CalculatorImpuestos ci = new CalculatorImpuestos();

            //2- Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //3- Assert iva = 8%
            //monto reserva = 1250
            //1250.00 * 16 = 248.00
            //m : decima sub
            Assert.AreEqual(248.00m, iva);

        }
        [TestMethod]
        public void ISHTest()
        {
            //Triple A, red Design
            //1- Arrange
            CalculatorImpuestos ci = new CalculatorImpuestos();

            //2- Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //3- Assert iva = 8%
            //ish = 3%
            //monto reserva = 1550
            //1550.00 * .03 = 46.50
            //m : decima sub
            Assert.AreEqual(46.50m, ish);

        }
        [TestMethod]
        public void MontoTotalTest()
        {
            //Triple A, red Design
            //1- Arrange
            CalculatorImpuestos ci = new CalculatorImpuestos();

            //2- Act
            decimal iva = ci.ObtenerIVA(1550m);
            decimal ish = ci.ObtenerISH(1550m, 0.03m);
            decimal total = ci.ObtenerTotal(iva, ish, 1550m);
            //3- Assert 
            //iva = 248
            //ish = 46.5
            //monto reserva = 1550
            //1550.00 + 248 + 46.5 = 1884.5
            Assert.AreEqual(1844.5m, total);

        }
    }
}
