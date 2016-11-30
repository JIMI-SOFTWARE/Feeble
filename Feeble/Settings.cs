using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    /// <summary>
    /// Generic recording settings available to both screen capture and screen streaming. 
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Controls the type of recording, either recording the entire Desktop or just a window.
        /// </summary>
        public RecordingRegionType recordingRegionType { get; set; }

        
        /// <summary>
        /// Directshow audio capture device that is to be used.
        /// </summary>
        public string audioDevice { get; set; }    
        
        /// <summary>
        /// Directshow audio capture devices to be used.
        /// </summary>
        public List<string> audioDevices { get; set; }

        /// <summary>
        /// Directshow video capture devices to be used.
        /// </summary>
        public List<VideoDevice> videoDevices { get; set; }

        /// <summary>
        /// Location of the FFmpeg executable.
        /// </summary>
        public string ffmpegLocation { get; set; }

        /// <summary>
        /// Title of the window to be recorded. Will only take effect if the recordingRegionType is set to window.
        /// </summary>
        public string windowTitle { get; set; }

        /// <summary>
        /// Horizontal Resolution to be recorded. Will only take effect if the recordingRegionType is set to desktop.
        /// </summary>
        public int horizontalResolution { get; set; }

        /// <summary>
        /// Framerate for recording.
        /// </summary>
        public int frameRate { get; set; }

        /// <summary>
        /// Vertical Resolution to be recorded. Will only take effect if the recordingRegionType is set to desktop.
        /// </summary>
        public int verticalResolution { get; set; }

        /// <summary>
        /// Currently not implemented.
        /// </summary>
        public int videoFramerate { get; set; }

        /// <summary>
        /// X Offset for recording. This offset starts from the top left hand corner of the primary monitor. If there is a monitor to the left of the primary monitor the offset will need to be negative to record it.
        /// </summary>
        public int offSetX { get; set; }

        /// <summary>
        /// Y offset for recording. This Offset start from the top left hand corner of the primary monitor. If there is a monitor to the left of the primary monitor the offset will need to be negative to record it.
        /// </summary>
        public int offSetY { get; set; }

        /// <summary>
        /// If set to true will display the mouse cursor in the recording.
        /// </summary>
        public bool drawMouse { get; set; }

        /// <summary>
        /// If set to true will display a boarder on the screen around the selected recording region. 
        /// </summary>
        public bool drawCaptureRegion { get; set; }

        /// <summary>
        /// Allows the output from FFmpeg to be redirect to a method of your choosing. This event will fire every time a new line would be displayed by FFmpeg.
        /// </summary>
        public processFFmpegOutput errorOutputHandler { get; set; }
    }
}
