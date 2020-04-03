namespace TicTacToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.xPointLabel = new System.Windows.Forms.Label();
            this.oLabel = new System.Windows.Forms.Label();
            this.oPointLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.turnValue = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.YellowGreen;
            this.A1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A1.Location = new System.Drawing.Point(12, 12);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.YellowGreen;
            this.A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A2.Location = new System.Drawing.Point(93, 12);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 0;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.YellowGreen;
            this.A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A3.Location = new System.Drawing.Point(174, 12);
            this.A3.Name = "A3";
            this.A3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 0;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.YellowGreen;
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B1.Location = new System.Drawing.Point(12, 93);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 0;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.YellowGreen;
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B2.Location = new System.Drawing.Point(93, 93);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 0;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.YellowGreen;
            this.B3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B3.Location = new System.Drawing.Point(174, 93);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 0;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.YellowGreen;
            this.C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C1.Location = new System.Drawing.Point(12, 174);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 0;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.YellowGreen;
            this.C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C2.Location = new System.Drawing.Point(93, 174);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 0;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.YellowGreen;
            this.C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C3.Location = new System.Drawing.Point(174, 174);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 0;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.xLabel.Location = new System.Drawing.Point(12, 261);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(90, 24);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X Points: ";
            // 
            // xPointLabel
            // 
            this.xPointLabel.AutoSize = true;
            this.xPointLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPointLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.xPointLabel.Location = new System.Drawing.Point(89, 262);
            this.xPointLabel.Name = "xPointLabel";
            this.xPointLabel.Size = new System.Drawing.Size(20, 24);
            this.xPointLabel.TabIndex = 1;
            this.xPointLabel.Text = "0";
            // 
            // oLabel
            // 
            this.oLabel.AutoSize = true;
            this.oLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.oLabel.Location = new System.Drawing.Point(159, 261);
            this.oLabel.Name = "oLabel";
            this.oLabel.Size = new System.Drawing.Size(91, 24);
            this.oLabel.TabIndex = 1;
            this.oLabel.Text = "O Points: ";
            // 
            // oPointLabel
            // 
            this.oPointLabel.AutoSize = true;
            this.oPointLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPointLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.oPointLabel.Location = new System.Drawing.Point(236, 262);
            this.oPointLabel.Name = "oPointLabel";
            this.oPointLabel.Size = new System.Drawing.Size(20, 24);
            this.oPointLabel.TabIndex = 1;
            this.oPointLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(93, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "[N]ew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnValue
            // 
            this.turnValue.AutoSize = true;
            this.turnValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.turnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnValue.ForeColor = System.Drawing.SystemColors.Info;
            this.turnValue.Location = new System.Drawing.Point(13, 291);
            this.turnValue.Name = "turnValue";
            this.turnValue.Size = new System.Drawing.Size(56, 18);
            this.turnValue.TabIndex = 1;
            this.turnValue.Text = "Turn: X";
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(175, 289);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "[R]eset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(262, 318);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oPointLabel);
            this.Controls.Add(this.xPointLabel);
            this.Controls.Add(this.oLabel);
            this.Controls.Add(this.turnValue);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label xPointLabel;
        private System.Windows.Forms.Label oLabel;
        private System.Windows.Forms.Label oPointLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turnValue;
        private System.Windows.Forms.Button resetButton;
    }
}

