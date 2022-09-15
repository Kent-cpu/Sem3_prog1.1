
namespace Lab1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.randomMatrixBtn = new System.Windows.Forms.Button();
            this.randomNumberBtn = new System.Windows.Forms.Button();
            this.randomTextBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 173);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(722, 355);
            this.dataGridView.TabIndex = 0;
            // 
            // randomMatrixBtn
            // 
            this.randomMatrixBtn.Location = new System.Drawing.Point(46, 25);
            this.randomMatrixBtn.Name = "randomMatrixBtn";
            this.randomMatrixBtn.Size = new System.Drawing.Size(101, 43);
            this.randomMatrixBtn.TabIndex = 1;
            this.randomMatrixBtn.Text = "Рандомная матрица";
            this.randomMatrixBtn.UseVisualStyleBackColor = true;
            this.randomMatrixBtn.Click += new System.EventHandler(this.randomMatrixBtn_Click);
            // 
            // randomNumberBtn
            // 
            this.randomNumberBtn.Location = new System.Drawing.Point(164, 25);
            this.randomNumberBtn.Name = "randomNumberBtn";
            this.randomNumberBtn.Size = new System.Drawing.Size(108, 43);
            this.randomNumberBtn.TabIndex = 2;
            this.randomNumberBtn.Text = "Рандомные числа";
            this.randomNumberBtn.UseVisualStyleBackColor = true;
            this.randomNumberBtn.Click += new System.EventHandler(this.randomNumberBtn_Click);
            // 
            // randomTextBox
            // 
            this.randomTextBox.Location = new System.Drawing.Point(46, 108);
            this.randomTextBox.Name = "randomTextBox";
            this.randomTextBox.Size = new System.Drawing.Size(379, 22);
            this.randomTextBox.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(298, 25);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(102, 43);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Поехали";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.randomTextBox);
            this.Controls.Add(this.randomNumberBtn);
            this.Controls.Add(this.randomMatrixBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button randomMatrixBtn;
        private System.Windows.Forms.Button randomNumberBtn;
        private System.Windows.Forms.TextBox randomTextBox;
        private System.Windows.Forms.Button startBtn;
    }
}

