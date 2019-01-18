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
            this.components = new System.ComponentModel.Container();
            this.TicketsofA = new System.Windows.Forms.Label();
            this.TicketsofB = new System.Windows.Forms.Label();
            this.TicketsofC = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextA = new System.Windows.Forms.TextBox();
            this.TextB = new System.Windows.Forms.TextBox();
            this.TextC = new System.Windows.Forms.TextBox();
            this.TicketsLabel = new System.Windows.Forms.Label();
            this.ABC_Holder = new System.Windows.Forms.GroupBox();
            this.DesTic = new System.Windows.Forms.Label();
            this.RevGen = new System.Windows.Forms.Label();
            this.CalRev = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Hold_Rev = new System.Windows.Forms.GroupBox();
            this.Rev_A = new System.Windows.Forms.TextBox();
            this.RevofA = new System.Windows.Forms.Label();
            this.Rev_B = new System.Windows.Forms.TextBox();
            this.TextofTotal = new System.Windows.Forms.TextBox();
            this.Rev_Total = new System.Windows.Forms.Label();
            this.Rev_C = new System.Windows.Forms.TextBox();
            this.RevofC = new System.Windows.Forms.Label();
            this.RevofB = new System.Windows.Forms.Label();
            this.ABC_Holder.SuspendLayout();
            this.Hold_Rev.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketsofA
            // 
            this.TicketsofA.AutoSize = true;
            this.TicketsofA.Location = new System.Drawing.Point(30, 26);
            this.TicketsofA.Name = "TicketsofA";
            this.TicketsofA.Size = new System.Drawing.Size(48, 13);
            this.TicketsofA.TabIndex = 0;
            this.TicketsofA.Text = "Class A :";
            // 
            // TicketsofB
            // 
            this.TicketsofB.AutoSize = true;
            this.TicketsofB.Location = new System.Drawing.Point(30, 51);
            this.TicketsofB.Name = "TicketsofB";
            this.TicketsofB.Size = new System.Drawing.Size(48, 13);
            this.TicketsofB.TabIndex = 1;
            this.TicketsofB.Text = "Class B :";
            // 
            // TicketsofC
            // 
            this.TicketsofC.AutoSize = true;
            this.TicketsofC.Location = new System.Drawing.Point(30, 78);
            this.TicketsofC.Name = "TicketsofC";
            this.TicketsofC.Size = new System.Drawing.Size(48, 13);
            this.TicketsofC.TabIndex = 2;
            this.TicketsofC.Text = "Class C :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextA
            // 
            this.TextA.Location = new System.Drawing.Point(84, 19);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(100, 20);
            this.TextA.TabIndex = 4;
            // 
            // TextB
            // 
            this.TextB.Location = new System.Drawing.Point(84, 48);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(100, 20);
            this.TextB.TabIndex = 5;
            // 
            // TextC
            // 
            this.TextC.Location = new System.Drawing.Point(84, 75);
            this.TextC.Name = "TextC";
            this.TextC.Size = new System.Drawing.Size(100, 20);
            this.TextC.TabIndex = 6;
            // 
            // TicketsLabel
            // 
            this.TicketsLabel.AutoSize = true;
            this.TicketsLabel.Location = new System.Drawing.Point(12, 9);
            this.TicketsLabel.Name = "TicketsLabel";
            this.TicketsLabel.Size = new System.Drawing.Size(66, 13);
            this.TicketsLabel.TabIndex = 7;
            this.TicketsLabel.Text = "Tickets Sold";
            // 
            // ABC_Holder
            // 
            this.ABC_Holder.Controls.Add(this.TextC);
            this.ABC_Holder.Controls.Add(this.TicketsofC);
            this.ABC_Holder.Controls.Add(this.TicketsofB);
            this.ABC_Holder.Controls.Add(this.TextA);
            this.ABC_Holder.Controls.Add(this.TextB);
            this.ABC_Holder.Controls.Add(this.TicketsofA);
            this.ABC_Holder.Location = new System.Drawing.Point(22, 73);
            this.ABC_Holder.Name = "ABC_Holder";
            this.ABC_Holder.Size = new System.Drawing.Size(200, 101);
            this.ABC_Holder.TabIndex = 8;
            this.ABC_Holder.TabStop = false;
            this.ABC_Holder.Text = "HoldThis";
            // 
            // DesTic
            // 
            this.DesTic.Location = new System.Drawing.Point(38, 40);
            this.DesTic.Name = "DesTic";
            this.DesTic.Size = new System.Drawing.Size(184, 40);
            this.DesTic.TabIndex = 9;
            this.DesTic.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // RevGen
            // 
            this.RevGen.AutoSize = true;
            this.RevGen.Location = new System.Drawing.Point(302, 14);
            this.RevGen.Name = "RevGen";
            this.RevGen.Size = new System.Drawing.Size(104, 13);
            this.RevGen.TabIndex = 18;
            this.RevGen.Text = "Revenue Generated";
            // 
            // CalRev
            // 
            this.CalRev.Location = new System.Drawing.Point(106, 190);
            this.CalRev.Name = "CalRev";
            this.CalRev.Size = new System.Drawing.Size(75, 59);
            this.CalRev.TabIndex = 19;
            this.CalRev.Text = "Calculate Revenue";
            this.CalRev.UseVisualStyleBackColor = true;
            this.CalRev.Click += new System.EventHandler(this.CalRev_Click_1);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(187, 190);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 59);
            this.Clear_Button.TabIndex = 20;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(268, 190);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 59);
            this.Exit_Button.TabIndex = 21;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Hold_Rev
            // 
            this.Hold_Rev.Controls.Add(this.Rev_A);
            this.Hold_Rev.Controls.Add(this.RevofA);
            this.Hold_Rev.Controls.Add(this.Rev_B);
            this.Hold_Rev.Controls.Add(this.TextofTotal);
            this.Hold_Rev.Controls.Add(this.Rev_Total);
            this.Hold_Rev.Controls.Add(this.Rev_C);
            this.Hold_Rev.Controls.Add(this.RevofC);
            this.Hold_Rev.Controls.Add(this.RevofB);
            this.Hold_Rev.Location = new System.Drawing.Point(242, 30);
            this.Hold_Rev.Name = "Hold_Rev";
            this.Hold_Rev.Size = new System.Drawing.Size(217, 144);
            this.Hold_Rev.TabIndex = 22;
            this.Hold_Rev.TabStop = false;
            this.Hold_Rev.Text = "HoldThis2";
            // 
            // Rev_A
            // 
            this.Rev_A.Location = new System.Drawing.Point(83, 16);
            this.Rev_A.Name = "Rev_A";
            this.Rev_A.Size = new System.Drawing.Size(100, 20);
            this.Rev_A.TabIndex = 21;
            // 
            // RevofA
            // 
            this.RevofA.AutoSize = true;
            this.RevofA.Location = new System.Drawing.Point(29, 19);
            this.RevofA.Name = "RevofA";
            this.RevofA.Size = new System.Drawing.Size(48, 13);
            this.RevofA.TabIndex = 18;
            this.RevofA.Text = "Class A :";
            // 
            // Rev_B
            // 
            this.Rev_B.Location = new System.Drawing.Point(83, 47);
            this.Rev_B.Name = "Rev_B";
            this.Rev_B.Size = new System.Drawing.Size(100, 20);
            this.Rev_B.TabIndex = 22;
            // 
            // TextofTotal
            // 
            this.TextofTotal.Location = new System.Drawing.Point(83, 114);
            this.TextofTotal.Name = "TextofTotal";
            this.TextofTotal.Size = new System.Drawing.Size(100, 20);
            this.TextofTotal.TabIndex = 25;
            // 
            // Rev_Total
            // 
            this.Rev_Total.AutoSize = true;
            this.Rev_Total.Location = new System.Drawing.Point(40, 121);
            this.Rev_Total.Name = "Rev_Total";
            this.Rev_Total.Size = new System.Drawing.Size(37, 13);
            this.Rev_Total.TabIndex = 24;
            this.Rev_Total.Text = "Total :";
            // 
            // Rev_C
            // 
            this.Rev_C.Location = new System.Drawing.Point(83, 81);
            this.Rev_C.Name = "Rev_C";
            this.Rev_C.Size = new System.Drawing.Size(100, 20);
            this.Rev_C.TabIndex = 23;
            // 
            // RevofC
            // 
            this.RevofC.AutoSize = true;
            this.RevofC.Location = new System.Drawing.Point(29, 84);
            this.RevofC.Name = "RevofC";
            this.RevofC.Size = new System.Drawing.Size(48, 13);
            this.RevofC.TabIndex = 20;
            this.RevofC.Text = "Class C :";
            // 
            // RevofB
            // 
            this.RevofB.AutoSize = true;
            this.RevofB.Location = new System.Drawing.Point(29, 50);
            this.RevofB.Name = "RevofB";
            this.RevofB.Size = new System.Drawing.Size(48, 13);
            this.RevofB.TabIndex = 19;
            this.RevofB.Text = "Class B :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Hold_Rev);
            this.Controls.Add(this.CalRev);
            this.Controls.Add(this.RevGen);
            this.Controls.Add(this.DesTic);
            this.Controls.Add(this.ABC_Holder);
            this.Controls.Add(this.TicketsLabel);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ABC_Holder.ResumeLayout(false);
            this.ABC_Holder.PerformLayout();
            this.Hold_Rev.ResumeLayout(false);
            this.Hold_Rev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketsofA;
        private System.Windows.Forms.Label TicketsofB;
        private System.Windows.Forms.Label TicketsofC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.TextBox TextB;
        private System.Windows.Forms.TextBox TextC;
        private System.Windows.Forms.Label TicketsLabel;
        private System.Windows.Forms.GroupBox ABC_Holder;
        private System.Windows.Forms.Label DesTic;
        private System.Windows.Forms.GroupBox Hold_Rev;
        private System.Windows.Forms.Label RevGen;
        private System.Windows.Forms.Button CalRev;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Rev_A;
        private System.Windows.Forms.Label RevofA;
        private System.Windows.Forms.TextBox Rev_B;
        private System.Windows.Forms.TextBox TextofTotal;
        private System.Windows.Forms.Label Rev_Total;
        private System.Windows.Forms.TextBox Rev_C;
        private System.Windows.Forms.Label RevofC;
        private System.Windows.Forms.Label RevofB;
    }
}

