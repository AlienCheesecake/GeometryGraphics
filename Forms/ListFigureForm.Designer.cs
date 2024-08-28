namespace LAB
{
    partial class ListFigureForm
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
            this.buttonMoveToMassRobus = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Desrtoy = new System.Windows.Forms.Button();
            this.button_Erase = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMoveToMassRobus
            // 
            this.buttonMoveToMassRobus.Location = new System.Drawing.Point(97, 612);
            this.buttonMoveToMassRobus.Name = "buttonMoveToMassRobus";
            this.buttonMoveToMassRobus.Size = new System.Drawing.Size(127, 57);
            this.buttonMoveToMassRobus.TabIndex = 130;
            this.buttonMoveToMassRobus.Text = "Переместить";
            this.buttonMoveToMassRobus.UseVisualStyleBackColor = true;
            this.buttonMoveToMassRobus.Click += new System.EventHandler(this.buttonMoveToMassRobus_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(56, 575);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 20);
            this.label26.TabIndex = 129;
            this.label26.Text = "Y =";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(56, 547);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 20);
            this.label29.TabIndex = 128;
            this.label29.Text = "X =";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(97, 575);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(127, 22);
            this.textBox12.TabIndex = 127;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(97, 547);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(127, 22);
            this.textBox14.TabIndex = 126;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(99, 344);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(125, 54);
            this.button_Add.TabIndex = 125;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 24);
            this.label11.TabIndex = 124;
            this.label11.Text = "Работа с контейнером - списком";
            // 
            // button_Desrtoy
            // 
            this.button_Desrtoy.Location = new System.Drawing.Point(99, 416);
            this.button_Desrtoy.Name = "button_Desrtoy";
            this.button_Desrtoy.Size = new System.Drawing.Size(125, 54);
            this.button_Desrtoy.TabIndex = 123;
            this.button_Desrtoy.Text = "Уничтожить";
            this.button_Desrtoy.UseVisualStyleBackColor = true;
            this.button_Desrtoy.Click += new System.EventHandler(this.button_Desrtoy_Click);
            // 
            // button_Erase
            // 
            this.button_Erase.Location = new System.Drawing.Point(99, 272);
            this.button_Erase.Name = "button_Erase";
            this.button_Erase.Size = new System.Drawing.Size(125, 54);
            this.button_Erase.TabIndex = 122;
            this.button_Erase.Text = "Стереть";
            this.button_Erase.UseVisualStyleBackColor = true;
            this.button_Erase.Click += new System.EventHandler(this.button_Erase_Click);
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(99, 196);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(125, 56);
            this.button_Show.TabIndex = 121;
            this.button_Show.Text = "Нарисовать";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(99, 101);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(125, 74);
            this.buttonCreate.TabIndex = 120;
            this.buttonCreate.Text = "Создать пустой контейнер";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 689);
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // ListFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 713);
            this.Controls.Add(this.buttonMoveToMassRobus);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Desrtoy);
            this.Controls.Add(this.button_Erase);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListFigureForm";
            this.Text = "ListFigureForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMoveToMassRobus;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Desrtoy;
        private System.Windows.Forms.Button button_Erase;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}