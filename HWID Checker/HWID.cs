using System;
using System.Windows.Forms;

namespace HWID_Checker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string HWID;

        private void Main_Load(object sender, EventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value; //Changing the variable "HWID" (string) to the WindowsIdentity Value, you can use any other forms of HWID, you can even use MAC/IP (Not recommended)
            hwid_text.Text = HWID;
            hwid_text.ReadOnly = true;
        }

        private void copy_hwid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID);
            copy_hwid.Enabled = false;
            copy_hwid.Text = "Copied";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
