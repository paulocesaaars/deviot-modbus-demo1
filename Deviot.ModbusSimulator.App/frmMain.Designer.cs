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
            gbTemperature.SuspendLayout();
            gbPressure.SuspendLayout();
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
            btStart.Location = new Point(13, 240);
            btStart.Name = "btStart";
            btStart.Size = new Size(210, 23);
            btStart.TabIndex = 5;
            btStart.Text = "Iniciar";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(13, 240);
            btStop.Name = "btStop";
            btStop.Size = new Size(210, 23);
            btStop.TabIndex = 6;
            btStop.Text = "Parar";
            btStop.UseVisualStyleBackColor = true;
            btStop.Visible = false;
            btStop.Click += btStop_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(234, 281);
            Controls.Add(btStart);
            Controls.Add(btStop);
            Controls.Add(gbPressure);
            Controls.Add(gbTemperature);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(250, 320);
            MinimumSize = new Size(250, 320);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador";
            gbTemperature.ResumeLayout(false);
            gbTemperature.PerformLayout();
            gbPressure.ResumeLayout(false);
            gbPressure.PerformLayout();
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
    }
}