﻿namespace switchcase
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowtext = new System.Windows.Forms.TextBox();
            this.columntext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resulttest = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "row";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "column";
            // 
            // rowtext
            // 
            this.rowtext.Location = new System.Drawing.Point(136, 30);
            this.rowtext.Name = "rowtext";
            this.rowtext.Size = new System.Drawing.Size(100, 22);
            this.rowtext.TabIndex = 2;
            this.rowtext.Text = "5";
            // 
            // columntext
            // 
            this.columntext.Location = new System.Drawing.Point(136, 71);
            this.columntext.Name = "columntext";
            this.columntext.Size = new System.Drawing.Size(100, 22);
            this.columntext.TabIndex = 3;
            this.columntext.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "畫圖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resulttest
            // 
            this.resulttest.AutoSize = true;
            this.resulttest.Location = new System.Drawing.Point(338, 30);
            this.resulttest.Name = "resulttest";
            this.resulttest.Size = new System.Drawing.Size(0, 12);
            this.resulttest.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 354);
            this.Controls.Add(this.resulttest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.columntext);
            this.Controls.Add(this.rowtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowtext;
        private System.Windows.Forms.TextBox columntext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resulttest;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

