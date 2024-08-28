namespace LAB
{
    partial class PolimorfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Erase = new System.Windows.Forms.Button();
            this.button_Desrtoy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxr1 = new System.Windows.Forms.TextBox();
            this.textBoxr2 = new System.Windows.Forms.TextBox();
            this.button_Rotate = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Applay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 689);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(111, 73);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 54);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(111, 147);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(100, 54);
            this.button_Show.TabIndex = 3;
            this.button_Show.Text = "Нарисовать";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Erase
            // 
            this.button_Erase.Location = new System.Drawing.Point(111, 221);
            this.button_Erase.Name = "button_Erase";
            this.button_Erase.Size = new System.Drawing.Size(100, 54);
            this.button_Erase.TabIndex = 4;
            this.button_Erase.Text = "Стереть";
            this.button_Erase.UseVisualStyleBackColor = true;
            this.button_Erase.Click += new System.EventHandler(this.button_Erase_Click);
            // 
            // button_Desrtoy
            // 
            this.button_Desrtoy.Location = new System.Drawing.Point(111, 299);
            this.button_Desrtoy.Name = "button_Desrtoy";
            this.button_Desrtoy.Size = new System.Drawing.Size(100, 54);
            this.button_Desrtoy.TabIndex = 5;
            this.button_Desrtoy.Text = "Уничтожить";
            this.button_Desrtoy.UseVisualStyleBackColor = true;
            this.button_Desrtoy.Click += new System.EventHandler(this.button_Desrtoy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Все",
            "Круги",
            "Эллипсы",
            "Ромбы",
            "Прямоугольники",
            "Четырехугольники",
            "Линии"});
            this.comboBox1.Location = new System.Drawing.Point(19, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxr1
            // 
            this.textBoxr1.Location = new System.Drawing.Point(50, 437);
            this.textBoxr1.Name = "textBoxr1";
            this.textBoxr1.ReadOnly = true;
            this.textBoxr1.Size = new System.Drawing.Size(100, 22);
            this.textBoxr1.TabIndex = 7;
            // 
            // textBoxr2
            // 
            this.textBoxr2.Location = new System.Drawing.Point(50, 465);
            this.textBoxr2.Name = "textBoxr2";
            this.textBoxr2.ReadOnly = true;
            this.textBoxr2.Size = new System.Drawing.Size(100, 22);
            this.textBoxr2.TabIndex = 8;
            // 
            // button_Rotate
            // 
            this.button_Rotate.Enabled = false;
            this.button_Rotate.Location = new System.Drawing.Point(19, 502);
            this.button_Rotate.Name = "button_Rotate";
            this.button_Rotate.Size = new System.Drawing.Size(161, 23);
            this.button_Rotate.TabIndex = 9;
            this.button_Rotate.Text = "Поворот на 90*";
            this.button_Rotate.UseVisualStyleBackColor = true;
            this.button_Rotate.Click += new System.EventHandler(this.button_Rotate_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(218, 437);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 10;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(50, 591);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.ReadOnly = true;
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 12;
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(50, 563);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.ReadOnly = true;
            this.textBoxW.Size = new System.Drawing.Size(100, 22);
            this.textBoxW.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "r1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "r1 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "R =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "W =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "H =";
            // 
            // button_Applay
            // 
            this.button_Applay.Enabled = false;
            this.button_Applay.Location = new System.Drawing.Point(67, 634);
            this.button_Applay.Name = "button_Applay";
            this.button_Applay.Size = new System.Drawing.Size(190, 54);
            this.button_Applay.TabIndex = 14;
            this.button_Applay.Text = "Применить";
            this.button_Applay.UseVisualStyleBackColor = true;
            this.button_Applay.Click += new System.EventHandler(this.button_Applay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Полуоси";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Радиус";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ширина и высота";
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(218, 560);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.ReadOnly = true;
            this.textBoxRotate.Size = new System.Drawing.Size(100, 22);
            this.textBoxRotate.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Поворот в градусах";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 563);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "a =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(43, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Работа с массивами";
            // 
            // PolimorfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 713);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Applay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.textBoxRotate);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.button_Rotate);
            this.Controls.Add(this.textBoxr2);
            this.Controls.Add(this.textBoxr1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Desrtoy);
            this.Controls.Add(this.button_Erase);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "PolimorfForm";
            this.Text = "PolimorfForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PolimorfForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Erase;
        private System.Windows.Forms.Button button_Desrtoy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxr1;
        private System.Windows.Forms.TextBox textBoxr2;
        private System.Windows.Forms.Button button_Rotate;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Applay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}