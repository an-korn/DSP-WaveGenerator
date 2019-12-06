using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveGenerator.Chunks;

namespace WaveGenerator
{
    public enum WaveType
    {
        Sine,
        Pulse,
        Triangle,
        Sawtooth,
        WhiteNoise
    }

    class Generator
    {
        private WaveHeader header;
        private WaveFormatChunk format;
        private WaveDataChunk data;

        public Generator(WaveType type, int amplitude, double freq, double duty = 0.5)
        {
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            uint seconds = 5;
            uint numSamples = format.dwSamplesPerSecond * format.wChannels * seconds;
            data.shortArray = new short[numSamples];

            switch (type)
            {
                case WaveType.Sine:
                    Sine(amplitude, freq, numSamples);
                    break;
                case WaveType.Pulse:
                    Pulse(amplitude, freq, numSamples, duty);
                    break;
                case WaveType.Triangle:
                    Triangle(amplitude, freq, numSamples);
                    break;
                case WaveType.Sawtooth:
                    Sawtooth(amplitude, freq, numSamples);
                    break;
                case WaveType.WhiteNoise:
                    WhiteNoise(amplitude, numSamples);
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
            foreach(short dataPoint in data.shortArray)
            {
                writer.Write(dataPoint);
            }

            writer.Seek(4, SeekOrigin.Begin);
            uint filesize = (uint)writer.BaseStream.Length;
            writer.Write(filesize - 8);

            writer.Close();
            fileStream.Close(); 
        }

        private void Sine(int amplitude, double freq, uint numSamples)
        {
            double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSecond * format.wChannels);
            for (uint i = 0; i < numSamples; i++)
            {
                for (int channel = 0; channel < format.wChannels; channel++)
                {
                    data.shortArray[i + channel] = Convert.ToInt16(amplitude * Math.Sin(t * i));
                }
            }
        }

        private void Triangle(int amplitude, double freq, uint numSamples)
        {
            int samplesPerWaveLength = Convert.ToInt32(format.dwSamplesPerSecond / (freq / format.wChannels));
            short ampStep = Convert.ToInt16((amplitude * 2) / samplesPerWaveLength);
            short tempSample = (short)-amplitude;

            for (int i = 0; i < numSamples - 1; i++)
            {
                for (int channel = 0; channel < format.wChannels; channel++)
                {
                    if (Math.Abs(tempSample) > amplitude)
                        ampStep = (short)-ampStep;

                    tempSample += ampStep;
                    data.shortArray[i + channel] = tempSample;
                }
            }
        }

        private void Sawtooth(int amplitude, double freq, uint numSamples)
        {
            int samplesPerWaveLength = Convert.ToInt32(format.dwSamplesPerSecond / (freq / format.wChannels));
            short ampStep = Convert.ToInt16((amplitude * 2) / samplesPerWaveLength);
            short tempSample = (short)-amplitude;
            int totalSampleWritten = 0;

            while (totalSampleWritten < numSamples)
            {
                tempSample = (short)-amplitude;
                for (uint i = 0; i < samplesPerWaveLength && totalSampleWritten < numSamples; i++)
                {
                    for (int channel = 0; channel < format.wChannels; channel++)
                    {
                        tempSample += ampStep;
                        data.shortArray[totalSampleWritten] = tempSample;

                        totalSampleWritten++;
                    }
                }
            }
        }

        private void WhiteNoise(int amplitude, uint numSamples)
        {
            Random rand = new Random();
            short randomValue = 0;

            for (int i = 0; i < numSamples; i++)
            {
                randomValue = Convert.ToInt16(rand.Next(-amplitude, amplitude));
                data.shortArray[i] = randomValue;
            }
        }

        private void Pulse(int amplitude, double freq, uint numSamples, double duty)
        {
            double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSecond * format.wChannels);
            for (uint i = 0; i < numSamples - 1; i++)
            {
                for (int channel = 0; channel < format.wChannels; channel++)
                {
                    double sin = Math.Sin(t * i) + 1;
                    int value = sin >= 2 - 2 * duty ? 1 : 0;
                    data.shortArray[i + channel] = Convert.ToInt16(amplitude * value);
                }
            }
        }
    }
}
