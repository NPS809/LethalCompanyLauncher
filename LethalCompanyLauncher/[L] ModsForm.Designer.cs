namespace LethalCompanyLauncher
{
    partial class ModsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.list_enabledMods = new System.Windows.Forms.CheckedListBox();
            this.list_disabledMods = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_openDisMods = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_error = new System.Windows.Forms.Label();
            this.btn_disableAll = new System.Windows.Forms.Button();
            this.btn_enableAll = new System.Windows.Forms.Button();
            this.btn_openEnMods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Моды";
            // 
            // list_enabledMods
            // 
            this.list_enabledMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.list_enabledMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_enabledMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.list_enabledMods.FormattingEnabled = true;
            this.list_enabledMods.Location = new System.Drawing.Point(12, 53);
            this.list_enabledMods.Name = "list_enabledMods";
            this.list_enabledMods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_enabledMods.Size = new System.Drawing.Size(275, 287);
            this.list_enabledMods.TabIndex = 0;
            this.list_enabledMods.TabStop = false;
            this.list_enabledMods.SelectedIndexChanged += new System.EventHandler(this.list_enabledMods_SelectedIndexChanged);
            // 
            // list_disabledMods
            // 
            this.list_disabledMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.list_disabledMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_disabledMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.list_disabledMods.FormattingEnabled = true;
            this.list_disabledMods.Location = new System.Drawing.Point(303, 53);
            this.list_disabledMods.Name = "list_disabledMods";
            this.list_disabledMods.Size = new System.Drawing.Size(275, 287);
            this.list_disabledMods.TabIndex = 0;
            this.list_disabledMods.TabStop = false;
            this.list_disabledMods.SelectedIndexChanged += new System.EventHandler(this.list_disabledMods_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "✅ Включенные моды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(454, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "❌Выключенные моды";
            // 
            // btn_openDisMods
            // 
            this.btn_openDisMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openDisMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_openDisMods.Location = new System.Drawing.Point(548, 346);
            this.btn_openDisMods.Name = "btn_openDisMods";
            this.btn_openDisMods.Size = new System.Drawing.Size(30, 30);
            this.btn_openDisMods.TabIndex = 7;
            this.btn_openDisMods.TabStop = false;
            this.btn_openDisMods.Text = "📁";
            this.toolTip1.SetToolTip(this.btn_openDisMods, "Открыть папку с выключенными модами");
            this.btn_openDisMods.UseVisualStyleBackColor = true;
            this.btn_openDisMods.Click += new System.EventHandler(this.btn_openDisMods_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.Location = new System.Drawing.Point(548, 384);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Text = "🔃";
            this.toolTip1.SetToolTip(this.btn_refresh, "Обновить");
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_error.Location = new System.Drawing.Point(12, 401);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(60, 13);
            this.txt_error.TabIndex = 9;
            this.txt_error.Text = "[!] error text";
            // 
            // btn_disableAll
            // 
            this.btn_disableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disableAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_disableAll.Location = new System.Drawing.Point(48, 346);
            this.btn_disableAll.Name = "btn_disableAll";
            this.btn_disableAll.Size = new System.Drawing.Size(114, 30);
            this.btn_disableAll.TabIndex = 10;
            this.btn_disableAll.TabStop = false;
            this.btn_disableAll.Text = "Выключить всё";
            this.btn_disableAll.UseVisualStyleBackColor = true;
            this.btn_disableAll.Click += new System.EventHandler(this.btn_disableAll_Click);
            // 
            // btn_enableAll
            // 
            this.btn_enableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enableAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enableAll.Location = new System.Drawing.Point(428, 346);
            this.btn_enableAll.Name = "btn_enableAll";
            this.btn_enableAll.Size = new System.Drawing.Size(114, 30);
            this.btn_enableAll.TabIndex = 11;
            this.btn_enableAll.TabStop = false;
            this.btn_enableAll.Text = "Включить всё";
            this.btn_enableAll.UseVisualStyleBackColor = true;
            this.btn_enableAll.Click += new System.EventHandler(this.btn_enableAll_Click);
            // 
            // btn_openEnMods
            // 
            this.btn_openEnMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openEnMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_openEnMods.Location = new System.Drawing.Point(12, 346);
            this.btn_openEnMods.Name = "btn_openEnMods";
            this.btn_openEnMods.Size = new System.Drawing.Size(30, 30);
            this.btn_openEnMods.TabIndex = 12;
            this.btn_openEnMods.TabStop = false;
            this.btn_openEnMods.Text = "📁";
            this.toolTip1.SetToolTip(this.btn_openEnMods, "Открыть папку с включенными модами");
            this.btn_openEnMods.UseVisualStyleBackColor = true;
            this.btn_openEnMods.Click += new System.EventHandler(this.btn_openEnMods_Click);
            // 
            // ModsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(590, 426);
            this.Controls.Add(this.btn_openEnMods);
            this.Controls.Add(this.btn_enableAll);
            this.Controls.Add(this.btn_disableAll);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.btn_openDisMods);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_disabledMods);
            this.Controls.Add(this.list_enabledMods);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModsForm";
            this.Text = "ModsForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_openDisMods;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label txt_error;
        internal System.Windows.Forms.CheckedListBox list_enabledMods;
        internal System.Windows.Forms.CheckedListBox list_disabledMods;
        private System.Windows.Forms.Button btn_disableAll;
        private System.Windows.Forms.Button btn_enableAll;
        private System.Windows.Forms.Button btn_openEnMods;
    }
}