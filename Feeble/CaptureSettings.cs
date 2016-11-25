using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    /// <summary>
    /// Recording settings unique to screen captures.
    /// </summary>
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

        /// <summary>
        /// If set to true will forcibly overwrite an existing file of the same filename. This setting is defaulted to true.
        /// </summary>
        public bool forceOutputFileOverwrite { get; set; }

        /// <summary>
        /// Location to save the recording to. If not set the recording will be saved to the FFmpeg location.
        /// </summary>
        public string saveLocation { get; set; }

        /// <summary>
        /// Filename of the recoding. This value is defaulted to "output"
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// Controls the output file type.
        /// </summary>
        public FileType fileType { get; set; }
    }
}
