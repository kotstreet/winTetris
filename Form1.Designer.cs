﻿namespace WinTetris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPlay = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pctNext = new System.Windows.Forms.PictureBox();
            this.pctGameField = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeGameStatus = new System.Windows.Forms.Button();
            this.tbpRecords = new System.Windows.Forms.TabPage();
            this.lblRecords = new System.Windows.Forms.Label();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDeep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpHelp = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tbpPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameField)).BeginInit();
            this.tbpRecords.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.tbpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpPlay);
            this.tabControl1.Controls.Add(this.tbpRecords);
            this.tabControl1.Controls.Add(this.tbpSettings);
            this.tabControl1.Controls.Add(this.tbpHelp);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 477);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpPlay
            // 
            this.tbpPlay.Controls.Add(this.btnStop);
            this.tbpPlay.Controls.Add(this.lblLines);
            this.tbpPlay.Controls.Add(this.lblRecord);
            this.tbpPlay.Controls.Add(this.label10);
            this.tbpPlay.Controls.Add(this.pctNext);
            this.tbpPlay.Controls.Add(this.pctGameField);
            this.tbpPlay.Controls.Add(this.label9);
            this.tbpPlay.Controls.Add(this.label8);
            this.tbpPlay.Controls.Add(this.btnChangeGameStatus);
            this.tbpPlay.Location = new System.Drawing.Point(4, 29);
            this.tbpPlay.Name = "tbpPlay";
            this.tbpPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlay.Size = new System.Drawing.Size(500, 444);
            this.tbpPlay.TabIndex = 0;
            this.tbpPlay.Text = "Играть";
            this.tbpPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(388, 388);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 37);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(384, 345);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(18, 20);
            this.lblLines.TabIndex = 21;
            this.lblLines.Text = "0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(384, 284);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(18, 20);
            this.lblRecord.TabIndex = 20;
            this.lblRecord.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Следующая:";
            // 
            // pctNext
            // 
            this.pctNext.Location = new System.Drawing.Point(409, 135);
            this.pctNext.Name = "pctNext";
            this.pctNext.Size = new System.Drawing.Size(72, 111);
            this.pctNext.TabIndex = 18;
            this.pctNext.TabStop = false;
            // 
            // pctGameField
            // 
            this.pctGameField.Location = new System.Drawing.Point(8, 6);
            this.pctGameField.Name = "pctGameField";
            this.pctGameField.Size = new System.Drawing.Size(370, 429);
            this.pctGameField.TabIndex = 17;
            this.pctGameField.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Линий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Рекорд";
            // 
            // btnChangeGameStatus
            // 
            this.btnChangeGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeGameStatus.Location = new System.Drawing.Point(388, 44);
            this.btnChangeGameStatus.Name = "btnChangeGameStatus";
            this.btnChangeGameStatus.Size = new System.Drawing.Size(93, 37);
            this.btnChangeGameStatus.TabIndex = 12;
            this.btnChangeGameStatus.Text = "Начать";
            this.btnChangeGameStatus.UseVisualStyleBackColor = true;
            this.btnChangeGameStatus.Click += new System.EventHandler(this.btnChangeGameStatus_Click);
            // 
            // tbpRecords
            // 
            this.tbpRecords.Controls.Add(this.lblRecords);
            this.tbpRecords.Location = new System.Drawing.Point(4, 29);
            this.tbpRecords.Name = "tbpRecords";
            this.tbpRecords.Size = new System.Drawing.Size(500, 444);
            this.tbpRecords.TabIndex = 2;
            this.tbpRecords.Text = "Рекорды";
            this.tbpRecords.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecords.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblRecords.Location = new System.Drawing.Point(26, 21);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(65, 22);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "gecnj";
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.btnEditSettings);
            this.tbpSettings.Controls.Add(this.label5);
            this.tbpSettings.Controls.Add(this.label3);
            this.tbpSettings.Controls.Add(this.label2);
            this.tbpSettings.Controls.Add(this.nudSpeed);
            this.tbpSettings.Controls.Add(this.label6);
            this.tbpSettings.Controls.Add(this.nudDeep);
            this.tbpSettings.Controls.Add(this.label4);
            this.tbpSettings.Controls.Add(this.nudWidth);
            this.tbpSettings.Controls.Add(this.label1);
            this.tbpSettings.Location = new System.Drawing.Point(4, 29);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(500, 444);
            this.tbpSettings.TabIndex = 1;
            this.tbpSettings.Text = "Настройка";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSettings.Location = new System.Drawing.Point(342, 381);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(93, 37);
            this.btnEditSettings.TabIndex = 11;
            this.btnEditSettings.Text = "Принять";
            this.btnEditSettings.UseVisualStyleBackColor = true;
            this.btnEditSettings.Click += new System.EventHandler(this.btnEditSettings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(43, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 128);
            this.label5.TabIndex = 10;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "    Глубина игрового поля  не может быть меньше 10 клеточек\r\nи не может быть боль" +
    "ше 28 клеточек (рекомендуемое значе-\r\nние 20 клеточек).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "    Ширина игрового поля  не может быть меньше 4 клеточек\r\nи не может быть больше" +
    " 22 клеточек (рекомендуемое значе-\r\nние 10 клеточек).";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(327, 242);
            this.nudSpeed.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 26);
            this.nudSpeed.TabIndex = 7;
            this.nudSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Скорость падения фигур";
            // 
            // nudDeep
            // 
            this.nudDeep.Location = new System.Drawing.Point(327, 137);
            this.nudDeep.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudDeep.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDeep.Name = "nudDeep";
            this.nudDeep.Size = new System.Drawing.Size(120, 26);
            this.nudDeep.TabIndex = 4;
            this.nudDeep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Глубина игрового поля";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(327, 39);
            this.nudWidth.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 26);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина игрового поля";
            // 
            // tbpHelp
            // 
            this.tbpHelp.Controls.Add(this.label7);
            this.tbpHelp.Location = new System.Drawing.Point(4, 29);
            this.tbpHelp.Name = "tbpHelp";
            this.tbpHelp.Size = new System.Drawing.Size(500, 444);
            this.tbpHelp.TabIndex = 3;
            this.tbpHelp.Text = "Помощь";
            this.tbpHelp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 440);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 476);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетрис";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbpPlay.ResumeLayout(false);
            this.tbpPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameField)).EndInit();
            this.tbpRecords.ResumeLayout(false);
            this.tbpRecords.PerformLayout();
            this.tbpSettings.ResumeLayout(false);
            this.tbpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.tbpHelp.ResumeLayout(false);
            this.tbpHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPlay;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.TabPage tbpRecords;
        private System.Windows.Forms.TabPage tbpHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDeep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangeGameStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pctNext;
        private System.Windows.Forms.PictureBox pctGameField;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
    }
}

