namespace WindowsFormsApplication1
{
    partial class Medium
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
            this.timer1Medium = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1Medium
            // 
            this.timer1Medium.Tick += new System.EventHandler(this.timer1Medium_Tick);
            // 
            // Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 641);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "Medium";
            this.Text = "Medium";
            this.Load += new System.EventHandler(this.Medium_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Medium_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Medium_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1Medium;
    }
}