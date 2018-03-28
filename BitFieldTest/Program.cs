using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFieldTest
{
    class Program
    {
        enum DialogProperties {
            NONE = 0,
            OK_Button = 1 << 1,
            Ja_Button = 1 << 2,
            Nein_Button = 1 << 3,
            Cancel_Button = 1 << 4
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.TestAufruf(DialogProperties.Ja_Button);
        }

        public void TestAufruf(DialogProperties flags)
        {
            if ((flags & DialogProperties.Ja_Button) == DialogProperties.Ja_Button)
            {
                Console.WriteLine("JA true, ");
            }
            if ((flags & DialogProperties.Nein_Button) == DialogProperties.Nein_Button)
            {

            }
            if ((flags & DialogProperties.Cancel_Button) == DialogProperties.Cancel_Button)
            {

            }
            if ((flags & DialogProperties.OK_Button) == DialogProperties.OK_Button)
            {

            }
        }
    }

}
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace speed4cell.Views
//{
//    public partial class QuestionDialog : BaseDialog
//    {
//        public QuestionDialog(string messege, string title, DialogProperties flags)
//        {
//            InitializeComponent();
//            labelqustion.Text = messege;
//            lblDialogName.Text = title;
//            ButtonVisibilty(flags);
//        }

//        private void btnOK_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = System.Windows.Forms.DialogResult.OK;
//            Close();
//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void btnNo_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = System.Windows.Forms.DialogResult.No;
//            Close();
//        }

//        public enum DialogProperties
//        {
//            NONE = 0,
//            OK_Button = 1,
//            yes_NO_Button = 2,
//            Yes_No_Cancel_Button = 3,
//            Cancel_Button = 4
//        }

//        public void ButtonVisibilty(DialogProperties flags)
//        {
//            if (flags == DialogProperties.yes_NO_Button)
//            {
//                btnCancel.Visible = false;
//                btnOK.Visible = true;
//                btnNo.Visible = true;
//            }
//            else if (flags == DialogProperties.Yes_No_Cancel_Button)
//            {
//                btnCancel.Visible = true;
//                btnOK.Visible = true;
//                btnNo.Visible = true;
//            }
C# Fundamentals: Combining Enum Values with Bit-Flags
//            else if (flags == DialogProperties.NONE)
//            {
//                btnCancel.Visible = false;
//                btnOK.Visible = false;
//                btnNo.Visible = false;
//            }
//        }
//    }
//}
