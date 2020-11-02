namespace HtmlParser
{
    partial class FormMain
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
            this.listbTitles = new System.Windows.Forms.ListBox();
            this.numStartPoint = new System.Windows.Forms.NumericUpDown();
            this.lbStartPoint = new System.Windows.Forms.Label();
            this.lbEndPoint = new System.Windows.Forms.Label();
            this.numEndPoint = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // listbTitles
            // 
            this.listbTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbTitles.FormattingEnabled = true;
            this.listbTitles.Location = new System.Drawing.Point(12, 16);
            this.listbTitles.Name = "listbTitles";
            this.listbTitles.Size = new System.Drawing.Size(258, 420);
            this.listbTitles.TabIndex = 0;
            // 
            // numStartPoint
            // 
            this.numStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartPoint.Location = new System.Drawing.Point(286, 19);
            this.numStartPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartPoint.Name = "numStartPoint";
            this.numStartPoint.Size = new System.Drawing.Size(120, 20);
            this.numStartPoint.TabIndex = 2;
            this.numStartPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbStartPoint
            // 
            this.lbStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStartPoint.AutoSize = true;
            this.lbStartPoint.Location = new System.Drawing.Point(283, 3);
            this.lbStartPoint.Name = "lbStartPoint";
            this.lbStartPoint.Size = new System.Drawing.Size(56, 13);
            this.lbStartPoint.TabIndex = 3;
            this.lbStartPoint.Text = "Start Point";
            // 
            // lbEndPoint
            // 
            this.lbEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndPoint.AutoSize = true;
            this.lbEndPoint.Location = new System.Drawing.Point(283, 47);
            this.lbEndPoint.Name = "lbEndPoint";
            this.lbEndPoint.Size = new System.Drawing.Size(53, 13);
            this.lbEndPoint.TabIndex = 5;
            this.lbEndPoint.Text = "End Point";
            // 
            // numEndPoint
            // 
            this.numEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numEndPoint.Location = new System.Drawing.Point(286, 63);
            this.numEndPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndPoint.Name = "numEndPoint";
            this.numEndPoint.Size = new System.Drawing.Size(120, 20);
            this.numEndPoint.TabIndex = 4;
            this.numEndPoint.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(286, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 25);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(286, 131);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(120, 25);
            this.btnAbort.TabIndex = 7;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbEndPoint);
            this.Controls.Add(this.numEndPoint);
            this.Controls.Add(this.lbStartPoint);
            this.Controls.Add(this.numStartPoint);
            this.Controls.Add(this.listbTitles);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.numStartPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbTitles;
        private System.Windows.Forms.NumericUpDown numStartPoint;
        private System.Windows.Forms.Label lbStartPoint;
        private System.Windows.Forms.Label lbEndPoint;
        private System.Windows.Forms.NumericUpDown numEndPoint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
    }
}

