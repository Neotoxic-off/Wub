using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wub.Popup
{
    public partial class Ok : Form
    {
        public Ok(string title, string message)
        {
            InitializeComponent();
            Initialize(title, message);
        }

        private void Initialize(string title, string message)
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label_title.Text = title;
            label_content.Text = message;
        }

        private void button_ok_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
