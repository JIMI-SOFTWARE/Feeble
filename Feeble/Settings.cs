using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    public class Settings
    {
        public RecordingRegionType recordingRegionType { get; set; }
        public FileType fileType { get; set; }

        public string audioDevice { get; set; }      
        public string ffmpegLocation { get; set; }
        public string windowTitle { get; set; }
        public string microphoneDevice { get; set; }

        public int horizontalResolution { get; set; }
        public int frameRate { get; set; }
        public int verticalResolution { get; set; }
        public int videoFramerate { get; set; }
        public int offSetX { get; set; }
        public int offSetY { get; set; }

        public bool drawMouse { get; set; }
        public bool drawCaptureRegion { get; set; }

        public processFFmpegOutput standardOutputHandler { get; set; }
        public processFFmpegOutput errorOutputHandler { get; set; }
    }
}
