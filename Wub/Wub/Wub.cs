using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wub
{
    public partial class Wub : Form
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private List<string> required = null;
        private Dictionary<string, object> injections = null;
        private Dictionary<string, object> configuration = null;
        private Popup.Ok done = new Popup.Ok(Settings.done);
        private Logger.logger logger = new Logger.logger();

        public Wub()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            worker.DoWork += new DoWorkEventHandler(bypass);
            label_version.Text = Manager.Ui.version;
            required = new List<string>()
            {
                "SYSTEM",
                "SYSTEM\\Setup",
                "SYSTEM\\Setup\\LabConfig"
            };
            injections = new Dictionary<string, object>()
            {
                { "BypassTPMCheck", 1 },
                { "BypassSecureBootCheck", 1 },
                { "BypassRAMCheck", 1 }
            };
            configuration = new Dictionary<string, object>()
            {
                { "BypassTPMCheck", bypass_tmp.Checked },
                { "BypassRAMCheck", bypass_ram.Checked },
                { "BypassSecureBootCheck", bypass_sb.Checked }
            };
        }

        private void update_configuration()
        {
            configuration["BypassTPMCheck"] = bypass_tmp.Checked;
            configuration["BypassRAMCheck"] = bypass_ram.Checked;
            configuration["BypassSecureBootCheck"] = bypass_sb.Checked;
        }

        private void bypass(object sender, EventArgs e)
        {
            string path = required[required.Count - 1];
            RegistryKey key = null;

            get_hardware();
            update_configuration();
            check_requirements();
            key = Registry.LocalMachine.OpenSubKey(path, true);
            inject(key);
            key.Close();
        }

        private void get_hardware()
        {
            int bits = (Environment.Is64BitOperatingSystem == true ? 64 : 32);

            log($"MachineName: {Environment.MachineName}");
            log($"Version: {bits} bits");
            log($"OS Version: {Environment.OSVersion}");
            log($"Processor Count: {Environment.ProcessorCount}");
        }

        private void log(string message)
        {
            Manager.Threads.set_textbox(status, message);
            logger.add($"[{DateTime.Now}] {message}");
        }

        private void dump()
        {
            logger.dump();
        }

        private void check_requirements()
        {
            log("checking requirements");
            foreach (string requirement in required)
            {
                log($"checking {requirement}");
                if (Registry.LocalMachine.OpenSubKey(requirement) == null)
                {
                    log($"creating {requirement}");
                    Registry.LocalMachine.CreateSubKey(requirement);
                    log($"{requirement} created");
                }
            }
        }

        private void inject(RegistryKey key)
        {
            string[] presents = key.GetValueNames();

            log($"injecting bypasses");
            foreach (KeyValuePair<string, object> injection in injections)
            {
                if ((bool)configuration[injection.Key] == true)
                {
                    log($"bypassing: {injection.Key}");
                    if (presents.Contains(injection.Key) == false)
                    {
                        key.SetValue(injection.Key, injection.Value);
                    }
                    else
                    {
                        if (key.GetValue(injection.Key) != injection.Value)
                        {
                            if (Manager.Threads.get_switch_button(button_update) == true)
                            {
                                log($"updating registry value");
                                key.SetValue(injection.Key, injection.Value);
                            }
                        }
                        else
                        {
                            log($"bypass {injection.Key} present");
                        }
                    }
                }
            }

            log($"bypass injected");
            dump();
        }

        private void update_button(bool status)
        {
            button_bypass.Enabled = status;
            button_exit.Enabled = status;
            button_about.Enabled = status;
            bypass_ram.Enabled = status;
            bypass_tmp.Enabled = status;
            bypass_sb.Enabled = status;
            button_bypass.Enabled = status;
        }

        private void button_bypass_Click(object sender, EventArgs e)
        {
            update_button(false);
            Manager.Threads.worker(worker);
            done.ShowDialog();
            update_button(true);
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            Popup.Ok ok = new Popup.Ok(Settings.about);
            ok.ShowDialog();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
