using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    public class CaptureSettings : Settings
    {
        public CaptureSettings()
        {
            recordingRegionType = RecordingRegionType.desktop;
            fileType = FileType.mp4;
            forceOutputFileOverwrite = true;
            fileName = "output";
            frameRate = 60;
        }

        public bool forceOutputFileOverwrite { get; set; }
        public string saveLocation { get; set; }
        public string fileName { get; set; }
    }
}
