using System.Windows.Forms;

namespace XForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.grpSerialConfig = new System.Windows.Forms.GroupBox();
            this.lblPortName = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.lblSendInterval = new System.Windows.Forms.Label();
            this.nudSendInterval = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSerialConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 12);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(400, 200);
            this.txtReceive.TabIndex = 0;
            this.txtReceive.Text = "数据接收区";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 220);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(400, 180);
            this.txtSend.TabIndex = 1;
            // 
            // grpSerialConfig
            // 
            this.grpSerialConfig.Controls.Add(this.lblPortName);
            this.grpSerialConfig.Controls.Add(this.cmbPortName);
            this.grpSerialConfig.Controls.Add(this.lblBaudRate);
            this.grpSerialConfig.Controls.Add(this.cmbBaudRate);
            this.grpSerialConfig.Controls.Add(this.lblDataBits);
            this.grpSerialConfig.Controls.Add(this.cmbDataBits);
            this.grpSerialConfig.Controls.Add(this.lblStopBits);
            this.grpSerialConfig.Controls.Add(this.cmbStopBits);
            this.grpSerialConfig.Controls.Add(this.lblParity);
            this.grpSerialConfig.Controls.Add(this.cmbParity);
            this.grpSerialConfig.Location = new System.Drawing.Point(420, 12);
            this.grpSerialConfig.Name = "grpSerialConfig";
            this.grpSerialConfig.Size = new System.Drawing.Size(203, 200);
            this.grpSerialConfig.TabIndex = 2;
            this.grpSerialConfig.TabStop = false;
            this.grpSerialConfig.Text = "串口配置";
            // 
            // lblPortName
            // 
            this.lblPortName.Location = new System.Drawing.Point(10, 20);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(54, 23);
            this.lblPortName.TabIndex = 0;
            this.lblPortName.Text = "端口号：";
            // 
            // cmbPortName
            // 
            this.cmbPortName.Location = new System.Drawing.Point(70, 18);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Location = new System.Drawing.Point(10, 50);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(54, 23);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "波特率：";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Location = new System.Drawing.Point(70, 48);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // lblDataBits
            // 
            this.lblDataBits.Location = new System.Drawing.Point(10, 80);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(54, 23);
            this.lblDataBits.TabIndex = 4;
            this.lblDataBits.Text = "数据位：";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Location = new System.Drawing.Point(70, 78);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cmbDataBits.TabIndex = 5;
            // 
            // lblStopBits
            // 
            this.lblStopBits.Location = new System.Drawing.Point(10, 110);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(54, 23);
            this.lblStopBits.TabIndex = 6;
            this.lblStopBits.Text = "停止位：";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Location = new System.Drawing.Point(70, 108);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cmbStopBits.TabIndex = 7;
            // 
            // lblParity
            // 
            this.lblParity.Location = new System.Drawing.Point(10, 138);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(54, 25);
            this.lblParity.TabIndex = 8;
            this.lblParity.Text = "校验位：";
            // 
            // cmbParity
            // 
            this.cmbParity.Location = new System.Drawing.Point(70, 138);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 20);
            this.cmbParity.TabIndex = 9;
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Location = new System.Drawing.Point(420, 220);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(79, 30);
            this.btnOpenClose.TabIndex = 3;
            this.btnOpenClose.Text = "打开串口";
            // 
            // chkDTR
            // 
            this.chkDTR.Location = new System.Drawing.Point(424, 260);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(75, 24);
            this.chkDTR.TabIndex = 4;
            this.chkDTR.Text = "DTR";
            // 
            // chkRTS
            // 
            this.chkRTS.Location = new System.Drawing.Point(505, 260);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(75, 24);
            this.chkRTS.TabIndex = 5;
            this.chkRTS.Text = "RTS";
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.Location = new System.Drawing.Point(420, 290);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(104, 24);
            this.chkAutoSend.TabIndex = 6;
            this.chkAutoSend.Text = "自动发送";
            // 
            // lblSendInterval
            // 
            this.lblSendInterval.Location = new System.Drawing.Point(422, 328);
            this.lblSendInterval.Name = "lblSendInterval";
            this.lblSendInterval.Size = new System.Drawing.Size(77, 25);
            this.lblSendInterval.TabIndex = 7;
            this.lblSendInterval.Text = "间隔(ms)：";
            // 
            // nudSendInterval
            // 
            this.nudSendInterval.Location = new System.Drawing.Point(518, 326);
            this.nudSendInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSendInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSendInterval.Name = "nudSendInterval";
            this.nudSendInterval.Size = new System.Drawing.Size(105, 21);
            this.nudSendInterval.TabIndex = 8;
            this.nudSendInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(424, 370);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(532, 370);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 30);
            this.btnClearSend.TabIndex = 10;
            this.btnClearSend.Text = "清除发送";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "关闭串口";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.grpSerialConfig);
            this.Controls.Add(this.btnOpenClose);
            this.Controls.Add(this.chkDTR);
            this.Controls.Add(this.chkRTS);
            this.Controls.Add(this.chkAutoSend);
            this.Controls.Add(this.lblSendInterval);
            this.Controls.Add(this.nudSendInterval);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClearSend);
            this.Name = "Form1";
            this.Text = "串口通讯";
            this.grpSerialConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSendInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtReceive;
        private TextBox txtSend;
        private GroupBox grpSerialConfig;
        private Label lblPortName;
        private ComboBox cmbPortName;
        private Label lblBaudRate;
        private ComboBox cmbBaudRate;
        private Label lblDataBits;
        private ComboBox cmbDataBits;
        private Label lblStopBits;
        private ComboBox cmbStopBits;
        private Label lblParity;
        private ComboBox cmbParity;
        private Button btnOpenClose;
        private CheckBox chkDTR;
        private CheckBox chkRTS;
        private CheckBox chkAutoSend;
        private Label lblSendInterval;
        private NumericUpDown nudSendInterval;
        private Button btnSend;
        private Button btnClearSend;
        private Button button1;
    }
}

