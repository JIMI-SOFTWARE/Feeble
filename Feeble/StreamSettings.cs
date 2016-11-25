using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    public class StreamSettings : Settings
    {
        public StreamSettings()
        {
            videoBitrate = 3500; //Max twitch bit rate
            keyFrameIntervalInSeconds = 2; //twitch setting
            frameRate = 30;
        }
       
        public int videoBitrate { get; set; }
        public int audioBitrate { get; set; }
        public int keyFrameIntervalInSeconds { get; set; }
        public string twitchStreamKey { get; set; }
        public string twitchBroadcastURL { get; set; }
    }
}
