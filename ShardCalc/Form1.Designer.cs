
namespace ShardCalc
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
            this.lots = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.identified = new System.Windows.Forms.CheckBox();
            this.lotPrice = new System.Windows.Forms.TextBox();
            this.shardPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lots
            // 
            this.lots.Location = new System.Drawing.Point(12, 12);
            this.lots.Name = "lots";
            this.lots.Size = new System.Drawing.Size(100, 20);
            this.lots.TabIndex = 0;
            this.lots.TextChanged += new System.EventHandler(this.lots_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lots";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(12, 39);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(100, 20);
            this.level.TabIndex = 2;
            this.level.TextChanged += new System.EventHandler(this.level_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 144);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(73, 20);
            this.result.TabIndex = 4;
            this.result.Text = "0 Shards";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Uncommon",
            "Rare",
            "Mythical",
            "Legendary",
            "Souvenir",
            "Epic",
            "Relic"});
            this.checkedListBox1.Location = new System.Drawing.Point(187, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 109);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // identified
            // 
            this.identified.AutoSize = true;
            this.identified.Location = new System.Drawing.Point(12, 124);
            this.identified.Name = "identified";
            this.identified.Size = new System.Drawing.Size(69, 17);
            this.identified.TabIndex = 6;
            this.identified.Text = "Identified";
            this.identified.UseVisualStyleBackColor = true;
            this.identified.CheckedChanged += new System.EventHandler(this.identified_CheckedChanged);
            // 
            // lotPrice
            // 
            this.lotPrice.Location = new System.Drawing.Point(12, 66);
            this.lotPrice.Name = "lotPrice";
            this.lotPrice.Size = new System.Drawing.Size(100, 20);
            this.lotPrice.TabIndex = 7;
            this.lotPrice.TextChanged += new System.EventHandler(this.lotPrice_TextChanged);
            // 
            // shardPrice
            // 
            this.shardPrice.Location = new System.Drawing.Point(12, 92);
            this.shardPrice.Name = "shardPrice";
            this.shardPrice.Size = new System.Drawing.Size(100, 20);
            this.shardPrice.TabIndex = 8;
            this.shardPrice.TextChanged += new System.EventHandler(this.shardPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lot Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shard Price";
            // 
            // sell
            // 
            this.sell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sell.AutoSize = true;
            this.sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.Location = new System.Drawing.Point(183, 144);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(59, 20);
            this.sell.TabIndex = 13;
            this.sell.Text = "0K / 0K";
            this.sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 251);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shardPrice);
            this.Controls.Add(this.lotPrice);
            this.Controls.Add(this.identified);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ShardCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox identified;
        private System.Windows.Forms.TextBox lotPrice;
        private System.Windows.Forms.TextBox shardPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sell;
    }
}

