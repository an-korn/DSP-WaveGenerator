using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveGenerator.Chunks;

namespace WaveGenerator
{
    class Modulator
    {
        public enum ModulationType
        {
            Amplitude,
            Frequency
        }

        private WaveHeader header;
        private WaveFormatChunk format;
        private WaveDataChunk data;
        private Random rand = new Random();

        public Modulator(ModulationType modType, WaveType type1, WaveType type2, int amplitude1, int amplitude2, double freq1, double freq2, double duty1 = 0.5, double duty2 = 0.5)
        {
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            uint seconds = 5;
            uint numSamples = format.dwSamplesPerSecond * format.wChannels * seconds;
            data.shortArray = new short[numSamples];

            switch (modType)
            {
                case ModulationType.Amplitude:
                    for (uint i = 0; i < numSamples; i++)
                    {
                        for (int channel = 0; channel < format.wChannels; channel++)
                        {
                            double lfo = 0;
                            switch(type1)
                            {
                                case WaveType.Sine:
                                    lfo = Sine(amplitude1, freq1, numSamples, i);
                                    break;
                                case WaveType.Pulse:
                                    lfo = Pulse(amplitude1, freq1, numSamples, duty1, 1);
                                    break;
                                case WaveType.Triangle:
                                    lfo = Triangle(amplitude1, freq1, numSamples, i);
                                    break;
                                case WaveType.Sawtooth:
                                    lfo = Sawtooth(amplitude1, freq1, numSamples, i);
                                    break;
                                case WaveType.WhiteNoise:
                                    lfo = WhiteNoise(amplitude1);
                                    break;
                            }
                            short fl = Convert.ToInt16(Sine(amplitude2, freq2, numSamples, i));
                            int k = fl * Convert.ToInt16(lfo);
                            data.shortArray[i + channel] = Convert.ToInt16((k + fl*256*128) >> 16);
                        }
                    }
                    break;
                case ModulationType.Frequency:
                    double fi = 0;
                    for (uint i = 0; i < numSamples; i++)
                    {
                        for (int channel = 0; channel < format.wChannels; channel++)
                        {

                            double lfo = 0;
                            switch(type1)
                            {
                                case WaveType.Sine:
                                    lfo = Sine(amplitude1, freq1, numSamples, i);
                                    break;
                                case WaveType.Pulse:
                                    lfo = Pulse(amplitude1, freq1, numSamples, duty1, 1);
                                    break;
                                case WaveType.Triangle:
                                    lfo = Triangle(amplitude1, freq1, numSamples, 1);
                                    break;
                                case WaveType.Sawtooth:
                                    lfo = Sawtooth(amplitude1, freq1, numSamples, 1);
                                    break;
                                case WaveType.WhiteNoise:
                                    lfo = WhiteNoise(amplitude1);
                                    break;
                            }
                            fi += 2 * Math.PI * (freq2 + freq2 * lfo) / format.dwSamplesPerSecond;
                            data.shortArray[i + channel] = Convert.ToInt16(amplitude2 * Math.Sin(fi));
                        }
                    }
                    break;
            }

            data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
        }

        public void Save(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create);

            BinaryWriter writer = new BinaryWriter(fileStream);

            writer.Write(header.sGroupID.ToCharArray());
            writer.Write(header.dwFileLength);
            writer.Write(header.sRiffType.ToCharArray());

            writer.Write(format.sChunkID.ToCharArray());
            writer.Write(format.dwChunkSize);
            writer.Write(format.wFormatTag);
            writer.Write(format.wChannels);
            writer.Write(format.dwSamplesPerSecond);
            writer.Write(format.dwAvgBytesPerSecond);
            writer.Write(format.wBlockAlign);
            writer.Write(format.wBitsPerSample);

            writer.Write(data.sChunkID.ToCharArray());
            writer.Write(data.dwChunkSize);
            foreach (short dataPoint in data.shortArray)
            {
                writer.Write(dataPoint);
            }

            writer.Seek(4, SeekOrigin.Begin);
            uint filesize = (uint)writer.BaseStream.Length;
            writer.Write(filesize - 8);

            writer.Close();
            fileStream.Close();
        }

        private double Sine(int amplitude, double freq, uint numSamples, uint n)
        {
            return amplitude * Math.Sin(2 * Math.PI * freq * n / (format.dwSamplesPerSecond * format.wChannels));

        }

        private double WhiteNoise(int amplitude)
        {
            return (rand.Next(-amplitude, amplitude));
        }

        private double Pulse(int amplitude, double freq, uint numSamples, double duty, uint n)
        {
            double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSecond * format.wChannels);
            double sin = Math.Sin(t * n) + 1;
            int value = sin >= 2 - 2 * duty ? 1 : 0;
            return (amplitude * value);
        }

        private double Triangle(int amplitude, double freq, uint numSamples, uint n)
        {
            double t = (Math.PI * 2 * freq) / format.dwSamplesPerSecond * format.wChannels;
            double sin = Math.Sin(t * n);
            double value = Math.Asin(sin);
            return (2 * amplitude * value / Math.PI);
        }

        private double Sawtooth(int amplitude, double freq, uint numSamples, uint n)
        {
            double t = (Math.PI * 2 * freq) / numSamples;
            double sin = Math.Tan(t * n);
            double value = Math.Atan(sin);
            return (2 * amplitude * value / Math.PI);
        }
    }
}
