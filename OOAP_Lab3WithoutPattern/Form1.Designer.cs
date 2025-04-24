namespace OOAP_Lab3WithPattern
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownRandLen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonQuick = new System.Windows.Forms.RadioButton();
            this.radioButtonBubble = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.dataGridViewSort = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandLen)).BeginInit();
            this.groupBoxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).BeginInit();
            this.groupBoxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1071, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "СРАВНЕНИЕ СОРТИРОВОК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Набор чисел";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToResizeColumns = false;
            this.dataGridViewList.AllowUserToResizeRows = false;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num});
            this.dataGridViewList.Location = new System.Drawing.Point(29, 103);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.Size = new System.Drawing.Size(177, 304);
            this.dataGridViewList.TabIndex = 2;
            // 
            // num
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.num.DefaultCellStyle = dataGridViewCellStyle1;
            this.num.Frozen = true;
            this.num.HeaderText = "число";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDownRandLen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(243, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сгенерировать набор случайных чисел";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateRandomList);
            // 
            // numericUpDownRandLen
            // 
            this.numericUpDownRandLen.Location = new System.Drawing.Point(197, 40);
            this.numericUpDownRandLen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRandLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRandLen.Name = "numericUpDownRandLen";
            this.numericUpDownRandLen.Size = new System.Drawing.Size(73, 26);
            this.numericUpDownRandLen.TabIndex = 1;
            this.numericUpDownRandLen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество чисел";
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSort.Controls.Add(this.radioButtonQuick);
            this.groupBoxSort.Controls.Add(this.radioButtonBubble);
            this.groupBoxSort.Controls.Add(this.buttonSort);
            this.groupBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort.Location = new System.Drawing.Point(243, 175);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(526, 173);
            this.groupBoxSort.TabIndex = 4;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Выбрать алгоритм сортировки";
            // 
            // radioButtonQuick
            // 
            this.radioButtonQuick.AutoSize = true;
            this.radioButtonQuick.Location = new System.Drawing.Point(39, 118);
            this.radioButtonQuick.Name = "radioButtonQuick";
            this.radioButtonQuick.Size = new System.Drawing.Size(206, 24);
            this.radioButtonQuick.TabIndex = 4;
            this.radioButtonQuick.TabStop = true;
            this.radioButtonQuick.Text = "Быстрая сортировка";
            this.radioButtonQuick.UseVisualStyleBackColor = true;
            // 
            // radioButtonBubble
            // 
            this.radioButtonBubble.AutoSize = true;
            this.radioButtonBubble.Location = new System.Drawing.Point(39, 54);
            this.radioButtonBubble.Name = "radioButtonBubble";
            this.radioButtonBubble.Size = new System.Drawing.Size(226, 24);
            this.radioButtonBubble.TabIndex = 3;
            this.radioButtonBubble.TabStop = true;
            this.radioButtonBubble.Text = "Сортировка пузырьком";
            this.radioButtonBubble.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(340, 91);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(166, 34);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ClickSortData);
            // 
            // dataGridViewSort
            // 
            this.dataGridViewSort.AllowUserToAddRows = false;
            this.dataGridViewSort.AllowUserToDeleteRows = false;
            this.dataGridViewSort.AllowUserToResizeColumns = false;
            this.dataGridViewSort.AllowUserToResizeRows = false;
            this.dataGridViewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewSort.Location = new System.Drawing.Point(803, 107);
            this.dataGridViewSort.Name = "dataGridViewSort";
            this.dataGridViewSort.RowHeadersWidth = 51;
            this.dataGridViewSort.RowTemplate.Height = 24;
            this.dataGridViewSort.Size = new System.Drawing.Size(177, 304);
            this.dataGridViewSort.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "число";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(799, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отсортированный набор";
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxRes.Controls.Add(this.labelResult);
            this.groupBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRes.Location = new System.Drawing.Point(243, 365);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(526, 73);
            this.groupBoxRes.TabIndex = 4;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Временные затраты";
            this.groupBoxRes.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 36);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(183, 20);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Затраченное время:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.groupBoxRes);
            this.Controls.Add(this.dataGridViewSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandLen)).EndInit();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).EndInit();
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownRandLen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.DataGridView dataGridViewSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonQuick;
        private System.Windows.Forms.RadioButton radioButtonBubble;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.Label labelResult;
    }
}

