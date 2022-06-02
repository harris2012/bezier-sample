
namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AXTextBox = new System.Windows.Forms.TextBox();
            this.CYTextBox = new System.Windows.Forms.TextBox();
            this.CXTextBox = new System.Windows.Forms.TextBox();
            this.BYTextBox = new System.Windows.Forms.TextBox();
            this.BXTextBox = new System.Windows.Forms.TextBox();
            this.AYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 635);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AXTextBox
            // 
            this.AXTextBox.Location = new System.Drawing.Point(29, 6);
            this.AXTextBox.Name = "AXTextBox";
            this.AXTextBox.Size = new System.Drawing.Size(100, 21);
            this.AXTextBox.TabIndex = 2;
            this.AXTextBox.Text = "10";
            // 
            // CYTextBox
            // 
            this.CYTextBox.Location = new System.Drawing.Point(678, 6);
            this.CYTextBox.Name = "CYTextBox";
            this.CYTextBox.Size = new System.Drawing.Size(100, 21);
            this.CYTextBox.TabIndex = 3;
            this.CYTextBox.Text = "400";
            // 
            // CXTextBox
            // 
            this.CXTextBox.Location = new System.Drawing.Point(561, 6);
            this.CXTextBox.Name = "CXTextBox";
            this.CXTextBox.Size = new System.Drawing.Size(100, 21);
            this.CXTextBox.TabIndex = 4;
            this.CXTextBox.Text = "400";
            // 
            // BYTextBox
            // 
            this.BYTextBox.Location = new System.Drawing.Point(413, 6);
            this.BYTextBox.Name = "BYTextBox";
            this.BYTextBox.Size = new System.Drawing.Size(100, 21);
            this.BYTextBox.TabIndex = 5;
            this.BYTextBox.Text = "400";
            // 
            // BXTextBox
            // 
            this.BXTextBox.Location = new System.Drawing.Point(298, 6);
            this.BXTextBox.Name = "BXTextBox";
            this.BXTextBox.Size = new System.Drawing.Size(100, 21);
            this.BXTextBox.TabIndex = 6;
            this.BXTextBox.Text = "10";
            // 
            // AYTextBox
            // 
            this.AYTextBox.Location = new System.Drawing.Point(145, 6);
            this.AYTextBox.Name = "AYTextBox";
            this.AYTextBox.Size = new System.Drawing.Size(100, 21);
            this.AYTextBox.TabIndex = 7;
            this.AYTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AYTextBox);
            this.Controls.Add(this.BXTextBox);
            this.Controls.Add(this.BYTextBox);
            this.Controls.Add(this.CXTextBox);
            this.Controls.Add(this.CYTextBox);
            this.Controls.Add(this.AXTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AXTextBox;
        private System.Windows.Forms.TextBox CYTextBox;
        private System.Windows.Forms.TextBox CXTextBox;
        private System.Windows.Forms.TextBox BYTextBox;
        private System.Windows.Forms.TextBox BXTextBox;
        private System.Windows.Forms.TextBox AYTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

