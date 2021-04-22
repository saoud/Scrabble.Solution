using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests 
{
  [TestClass]
  public class ScrabbleLogicTests
  {
    [TestMethod]
    public void BigWordBonus_ReturnsTrueifwordis7letters_true()
    { 
      //arrange
      string BigWord = "congeal";
      //act
      bool TestResult = Logic.BigWordBonus(BigWord);
      Assert.AreEqual(TestResult, true);

    }
  } 
}