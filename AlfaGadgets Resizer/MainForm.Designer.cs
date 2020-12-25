
namespace AlfaGadgets_Resizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseBTN);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Small";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SmallBTN);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Medium";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MediumBTN);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 56);
            this.button4.TabIndex = 4;
            this.button4.Text = "Large";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.LargeBTN);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "XLarge";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.XlargeBTN);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "XXlarge";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.XXlargeBTN);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(150, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 56);
            this.button7.TabIndex = 7;
            this.button7.Text = "Reset default settings";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NormalBTN);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 533);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 33);
            this.button8.TabIndex = 8;
            this.button8.Text = "About";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AboutBTN);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "AlfaGadgets Resize ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Version: 0.1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AlfaGadgetsResizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

