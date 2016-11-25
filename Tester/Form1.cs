using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Feeble;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Tester
{
    public partial class Form1 : Form
    {

        private Feeble.Feeble feeble;
        private List<string> audioDeviceList;

        public Form1()
        {
            InitializeComponent();
            var d = new DirectShow(ffmpegLocation.Text);
            d.GetDirectShowDevices();

            audioDeviceList = d.audioDevices;

            cdAudioDevice.DataSource = audioDeviceList;
        }

        public void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            //* Do your stuff with the output (write to console/log/StringBuilder)
            MessageBox.Show(outLine.Data);
        }

        private void captureDesktop(object sender, EventArgs e)
        {
            var settings = new CaptureSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.desktop;
            settings.fileName = cdOutputFile.Text;
            settings.saveLocation = saveLocation.Text;
            settings.audioDevice = cdAudioDevice.SelectedValue.ToString();

            if (cdVerRes.Text != "")
            {
                settings.verticalResolution = int.Parse(cdVerRes.Text);
            }

            if (cdHozRes.Text != "")
            {
                settings.horizontalResolution = int.Parse(cdHozRes.Text);
            }

            if (cdXOffSet.Text != "")
            {
                settings.offSetX = int.Parse(cdXOffSet.Text);
            }

            if (cdYOffset.Text != "")
            {
                settings.offSetY = int.Parse(cdYOffset.Text);
            }

            settings.drawCaptureRegion = cdDrawRegion.Checked;


            var temp = Task.Run(() => feeble.Capture(settings));
          
        }

        private void captureWindow(object sender, EventArgs e)
        {

            var settings = new CaptureSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.window;
            settings.fileName = cdOutputFile.Text;
            settings.saveLocation = saveLocation.Text;
            settings.windowTitle = cwWindowTitle.Text;
          


            var temp = Task.Run(() => feeble.Capture(settings));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feeble.FFmpeg f = new FFmpeg(ffmpegLocation.Text);
            f.Arguments = " -list_devices true -f dshow -i dummy";
            string test = f.Start(true);

            MessageBox.Show(test);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feeble.Stop();
        }

        private void stream(object sender, EventArgs e)
        {
            var settings = new StreamSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.window;
            settings.windowTitle = "Super Tennis (E) (V1.0)";
            settings.twitchBroadcastURL = "live.twitch.tv";
            settings.videoBitrate = 500;
            settings.audioDevice = "Stereo Mix (Realtek High Definition Audio)";
            settings.twitchStreamKey = "live_95092020_kHakXQ6xx3KrXWwKhZ5ocQEMirIk1i";

            //settings.verticalResolution = 500;
            //settings.horizontalResolution = 500;
            //settings.offSetX = 500;
            //settings.offSetY = 500;
            //settings.drawCaptureRegion = true;

            //Closure
            var temp = Task.Run(() => feeble.Stream(settings));

            
        }

        private void getDirectShowDevices(object sender, EventArgs e)
        {
          //  var d = new Feeble.DirectShow(ffmpegLocation.Text);
            //d.getDirectShowDevices();

          //  string test = "";
        }

        private void captureDesktopWithSound(object sender, EventArgs e)
        {
            /*var settings = new CaptureSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.desktop;
            settings.fileName = fileName.Text;
            settings.saveLocation = saveLocation.Text;
            settings.audioDevice = "Stereo Mix (Realtek High Definition Audio)";
            //settings.verticalResolution = 301;
            //settings.horizontalResolution = 507;
            //settings.offSetX = 501;
            //settings.offSetY = 406;
            //settings.drawCaptureRegion = true;

            //Closure
            var temp = Task.Run(() => feeble.Capture(settings));*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            feeble.Stop();
        }
    }
}
