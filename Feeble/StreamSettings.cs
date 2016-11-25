using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    /// <summary>
    /// Recording settings unique to screen streaming.
    /// </summary>
    public class StreamSettings : Settings
    {
        public StreamSettings()
        {
            videoBitrate = 500; 
            keyFrameIntervalInSeconds = 2; 
            frameRate = 30;
            twitchBroadcastURL = "live.twitch.tv";
        }
       
        /// <summary>
        /// Controls the video bitrate. This defaults to 500kbps.
        /// </summary>
        public int videoBitrate { get; set; }

        /// <summary>
        /// Not implemented. 
        /// </summary>
        public int audioBitrate { get; set; }

        /// <summary>
        /// Controls the key frame interval. Defaults to 2 second (Twitch recommended)
        /// </summary>
        public int keyFrameIntervalInSeconds { get; set; }

        /// <summary>
        /// Sets the Twitch Stream Key. 
        /// </summary>
        public string twitchStreamKey { get; set; }

        /// <summary>
        /// Sets the Twitch BroadcastURL. Default to live.twitch.tv 
        /// </summary>
        public string twitchBroadcastURL { get; set; }
    }
}
