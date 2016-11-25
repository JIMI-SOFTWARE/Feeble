using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Feeble
{
    public class Feeble
    {
        private FFmpeg ffmpeg;

        public Feeble()
        {
           
        } 

        public void Stream(StreamSettings settings)
        {
            if (settings.ffmpegLocation != null) settings.ffmpegLocation.Trim();
            
            StringBuilder args = new StringBuilder();

            if (settings.audioDevice != "" && settings.audioDevice != null)
            {
                args.Append("-f dshow -audio_buffer_size 80 -i audio=\"");
                args.Append(settings.audioDevice);
                args.Append("\" ");
            }

            args.Append("-f gdigrab -framerate ");
            args.Append(settings.frameRate.ToString());
            args.Append(" ");

            if (settings.drawMouse)
            {
                args.Append(" -draw_mouse 1 ");
            }
            else
            {
                args.Append(" -draw_mouse 0 ");
            }

            if (settings.drawCaptureRegion)
            {
                args.Append(" -show_region 1 ");
            }

            switch (settings.recordingRegionType)
            {
                case RecordingRegionType.desktop:

                    args.Append(" -offset_x ");
                    args.Append(settings.offSetX);
                    args.Append(" -offset_y ");
                    args.Append(settings.offSetY);

                    if (settings.horizontalResolution != 0 && settings.verticalResolution != 0)
                    {
                        args.Append(" -video_size ");
                        args.Append(settings.horizontalResolution);
                        args.Append("x");
                        args.Append(settings.verticalResolution);
                        args.Append(" ");
                    }

                    args.Append("-i desktop -vf scale=trunc(in_w/2)*2:trunc(in_h/2)*2");

                    break;

                case RecordingRegionType.window:
                    args.Append("-i title=\"");
                    args.Append(settings.windowTitle);
                    args.Append("\" -vf scale=trunc(in_w/2)*2:trunc(in_h/2)*2");

                    break;
            }

            args.Append(" -c:a aac -c:v libx264 -preset:v veryfast -pix_fmt yuv420p -force_key_frames ");
            args.Append("00:02:00 ");
            args.Append(" -b:v ");
            args.Append(settings.videoBitrate);
            args.Append("k");
            args.Append(" -maxrate ");
            args.Append(settings.videoBitrate);
            args.Append("k");
            args.Append(" -bufsize ");
            args.Append(settings.videoBitrate*2);
            args.Append("k");
            args.Append(" -f flv rtmp://");
            args.Append(settings.twitchBroadcastURL);
            args.Append("/app/");
            args.Append(settings.twitchStreamKey);

            ffmpeg = new FFmpeg(settings.ffmpegLocation);
            ffmpeg.Arguments = args.ToString();
            ffmpeg.Start(false);
        }

        public void Capture(CaptureSettings settings)
        {
            if (settings.saveLocation != null) settings.saveLocation.Trim();
            if (settings.fileName != null) settings.fileName.Trim();
            if (settings.ffmpegLocation != null) settings.ffmpegLocation.Trim();

            if (settings.saveLocation != null)
            {
                if (!settings.saveLocation.EndsWith("\\")) settings.saveLocation += "\\";
            }

            StringBuilder args = new StringBuilder();

            if (settings.audioDevice != "" && settings.audioDevice != null)
            {
                args.Append("-f dshow -audio_buffer_size 80 -i audio=\"");
                args.Append(settings.audioDevice);
                args.Append("\" ");
            }

            args.Append("-f gdigrab -framerate ");
            args.Append(settings.frameRate.ToString());
            args.Append(" ");

            if (settings.drawMouse)
            {
                args.Append(" -draw_mouse 1 ");
            }
            else
            {
                args.Append(" -draw_mouse 0 ");
            }

            if (settings.drawCaptureRegion)
            {
                args.Append(" -show_region 1 ");
            }

            switch (settings.recordingRegionType)
            {
                case RecordingRegionType.desktop:

                    args.Append(" -offset_x ");
                    args.Append(settings.offSetX);
                    args.Append(" -offset_y ");
                    args.Append(settings.offSetY);

                    if (settings.horizontalResolution != 0 && settings.verticalResolution != 0)
                    {
                        args.Append(" -video_size ");
                        args.Append(settings.horizontalResolution);
                        args.Append("x");
                        args.Append(settings.verticalResolution);
                        args.Append(" ");
                    }

                    args.Append(" -i desktop -vf scale=trunc(in_w/2)*2:trunc(in_h/2)*2");

                    break;

                case RecordingRegionType.window:

                    args.Append("-i title=\"");
                    args.Append(settings.windowTitle);
                    args.Append("\" -vf scale=trunc(in_w/2)*2:trunc(in_h/2)*2");

                    break;
            }
            
            args.Append(" -c:a aac -c:v libx264 -preset:v fast -pix_fmt yuv420p ");

            if(settings.audioDevice != "" && settings.audioDevice != null)
            {
                args.Append(" -af \"aresample=async=1000\" ");
            }

            args.Append(settings.saveLocation);
            args.Append(settings.fileName);

            switch (settings.fileType)
            {
                case FileType.mp4:

                    args.Append(".mp4");

                    break;
            }

            if (settings.forceOutputFileOverwrite)
            {
                args.Append(" -y");
            }

            ffmpeg = new FFmpeg(settings.ffmpegLocation);
            ffmpeg.Arguments = args.ToString();
            ffmpeg.Start(false);
        }

        public void Stop()
        {
            ffmpeg.Stop();  
        }
    }
}
