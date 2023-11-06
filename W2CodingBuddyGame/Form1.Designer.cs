namespace W2CodingBuddyGame
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            playerCAR = new PictureBox();
            policeCAR = new PictureBox();
            roadG2 = new PictureBox();
            roadG = new PictureBox();
            scoreTimer = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerCAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)policeCAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadG2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadG).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 548);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 506);
            label1.Name = "label1";
            label1.Size = new Size(409, 23);
            label1.TabIndex = 1;
            label1.Text = "Score: 0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(playerCAR);
            panel1.Controls.Add(policeCAR);
            panel1.Controls.Add(roadG2);
            panel1.Controls.Add(roadG);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 470);
            panel1.TabIndex = 2;
            // 
            // playerCAR
            // 
            playerCAR.Image = Resource1.Audi2;
            playerCAR.Location = new Point(96, 347);
            playerCAR.Name = "playerCAR";
            playerCAR.Size = new Size(48, 106);
            playerCAR.SizeMode = PictureBoxSizeMode.AutoSize;
            playerCAR.TabIndex = 5;
            playerCAR.TabStop = false;
            // 
            // policeCAR
            // 
            policeCAR.Image = Resource1.Police2;
            policeCAR.Location = new Point(286, 27);
            policeCAR.Name = "policeCAR";
            policeCAR.Size = new Size(49, 108);
            policeCAR.SizeMode = PictureBoxSizeMode.AutoSize;
            policeCAR.TabIndex = 3;
            policeCAR.TabStop = false;
            // 
            // roadG2
            // 
            roadG2.Image = Resource1.road;
            roadG2.Location = new Point(3, 0);
            roadG2.Name = "roadG2";
            roadG2.Size = new Size(409, 470);
            roadG2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadG2.TabIndex = 1;
            roadG2.TabStop = false;
            // 
            // roadG
            // 
            roadG.Image = Resource1.road;
            roadG.Location = new Point(0, -519);
            roadG.Name = "roadG";
            roadG.Size = new Size(409, 470);
            roadG.SizeMode = PictureBoxSizeMode.StretchImage;
            roadG.TabIndex = 0;
            roadG.TabStop = false;
            // 
            // scoreTimer
            // 
            scoreTimer.Interval = 10;
            scoreTimer.Tick += scoreTimer_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(218, 548);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Stop Game";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 605);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerCAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)policeCAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadG2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private PictureBox roadG;
        private PictureBox roadG2;
        private PictureBox playerCAR;
        private PictureBox policeCAR;
        private System.Windows.Forms.Timer scoreTimer;
        private Button button2;
    }
}