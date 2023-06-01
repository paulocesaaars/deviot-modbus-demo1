namespace Deviot.ModbusSimulator.App
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            gbTemperature = new GroupBox();
            txtTemperatureOut = new TextBox();
            lbTemperaturaOut = new Label();
            txtTemperatureIn = new TextBox();
            lbTemperatureIn = new Label();
            gbPressure = new GroupBox();
            txtPressureOut = new TextBox();
            lbPressureOut = new Label();
            txtPressureIn = new TextBox();
            lbPressureIn = new Label();
            btStart = new Button();
            btStop = new Button();
            gbMotor = new GroupBox();
            btOff = new Button();
            btOn = new Button();
            displayStatus = new Label();
            lblStatus = new Label();
            gbTemperature.SuspendLayout();
            gbPressure.SuspendLayout();
            gbMotor.SuspendLayout();
            SuspendLayout();
            // 
            // gbTemperature
            // 
            gbTemperature.Controls.Add(txtTemperatureOut);
            gbTemperature.Controls.Add(lbTemperaturaOut);
            gbTemperature.Controls.Add(txtTemperatureIn);
            gbTemperature.Controls.Add(lbTemperatureIn);
            gbTemperature.Location = new Point(12, 12);
            gbTemperature.Name = "gbTemperature";
            gbTemperature.Size = new Size(211, 100);
            gbTemperature.TabIndex = 0;
            gbTemperature.TabStop = false;
            gbTemperature.Text = "Temperatura";
            // 
            // txtTemperatureOut
            // 
            txtTemperatureOut.Location = new Point(69, 58);
            txtTemperatureOut.Name = "txtTemperatureOut";
            txtTemperatureOut.ReadOnly = true;
            txtTemperatureOut.Size = new Size(100, 23);
            txtTemperatureOut.TabIndex = 3;
            // 
            // lbTemperaturaOut
            // 
            lbTemperaturaOut.AutoSize = true;
            lbTemperaturaOut.Location = new Point(27, 62);
            lbTemperaturaOut.Name = "lbTemperaturaOut";
            lbTemperaturaOut.Size = new Size(38, 15);
            lbTemperaturaOut.TabIndex = 2;
            lbTemperaturaOut.Text = "Saída:";
            // 
            // txtTemperatureIn
            // 
            txtTemperatureIn.Location = new Point(69, 28);
            txtTemperatureIn.Name = "txtTemperatureIn";
            txtTemperatureIn.ReadOnly = true;
            txtTemperatureIn.Size = new Size(100, 23);
            txtTemperatureIn.TabIndex = 1;
            // 
            // lbTemperatureIn
            // 
            lbTemperatureIn.AutoSize = true;
            lbTemperatureIn.Location = new Point(15, 32);
            lbTemperatureIn.Name = "lbTemperatureIn";
            lbTemperatureIn.Size = new Size(50, 15);
            lbTemperatureIn.TabIndex = 0;
            lbTemperatureIn.Text = "Entrada:";
            // 
            // gbPressure
            // 
            gbPressure.Controls.Add(txtPressureOut);
            gbPressure.Controls.Add(lbPressureOut);
            gbPressure.Controls.Add(txtPressureIn);
            gbPressure.Controls.Add(lbPressureIn);
            gbPressure.Location = new Point(12, 127);
            gbPressure.Name = "gbPressure";
            gbPressure.Size = new Size(211, 100);
            gbPressure.TabIndex = 4;
            gbPressure.TabStop = false;
            gbPressure.Text = "Pressão";
            // 
            // txtPressureOut
            // 
            txtPressureOut.Location = new Point(69, 58);
            txtPressureOut.Name = "txtPressureOut";
            txtPressureOut.ReadOnly = true;
            txtPressureOut.Size = new Size(100, 23);
            txtPressureOut.TabIndex = 3;
            // 
            // lbPressureOut
            // 
            lbPressureOut.AutoSize = true;
            lbPressureOut.Location = new Point(27, 62);
            lbPressureOut.Name = "lbPressureOut";
            lbPressureOut.Size = new Size(38, 15);
            lbPressureOut.TabIndex = 2;
            lbPressureOut.Text = "Saída:";
            // 
            // txtPressureIn
            // 
            txtPressureIn.Location = new Point(69, 28);
            txtPressureIn.Name = "txtPressureIn";
            txtPressureIn.ReadOnly = true;
            txtPressureIn.Size = new Size(100, 23);
            txtPressureIn.TabIndex = 1;
            // 
            // lbPressureIn
            // 
            lbPressureIn.AutoSize = true;
            lbPressureIn.Location = new Point(15, 32);
            lbPressureIn.Name = "lbPressureIn";
            lbPressureIn.Size = new Size(50, 15);
            lbPressureIn.TabIndex = 0;
            lbPressureIn.Text = "Entrada:";
            // 
            // btStart
            // 
            btStart.Location = new Point(13, 389);
            btStart.Name = "btStart";
            btStart.Size = new Size(210, 23);
            btStart.TabIndex = 5;
            btStart.Text = "Iniciar Simulação";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(12, 388);
            btStop.Name = "btStop";
            btStop.Size = new Size(210, 23);
            btStop.TabIndex = 6;
            btStop.Text = "Parar Simulação";
            btStop.UseVisualStyleBackColor = true;
            btStop.Visible = false;
            btStop.Click += btStop_Click;
            // 
            // gbMotor
            // 
            gbMotor.Controls.Add(btOff);
            gbMotor.Controls.Add(btOn);
            gbMotor.Controls.Add(displayStatus);
            gbMotor.Controls.Add(lblStatus);
            gbMotor.Location = new Point(12, 242);
            gbMotor.Name = "gbMotor";
            gbMotor.Size = new Size(211, 135);
            gbMotor.TabIndex = 7;
            gbMotor.TabStop = false;
            gbMotor.Text = "Bomba da Água";
            // 
            // btOff
            // 
            btOff.Enabled = false;
            btOff.Location = new Point(15, 94);
            btOff.Name = "btOff";
            btOff.Size = new Size(180, 23);
            btOff.TabIndex = 3;
            btOff.Text = "Desligar";
            btOff.UseVisualStyleBackColor = true;
            btOff.Click += btOff_Click;
            // 
            // btOn
            // 
            btOn.Enabled = false;
            btOn.Location = new Point(15, 65);
            btOn.Name = "btOn";
            btOn.Size = new Size(180, 23);
            btOn.TabIndex = 2;
            btOn.Text = "Ligar";
            btOn.UseVisualStyleBackColor = true;
            btOn.Click += btOn_Click;
            // 
            // displayStatus
            // 
            displayStatus.AutoSize = true;
            displayStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            displayStatus.Location = new Point(71, 33);
            displayStatus.Name = "displayStatus";
            displayStatus.Size = new Size(69, 17);
            displayStatus.TabIndex = 1;
            displayStatus.Text = "Desligada";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(234, 421);
            Controls.Add(gbMotor);
            Controls.Add(btStart);
            Controls.Add(btStop);
            Controls.Add(gbPressure);
            Controls.Add(gbTemperature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(250, 460);
            MinimumSize = new Size(250, 460);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            gbTemperature.ResumeLayout(false);
            gbTemperature.PerformLayout();
            gbPressure.ResumeLayout(false);
            gbPressure.PerformLayout();
            gbMotor.ResumeLayout(false);
            gbMotor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTemperature;
        private TextBox txtTemperatureOut;
        private Label lbTemperaturaOut;
        private TextBox txtTemperatureIn;
        private Label lbTemperatureIn;
        private GroupBox gbPressure;
        private TextBox txtPressureOut;
        private Label lbPressureOut;
        private TextBox txtPressureIn;
        private Label lbPressureIn;
        private Button btStart;
        private Button btStop;
        private GroupBox gbMotor;
        private Label displayStatus;
        private Label lblStatus;
        private Button btOff;
        private Button btOn;
    }
}