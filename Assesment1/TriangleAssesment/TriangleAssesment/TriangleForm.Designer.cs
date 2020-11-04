namespace TriangleAssesment
{
    partial class TriangleForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblside1 = new System.Windows.Forms.Label();
            this.lblside2 = new System.Windows.Forms.Label();
            this.lblside3 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.txtnumber3 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(4, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(375, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Please enter 3 numbers for a triangle";
            // 
            // lblside1
            // 
            this.lblside1.AutoSize = true;
            this.lblside1.Location = new System.Drawing.Point(13, 65);
            this.lblside1.Name = "lblside1";
            this.lblside1.Size = new System.Drawing.Size(81, 21);
            this.lblside1.TabIndex = 0;
            this.lblside1.Text = "Number 1";
            // 
            // lblside2
            // 
            this.lblside2.AutoSize = true;
            this.lblside2.Location = new System.Drawing.Point(13, 117);
            this.lblside2.Name = "lblside2";
            this.lblside2.Size = new System.Drawing.Size(81, 21);
            this.lblside2.TabIndex = 0;
            this.lblside2.Text = "Number 2";
            // 
            // lblside3
            // 
            this.lblside3.AutoSize = true;
            this.lblside3.Location = new System.Drawing.Point(13, 169);
            this.lblside3.Name = "lblside3";
            this.lblside3.Size = new System.Drawing.Size(81, 21);
            this.lblside3.TabIndex = 0;
            this.lblside3.Text = "Number 3";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(123, 62);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 29);
            this.txtnumber1.TabIndex = 1;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(123, 114);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 29);
            this.txtnumber2.TabIndex = 2;
            // 
            // txtnumber3
            // 
            this.txtnumber3.Location = new System.Drawing.Point(123, 166);
            this.txtnumber3.Name = "txtnumber3";
            this.txtnumber3.Size = new System.Drawing.Size(100, 29);
            this.txtnumber3.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(17, 234);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 42);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(123, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 0;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 298);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtnumber3);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lblside3);
            this.Controls.Add(this.lblside2);
            this.Controls.Add(this.lblside1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TriangleForm";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblside1;
        private System.Windows.Forms.Label lblside2;
        private System.Windows.Forms.Label lblside3;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.TextBox txtnumber3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
    }
}

