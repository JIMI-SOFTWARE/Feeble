using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Feeble
{
    public class FFmpeg
    {
        private Process ffmpeg;

        public processFFmpegOutput ErrorDataHandler;
        public string Arguments = "";

        public FFmpeg(string ffmpegLocation)
        {
            ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = ffmpegLocation;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.CreateNoWindow = true;
            //ffmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        }

        public string Start(bool outputAsString)
        {
            ffmpeg.StartInfo.Arguments = Arguments;   
            
            ffmpeg.StartInfo.RedirectStandardInput = true;

            if (outputAsString)
            {
                ffmpeg.StartInfo.RedirectStandardError = true;
                ffmpeg.Start();
                
                string output = ffmpeg.StandardError.ReadToEnd();

                return output;
            }
            else
            {
                if (ErrorDataHandler != null)
                {
                    ffmpeg.StartInfo.RedirectStandardError = true;
                    ffmpeg.ErrorDataReceived += new DataReceivedEventHandler(ErrorDataHandler);
                }

                ffmpeg.Start();

                if (ErrorDataHandler != null)
                {
                    ffmpeg.BeginErrorReadLine();
                }

                return "";
            }
        }
        
        public void Stop()
        {
            ffmpeg.StandardInput.WriteLine("q");
            ffmpeg.StandardInput.Close();
        } 
    }
}
