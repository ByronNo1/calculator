namespace calculator
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_PosNeg = new System.Windows.Forms.Button();
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_A4 = new System.Windows.Forms.Button();
            this.btn_DEL = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.White;
            this.btn_0.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_0.Location = new System.Drawing.Point(125, 500);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(114, 100);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_1.Location = new System.Drawing.Point(5, 394);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(114, 100);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2.Location = new System.Drawing.Point(125, 394);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(114, 100);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_PosNeg
            // 
            this.btn_PosNeg.BackColor = System.Drawing.Color.White;
            this.btn_PosNeg.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PosNeg.Location = new System.Drawing.Point(5, 500);
            this.btn_PosNeg.Name = "btn_PosNeg";
            this.btn_PosNeg.Size = new System.Drawing.Size(114, 100);
            this.btn_PosNeg.TabIndex = 0;
            this.btn_PosNeg.Text = "±";
            this.btn_PosNeg.UseVisualStyleBackColor = false;
            this.btn_PosNeg.Click += new System.EventHandler(this.btn_PosNeg_Click);
            // 
            // btn_Point
            // 
            this.btn_Point.BackColor = System.Drawing.Color.White;
            this.btn_Point.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Point.Location = new System.Drawing.Point(245, 500);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(114, 100);
            this.btn_Point.TabIndex = 0;
            this.btn_Point.Text = ".";
            this.btn_Point.UseVisualStyleBackColor = false;
            this.btn_Point.Click += new System.EventHandler(this.btn_Point_Click);
            // 
            // btn_Equal
            // 
            this.btn_Equal.BackColor = System.Drawing.Color.White;
            this.btn_Equal.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Equal.Location = new System.Drawing.Point(365, 500);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(114, 100);
            this.btn_Equal.TabIndex = 0;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = false;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_3.Location = new System.Drawing.Point(245, 394);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(114, 100);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_A1
            // 
            this.btn_A1.BackColor = System.Drawing.Color.White;
            this.btn_A1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_A1.Location = new System.Drawing.Point(365, 394);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(114, 100);
            this.btn_A1.TabIndex = 0;
            this.btn_A1.Text = "+";
            this.btn_A1.UseVisualStyleBackColor = false;
            this.btn_A1.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_4.Location = new System.Drawing.Point(5, 288);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(114, 100);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_6.Location = new System.Drawing.Point(245, 288);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(114, 100);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_A2
            // 
            this.btn_A2.BackColor = System.Drawing.Color.White;
            this.btn_A2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_A2.Location = new System.Drawing.Point(365, 288);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(114, 100);
            this.btn_A2.TabIndex = 0;
            this.btn_A2.Text = "-";
            this.btn_A2.UseVisualStyleBackColor = false;
            this.btn_A2.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_5.Location = new System.Drawing.Point(125, 288);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(114, 100);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_7.Location = new System.Drawing.Point(5, 182);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(114, 100);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_9.Location = new System.Drawing.Point(245, 182);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(114, 100);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_A3
            // 
            this.btn_A3.BackColor = System.Drawing.Color.White;
            this.btn_A3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_A3.Location = new System.Drawing.Point(365, 182);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(114, 100);
            this.btn_A3.TabIndex = 0;
            this.btn_A3.Text = "×";
            this.btn_A3.UseVisualStyleBackColor = false;
            this.btn_A3.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_8.Location = new System.Drawing.Point(125, 182);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(114, 100);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.White;
            this.btn_C.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_C.Location = new System.Drawing.Point(5, 76);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(114, 100);
            this.btn_C.TabIndex = 0;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_A4
            // 
            this.btn_A4.BackColor = System.Drawing.Color.White;
            this.btn_A4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_A4.Location = new System.Drawing.Point(365, 76);
            this.btn_A4.Name = "btn_A4";
            this.btn_A4.Size = new System.Drawing.Size(114, 100);
            this.btn_A4.TabIndex = 0;
            this.btn_A4.Text = "÷";
            this.btn_A4.UseVisualStyleBackColor = false;
            this.btn_A4.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_DEL
            // 
            this.btn_DEL.BackColor = System.Drawing.Color.White;
            this.btn_DEL.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DEL.Location = new System.Drawing.Point(125, 76);
            this.btn_DEL.Name = "btn_DEL";
            this.btn_DEL.Size = new System.Drawing.Size(234, 100);
            this.btn_DEL.TabIndex = 0;
            this.btn_DEL.Text = "←";
            this.btn_DEL.UseVisualStyleBackColor = false;
            this.btn_DEL.Click += new System.EventHandler(this.btn_DEL_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(5, 9);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(476, 59);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 610);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn_DEL);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_A4);
            this.Controls.Add(this.btn_A3);
            this.Controls.Add(this.btn_A2);
            this.Controls.Add(this.btn_A1);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_Point);
            this.Controls.Add(this.btn_PosNeg);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_PosNeg;
        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_A4;
        private System.Windows.Forms.Button btn_DEL;
        private System.Windows.Forms.TextBox txtResult;
    }
}

