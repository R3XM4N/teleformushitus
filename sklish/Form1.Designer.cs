namespace formlike
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.char1 = new System.Windows.Forms.PictureBox();
            this.char2 = new System.Windows.Forms.PictureBox();
            this.use_1_1 = new System.Windows.Forms.Button();
            this.use_1_2 = new System.Windows.Forms.Button();
            this.use_1_3 = new System.Windows.Forms.Button();
            this.hp1test = new System.Windows.Forms.ProgressBar();
            this.testvalues = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hp2test = new System.Windows.Forms.ProgressBar();
            this.enemy_name = new System.Windows.Forms.TextBox();
            this.pee_name = new System.Windows.Forms.TextBox();
            this.close_buttonnot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_buttonnot)).BeginInit();
            this.SuspendLayout();
            // 
            // char1
            // 
            this.char1.BackColor = System.Drawing.Color.Transparent;
            this.char1.BackgroundImage = global::formlike.Properties.Resources.charbet1;
            this.char1.Location = new System.Drawing.Point(97, 81);
            this.char1.MaximumSize = new System.Drawing.Size(209, 415);
            this.char1.MinimumSize = new System.Drawing.Size(209, 415);
            this.char1.Name = "char1";
            this.char1.Size = new System.Drawing.Size(209, 415);
            this.char1.TabIndex = 0;
            this.char1.TabStop = false;
            // 
            // char2
            // 
            this.char2.BackColor = System.Drawing.Color.Transparent;
            this.char2.BackgroundImage = global::formlike.Properties.Resources.charbet2;
            this.char2.Location = new System.Drawing.Point(626, 81);
            this.char2.MaximumSize = new System.Drawing.Size(209, 415);
            this.char2.MinimumSize = new System.Drawing.Size(209, 415);
            this.char2.Name = "char2";
            this.char2.Size = new System.Drawing.Size(209, 415);
            this.char2.TabIndex = 1;
            this.char2.TabStop = false;
            // 
            // use_1_1
            // 
            this.use_1_1.Location = new System.Drawing.Point(74, 515);
            this.use_1_1.Name = "use_1_1";
            this.use_1_1.Size = new System.Drawing.Size(75, 23);
            this.use_1_1.TabIndex = 2;
            this.use_1_1.Text = "use-1-1";
            this.use_1_1.UseVisualStyleBackColor = true;
            this.use_1_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // use_1_2
            // 
            this.use_1_2.Location = new System.Drawing.Point(172, 514);
            this.use_1_2.Name = "use_1_2";
            this.use_1_2.Size = new System.Drawing.Size(75, 23);
            this.use_1_2.TabIndex = 3;
            this.use_1_2.Text = "use-1-2";
            this.use_1_2.UseVisualStyleBackColor = true;
            this.use_1_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // use_1_3
            // 
            this.use_1_3.Location = new System.Drawing.Point(263, 514);
            this.use_1_3.Name = "use_1_3";
            this.use_1_3.Size = new System.Drawing.Size(75, 23);
            this.use_1_3.TabIndex = 4;
            this.use_1_3.Text = "use-1-3";
            this.use_1_3.UseVisualStyleBackColor = true;
            this.use_1_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hp1test
            // 
            this.hp1test.BackColor = System.Drawing.Color.Maroon;
            this.hp1test.Location = new System.Drawing.Point(134, 81);
            this.hp1test.Name = "hp1test";
            this.hp1test.Size = new System.Drawing.Size(136, 23);
            this.hp1test.TabIndex = 8;
            this.hp1test.Value = 100;
            // 
            // testvalues
            // 
            this.testvalues.BackColor = System.Drawing.Color.White;
            this.testvalues.Location = new System.Drawing.Point(74, 29);
            this.testvalues.Name = "testvalues";
            this.testvalues.ReadOnly = true;
            this.testvalues.Size = new System.Drawing.Size(789, 20);
            this.testvalues.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 75);
            this.button1.TabIndex = 11;
            this.button1.Text = "magicalbutton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.magicalbutton);
            // 
            // hp2test
            // 
            this.hp2test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hp2test.Location = new System.Drawing.Point(666, 81);
            this.hp2test.Name = "hp2test";
            this.hp2test.Size = new System.Drawing.Size(135, 23);
            this.hp2test.TabIndex = 9;
            this.hp2test.Value = 100;
            // 
            // enemy_name
            // 
            this.enemy_name.BackColor = System.Drawing.SystemColors.Control;
            this.enemy_name.Location = new System.Drawing.Point(628, 55);
            this.enemy_name.Name = "enemy_name";
            this.enemy_name.ReadOnly = true;
            this.enemy_name.Size = new System.Drawing.Size(209, 20);
            this.enemy_name.TabIndex = 12;
            this.enemy_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pee_name
            // 
            this.pee_name.BackColor = System.Drawing.SystemColors.Control;
            this.pee_name.Location = new System.Drawing.Point(97, 55);
            this.pee_name.Name = "pee_name";
            this.pee_name.ReadOnly = true;
            this.pee_name.Size = new System.Drawing.Size(209, 20);
            this.pee_name.TabIndex = 13;
            this.pee_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close_buttonnot
            // 
            this.close_buttonnot.BackColor = System.Drawing.Color.Transparent;
            this.close_buttonnot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_buttonnot.ErrorImage = global::formlike.Properties.Resources.close;
            this.close_buttonnot.Image = global::formlike.Properties.Resources.close;
            this.close_buttonnot.InitialImage = global::formlike.Properties.Resources.close;
            this.close_buttonnot.Location = new System.Drawing.Point(874, 2);
            this.close_buttonnot.Name = "close_buttonnot";
            this.close_buttonnot.Size = new System.Drawing.Size(25, 25);
            this.close_buttonnot.TabIndex = 14;
            this.close_buttonnot.TabStop = false;
            this.close_buttonnot.Click += new System.EventHandler(this.close_buttonnot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::formlike.Properties.Resources.backproj;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.close_buttonnot);
            this.Controls.Add(this.pee_name);
            this.Controls.Add(this.enemy_name);
            this.Controls.Add(this.hp2test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testvalues);
            this.Controls.Add(this.hp1test);
            this.Controls.Add(this.use_1_3);
            this.Controls.Add(this.use_1_2);
            this.Controls.Add(this.use_1_1);
            this.Controls.Add(this.char2);
            this.Controls.Add(this.char1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "^w^";
            ((System.ComponentModel.ISupportInitialize)(this.char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_buttonnot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox char1;
        private System.Windows.Forms.PictureBox char2;
        private System.Windows.Forms.Button use_1_1;
        private System.Windows.Forms.Button use_1_2;
        private System.Windows.Forms.Button use_1_3;
        private System.Windows.Forms.ProgressBar hp1test;
        private System.Windows.Forms.TextBox testvalues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar hp2test;
        private System.Windows.Forms.TextBox enemy_name;
        private System.Windows.Forms.TextBox pee_name;
        private System.Windows.Forms.PictureBox close_buttonnot;
    }
}

