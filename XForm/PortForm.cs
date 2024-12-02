using System.Windows.Forms;
using XPorter.Domain;
using XPorter.Infrastructure.Services;

namespace XForm
{
    public partial class PortForm : Form
    {

        public PortForm()
        {
            InitializeComponent();
            InitializeFormParams();
        }
        private void cmbPortName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var obj = ((ComboBox)sender).SelectedValue.ToString();
            var status = XSerialPortFactory.CheckSerialStatus(obj) ? "已开启" : "未开启";
            statusStrip1.Items[1].Text = $"{obj}:{status}";
        }

        private void btnOpenClose_Click(object sender, System.EventArgs e)
        {
            if(XSerialPortFactory.)
        }
    }
}
