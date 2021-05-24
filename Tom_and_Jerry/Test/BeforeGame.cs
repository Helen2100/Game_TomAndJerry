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
    {//создаем глобальные переменные
        runningJerry flag = new runningJerry();//вызываем класс runningJerry()
        List<int> constGame = new List<int> { 17, 0, 1, 10, 13, 535, -224, 536, 323, 482 };//создаем лист с константами
        /// <summary>
        /// проверка начального состояние игры(закончена/не закончена)
        /// </summary>
        [Test]
        public void GameIsOver() => Assert.AreEqual(flag.GameOver(), "error");//т.к в начале игры некоторые элементы не должны быть на экране
        /// <summary>
        /// //проверка на начальные параметры фигур персонажей и надписей
        /// </summary>
        [Test]
        public void GameResent_Const() => Assert.AreEqual(flag.GameReset(), constGame);
        /// <summary>
        /// проверка начального состояние главного персонажа(прыгает/не прыгает)
        /// </summary>
        [Test]
        public void JerryDoesJump() => Assert.AreEqual(flag.JumpingJerry(), "Jerry doesn't jump");
    }
}
