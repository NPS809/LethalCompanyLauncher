namespace LethalCompanyLauncher
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.onClose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.onStart = new System.Windows.Forms.ComboBox();
            this.tb_opacity = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки";
            // 
            // onClose
            // 
            this.onClose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onClose.FormattingEnabled = true;
            this.onClose.Items.AddRange(new object[] {
            "Свернуть лаунчер в значок на панели задач",
            "Закрыть лаунчер"});
            this.onClose.Location = new System.Drawing.Point(17, 53);
            this.onClose.Name = "onClose";
            this.onClose.Size = new System.Drawing.Size(225, 21);
            this.onClose.TabIndex = 0;
            this.onClose.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "При нажатие на кнопку закрытия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "При запуске игры:";
            // 
            // onStart
            // 
            this.onStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onStart.FormattingEnabled = true;
            this.onStart.Items.AddRange(new object[] {
            "Не закрывать окно лаунчера",
            "Свернуть окно лаунчера",
            "Свернуть лаунчер в значок на панели задач",
            "Полностью выйти из лаунчера"});
            this.onStart.Location = new System.Drawing.Point(17, 103);
            this.onStart.Name = "onStart";
            this.onStart.Size = new System.Drawing.Size(225, 21);
            this.onStart.TabIndex = 0;
            this.onStart.TabStop = false;
            // 
            // tb_opacity
            // 
            this.tb_opacity.AutoSize = false;
            this.tb_opacity.Location = new System.Drawing.Point(17, 153);
            this.tb_opacity.Maximum = 100;
            this.tb_opacity.Minimum = 30;
            this.tb_opacity.Name = "tb_opacity";
            this.tb_opacity.Size = new System.Drawing.Size(225, 20);
            this.tb_opacity.TabIndex = 0;
            this.tb_opacity.TabStop = false;
            this.tb_opacity.Value = 100;
            this.tb_opacity.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Прозрачность окна:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(590, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_opacity);
            this.Controls.Add(this.onStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = " x";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tb_opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_opacity;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox onClose;
        internal System.Windows.Forms.ComboBox onStart;
    }
}