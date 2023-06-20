namespace Solartec
{
    partial class Autorize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorize));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.textBox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(219, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(213, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Icon = ((System.Drawing.Image)(resources.GetObject("textBox1.Icon")));
            this.textBox1.Location = new System.Drawing.Point(140, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 41);
            this.textBox1.TabIndex = 15;
            this.textBox1.text = "";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox2.BackgroundImage")));
            this.textBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Icon = ((System.Drawing.Image)(resources.GetObject("textBox2.Icon")));
            this.textBox2.Location = new System.Drawing.Point(140, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 41);
            this.textBox2.TabIndex = 16;
            this.textBox2.text = "";
            this.textBox2.OnTextChange += new System.EventHandler(this.textBox2_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(118, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 180);
            this.panel1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.ActiveBorderThickness = 1;
            this.button3.ActiveCornerRadius = 20;
            this.button3.ActiveFillColor = System.Drawing.Color.Yellow;
            this.button3.ActiveForecolor = System.Drawing.Color.Black;
            this.button3.ActiveLineColor = System.Drawing.Color.Yellow;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.ButtonText = "Вихід";
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SeaGreen;
            this.button3.IdleBorderThickness = 1;
            this.button3.IdleCornerRadius = 20;
            this.button3.IdleFillColor = System.Drawing.Color.DimGray;
            this.button3.IdleForecolor = System.Drawing.Color.Yellow;
            this.button3.IdleLineColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(43, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 41);
            this.button3.TabIndex = 2;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.ActiveBorderThickness = 1;
            this.button2.ActiveCornerRadius = 20;
            this.button2.ActiveFillColor = System.Drawing.Color.Yellow;
            this.button2.ActiveForecolor = System.Drawing.Color.Black;
            this.button2.ActiveLineColor = System.Drawing.Color.Yellow;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ButtonText = "Реєстрація";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.IdleBorderThickness = 1;
            this.button2.IdleCornerRadius = 20;
            this.button2.IdleFillColor = System.Drawing.Color.DimGray;
            this.button2.IdleForecolor = System.Drawing.Color.Yellow;
            this.button2.IdleLineColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(43, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 41);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 20;
            this.button1.ActiveFillColor = System.Drawing.Color.Yellow;
            this.button1.ActiveForecolor = System.Drawing.Color.Black;
            this.button1.ActiveLineColor = System.Drawing.Color.Yellow;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "Вхід";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 20;
            this.button1.IdleFillColor = System.Drawing.Color.DimGray;
            this.button1.IdleForecolor = System.Drawing.Color.Yellow;
            this.button1.IdleLineColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(43, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Autorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(477, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Autorize";
            this.Text = "Вхід";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox textBox1;
        private Bunifu.Framework.UI.BunifuTextbox textBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 button3;
        private Bunifu.Framework.UI.BunifuThinButton2 button2;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
    }
}

