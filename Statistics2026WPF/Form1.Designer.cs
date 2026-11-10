namespace Statistics2026WPF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btncolumn = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnpie = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btbMode = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 58);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Subjects";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(537, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAverage.Location = new System.Drawing.Point(12, 378);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(160, 49);
            this.btnAverage.TabIndex = 1;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btncolumn
            // 
            this.btncolumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncolumn.Location = new System.Drawing.Point(595, 292);
            this.btncolumn.Name = "btncolumn";
            this.btncolumn.Size = new System.Drawing.Size(164, 66);
            this.btncolumn.TabIndex = 2;
            this.btncolumn.Text = "Column";
            this.btncolumn.UseVisualStyleBackColor = true;
            this.btncolumn.Click += new System.EventHandler(this.btnchart_Click);
            // 
            // btnline
            // 
            this.btnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnline.Location = new System.Drawing.Point(595, 172);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(164, 75);
            this.btnline.TabIndex = 3;
            this.btnline.Text = "Line";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnpie
            // 
            this.btnpie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpie.Location = new System.Drawing.Point(595, 58);
            this.btnpie.Name = "btnpie";
            this.btnpie.Size = new System.Drawing.Size(164, 79);
            this.btnpie.TabIndex = 4;
            this.btnpie.Text = "Pie";
            this.btnpie.UseVisualStyleBackColor = true;
            this.btnpie.Click += new System.EventHandler(this.btnpie_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumbers.Location = new System.Drawing.Point(12, 12);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(537, 40);
            this.txtNumbers.TabIndex = 5;
            this.txtNumbers.TextChanged += new System.EventHandler(this.txtNumbers_TextChanged);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedian.Location = new System.Drawing.Point(178, 378);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(141, 49);
            this.btnMedian.TabIndex = 6;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btbMode
            // 
            this.btbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btbMode.Location = new System.Drawing.Point(325, 378);
            this.btbMode.Name = "btbMode";
            this.btbMode.Size = new System.Drawing.Size(131, 49);
            this.btbMode.TabIndex = 7;
            this.btbMode.Text = "Mode";
            this.btbMode.UseVisualStyleBackColor = true;
            this.btbMode.Click += new System.EventHandler(this.btbMode_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(479, 384);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(107, 37);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "output";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btbMode);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.btnpie);
            this.Controls.Add(this.btnline);
            this.Controls.Add(this.btncolumn);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btncolumn;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnpie;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btbMode;
        private System.Windows.Forms.Label lblOutput;
    }
}

