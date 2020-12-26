
namespace SortingExp_排序範例
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TxQNo = new System.Windows.Forms.TextBox();
            this.TxRRg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxQNo
            // 
            this.TxQNo.Location = new System.Drawing.Point(1298, 12);
            this.TxQNo.Name = "TxQNo";
            this.TxQNo.Size = new System.Drawing.Size(85, 23);
            this.TxQNo.TabIndex = 0;
            this.TxQNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxRRg
            // 
            this.TxRRg.Location = new System.Drawing.Point(1298, 42);
            this.TxRRg.Name = "TxRRg";
            this.TxRRg.Size = new System.Drawing.Size(85, 23);
            this.TxRRg.TabIndex = 1;
            this.TxRRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "數據數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1218, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "數據範圍";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(1220, 87);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(163, 38);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "隨機數產生";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(1221, 142);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(163, 38);
            this.btnBubble.TabIndex = 5;
            this.btnBubble.Text = "氣泡排序法";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(1221, 527);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(163, 38);
            this.btnTree.TabIndex = 6;
            this.btnTree.Text = "堆積樹排序法";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(1218, 472);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(163, 38);
            this.btnRadix.TabIndex = 7;
            this.btnRadix.Text = "基數排序法";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(1218, 417);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(163, 38);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "合併排序法";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(1220, 362);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(163, 38);
            this.btnQuick.TabIndex = 9;
            this.btnQuick.Text = "快速排序法";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(1220, 307);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(163, 38);
            this.btnShell.TabIndex = 10;
            this.btnShell.Text = "謝爾排序法";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1220, 252);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(163, 38);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "插入排序法";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1220, 197);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(163, 38);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "選擇排序法";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Number";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1196, 614);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1221, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "耗時 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1274, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 641);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxRRg);
            this.Controls.Add(this.TxQNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxQNo;
        private System.Windows.Forms.TextBox TxRRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

