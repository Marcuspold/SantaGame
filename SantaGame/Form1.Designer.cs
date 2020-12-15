
namespace SantaGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Snow = new System.Windows.Forms.PictureBox();
            this.House = new System.Windows.Forms.PictureBox();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Snow1 = new System.Windows.Forms.PictureBox();
            this.Snow2 = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Snow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            this.SuspendLayout();
            // 
            // Snow
            // 
            this.Snow.Image = ((System.Drawing.Image)(resources.GetObject("Snow.Image")));
            this.Snow.Location = new System.Drawing.Point(-9, 387);
            this.Snow.Name = "Snow";
            this.Snow.Size = new System.Drawing.Size(734, 63);
            this.Snow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snow.TabIndex = 0;
            this.Snow.TabStop = false;
            // 
            // House
            // 
            this.House.Image = ((System.Drawing.Image)(resources.GetObject("House.Image")));
            this.House.Location = new System.Drawing.Point(326, 270);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(176, 121);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.House.TabIndex = 1;
            this.House.TabStop = false;
            // 
            // Tree2
            // 
            this.Tree2.Image = ((System.Drawing.Image)(resources.GetObject("Tree2.Image")));
            this.Tree2.Location = new System.Drawing.Point(576, 270);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(64, 121);
            this.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree2.TabIndex = 2;
            this.Tree2.TabStop = false;
            // 
            // Tree1
            // 
            this.Tree1.Image = ((System.Drawing.Image)(resources.GetObject("Tree1.Image")));
            this.Tree1.Location = new System.Drawing.Point(125, 270);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(79, 121);
            this.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree1.TabIndex = 3;
            this.Tree1.TabStop = false;
            // 
            // Moon
            // 
            this.Moon.Image = ((System.Drawing.Image)(resources.GetObject("Moon.Image")));
            this.Moon.Location = new System.Drawing.Point(12, 12);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(95, 66);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon.TabIndex = 4;
            this.Moon.TabStop = false;
            // 
            // Snow1
            // 
            this.Snow1.Image = ((System.Drawing.Image)(resources.GetObject("Snow1.Image")));
            this.Snow1.Location = new System.Drawing.Point(402, 22);
            this.Snow1.Name = "Snow1";
            this.Snow1.Size = new System.Drawing.Size(53, 56);
            this.Snow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snow1.TabIndex = 5;
            this.Snow1.TabStop = false;
            // 
            // Snow2
            // 
            this.Snow2.Image = ((System.Drawing.Image)(resources.GetObject("Snow2.Image")));
            this.Snow2.Location = new System.Drawing.Point(508, 207);
            this.Snow2.Name = "Snow2";
            this.Snow2.Size = new System.Drawing.Size(68, 57);
            this.Snow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snow2.TabIndex = 6;
            this.Snow2.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(33, 123);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(136, 67);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 7;
            this.Santa.TabStop = false;
            this.Santa.Click += new System.EventHandler(this.Santa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(284, 31);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(70, 15);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "Score Board";
            // 
            // PlayAgain
            // 
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Location = new System.Drawing.Point(290, 135);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(149, 75);
            this.PlayAgain.TabIndex = 9;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.Snow2);
            this.Controls.Add(this.Snow1);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Tree1);
            this.Controls.Add(this.Tree2);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Snow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Snow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Snow;
        private System.Windows.Forms.PictureBox House;
        private System.Windows.Forms.PictureBox Tree2;
        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox Snow1;
        private System.Windows.Forms.PictureBox Snow2;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button PlayAgain;
    }
}

