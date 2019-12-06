using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveGenerator.Chunks
{
    class WaveHeader
    {
        public string sGroupID;
        public uint dwFileLength;
        public string sRiffType;

        public WaveHeader()
        {
            sGroupID = "RIFF";
            dwFileLength = 0;
            sRiffType = "WAVE";
        }
    }
}
