using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wub.Manager
{
    public class Threads
    {
        public static void worker(BackgroundWorker data)
        {
            data.RunWorkerAsync();

            while (data.IsBusy == true)
            {
                Application.DoEvents();
            }
        }

        public static void label(Control controller, string data)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Text = data;
            }));
        }

        public static string get_label(Control controller)
        {
            string value = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                value = controller.Text;
            }));

            return (value);
        }

        public static void set_richtextbox(RichTextBox controller, string value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.AppendText(value);
            }));
        }

        public static void listview(ListView controller, ImageList images, List<string> items)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] != string.Empty)
                            controller.Items.Add(items[i], i);
                    }
                }
                else
                {
                    controller.Items.Clear();
                }
                controller.LargeImageList = images;
                controller.Enabled = true;
            }));
        }

        public static void combobox(ComboBox controller, List<string> items)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] != string.Empty)
                            controller.Items.Add(items[i]);
                    }
                }
                else
                {
                    controller.Items.Clear();
                }
                controller.Enabled = true;
            }));
        }

        public static object get_combobox(ComboBox controller)
        {
            object result = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                result = controller.SelectedItem;
            }));

            return (result);
        }

        public static void check(CheckBox controller, bool checked_value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Checked = checked_value;
            }));
        }

        public static decimal get_numeric(NumericUpDown controller)
        {
            decimal value = 0;

            controller.Invoke(new MethodInvoker(delegate
            {
                value = controller.Value;
            }));

            return (value);
        }

        public static void set_numeric(NumericUpDown controller, decimal value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Value = value;
            }));
        }

        public static bool switch_button(Bunifu.UI.WinForms.BunifuToggleSwitch controller)
        {
            bool checked_status = false;

            controller.Invoke(new MethodInvoker(delegate
            {
                checked_status = controller.Checked;
            }));

            return (checked_status);
        }

        public static bool get_switch_button(Bunifu.UI.WinForms.BunifuToggleSwitch controller)
        {
            bool checked_status = false;

            controller.Invoke(new MethodInvoker(delegate
            {
                checked_status = controller.Checked;
            }));

            return (checked_status);
        }

        public static void enabler_switch_button(Bunifu.UI.WinForms.BunifuToggleSwitch controller, bool status)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = status;
            }));
        }

        public static void set_switch_button(Bunifu.UI.WinForms.BunifuToggleSwitch controller, bool status)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Checked = status;
            }));
        }

        public static void button(Bunifu.UI.WinForms.BunifuButton.BunifuButton controller, bool enabled)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = enabled;
            }));
        }

        public static Form get_form(Form controller)
        {
            Form result = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                result = controller;
            }));

            return (result);
        }

        public static RichTextBox get_richtext(RichTextBox controller)
        {
            RichTextBox box = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                box = controller;
            }));

            return (box);
        }

        public static void add_richtext(RichTextBox controller, string line)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.AppendText($"{line}\n");
            }));
        }

        public static void set_textbox(Bunifu.UI.WinForms.BunifuTextBox controller, string value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Text = value;
            }));
        }

        public static void add_listview(ListView controller, string offset, string value)
        {
            string[] arr = { offset, value };

            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Items.Add(new ListViewItem(arr));
            }));
        }

        public static void lock_listview(ListView controller, bool value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                if (controller.Enabled != value)
                    controller.Enabled = value;
            }));
        }

        public static CheckedListBox get_checkedlistbox(CheckedListBox controller)
        {
            CheckedListBox box = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                box = controller;
            }));

            return (box);
        }

        public static void set_checkedlistbox(CheckedListBox controller, bool value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = value;
            }));
        }

        public static void add_checkedlistbox(CheckedListBox controller, string data)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Items.Add(data);
            }));
        }
    }
}
