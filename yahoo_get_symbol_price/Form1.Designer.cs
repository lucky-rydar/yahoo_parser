namespace yahoo_get_symbol_price
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SymbolTextEdit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Symbol = new System.Windows.Forms.Label();
            this.PriceDifference = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousClose = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MarketCap = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SymbolTextEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 126);
            this.panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(411, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 31);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SymbolTextEdit
            // 
            this.SymbolTextEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymbolTextEdit.Location = new System.Drawing.Point(90, 46);
            this.SymbolTextEdit.Name = "SymbolTextEdit";
            this.SymbolTextEdit.Size = new System.Drawing.Size(263, 24);
            this.SymbolTextEdit.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Symbol);
            this.panel2.Controls.Add(this.PriceDifference);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 316);
            this.panel2.TabIndex = 1;
            // 
            // Symbol
            // 
            this.Symbol.AutoSize = true;
            this.Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol.Location = new System.Drawing.Point(15, 25);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(78, 29);
            this.Symbol.TabIndex = 3;
            this.Symbol.Text = "NULL";
            // 
            // PriceDifference
            // 
            this.PriceDifference.AutoSize = true;
            this.PriceDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceDifference.ForeColor = System.Drawing.Color.Black;
            this.PriceDifference.Location = new System.Drawing.Point(16, 150);
            this.PriceDifference.Name = "PriceDifference";
            this.PriceDifference.Size = new System.Drawing.Size(77, 24);
            this.PriceDifference.TabIndex = 1;
            this.PriceDifference.Text = "0.0 (0%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(16, 102);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 24);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(197, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Previous Close: ";
            // 
            // PreviousClose
            // 
            this.PreviousClose.AutoSize = true;
            this.PreviousClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousClose.Location = new System.Drawing.Point(375, 172);
            this.PreviousClose.Name = "PreviousClose";
            this.PreviousClose.Size = new System.Drawing.Size(31, 20);
            this.PreviousClose.TabIndex = 3;
            this.PreviousClose.Text = "0.0";
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(375, 192);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(31, 20);
            this.Open.TabIndex = 5;
            this.Open.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(197, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Open: ";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Volume.Location = new System.Drawing.Point(375, 212);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(31, 20);
            this.Volume.TabIndex = 7;
            this.Volume.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(197, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Volume: ";
            // 
            // MarketCap
            // 
            this.MarketCap.AutoSize = true;
            this.MarketCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarketCap.Location = new System.Drawing.Point(375, 232);
            this.MarketCap.Name = "MarketCap";
            this.MarketCap.Size = new System.Drawing.Size(31, 20);
            this.MarketCap.TabIndex = 9;
            this.MarketCap.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(197, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Market Cap: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Symbol";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(575, 442);
            this.Controls.Add(this.MarketCap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PreviousClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(591, 481);
            this.MinimumSize = new System.Drawing.Size(591, 481);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SymbolTextEdit;
        private System.Windows.Forms.Label PriceDifference;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PreviousClose;
        private System.Windows.Forms.Label Open;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MarketCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Symbol;
        private System.Windows.Forms.Label label2;
    }
}

