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
        public Ok(string message)
        {
            InitializeComponent();
            Initialize(message);
        }

        private void Initialize(string message)
        {
            Region = Region.FromHrgn(Manager.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label_content.Text = message;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
