using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WaveGenerator.Modulator;

namespace WaveGenerator
{
    public partial class WaveGenerator : Form
    {
        public List<KeyValuePair<WaveType, KeyValuePair<int, double>>> Signals = new List<KeyValuePair<WaveType, KeyValuePair<int, double>>>();

        public WaveGenerator()
        {
            InitializeComponent();
        }

        private void generateWave_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\test.wav";
            int amplitude = AmplitudeTrackBar.Value;
            double frequency = FrequencyTrackBar.Value;
            double duty = (double)DutyFactor.Value / 100;
            WaveType waveType = (WaveType)short.Parse(WaveTypeBox.SelectedValue.ToString());
            Generator wave = new Generator(waveType, amplitude, frequency, duty);
            wave.Save(filePath);

            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }

        private void WaveGenerator_Load(object sender, EventArgs e)
        {
            label4.Text = AmplitudeTrackBar.Value.ToString(CultureInfo.InvariantCulture);
            label5.Text = FrequencyTrackBar.Value.ToString(CultureInfo.InvariantCulture) + " Hz";
            label9.Text = AmplitudePoly.Value.ToString(CultureInfo.InvariantCulture);
            label10.Text = FrequencyPoly.Value.ToString(CultureInfo.InvariantCulture) + " Hz";
            label12.Text = DutyFactor.Value.ToString(CultureInfo.InvariantCulture) + "%";
            label12.Hide();
            DutyFactor.Hide();
            label11.Hide();

            List<KeyValuePair<string, string>> WaveTypeList = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> WaveTypeList2 = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> ModTypeList = new List<KeyValuePair<string, string>>();
            Object[] waveTypes = new Object[5];
            Array types = Enum.GetValues(typeof(WaveType));
            Array modTypes = Enum.GetValues(typeof(ModulationType));
            foreach (WaveType type in types)
            {
                WaveTypeList.Add(new KeyValuePair<string, string>(type.ToString(), ((int)type).ToString()));
                WaveTypeList2.Add(new KeyValuePair<string, string>(type.ToString(), ((int)type).ToString()));
                waveTypes[(int)type] = type.ToString();
            }

            foreach (ModulationType type in modTypes)
            {
                ModTypeList.Add(new KeyValuePair<string, string>(type.ToString(), ((int)type).ToString()));
            }
            WaveTypeBox.DataSource = WaveTypeList;
            WaveTypeBox.DisplayMember = "Key";
            WaveTypeBox.ValueMember = "Value";

            ModulationTypeBox.DataSource = ModTypeList;
            ModulationTypeBox.DisplayMember = "Key";
            ModulationTypeBox.ValueMember = "Value";

            WaveTypePolyBox.DataSource = WaveTypeList2;
            WaveTypePolyBox.DisplayMember = "Key";
            WaveTypePolyBox.ValueMember = "Value";
        }

        private void AmplitudeTrackBar_Scroll(object sender, EventArgs e)
        {
            label4.Text = AmplitudeTrackBar.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void FrequencyTrackBar_Scroll(object sender, EventArgs e)
        {
            label5.Text = FrequencyTrackBar.Value.ToString(CultureInfo.InvariantCulture) + " Hz";
        }

        private void AmplitudePoly_Scroll(object sender, EventArgs e)
        {
            label9.Text = AmplitudePoly.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void FrequencyPoly_Scroll(object sender, EventArgs e)
        {
            label10.Text = FrequencyPoly.Value.ToString(CultureInfo.InvariantCulture) + " Hz";
        }

        private void DutyFactor_Scroll(object sender, EventArgs e)
        {
            label12.Text = DutyFactor.Value.ToString(CultureInfo.InvariantCulture) + "%";
        }

        private void WaveTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> type = (KeyValuePair<string, string>)WaveTypeBox.SelectedItem;
            if (type.Key == "Pulse")
            {
                label12.Show();
                DutyFactor.Show();
                label11.Show();
            }
            else
            {
                label12.Hide();
                DutyFactor.Hide();
                label11.Hide();
            }
        }

        private void addSignal_Click(object sender, EventArgs e)
        {
            var signalAttributes = new KeyValuePair<int, double>(AmplitudePoly.Value, FrequencyPoly.Value);
            WaveType waveType = (WaveType)short.Parse(WaveTypePolyBox.SelectedValue.ToString());
            Signals.Add(new KeyValuePair<WaveType, KeyValuePair<int, double>>(waveType, signalAttributes));
            WaveTypeList.Items.Add(waveType.ToString());
        }

        private void removeSignal_Click(object sender, EventArgs e)
        {
            var index = WaveTypeList.SelectedIndex;

            if (index > -1)
            {
                WaveTypeList.Items.RemoveAt(index);
                Signals.RemoveAt(index);
            }
        }

        private void generatePoly_Click(object sender, EventArgs e)
        {
            List<int> Amplitudes = new List<int>();
            List<double> Frequences = new List<double>();
            List<WaveType> SignalTypes = new List<WaveType>();
            foreach (KeyValuePair<WaveType, KeyValuePair<int, double>> attribute in Signals)
            {
                Amplitudes.Add(attribute.Value.Key);
                Frequences.Add(attribute.Value.Value);
                SignalTypes.Add(attribute.Key);
            }

            string filePath = @"E:\test.wav";
            PolyGenerator wave = new PolyGenerator(SignalTypes, Amplitudes, Frequences);
            wave.Save(filePath);

            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }

        private void GenModButton_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\test.wav";
            int amplitude1 = AmplitudeTrackBar.Value;
            double frequency1 = FrequencyTrackBar.Value;
            int amplitude2 = AmplitudePoly.Value;
            double frequency2 = FrequencyPoly.Value;
            double duty1 = (double)DutyFactor.Value / 100;
            double duty2 = (double)DutyFactor.Value / 100;
            WaveType waveType1 = (WaveType)short.Parse(WaveTypeBox.SelectedValue.ToString());
            WaveType waveType2 = (WaveType)short.Parse(WaveTypePolyBox.SelectedValue.ToString());
            ModulationType modType = (ModulationType)short.Parse(ModulationTypeBox.SelectedValue.ToString());
            Modulator wave = new Modulator(modType, waveType1, waveType2, amplitude1, amplitude2, frequency1, frequency2, duty1, duty2);
            wave.Save(filePath);

            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }
    }
}
