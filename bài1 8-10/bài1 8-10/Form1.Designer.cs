namespace bài1_8_10
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
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblTotalLabel = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(24, 24);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(116, 20);
            lblUnitPrice.TabIndex = 0;
            lblUnitPrice.Text = "Đơn giá dịch vụ:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(160, 20);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(150, 27);
            txtUnitPrice.TabIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 64);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(114, 20);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Số lượng khách:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(160, 60);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 27);
            txtQuantity.TabIndex = 1;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(24, 104);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(88, 20);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "% Giảm giá:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(160, 100);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(150, 27);
            txtDiscount.TabIndex = 2;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Location = new Point(24, 148);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(150, 20);
            lblTotalLabel.TabIndex = 3;
            lblTotalLabel.Text = "Tổng tiền thanh toán:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(160, 148);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "0.00";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 190);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Tính tiền";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(190, 190);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 30);
            btnReset.TabIndex = 5;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 250);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblTotalLabel);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Charge Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

