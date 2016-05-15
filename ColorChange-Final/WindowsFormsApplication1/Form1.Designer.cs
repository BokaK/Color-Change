namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.endGame = new System.Windows.Forms.Label();
            this.wonGame = new System.Windows.Forms.Label();
            this.poeni = new System.Windows.Forms.Label();
            this.lbpoeni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "00:45";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // endGame
            // 
            this.endGame.AutoSize = true;
            this.endGame.BackColor = System.Drawing.Color.RosyBrown;
            this.endGame.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.Firebrick;
            this.endGame.Location = new System.Drawing.Point(12, 167);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(267, 54);
            this.endGame.TabIndex = 4;
            this.endGame.Text = "GAME OVER";
            // 
            // wonGame
            // 
            this.wonGame.AutoSize = true;
            this.wonGame.BackColor = System.Drawing.Color.RosyBrown;
            this.wonGame.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonGame.ForeColor = System.Drawing.Color.Firebrick;
            this.wonGame.Location = new System.Drawing.Point(54, 167);
            this.wonGame.Name = "wonGame";
            this.wonGame.Size = new System.Drawing.Size(178, 108);
            this.wonGame.TabIndex = 5;
            this.wonGame.Text = "NICELY \r\n DONE\r\n";
            this.wonGame.Click += new System.EventHandler(this.wonGame_Click);
            // 
            // poeni
            // 
            this.poeni.AutoSize = true;
            this.poeni.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poeni.Location = new System.Drawing.Point(1, 607);
            this.poeni.Name = "poeni";
            this.poeni.Size = new System.Drawing.Size(77, 25);
            this.poeni.TabIndex = 6;
            this.poeni.Text = "label3";
            // 
            // lbpoeni
            // 
            this.lbpoeni.AutoSize = true;
            this.lbpoeni.BackColor = System.Drawing.Color.DimGray;
            this.lbpoeni.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpoeni.ForeColor = System.Drawing.Color.Firebrick;
            this.lbpoeni.Location = new System.Drawing.Point(78, 275);
            this.lbpoeni.Name = "lbpoeni";
            this.lbpoeni.Size = new System.Drawing.Size(0, 30);
            this.lbpoeni.TabIndex = 7;
            this.lbpoeni.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 641);
            this.Controls.Add(this.lbpoeni);
            this.Controls.Add(this.poeni);
            this.Controls.Add(this.wonGame);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "COLOR CHANGE - EASY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label endGame;
        private System.Windows.Forms.Label wonGame;
        private System.Windows.Forms.Label poeni;
        private System.Windows.Forms.Label lbpoeni;
    }
}

