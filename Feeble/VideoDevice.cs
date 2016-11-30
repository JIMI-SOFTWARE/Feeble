using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeble
{
    public class VideoDevice
    {
        /// <summary>
        /// Diretshow video device name.
        /// </summary>
        public string deviceName { get; set; }

        public int horizontalResolution { get; set; }

        public int verticalResolution { get; set; }

        /// <summary>
        /// X Offset for recording. This offset starts from the top left hand corner of the primary monitor. If there is a monitor to the left of the primary monitor the offset will need to be negative to record it.
        /// </summary>
        public int offSetX { get; set; }

        /// <summary>
        /// Y offset for recording. This Offset start from the top left hand corner of the primary monitor. If there is a monitor to the left of the primary monitor the offset will need to be negative to record it.
        /// </summary>
        public int offSetY { get; set; }
    }
}
