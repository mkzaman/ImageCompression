using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompressor
{
    public interface IImageCompressor
    {
        void CompressImage(int CompressionRate, string inputfilePath, string outputfilePath = "");
    }
}
