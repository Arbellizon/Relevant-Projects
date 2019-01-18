namespace WindowsFormsApp1
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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Carddes = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB5 = new System.Windows.Forms.PictureBox();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.ClosestToCards = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit_Button.Location = new System.Drawing.Point(173, 182);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(73, 19);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "EXIT";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Carddes
            // 
            this.Carddes.AutoSize = true;
            this.Carddes.Location = new System.Drawing.Point(130, 19);
            this.Carddes.Name = "Carddes";
            this.Carddes.Size = new System.Drawing.Size(158, 13);
            this.Carddes.TabIndex = 2;
            this.Carddes.Text = "Click A Card TO SEE ITS Name";
            this.Carddes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PB1
            // 
            this.PB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB1.Image = ((System.Drawing.Image)(resources.GetObject("PB1.Image")));
            this.PB1.Location = new System.Drawing.Point(49, 54);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(52, 72);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB1.TabIndex = 3;
            this.PB1.TabStop = false;
            this.PB1.Tag = "Ace of Spades";
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // PB5
            // 
            this.PB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB5.Image = ((System.Drawing.Image)(resources.GetObject("PB5.Image")));
            this.PB5.Location = new System.Drawing.Point(313, 54);
            this.PB5.Name = "PB5";
            this.PB5.Size = new System.Drawing.Size(52, 72);
            this.PB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB5.TabIndex = 4;
            this.PB5.TabStop = false;
            this.PB5.Tag = "Red Joker";
            this.PB5.Click += new System.EventHandler(this.PB5_Click);
            // 
            // PB4
            // 
            this.PB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB4.Image = ((System.Drawing.Image)(resources.GetObject("PB4.Image")));
            this.PB4.Location = new System.Drawing.Point(248, 54);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(52, 72);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB4.TabIndex = 5;
            this.PB4.TabStop = false;
            this.PB4.Tag = "King Of Clubs";
            this.PB4.Click += new System.EventHandler(this.PB4_Click);
            // 
            // PB3
            // 
            this.PB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB3.Image = ((System.Drawing.Image)(resources.GetObject("PB3.Image")));
            this.PB3.Location = new System.Drawing.Point(182, 54);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(52, 72);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB3.TabIndex = 6;
            this.PB3.TabStop = false;
            this.PB3.Tag = "Queen of Diamonds";
            this.PB3.Click += new System.EventHandler(this.PB3_Click);
            // 
            // PB2
            // 
            this.PB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB2.Image = ((System.Drawing.Image)(resources.GetObject("PB2.Image")));
            this.PB2.Location = new System.Drawing.Point(116, 54);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(52, 72);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB2.TabIndex = 7;
            this.PB2.TabStop = false;
            this.PB2.Tag = "Jak Of Hearts";
            this.PB2.Click += new System.EventHandler(this.PB2_Click);
            // 
            // ClosestToCards
            // 
            this.ClosestToCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClosestToCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosestToCards.Location = new System.Drawing.Point(49, 146);
            this.ClosestToCards.Name = "ClosestToCards";
            this.ClosestToCards.Size = new System.Drawing.Size(316, 23);
            this.ClosestToCards.TabIndex = 8;
            this.ClosestToCards.Text = "Pick A Card";
            this.ClosestToCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(418, 216);
            this.Controls.Add(this.ClosestToCards);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB5);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.Carddes);
            this.Controls.Add(this.Exit_Button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "gum";
            this.Text = "Card Identifyer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Carddes;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB5;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.Label ClosestToCards;
    }
}

