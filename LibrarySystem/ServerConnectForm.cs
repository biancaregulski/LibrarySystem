using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace LibrarySystem {
    public partial class ServerConnectForm : Form {
        public MainForm ParentForm { get; set; }
        public ServerConnectForm() {
            InitializeComponent();
        }


        private void buttonOk_Click(object sender, EventArgs e) {
            foreach (Control c in this.Controls) {
                if (c.GetType().Name.ToString() == "MaskedTextBox") {
                    if (string.IsNullOrWhiteSpace(c.Text)) {
                        labelNotification.Text = "All fields must be filled in.";
                        return;
                    }
                }
            }
            IPAddress address;
            if (!IPAddress.TryParse(textBoxAddress.Text, out address)) {
                labelNotification.Text = "Invalid IP address.";
                return;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e) {
            if (textBoxAddress.Text.Equals("127.0.0.1")) {
                textBoxAddress.Text = "";
                textBoxAddress.ForeColor = Color.Black;
            }
        }
        private void textBoxAddress_Leave(object sender, EventArgs e) {
            // set text hint when address text box not in focus
            if (textBoxAddress.Text.Equals("")) {
                textBoxAddress.Text = "127.0.0.1";
                textBoxAddress.ForeColor = Color.Gray;
            }
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBox2.Select(0, 0);
            });
        }
    }
}
