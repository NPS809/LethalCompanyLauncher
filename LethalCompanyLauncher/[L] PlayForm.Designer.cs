namespace LethalCompanyLauncher
{
    partial class PlayForm
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_openDIrectory = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_play = new System.Windows.Forms.Button();
            this.txt_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Играть";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.Location = new System.Drawing.Point(548, 384);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Text = "🔃";
            this.toolTip1.SetToolTip(this.btn_refresh, "Обновить");
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_openDIrectory
            // 
            this.btn_openDIrectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openDIrectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_openDIrectory.Location = new System.Drawing.Point(512, 384);
            this.btn_openDIrectory.Name = "btn_openDIrectory";
            this.btn_openDIrectory.Size = new System.Drawing.Size(30, 30);
            this.btn_openDIrectory.TabIndex = 0;
            this.btn_openDIrectory.TabStop = false;
            this.btn_openDIrectory.Text = "📁";
            this.toolTip1.SetToolTip(this.btn_openDIrectory, "Открыть папку лаунчера / игры");
            this.btn_openDIrectory.UseVisualStyleBackColor = true;
            this.btn_openDIrectory.Click += new System.EventHandler(this.btn_openDIrectory_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_play.Location = new System.Drawing.Point(15, 30);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 40);
            this.btn_play.TabIndex = 3;
            this.btn_play.TabStop = false;
            this.btn_play.Text = "Играть";
            this.toolTip1.SetToolTip(this.btn_play, "Запустить игру");
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_error.Location = new System.Drawing.Point(12, 401);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(60, 13);
            this.txt_error.TabIndex = 5;
            this.txt_error.Text = "[!] error text";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(590, 426);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_openDIrectory);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_openDIrectory;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btn_play;
        internal System.Windows.Forms.Label txt_error;
    }
}