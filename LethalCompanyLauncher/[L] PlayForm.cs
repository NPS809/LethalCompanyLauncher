using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LethalCompanyLauncher
{
    public partial class PlayForm : Form
    {
        MainForm mf;
        public PlayForm(MainForm mf)
        {
            this.mf = mf;
            TopLevel = false;
            Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, System.EventArgs e) => mf.UpdateAll();

        internal void btn_openDIrectory_Click(object sender, System.EventArgs e)
        {
            try {Process.Start("explorer.exe", mf.path); }
            catch (Exception ex) { MessageBox.Show($"Произошла ошибка\n\n{ex}"); }   
        }

        internal void btn_play_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(mf.path + mf.exe_offset)) {
                try { 
                    Process.Start(mf.path + mf.exe_offset); 
                    switch  (mf.sf.onStart.SelectedIndex)
                    {
                        case 1:
                            mf.WindowState = FormWindowState.Minimized;
                            break;
                        case 2:
                            mf.HideInTaskBar();
                            break;
                        case 3:
                            Application.Exit();
                            break;
                    }
                
                }
                catch (Exception ex) { MessageBox.Show($"Произошла ошибка\n\n{ex}"); }   
            } else
                MessageBox.Show("Файл запуска игры не найден. Запуск невозможен");
        }
    }
}
