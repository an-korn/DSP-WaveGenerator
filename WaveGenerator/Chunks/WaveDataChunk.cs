using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveGenerator.Chunks
{
    class WaveDataChunk
    {
        public string sChunkID;
        public uint dwChunkSize;
        public short[] shortArray;

        public WaveDataChunk()
        {
            sChunkID = "data";
            shortArray = new short[0];
            dwChunkSize = 0;
        }
    }
}
