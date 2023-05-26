using FluentModbus;
using Microsoft.Win32;
using System;

namespace Deviot.ModbusSimulator.App
{
    public partial class frmMain : Form
    {
        private ModbusTcpServer _modbusTcpServer;
        private CancellationTokenSource _cancellationTokenSource;
        
        private const string GENERIC_TITLE_ERROR = "Erro não esperado";

        public frmMain()
        {
            _modbusTcpServer = new ModbusTcpServer();
            InitializeComponent();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(GENERIC_TITLE_ERROR, message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearValues()
        {
            txtTemperatureIn.Invoke((MethodInvoker)(() => txtTemperatureIn.Clear()));
            txtTemperatureOut.Invoke((MethodInvoker)(() => txtTemperatureOut.Clear()));
            txtPressureIn.Invoke((MethodInvoker)(() => txtPressureIn.Clear()));
            txtPressureOut.Invoke((MethodInvoker)(() => txtPressureOut.Clear()));
        }

        private int RandomNumber(int currentNumber, int min, int max)
        {
            var random = new Random();
            var randomNumber = random.Next(-1, 1);
            var newNumber = currentNumber + randomNumber;

            if (newNumber > max)
                newNumber = currentNumber - 1;

            if (newNumber < min)
                newNumber = currentNumber + 1;

            return newNumber;
        }

        private void UpdateValues()
        {
            var temperarturaIn = default(int);
            var temperarturaOut = default(int);
            var pressureIn = default(int);
            var pressureOut = default(int);
            var registers = _modbusTcpServer.GetHoldingRegisters();

            txtTemperatureIn.Invoke((MethodInvoker)(() => temperarturaIn = int.Parse(txtTemperatureIn.Text)));
            temperarturaIn = RandomNumber(temperarturaIn, 150, 250);

            txtTemperatureIn.Invoke((MethodInvoker)(() => txtTemperatureIn.Text = temperarturaIn.ToString()));
            registers.SetMidLittleEndian(0, temperarturaIn);

            txtTemperatureOut.Invoke((MethodInvoker)(() => temperarturaOut = int.Parse(txtTemperatureOut.Text)));
            temperarturaOut = RandomNumber(temperarturaOut, 350, 450);

            txtTemperatureOut.Invoke((MethodInvoker)(() => txtTemperatureOut.Text = temperarturaOut.ToString()));
            registers.SetMidLittleEndian(1, temperarturaOut);

            txtPressureIn.Invoke((MethodInvoker)(() => pressureIn = int.Parse(txtPressureIn.Text)));
            pressureIn = RandomNumber(pressureIn, 200, 300);

            txtPressureIn.Invoke((MethodInvoker)(() => txtPressureIn.Text = pressureIn.ToString()));
            registers.SetMidLittleEndian(2, pressureIn);

            txtPressureOut.Invoke((MethodInvoker)(() => pressureOut = int.Parse(txtPressureOut.Text)));
            pressureOut = RandomNumber(pressureOut, 300, 400);

            txtPressureOut.Invoke((MethodInvoker)(() => txtPressureOut.Text = pressureOut.ToString()));
            registers.SetMidLittleEndian(3, pressureOut);

            _modbusTcpServer.Update();
        }

        private void ExecutionAsync()
        {
            try
            {
                _modbusTcpServer = new ModbusTcpServer();
                _modbusTcpServer.Start();

                while (!_cancellationTokenSource.IsCancellationRequested)
                {
                    UpdateValues();
                    Task.Delay(10000, _cancellationTokenSource.Token).Wait();
                }

                _modbusTcpServer.Stop();
                ClearValues();
            }
            catch (Exception)
            {
                _modbusTcpServer.Stop();
            }     
            finally
            {
                _modbusTcpServer.Dispose();
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                btStart.Visible = false;
                btStop.Visible = true;

                txtTemperatureIn.Text = "200";
                txtTemperatureOut.Text = "400";
                txtPressureIn.Text = "250";
                txtPressureOut.Text = "350";

                _cancellationTokenSource = new CancellationTokenSource();
                Task.Run(ExecutionAsync);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            try
            {
                btStart.Visible = true;
                btStop.Visible = false;

                _cancellationTokenSource.Cancel();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
    }
}