using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.IO;

namespace LethalCompanyLauncher
{
    public partial class ModsForm : Form
    {
        MainForm mf;
        public ModsForm(MainForm mf)
        {
            TopLevel = false;
            Dock = DockStyle.Fill;
            InitializeComponent();
            this.mf = mf;
        }

        internal void btn_openDisMods_Click(object sender, System.EventArgs e)
        {
            try { 
                if (Directory.Exists(mf.path + mf.mods_offset))
                    Process.Start("explorer.exe", mf.path + mf.disabled_mods_offset);
                else
                    MessageBox.Show("Папка с включенными модами не обнаружена");
            }
            catch (Exception ex) { MessageBox.Show($"Произошла ошибка\n\n{ex}"); }
        }

        private void list_enabledMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_enabledMods.SelectedIndex == -1) return;
            try
            {
                File.Move(mf.path + mf.mods_offset + list_enabledMods.SelectedItem,
                    mf.path + mf.disabled_mods_offset + list_enabledMods.SelectedItem);
                mf.UpdateAll();
            } catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка\n\n{ex}");
            }
        }

        private void list_disabledMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_disabledMods.SelectedIndex == -1) return;
            try
            {
                File.Move(mf.path + mf.disabled_mods_offset + list_disabledMods.SelectedItem,
                    mf.path + mf.mods_offset + list_disabledMods.SelectedItem);
                mf.UpdateAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка\n\n{ex}");
            }
        }

        private void btn_disableAll_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(mf.path + mf.mods_offset)) return;
            if (!Directory.Exists(mf.path + mf.disabled_mods_offset)) return;
            foreach (string file in Directory.GetFiles(mf.path + mf.mods_offset)) 
                File.Move(file, mf.path + mf.disabled_mods_offset + Path.GetFileName(file));
            mf.UpdateAll();
        }

        private void btn_enableAll_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(mf.path + mf.mods_offset)) return;
            if (!Directory.Exists(mf.path + mf.disabled_mods_offset)) return;
            foreach (string file in Directory.GetFiles(mf.path + mf.disabled_mods_offset))
                File.Move(file, mf.path + mf.mods_offset + Path.GetFileName(file));
            mf.UpdateAll();
        }

        internal void btn_openEnMods_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(mf.path + mf.mods_offset))
                    Process.Start("explorer.exe", mf.path + mf.mods_offset);
                else
                    MessageBox.Show("Папка с выключенными модами не обнаружена");
            }
            catch (Exception ex) { MessageBox.Show($"Произошла ошибка\n\n{ex}"); }
        }
    }
}
