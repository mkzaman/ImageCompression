using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompressor
{
    public class JpegImageCompressor : IImageCompressor
    {
        public void CompressImage(int CompressionRate, string inputfilePath, string outputfilePath = "")
        {
            using (var memStream = new MemoryStream())
            {
                var magickImage = new MagickImage(inputfilePath);

                magickImage.Quality = CompressionRate;
                magickImage.Strip();
                magickImage.Write(memStream);
                var compressImageSize = memStream.Length;
                var compressImage = Image.FromStream(memStream, true, true);
                compressImage.Save(inputfilePath);
            }
        }
    }
}
