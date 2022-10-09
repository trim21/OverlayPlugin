using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RainbowMage.OverlayPlugin.Updater
{
    public partial class CefMissingTab : UserControl
    {
        private string _cefPath;
        private object _pluginLoader;
        private TinyIoCContainer _container;

        public CefMissingTab(string cefPath, object pluginLoader, TinyIoCContainer container)
        {
            InitializeComponent();

            _container = container;
            _cefPath = cefPath;
            _pluginLoader = pluginLoader;
            lnkManual.Text = CefInstaller.GetUrl();

            container.Resolve<ILogger>().RegisterListener((entry) =>
            {
                logBox.AppendText($"[{entry.Time}] {entry.Level}: {entry.Message}" + Environment.NewLine);
            });
        }

        private async void btnOpenManual_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CEF bundle|*.7z";
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            if (await CefInstaller.InstallCef(_cefPath, dialog.FileName))
            {
                Parent.Controls.Remove(this);
                _pluginLoader.GetType().GetMethod("FinishInit").Invoke(_pluginLoader, new object[] { _container });
            }
        }

        private async void btnStartAuto_Click(object sender, EventArgs e)
        {
            if (await CefInstaller.EnsureCef(_cefPath))
            {
                Parent.Controls.Remove(this);
                _pluginLoader.GetType().GetMethod("FinishInit").Invoke(_pluginLoader, new object[] { _container });
            }
        }

        private void lnkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkManual.Text);
        }
    }
}
