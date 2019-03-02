﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTestingDemo.Tests
{
    [TestFixture]
    public class TextCreatorTests
    {
        [Test]
        public void ExportText_ProperUse_ReturnCorrectStringAndClearSB()
        {
            //Arrange
            var textCreator = new TextCreator();
            textCreator.AddTitle("Title");
            textCreator.AddDescription("Description");

            //Act
            var resultText = textCreator.ExportText();
            var expectedText = "Title\r\nDescription\r\n";
            
            var resultClean = textCreator.ExportText();
            var expectedCleanedText = "";
            
            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedText, resultText);
                Assert.AreEqual(expectedCleanedText, resultClean);
            });
            
        }
    }
}
