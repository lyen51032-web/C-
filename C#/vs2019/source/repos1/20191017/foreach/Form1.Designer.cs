namespace @foreach
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
            this.namelb1 = new System.Windows.Forms.Label();
            this.namelb2 = new System.Windows.Forms.Label();
            this.namelb3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelb1
            // 
            this.namelb1.AutoSize = true;
            this.namelb1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namelb1.Location = new System.Drawing.Point(108, 52);
            this.namelb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelb1.Name = "namelb1";
            this.namelb1.Size = new System.Drawing.Size(46, 16);
            this.namelb1.TabIndex = 0;
            this.namelb1.Text = "label1";
            // 
            // namelb2
            // 
            this.namelb2.AutoSize = true;
            this.namelb2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namelb2.Location = new System.Drawing.Point(108, 101);
            this.namelb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelb2.Name = "namelb2";
            this.namelb2.Size = new System.Drawing.Size(46, 16);
            this.namelb2.TabIndex = 1;
            this.namelb2.Text = "label2";
            // 
            // namelb3
            // 
            this.namelb3.AutoSize = true;
            this.namelb3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namelb3.Location = new System.Drawing.Point(108, 153);
            this.namelb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelb3.Name = "namelb3";
            this.namelb3.Size = new System.Drawing.Size(46, 16);
            this.namelb3.TabIndex = 2;
            this.namelb3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namelb3);
            this.Controls.Add(this.namelb2);
            this.Controls.Add(this.namelb1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelb1;
        private System.Windows.Forms.Label namelb2;
        private System.Windows.Forms.Label namelb3;
        private System.Windows.Forms.Button button1;
    }
}

