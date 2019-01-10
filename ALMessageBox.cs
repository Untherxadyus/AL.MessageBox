using AL.Tools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AL.MessageBox
{
    public static class ALMessageBox
    {
        public static DialogResult Show(MessageBoxTypes MessageBoxType, string Message)
        {
            using (var frm = new ALMessageForm(MessageBoxType, Message))
            {
                return frm.ShowDialog();
            }
        }
    }
}
