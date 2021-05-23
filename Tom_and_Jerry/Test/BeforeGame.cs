using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Game_TomAndJerry;

namespace Test
{
    [TestFixture]
    public class BeforeGame
    {
        [Test]
        public void GameIsOver()
        {//проверка игры на начальное ее состояние
            var flag = new runningJerry();
            Assert.AreEqual(flag.GameOver(), "error");
        }
        [Test]
        public void GameResent_Const()
        {//проверка на начальные значения переменных
            List<int> constGame = new List<int> {17, 0, 1, 10, 13, 535, -224, 536, 323, 482 };
            var resultConst = new runningJerry();
            Assert.AreEqual(resultConst.GameReset(), constGame);
        }
        [Test]
        public void JerryDoesJump()
        {//проверка начального состояния персонажа
            var flag = new runningJerry();
            Assert.AreEqual(flag.JumpingJerry(), "Jerry doesn't jump");
        }
    }
}
