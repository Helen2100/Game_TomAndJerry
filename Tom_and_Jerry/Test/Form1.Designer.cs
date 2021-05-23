
namespace Game_TomAndJerry
{
    partial class runningJerry
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Jerry = new System.Windows.Forms.PictureBox();
            this.cheese1 = new System.Windows.Forms.PictureBox();
            this.mousetrap = new System.Windows.Forms.PictureBox();
            this.cheese2 = new System.Windows.Forms.PictureBox();
            this.dynamit = new System.Windows.Forms.PictureBox();
            this.gameOverPicture = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtRule = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mousetrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Jerry
            // 
            this.Jerry.BackColor = System.Drawing.Color.Transparent;
            this.Jerry.Image = global::Game_TomAndJerry.Resources.JerryCheese;
            this.Jerry.Location = new System.Drawing.Point(37, 482);
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(85, 84);
            this.Jerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jerry.TabIndex = 0;
            this.Jerry.TabStop = false;
            this.Jerry.Tag = "player";
            // 
            // cheese1
            // 
            this.cheese1.BackColor = System.Drawing.Color.Transparent;
            this.cheese1.Image = global::Game_TomAndJerry.Resources.cheese;
            this.cheese1.Location = new System.Drawing.Point(157, 536);
            this.cheese1.Name = "cheese1";
            this.cheese1.Size = new System.Drawing.Size(48, 30);
            this.cheese1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cheese1.TabIndex = 1;
            this.cheese1.TabStop = false;
            this.cheese1.Tag = "bonus";
            // 
            // mousetrap
            // 
            this.mousetrap.BackColor = System.Drawing.Color.Transparent;
            this.mousetrap.Image = global::Game_TomAndJerry.Resources.mousetrap;
            this.mousetrap.Location = new System.Drawing.Point(269, 535);
            this.mousetrap.Name = "mousetrap";
            this.mousetrap.Size = new System.Drawing.Size(56, 31);
            this.mousetrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mousetrap.TabIndex = 2;
            this.mousetrap.TabStop = false;
            this.mousetrap.Tag = "trap";
            // 
            // cheese2
            // 
            this.cheese2.BackColor = System.Drawing.Color.Transparent;
            this.cheese2.Image = global::Game_TomAndJerry.Resources.cheese;
            this.cheese2.Location = new System.Drawing.Point(610, 324);
            this.cheese2.Name = "cheese2";
            this.cheese2.Size = new System.Drawing.Size(48, 30);
            this.cheese2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cheese2.TabIndex = 3;
            this.cheese2.TabStop = false;
            this.cheese2.Tag = "bonus";
            // 
            // dynamit
            // 
            this.dynamit.BackColor = System.Drawing.Color.Transparent;
            this.dynamit.Image = global::Game_TomAndJerry.Resources.dynamit;
            this.dynamit.Location = new System.Drawing.Point(447, -224);
            this.dynamit.Name = "dynamit";
            this.dynamit.Size = new System.Drawing.Size(76, 717);
            this.dynamit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dynamit.TabIndex = 4;
            this.dynamit.TabStop = false;
            this.dynamit.Tag = "trap";
            // 
            // gameOverPicture
            // 
            this.gameOverPicture.Image = global::Game_TomAndJerry.Resources.Tom_caught_Jerry;
            this.gameOverPicture.Location = new System.Drawing.Point(269, 154);
            this.gameOverPicture.Name = "gameOverPicture";
            this.gameOverPicture.Size = new System.Drawing.Size(424, 286);
            this.gameOverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOverPicture.TabIndex = 5;
            this.gameOverPicture.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(28, 31);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(149, 54);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Счет: 0";
            // 
            // txtRule
            // 
            this.txtRule.AutoSize = true;
            this.txtRule.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRule.Location = new System.Drawing.Point(733, 31);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(214, 129);
            this.txtRule.TabIndex = 7;
            this.txtRule.Text = "Кнопки:\r\n↑ - прыжок\r\n↓ - пригнуться";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(315, 439);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(325, 54);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "Ваш результат: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // runningJerry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Game_TomAndJerry.Resources.blackground;
            this.ClientSize = new System.Drawing.Size(956, 597);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.gameOverPicture);
            this.Controls.Add(this.dynamit);
            this.Controls.Add(this.cheese2);
            this.Controls.Add(this.mousetrap);
            this.Controls.Add(this.cheese1);
            this.Controls.Add(this.Jerry);
            this.Name = "runningJerry";
            this.Text = "Jerry EndLess Runner Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mousetrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jerry;
        private System.Windows.Forms.PictureBox cheese1;
        private System.Windows.Forms.PictureBox mousetrap;
        private System.Windows.Forms.PictureBox cheese2;
        private System.Windows.Forms.PictureBox dynamit;
        private System.Windows.Forms.PictureBox gameOverPicture;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtRule;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Timer gameTimer;
    }
}

