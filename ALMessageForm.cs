using System;
using System.Drawing;
using System.Windows.Forms;

namespace AL.MessageBox
{
    internal partial class ALMessageForm : Form
    {
        private MessageBoxTypes _MessageBoxType;

        public ALMessageForm()
        {
            InitializeComponent();
        }

        public ALMessageForm(MessageBoxTypes MessageBoxType) : this()
        {
            _MessageBoxType = MessageBoxType;

            switch (_MessageBoxType)
            {
                case MessageBoxTypes.Error:
                    pnlHeader.BackColor = Color.Crimson;
                    pbIcon.Image = Properties.Resources.Error_96x96_;
                    lblTitle.Text = "Error";
                    btn2.Visible = true;
                    btn2.Text = "Ok";
                    btn2.Image = Properties.Resources.Done_32x32_;
                    break;
                case MessageBoxTypes.Information:
                    pnlHeader.BackColor = Color.RoyalBlue;
                    pbIcon.Image = Properties.Resources.Information_128x128_;
                    lblTitle.Text = "Information";
                    btn2.Visible = true;
                    btn2.Text = "Ok";
                    btn2.Image = Properties.Resources.Done_32x32_;
                    break;
                case MessageBoxTypes.Message:
                    pnlHeader.BackColor = Color.Green;
                    pbIcon.Image = Properties.Resources.Message_96x96_;
                    lblTitle.Text = "Message";
                    btn2.Visible = true;
                    btn2.Text = "OK";
                    btn2.Image = Properties.Resources.Done_32x32_;
                    break;
                case MessageBoxTypes.Question:
                    pnlHeader.BackColor = Color.DimGray;
                    pbIcon.Image = Properties.Resources.Question_128x128_;
                    lblTitle.Text = "Question";
                    btn1.Visible = true;
                    btn1.Text = "Yes";
                    btn1.Image = Properties.Resources.Done_32x32_;
                    btn2.Visible = true;
                    btn2.Text = "No";
                    btn2.Image = Properties.Resources.Error_32x32_;
                    break;
                case MessageBoxTypes.Warning:
                    pnlHeader.BackColor = Color.Gold;
                    pbIcon.Image = Properties.Resources.Warning_96x96_;
                    lblTitle.Text = "Warning";
                    btn2.Visible = true;
                    btn2.Text = "Ok";
                    btn2.Image = Properties.Resources.Done_32x32_;
                    break;
            }
        }

        public ALMessageForm(MessageBoxTypes MessageBoxType, string Message) : this(MessageBoxType)
        {
            lblMessage.Text = Message;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (sender as Button);

            switch (_MessageBoxType)
            {
                case MessageBoxTypes.Error:
                case MessageBoxTypes.Information:
                case MessageBoxTypes.Message:
                case MessageBoxTypes.Warning:
                    this.DialogResult = DialogResult.OK;
                    break;
                case MessageBoxTypes.Question:
                    switch (btn.Name)
                    {
                        case "btn1":
                            this.DialogResult = DialogResult.Yes;
                            break;
                        case "btn2":
                            this.DialogResult = DialogResult.No;
                            break;
                    }
                    break;
            }
        }
    }
}
