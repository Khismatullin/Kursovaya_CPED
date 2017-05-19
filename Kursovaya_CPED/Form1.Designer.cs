namespace Kursovaya_CPED
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxSrednee1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxCovariazionnaya1 = new System.Windows.Forms.RichTextBox();
            this.dataGridViewInputData1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewInputData2 = new System.Windows.Forms.DataGridView();
            this.richTextBoxCovariazionnaya2 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxSrednee2 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxUnionCovariazionnaya = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxInverseUnionCovariazionnaya = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.AutoSize = true;
            this.buttonSolve.Location = new System.Drawing.Point(770, 591);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(148, 42);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Вычислить";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Среднее переменных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Определить различие совокупностей по среднему какой-либо переменной";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(849, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "А затем использовать эту переменную для предсказания принадлежности новых членов " +
    "к какой-либо группе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Являются ли две или более совокупности значимо отличающимися одна от другой по ср" +
    "еднему значению какой-либо конкретной переменной";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1300, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Если среднее значение определенной переменной значимо различно для двух совокупно" +
    "стей, то вы можете сказать, что переменная разделяет данные совокупности.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(733, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Установить, какие из переменных вносят свой вклад в дискриминацию между совокупно" +
    "стями";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 644);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 148);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1236, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1236, 115);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSrednee1
            // 
            this.richTextBoxSrednee1.Location = new System.Drawing.Point(362, 45);
            this.richTextBoxSrednee1.Name = "richTextBoxSrednee1";
            this.richTextBoxSrednee1.Size = new System.Drawing.Size(363, 33);
            this.richTextBoxSrednee1.TabIndex = 2;
            this.richTextBoxSrednee1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ковариационная матрица";
            // 
            // richTextBoxCovariazionnaya1
            // 
            this.richTextBoxCovariazionnaya1.Location = new System.Drawing.Point(362, 104);
            this.richTextBoxCovariazionnaya1.Name = "richTextBoxCovariazionnaya1";
            this.richTextBoxCovariazionnaya1.Size = new System.Drawing.Size(363, 96);
            this.richTextBoxCovariazionnaya1.TabIndex = 5;
            this.richTextBoxCovariazionnaya1.Text = "";
            // 
            // dataGridViewInputData1
            // 
            this.dataGridViewInputData1.AllowUserToAddRows = false;
            this.dataGridViewInputData1.AllowUserToDeleteRows = false;
            this.dataGridViewInputData1.AllowUserToResizeColumns = false;
            this.dataGridViewInputData1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewInputData1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInputData1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInputData1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInputData1.CausesValidation = false;
            this.dataGridViewInputData1.Location = new System.Drawing.Point(16, 22);
            this.dataGridViewInputData1.Name = "dataGridViewInputData1";
            this.dataGridViewInputData1.RowTemplate.Height = 28;
            this.dataGridViewInputData1.Size = new System.Drawing.Size(340, 274);
            this.dataGridViewInputData1.TabIndex = 15;
            // 
            // dataGridViewInputData2
            // 
            this.dataGridViewInputData2.AllowUserToAddRows = false;
            this.dataGridViewInputData2.AllowUserToDeleteRows = false;
            this.dataGridViewInputData2.AllowUserToResizeColumns = false;
            this.dataGridViewInputData2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewInputData2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInputData2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInputData2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInputData2.CausesValidation = false;
            this.dataGridViewInputData2.Location = new System.Drawing.Point(16, 321);
            this.dataGridViewInputData2.Name = "dataGridViewInputData2";
            this.dataGridViewInputData2.RowTemplate.Height = 28;
            this.dataGridViewInputData2.Size = new System.Drawing.Size(340, 264);
            this.dataGridViewInputData2.TabIndex = 16;
            // 
            // richTextBoxCovariazionnaya2
            // 
            this.richTextBoxCovariazionnaya2.Location = new System.Drawing.Point(362, 400);
            this.richTextBoxCovariazionnaya2.Name = "richTextBoxCovariazionnaya2";
            this.richTextBoxCovariazionnaya2.Size = new System.Drawing.Size(363, 96);
            this.richTextBoxCovariazionnaya2.TabIndex = 20;
            this.richTextBoxCovariazionnaya2.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ковариационная матрица";
            // 
            // richTextBoxSrednee2
            // 
            this.richTextBoxSrednee2.Location = new System.Drawing.Point(362, 341);
            this.richTextBoxSrednee2.Name = "richTextBoxSrednee2";
            this.richTextBoxSrednee2.Size = new System.Drawing.Size(363, 33);
            this.richTextBoxSrednee2.TabIndex = 18;
            this.richTextBoxSrednee2.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Среднее переменных";
            // 
            // richTextBoxUnionCovariazionnaya
            // 
            this.richTextBoxUnionCovariazionnaya.Location = new System.Drawing.Point(745, 45);
            this.richTextBoxUnionCovariazionnaya.Name = "richTextBoxUnionCovariazionnaya";
            this.richTextBoxUnionCovariazionnaya.Size = new System.Drawing.Size(577, 110);
            this.richTextBoxUnionCovariazionnaya.TabIndex = 21;
            this.richTextBoxUnionCovariazionnaya.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(741, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Объединенная ковариационная";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(741, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Обратная объединенная ковариационная";
            // 
            // richTextBoxInverseUnionCovariazionnaya
            // 
            this.richTextBoxInverseUnionCovariazionnaya.Location = new System.Drawing.Point(745, 186);
            this.richTextBoxInverseUnionCovariazionnaya.Name = "richTextBoxInverseUnionCovariazionnaya";
            this.richTextBoxInverseUnionCovariazionnaya.Size = new System.Drawing.Size(577, 110);
            this.richTextBoxInverseUnionCovariazionnaya.TabIndex = 23;
            this.richTextBoxInverseUnionCovariazionnaya.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(741, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Коэффициенты дискриминантной функции";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(745, 359);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(577, 110);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 645);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBoxInverseUnionCovariazionnaya);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBoxUnionCovariazionnaya);
            this.Controls.Add(this.richTextBoxCovariazionnaya2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxSrednee2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewInputData2);
            this.Controls.Add(this.dataGridViewInputData1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBoxCovariazionnaya1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxSrednee1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSolve);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа \"Дискриминантный анализ\" Хисматуллин А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxSrednee1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxCovariazionnaya1;
        private System.Windows.Forms.DataGridView dataGridViewInputData1;
        private System.Windows.Forms.DataGridView dataGridViewInputData2;
        private System.Windows.Forms.RichTextBox richTextBoxCovariazionnaya2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxSrednee2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxUnionCovariazionnaya;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxInverseUnionCovariazionnaya;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

