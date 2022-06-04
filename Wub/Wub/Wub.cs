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
        private Logger.logger logger = new Logger.logger();
        private List<Module> modules = null;
        private Popup.Ok done = new Popup.Ok("Done", Settings.done);
        private Popup.Ok ok = new Popup.Ok("About", Settings.about);

        class Module
        {
            public string key { get; set; }
            public object value { get; set; }
            public string id { get; set; }
            public Bunifu.UI.WinForms.BunifuToggleSwitch2 button { get; set; }

            public Module(string ikey, object ivalue, string iid, Bunifu.UI.WinForms.BunifuToggleSwitch2 ibutton)
            {
                key = ikey;
                value = ivalue;
                id = iid;
                button = ibutton;
            }
        }

        public Wub()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            worker.DoWork += new DoWorkEventHandler(bypass);
            modules = new List<Module>()
            {
                new Module("BypassTPMCheck", 0x00000001, "TPM bypass", button_tpm),
                new Module("BypassRAMCheck", 0x00000001, "RAM bypass", button_ram),
                new Module("BypassSecureBootCheck", 0x00000001, "Secure Boot bypass", button_secure_boot)
            };
            required = new List<string>()
            {
                "SYSTEM",
                "SYSTEM\\Setup",
                "SYSTEM\\Setup\\LabConfig"
            };
        }

        private List<Module> get_configurations()
        {
            List<Module> content = new List<Module>();

            foreach (Module module in modules)
            {
                if (module.button.Checked == true)
                {
                    content.Add(module);
                }
            }

            return (content);
        }

        private void bypass(object sender, EventArgs e)
        {
            string path = required[required.Count - 1];
            RegistryKey key = null;

            get_hardware();
            check_requirements();
            key = Registry.LocalMachine.OpenSubKey(path, true);
            inject(key);
            key.Close();
        }

        private void get_hardware()
        {
            int bits = (Environment.Is64BitOperatingSystem == true ? 64 : 32);

            log($"WUB: {Manager.Ui.version}");
            log($"MachineName: {Environment.MachineName}");
            log($"Version: {bits} bits");
            log($"OS Version: {Environment.OSVersion}");
            log($"Processor Count: {Environment.ProcessorCount}");
        }

        private void log(string message)
        {
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
            List<Module> user_configuration = get_configurations();
            string[] presents = key.GetValueNames();

            log($"injecting modules");
            foreach (Module module in user_configuration)
            {
                log($"bypassing: {module.id}");
                if (presents.Contains(module.key) == false)
                {
                    key.SetValue(module.key, module.value);
                }
                else
                {
                    if (key.GetValue(module.key) != module.value)
                    {
                        log($"updating registry value");
                        key.SetValue(module.key, module.value);
                    }
                    else
                    {
                        log($"module {module.id} present");
                    }
                }
            }

            log($"all modules injected");
            dump();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Manager.Threads.worker(worker);
            done.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            ok.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
