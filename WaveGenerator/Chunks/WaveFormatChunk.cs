using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveGenerator.Chunks
{
    class WaveFormatChunk
    {
        public string sChunkID;
        public uint dwChunkSize;
        public ushort wFormatTag;
        public ushort wChannels;
        public uint dwSamplesPerSecond;
        public uint dwAvgBytesPerSecond;
        public ushort wBlockAlign;
        public ushort wBitsPerSample;

        public WaveFormatChunk()
        {
            sChunkID = "fmt ";
            dwChunkSize = 16;
            wChannels = 1;
            wFormatTag = 1;
            dwSamplesPerSecond = 44100;
            wBitsPerSample = 16;
            wBlockAlign = (ushort)(wChannels * (wBitsPerSample / 8));
            dwAvgBytesPerSecond = dwSamplesPerSecond * wBlockAlign;
        }
    }
}
