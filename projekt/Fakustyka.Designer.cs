using System;

namespace test
{
    partial class Fakustyka
    {
        /// <summary>
        /// Required designer variable.
        int wynik = 0;
        private int counter = 30;
        int wylosowany_indeks = 0;  //dzwiek ktory sie aktualnie odegral
        bool faza_szkoleniowa = false;

        // tablica bedzie taka [0]=cat [1]=cow [2]=dog [3]=frog [4]=horse itd...
        string[] tab = new string[9]{"../../cat.wav","../../cow.wav","../../dog.wav","../../frog.wav","../../horse.wav", "../../sheep.wav","../../elephant.wav","../../lion.wav","../../bird.wav"};

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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.sheep = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.lion = new System.Windows.Forms.PictureBox();
            this.elephant = new System.Windows.Forms.PictureBox();
            this.frog = new System.Windows.Forms.PictureBox();
            this.horse = new System.Windows.Forms.PictureBox();
            this.dog = new System.Windows.Forms.PictureBox();
            this.cow = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(657, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wroc do menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // czas
            // 
            this.czas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(657, 208);
            this.czas.Multiline = true;
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(131, 44);
            this.czas.TabIndex = 5;
            this.czas.Text = "Czas: 30";
            this.czas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(657, 278);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 50);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Wynik: 0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(427, 92);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(196, 76);
            this.Start.TabIndex = 12;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // sheep
            // 
            this.sheep.Image = global::test.Properties.Resources.sheep;
            this.sheep.Location = new System.Drawing.Point(279, 294);
            this.sheep.Name = "sheep";
            this.sheep.Size = new System.Drawing.Size(100, 99);
            this.sheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sheep.TabIndex = 18;
            this.sheep.TabStop = false;
            this.sheep.Click += new System.EventHandler(this.sheep_Click);
            // 
            // bird
            // 
            this.bird.Image = global::test.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(279, 179);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(100, 95);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 17;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // lion
            // 
            this.lion.Image = global::test.Properties.Resources.lion;
            this.lion.Location = new System.Drawing.Point(160, 294);
            this.lion.Name = "lion";
            this.lion.Size = new System.Drawing.Size(97, 99);
            this.lion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lion.TabIndex = 16;
            this.lion.TabStop = false;
            this.lion.Click += new System.EventHandler(this.lion_Click);
            // 
            // elephant
            // 
            this.elephant.Image = global::test.Properties.Resources.elephant;
            this.elephant.Location = new System.Drawing.Point(22, 294);
            this.elephant.Name = "elephant";
            this.elephant.Size = new System.Drawing.Size(108, 99);
            this.elephant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elephant.TabIndex = 14;
            this.elephant.TabStop = false;
            this.elephant.Click += new System.EventHandler(this.elephant_Click);
            // 
            // frog
            // 
            this.frog.Image = global::test.Properties.Resources.frog;
            this.frog.Location = new System.Drawing.Point(279, 63);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(100, 96);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog.TabIndex = 11;
            this.frog.TabStop = false;
            this.frog.Click += new System.EventHandler(this.frog_Click);
            // 
            // horse
            // 
            this.horse.Image = global::test.Properties.Resources.horse;
            this.horse.Location = new System.Drawing.Point(22, 183);
            this.horse.Name = "horse";
            this.horse.Size = new System.Drawing.Size(108, 91);
            this.horse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse.TabIndex = 10;
            this.horse.TabStop = false;
            this.horse.Click += new System.EventHandler(this.horse_Click);
            // 
            // dog
            // 
            this.dog.Image = global::test.Properties.Resources.dog;
            this.dog.Location = new System.Drawing.Point(160, 179);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(97, 95);
            this.dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog.TabIndex = 9;
            this.dog.TabStop = false;
            this.dog.Click += new System.EventHandler(this.dog_Click);
            // 
            // cow
            // 
            this.cow.Image = global::test.Properties.Resources.cow;
            this.cow.Location = new System.Drawing.Point(160, 63);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(97, 96);
            this.cow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow.TabIndex = 8;
            this.cow.TabStop = false;
            this.cow.Click += new System.EventHandler(this.cow_Click);
            // 
            // cat
            // 
            this.cat.Image = global::test.Properties.Resources.cat;
            this.cat.Location = new System.Drawing.Point(22, 63);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(108, 96);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 7;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(657, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 66);
            this.button1.TabIndex = 19;
            this.button1.Text = "Faza szkoleniowa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(657, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 62);
            this.button2.TabIndex = 20;
            this.button2.Text = "Rozpocznij test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fakustyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sheep);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.lion);
            this.Controls.Add(this.elephant);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.frog);
            this.Controls.Add(this.horse);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.cow);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fakustyka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "n ";
            ((System.ComponentModel.ISupportInitialize)(this.sheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox czas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox cow;
        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.PictureBox horse;
        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox elephant;
        private System.Windows.Forms.PictureBox lion;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox sheep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}