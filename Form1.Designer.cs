
namespace Assignment7
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
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picBot = new System.Windows.Forms.PictureBox();
            this.picPoint = new System.Windows.Forms.PictureBox();
            this.gravityUP = new System.Windows.Forms.Timer(this.components);
            this.gravityDwn = new System.Windows.Forms.Timer(this.components);
            this.movementtimer = new System.Windows.Forms.Timer(this.components);
            this.gameovertimer = new System.Windows.Forms.Timer(this.components);
            this.picground = new System.Windows.Forms.PictureBox();
            this.copter1 = new Assignment7.Copter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picground)).BeginInit();
            this.SuspendLayout();
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.Chartreuse;
            this.picTop.Location = new System.Drawing.Point(849, 23);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(39, 195);
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            // 
            // picBot
            // 
            this.picBot.BackColor = System.Drawing.Color.Chartreuse;
            this.picBot.Location = new System.Drawing.Point(849, 389);
            this.picBot.Name = "picBot";
            this.picBot.Size = new System.Drawing.Size(39, 203);
            this.picBot.TabIndex = 1;
            this.picBot.TabStop = false;
            // 
            // picPoint
            // 
            this.picPoint.Location = new System.Drawing.Point(894, 170);
            this.picPoint.Name = "picPoint";
            this.picPoint.Size = new System.Drawing.Size(40, 253);
            this.picPoint.TabIndex = 2;
            this.picPoint.TabStop = false;
            // 
            // gravityUP
            // 
            this.gravityUP.Interval = 1;
            this.gravityUP.Tick += new System.EventHandler(this.gravityUP_Tick);
            // 
            // gravityDwn
            // 
            this.gravityDwn.Interval = 1;
            this.gravityDwn.Tick += new System.EventHandler(this.gravityDwn_Tick);
            // 
            // movementtimer
            // 
            this.movementtimer.Enabled = true;
            this.movementtimer.Interval = 10;
            this.movementtimer.Tick += new System.EventHandler(this.movementtimer_Tick);
            // 
            // gameovertimer
            // 
            this.gameovertimer.Tick += new System.EventHandler(this.gameovertimer_Tick);
            // 
            // picground
            // 
            this.picground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picground.Location = new System.Drawing.Point(-3, 563);
            this.picground.Name = "picground";
            this.picground.Size = new System.Drawing.Size(1125, 31);
            this.picground.TabIndex = 3;
            this.picground.TabStop = false;
            // 
            // copter1
            // 
            this.copter1.BackColor = System.Drawing.Color.Red;
            this.copter1.Location = new System.Drawing.Point(144, 213);
            this.copter1.Name = "copter1";
            this.copter1.Size = new System.Drawing.Size(48, 48);
            this.copter1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(574, 389);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 74);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Restart";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 593);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copter1);
            this.Controls.Add(this.picground);
            this.Controls.Add(this.picPoint);
            this.Controls.Add(this.picBot);
            this.Controls.Add(this.picTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picBot;
        private System.Windows.Forms.PictureBox picPoint;
        private System.Windows.Forms.Timer gravityUP;
        private System.Windows.Forms.Timer gravityDwn;
        private System.Windows.Forms.Timer movementtimer;
        private System.Windows.Forms.Timer gameovertimer;
        private System.Windows.Forms.PictureBox picground;
        private Copter copter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}

