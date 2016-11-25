using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    public class DirectShow
    {
        private string ffmpegLocation = "";
        public List<string> audioDevices = new List<string>();
        public List<string> videoDevices = new List<string>();

        public DirectShow(string ffmpegLocation)
        {
            this.ffmpegLocation = ffmpegLocation;
        }

        public void GetDirectShowDevices()
        {
            var f = new FFmpeg(ffmpegLocation);
            f.Arguments = " -list_devices true -f dshow -i dummy";
            ProcessDirectShowText(f.Start(true));
        }

        private void ProcessDirectShowText(string ffmpegDirectShowText)
        {
            var arr = ffmpegDirectShowText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            bool isVideo = false;
            bool isAudio = false;

            foreach(var s in arr)
            {
                if(s.StartsWith("[dshow @ ") && !s.Contains("Alternative name \"@d"))
                {
                    if(s.Contains("DirectShow video devices"))
                    {
                        isVideo = true;
                        isAudio = false;
                    }

                    if(s.Contains("DirectShow audio devices"))
                    {
                        isVideo = false;
                        isAudio = true;
                    }

                    if (isVideo && !s.Contains("DirectShow video devices"))
                    {
                        videoDevices.Add((s.Substring(s.IndexOf("\""), s.Length - s.IndexOf("\""))).Replace("\"", ""));
                    }

                    if (isAudio && !s.Contains("DirectShow audio devices"))
                    {
                        audioDevices.Add((s.Substring(s.IndexOf("\""), s.Length - s.IndexOf("\""))).Replace("\"", ""));
                    }
                }
            }
        }
    }
}
