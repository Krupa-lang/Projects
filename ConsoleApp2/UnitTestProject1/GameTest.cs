﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;


namespace UnitTestProject1
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestOneThrow()
        {
            Game game = new Game();
            game.Add(5);    
            Assert.AreEqual(5, game.Score);
        }

        [TestMethod]
        public void TestTwoThrowsNoMark()
        {
            Game game = new Game();
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.Score);
        }

        [TestMethod]
        public void TestFourThrowsNoMark()
        {
            Game game = new Game();
            game.Add(5);
            game.Add(4);
            game.Add(7);
            game.Add(2);
            Assert.AreEqual(18, game.Score);
            Assert.AreEqual(9, game.ScoreForFrame(1));
            Assert.AreEqual(18, game.ScoreForFrame(2));

        }
    }
}
