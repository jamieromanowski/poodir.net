﻿using Chapter01;
using NUnit.Framework;

namespace Chapter01Tests
{
    [TestFixture]
    public class Listing10Tests
    {
        [Test]
        public void Diameters_GivenA2DArrayOfRimsAndTires_CalculatesWheelDiameters()
        {
            // rim and tire sizes (now in milimeters) in a 2d array
            int[,] data =
                {
                    {622, 20}, 
                    {622, 23}, 
                    {559, 30}, 
                    {559, 40}
                };

            var obscure = new Listing10.ObscuringReferences(data);
            var diameters = obscure.Diameters();

            Assert.That(diameters.Count == 4);
            Assert.AreEqual(662, diameters[0]);
            Assert.AreEqual(668, diameters[1]);
            Assert.AreEqual(619, diameters[2]);
            Assert.AreEqual(639, diameters[3]);
        }
    }
}
