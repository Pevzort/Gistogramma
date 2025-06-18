namespace Gistogramma
{
    partial class MainWindow
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
            this.gridNumbersBegin = new System.Windows.Forms.DataGridView();
            this.paramsBox = new System.Windows.Forms.GroupBox();
            this.paramsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.varUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.paramsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.randButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.resGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.CheckBox();
            this.systemsGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumbersBegin)).BeginInit();
            this.paramsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNumbersBegin
            // 
            this.gridNumbersBegin.AllowUserToAddRows = false;
            this.gridNumbersBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridNumbersBegin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridNumbersBegin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumbersBegin.Location = new System.Drawing.Point(298, 350);
            this.gridNumbersBegin.Name = "gridNumbersBegin";
            this.gridNumbersBegin.Size = new System.Drawing.Size(542, 228);
            this.gridNumbersBegin.TabIndex = 0;
            // 
            // paramsBox
            // 
            this.paramsBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paramsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paramsBox.Controls.Add(this.paramsUpDown);
            this.paramsBox.Controls.Add(this.label2);
            this.paramsBox.Controls.Add(this.varUpDown);
            this.paramsBox.Controls.Add(this.label1);
            this.paramsBox.Location = new System.Drawing.Point(12, 12);
            this.paramsBox.Name = "paramsBox";
            this.paramsBox.Size = new System.Drawing.Size(200, 124);
            this.paramsBox.TabIndex = 1;
            this.paramsBox.TabStop = false;
            this.paramsBox.Text = "Количество";
            // 
            // paramsUpDown
            // 
            this.paramsUpDown.Location = new System.Drawing.Point(103, 82);
            this.paramsUpDown.Name = "paramsUpDown";
            this.paramsUpDown.Size = new System.Drawing.Size(92, 20);
            this.paramsUpDown.TabIndex = 3;
            this.paramsUpDown.ValueChanged += new System.EventHandler(this.paramsUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Показатели---";
            // 
            // varUpDown
            // 
            this.varUpDown.Location = new System.Drawing.Point(103, 32);
            this.varUpDown.Name = "varUpDown";
            this.varUpDown.Size = new System.Drawing.Size(91, 20);
            this.varUpDown.TabIndex = 1;
            this.varUpDown.ValueChanged += new System.EventHandler(this.varUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Варианты-------";
            // 
            // paramsGrid
            // 
            this.paramsGrid.AllowUserToAddRows = false;
            this.paramsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paramsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paramsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paramsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paramsGrid.Location = new System.Drawing.Point(17, 350);
            this.paramsGrid.Name = "paramsGrid";
            this.paramsGrid.RowHeadersVisible = false;
            this.paramsGrid.Size = new System.Drawing.Size(228, 228);
            this.paramsGrid.TabIndex = 2;
            this.paramsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParamsNameChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(61, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Показатели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(293, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Матрица начальных значений";
            // 
            // randButton
            // 
            this.randButton.BackColor = System.Drawing.Color.LightCoral;
            this.randButton.Location = new System.Drawing.Point(12, 142);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(200, 23);
            this.randButton.TabIndex = 5;
            this.randButton.Text = "Случайные значения";
            this.randButton.UseVisualStyleBackColor = false;
            this.randButton.Click += new System.EventHandler(this.randButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Lime;
            this.enterButton.Location = new System.Drawing.Point(13, 171);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(199, 23);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Ввод";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // resGrid
            // 
            this.resGrid.AllowUserToAddRows = false;
            this.resGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resGrid.Location = new System.Drawing.Point(218, 44);
            this.resGrid.Name = "resGrid";
            this.resGrid.ReadOnly = true;
            this.resGrid.Size = new System.Drawing.Size(622, 92);
            this.resGrid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(409, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Результаты решения";
            // 
            // weightBox
            // 
            this.weightBox.AutoSize = true;
            this.weightBox.Location = new System.Drawing.Point(17, 285);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(108, 17);
            this.weightBox.TabIndex = 9;
            this.weightBox.Text = "Учитывать веса";
            this.weightBox.UseVisualStyleBackColor = true;
            // 
            // systemsGrid
            // 
            this.systemsGrid.AllowUserToAddRows = false;
            this.systemsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.systemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.systemsGrid.Location = new System.Drawing.Point(218, 191);
            this.systemsGrid.Name = "systemsGrid";
            this.systemsGrid.RowHeadersVisible = false;
            this.systemsGrid.Size = new System.Drawing.Size(122, 111);
            this.systemsGrid.TabIndex = 10;
            this.systemsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SystemsNameChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(218, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Объекты";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(870, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.systemsGrid);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resGrid);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paramsGrid);
            this.Controls.Add(this.paramsBox);
            this.Controls.Add(this.gridNumbersBegin);
            this.Name = "MainWindow";
            this.Text = "Гистограмма значений";
            ((System.ComponentModel.ISupportInitialize)(this.gridNumbersBegin)).EndInit();
            this.paramsBox.ResumeLayout(false);
            this.paramsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNumbersBegin;
        private System.Windows.Forms.GroupBox paramsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown varUpDown;
        private System.Windows.Forms.NumericUpDown paramsUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView paramsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView resGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox weightBox;
        private System.Windows.Forms.DataGridView systemsGrid;
        private System.Windows.Forms.Label label6;
    }
}

