using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_TomAndJerry
{
    public partial class runningJerry : Form
    {//создаем глобальные переменные
        bool jumping, isGameOver = false;//переменные отвечают за состояние Джерри(прыгает/не прыгает) и игры(закончена/не закончена)
        int jumpSpeed, trapSpeed, bonusSpeed, force, score;//переменные отвечают за скорость перемещения обьектов(первые 3), за высоту прыжка и счет
        string flag;//флаг, который необходим для тестов
        List<int> arrayConst;//лист, который необходим для тестов
        Random rand = new Random();//создаем переменную для функции рандома чисел
        public runningJerry()
        {//метод, который при запуске игры вызывает два метода
            InitializeComponent();//метод, который поддерживает конструктор
            GameReset();//метод, который присваивает глобальным переменным значения и вызывает метод запуска игры
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {//метод, который определяет дальнейшие действия игры, когда нажаты различные кнопки
            if (e.KeyCode == Keys.Up && jumping == false)//если нажата кнопка "стрелка вверх" и Джерри не прыгает
            {
                jumping = true;//заставляем Джерри прыгать, изменяя переменнную на значение true
                Jerry.Image = Resources.JerryCheese;//меняем рисунок Джерри
            }
            if (e.KeyCode == Keys.Down) Jerry.Image = Resources.runningJerry;//если нажата "стрелка вниз", то меняем рисунок Джерри
            if (e.KeyCode == Keys.R && isGameOver == true) GameReset();//если нажата кнопка "R" и игра окончена, то возвращяем в начало игры с начальными параметрами
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {//метод, который определяет дальнейшие действия игры, когда отжаты  кнопки
            if (jumping == true) jumping = false;//если Джерри прыгал, то условие прекращает данное действие
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {//метод, на который ссылается программа, когда игра запущена
            txtScore.Text = "Счет: " + score;//выводим надпись со счетом
            JumpingJerry();//вызываем метод, который заставляет Джерри прыгать
            TouchingJerry_MoveObject();//метод, который определяет дальнейшие действия персонажа(если он задел другой обьект)
            if (score > 5)//если счет больше 5
            {
                trapSpeed = 15;//то изменяем скорость ловушки
                bonusSpeed = 17;//то изменяем скорость бонуса(сыра)
            }
            if (score > 10)//если счет больше 10
            {
                trapSpeed = 20;//то изменяем скорость ловушки
                bonusSpeed = 23;//то изменяем скорость бонуса(сыра)
            }
        }
        public List<int> GameReset()
        {//присваиваем глобальным переменным начальные значения
            force = 17;//высота прыжка
            jumpSpeed = 0;//скорость перемещения обьекта вверх(прыжок) 
            jumping = false;//переменная отвечает за состояние обьекта(прыгает/не прыгает)
            score = 1;//счет игрока
            trapSpeed = 10;//скорость перемещения ловушек
            bonusSpeed = 13;//скорость перемещения бонусов(сыр)
            txtScore.Text = "Счет: " + score;//выводим текст-счет игрока
            txtResult.Visible = false;//убираем текст с конечным результатом
            isGameOver = false;//переменная отвечает за состояние игры(закончена/не закончена)
            gameOverPicture.Visible = false;//убираем рисунок, показывающий завершение игры
            mousetrap.Top = 535;//начальное положение мышеловки
            dynamit.Top = -224;//начальное положение динамита
            cheese1.Top = 536;//начальное положение сыра1
            cheese2.Top = 323;//начальное положение сыра2
            Jerry.Top = 566 - Jerry.Height;//начальное положение Джерри(координа по Х установлена в констукторе)
            Jerry.Image = Resources.JerryCheese;//присваиваем начальную картинку Джерри
            arrayConst = new List<int> { force, jumpSpeed, score, trapSpeed, bonusSpeed, mousetrap.Top, dynamit.Top, cheese1.Top, cheese2.Top, Jerry.Top};//заполняем лист константами(для теста)
            //теперь расставляем бонусы(сыр) и ловушки по карте(ось Х)
            foreach (Control x in this.Controls)//перебираем обьекты из коллекции элементов управления
            {
                if (x is PictureBox)//если х - рисунок
                {
                    if ((string)x.Tag == "trap")//если это ловушка
                        x.Left = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);//то перемещаем обьект вправо(за экран)
                    if (Math.Abs(dynamit.Left - mousetrap.Left) < 450)//если расстояние между ловушками слишком маленькое
                        dynamit.Left += 300;//то смещаем ловушку еще, чтобы Джерри мог проскачить между ловушками
                    if ((string)x.Tag == "bonus")//если это бонус(сыр)
                        x.Left = this.ClientSize.Width + rand.Next(250, 500) + (x.Width * 5);//то перемещаем обьект вправо(за экран)
                }
            }
            gameTimer.Start();
            return arrayConst;//возвращяем лист с константами
        }
        public string JumpingJerry()
        {//метод, который заставляет Джерри прыгать
            Jerry.Top += jumpSpeed;//перемещаем Джерри вверх(срабатывает одновременно с методом KeyIsDown)
            if (jumping == true && force < 0) jumping = false;//если Джерри прыгнул, то поменять значение jumping на false
            if (jumping == true)//если Джерри прыгает
            {
                jumpSpeed = -15;//перемещаем Джерри вверх
                force -= 1;//уменьшаем силу прыжка
            }
            else jumpSpeed = 15;//если Джерри больше не прыгает, то возвращяем начальную скорость прыжка, которая опускает обьект вниз
            if (Jerry.Top > (566 - Jerry.Height - 1) && jumping == false)
            {//условие, которое не позволяет провалиться Джерри и выйти за экран
                force = 17;//возвращем начальную силу прыжка
                Jerry.Top = 566 - Jerry.Height;//перемещаем Джерри на начальную позицию
                jumpSpeed = 0;//присваем 0 переменной, отвечающей за скорость прыжка
            }
            if (jumping == false && (Jerry.Top == 566 - Jerry.Height) && jumpSpeed == 0 && force == 17)//для проверки
                return flag = "Jerry doesn't jump";//если все правльно, то вывести слово "Jerry doesn't jump"
            if (jumpSpeed < 0)//если Джерри перемещается вверх(т.е скорость отрицательная)
                return flag = "Jerry jumps";//то вывести "Jerry jumps"
            if (force < 0 && jumping == false)//если Джерри закончил свой прыжок
                return flag = "Jerry has jumped";//то вывести "Jerry has jumped"
            else return flag = "Jerry falls";//если Джерри опускается, то вывести "Jerry falls"
        }
        public void TouchingJerry_MoveObject()
        {//метод, который определяет дальнейшие действия персонажа(если он задел другой обьект)
            foreach (Control x in this.Controls)//перебираем обьекты из коллекции элементов управления
            {
                if (x is PictureBox)//если х-картинка
                {
                    if ((string)x.Tag == "bonus")//если это бонус(сыр)
                    {
                        x.Left -= bonusSpeed;//смещаем влево обьект с определенной скоростью
                        if (x.Left < -100)//если обьект находиться за экраном(слева)
                            x.Left = this.ClientSize.Width + rand.Next(250, 500) + (x.Width * 5);//то перемещаем обьект вправо(за экран)
                        if (Jerry.Bounds.IntersectsWith(x.Bounds))//если писельная рамка Джерри задевает пиксельную рамку бонуса
                        {
                            x.Left = this.ClientSize.Width + rand.Next(250, 500) + (x.Width * 5);//то перемещаем обьект вправо(за экран)
                            score++;//+1 счету
                        }
                    }
                    if ((string)x.Tag == "trap")//если это ловушка
                    {
                        x.Left -= trapSpeed;//смещаем влево обьект с определенной скоростью
                        if (x.Left < -100)//если обьект находиться за экраном(слева)
                            x.Left = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);//то перемещаем обьект вправо(за экран)
                        if (Math.Abs(dynamit.Left - mousetrap.Left) < 450) dynamit.Left += 300;//смещаем еще, чтобы Джерри мог проскачить между ловушками
                        if (Jerry.Bounds.IntersectsWith(x.Bounds))//если пиксельная рамка Джерри задевает пиксельную рамку ловушки
                        {
                            if (x == dynamit)//если это динамит
                            {//то переменной playCrash присваиваем звук взырва динамита
                                System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Resources.boom);
                                playCrash.Play();//включить звук
                            }
                            if (x == mousetrap)//если это мышеловка
                            {//то переменной playCrash присваиваем звук закрывающейся мышеловки
                                System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Resources.trapHit);
                                playCrash.Play();//включить звук
                            }
                            GameOver();//завершить игру, т.к Джерри задел ловушку
                        }
                    }
                }
            }
        }
        public string GameOver()
        {//метод,который завершает игру
            gameTimer.Stop();//останавиваем таймер
            txtScore.Text = " Нажми R, чтобы начать игру заново";//вывести инструкцию
            txtResult.Visible = true;//показать табло с результатами
            txtResult.Text = "Ваш результат: " + score;//показать результат
            gameOverPicture.Visible = true;//показать картинку об окончании игры
            isGameOver = true;//привоить перемнной true, т.к игра окончена
            if (txtResult.Visible == true && gameOverPicture.Visible == true && isGameOver == true)//для проверки
                return flag = "correct";//если все правльно, то вывести слово "correct"
            else
                return flag = "error";//иначе "error"
        }
    }
}
