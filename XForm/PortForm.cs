using System.IO.Ports;
using System.Windows.Forms;
using XPorter.Domain;
using XPorter.Infrastructure.Components;
using XPorter.Infrastructure.Models;
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
            try
            {
                var Parityint = int.Parse(cmbParity.SelectedValue.ToString());
                var StopBitsint = int.Parse(cmbStopBits.SelectedValue.ToString());
                var config = new XPortConfig
                {
                    DataBits = int.Parse(cmbDataBits.SelectedValue.ToString()),
                    Parity = (Parityint) == 0? Parity.None : Parity.Even,
                    StopBits = (StopBitsint) == 0? StopBits.One : StopBits.Two,
                    PortName = cmbPortName.SelectedValue.ToString(),
                    BaudRate = int.Parse(cmbBaudRate.SelectedValue.ToString()),
                };
                if (PortFormEvent.CreateXPort(config) && PortFormEvent.OpenPort(config.PortName))
                {
                    statusStrip1.Items[1].Text = $"{config.PortName}:已开启";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            XSerialPortFactory.CloseAllPort();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                PortFormEvent.ClosePort(cmbPortName.SelectedValue.ToString());
                statusStrip1.Items[1].Text = $"{cmbPortName.SelectedValue.ToString()}:已关闭";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
