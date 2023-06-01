using FluentModbus;

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
            displayStatus.Invoke((MethodInvoker)(() => { displayStatus.Text = "Desligada"; displayStatus.ForeColor = Color.Black; }));
            btOn.Invoke((MethodInvoker)(() => { btOn.Enabled = false; }));
            btOff.Invoke((MethodInvoker)(() => { btOff.Enabled = false; }));
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
            var holdingRegisters = _modbusTcpServer.GetHoldingRegisters();
            var statusPump = holdingRegisters.GetLittleEndian<int>(4);

            txtTemperatureIn.Invoke((MethodInvoker)(() => temperarturaIn = int.Parse(txtTemperatureIn.Text)));
            temperarturaIn = RandomNumber(temperarturaIn, 150, 250);

            txtTemperatureIn.Invoke((MethodInvoker)(() => txtTemperatureIn.Text = temperarturaIn.ToString()));
            holdingRegisters.SetMidLittleEndian(0, temperarturaIn);

            txtTemperatureOut.Invoke((MethodInvoker)(() => temperarturaOut = int.Parse(txtTemperatureOut.Text)));
            temperarturaOut = RandomNumber(temperarturaOut, 350, 450);

            txtTemperatureOut.Invoke((MethodInvoker)(() => txtTemperatureOut.Text = temperarturaOut.ToString()));
            holdingRegisters.SetMidLittleEndian(1, temperarturaOut);

            txtPressureIn.Invoke((MethodInvoker)(() => pressureIn = int.Parse(txtPressureIn.Text)));
            pressureIn = RandomNumber(pressureIn, 200, 300);

            txtPressureIn.Invoke((MethodInvoker)(() => txtPressureIn.Text = pressureIn.ToString()));
            holdingRegisters.SetMidLittleEndian(2, pressureIn);

            txtPressureOut.Invoke((MethodInvoker)(() => pressureOut = int.Parse(txtPressureOut.Text)));
            pressureOut = RandomNumber(pressureOut, 300, 400);

            txtPressureOut.Invoke((MethodInvoker)(() => txtPressureOut.Text = pressureOut.ToString()));
            holdingRegisters.SetMidLittleEndian(3, pressureOut);

            holdingRegisters.SetMidLittleEndian(4, statusPump);

            var coils = _modbusTcpServer.GetCoils();
            var commandOn = coils.Get(0);
            var commandOff = coils.Get(1);

            if (commandOn)
            {
                coils.Set(0, false);
                holdingRegisters.SetMidLittleEndian(4, 2);
                displayStatus.Invoke((MethodInvoker)(() => { displayStatus.Text = "Ligada"; }));
                btOff.Invoke((MethodInvoker)(() => { btOff.Enabled = true; }));
            }

            if (commandOff)
            {
                coils.Set(1, false);
                holdingRegisters.SetMidLittleEndian(4, 0);
                displayStatus.Invoke((MethodInvoker)(() => { displayStatus.Text = "Desligada"; }));
                btOn.Invoke((MethodInvoker)(() => { btOn.Enabled = true; }));
            }

            _modbusTcpServer.Update();
        }

        private async Task ExecutionAsync()
        {
            try
            {
                _modbusTcpServer = new ModbusTcpServer();
                _modbusTcpServer.Start();

                while (!_cancellationTokenSource.IsCancellationRequested)
                {
                    UpdateValues();
                    await Task.WhenAny(Task.Delay(10000, _cancellationTokenSource.Token));
                }

                _modbusTcpServer.Stop();
                ClearValues();
            }
            catch (Exception)
            {
                _modbusTcpServer.Stop();
                ClearValues();
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

                btOn.Enabled = true;
                btOff.Enabled = false;

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

                btOn.Enabled = false;
                btOff.Enabled = false;

                _cancellationTokenSource.Cancel();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            btOn.Enabled = false;
            displayStatus.Text = "Ligando";
            displayStatus.ForeColor = Color.Green;

            var coils = _modbusTcpServer.GetCoils();
            var holdingRegisters = _modbusTcpServer.GetHoldingRegisters();

            coils.Set(0, true);
            holdingRegisters.SetMidLittleEndian(4, 1);
            _modbusTcpServer.Update();
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            btOff.Enabled = false;
            displayStatus.Text = "Desligando";
            displayStatus.ForeColor = Color.Black;

            var coils = _modbusTcpServer.GetCoils();
            var holdingRegisters = _modbusTcpServer.GetHoldingRegisters();
            coils.Set(1, true);
            holdingRegisters.SetMidLittleEndian(4, 3);
            _modbusTcpServer.Update();
        }
    }
}