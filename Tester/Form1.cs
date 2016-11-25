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
            cwAudioDevice.DataSource = audioDeviceList;
            sdAudioDevice.DataSource = audioDeviceList;
            swAudioDevice.DataSource = audioDeviceList;
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
            settings.drawMouse = cdDrawMouse.Checked;

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

        private void streamDesktop(object sender, EventArgs e)
        {
            var settings = new StreamSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.desktop;
            settings.twitchBroadcastURL = sdBroadcastUrl.Text;
            settings.twitchStreamKey = sdStreamKey.Text;
            settings.videoBitrate = 500;
            settings.audioDevice = sdAudioDevice.SelectedValue.ToString(); 
            settings.drawCaptureRegion = sdDrawRegion.Checked;
            settings.drawMouse = sdDrawMouse.Checked;

            if (sdVerRes.Text != "")
            {
                settings.verticalResolution = int.Parse(sdVerRes.Text);
            }

            if (sdHozRes.Text != "")
            {
                settings.horizontalResolution = int.Parse(sdHozRes.Text);
            }

            if (sdXOffSet.Text != "")
            {
                settings.offSetX = int.Parse(sdXOffSet.Text);
            }

            if (sdYOffset.Text != "")
            {
                settings.offSetY = int.Parse(sdYOffset.Text);
            }
 
            var temp = Task.Run(() => feeble.Stream(settings));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopRecording(object sender, EventArgs e)
        {
            feeble.Stop();
        }

        private void streamWindow(object sender, EventArgs e)
        {
            var settings = new StreamSettings();
            feeble = new Feeble.Feeble();
            settings.ffmpegLocation = ffmpegLocation.Text;
            settings.recordingRegionType = RecordingRegionType.window;
            settings.windowTitle = swWindowTitle.Text;
            settings.twitchBroadcastURL = swBroadcastUrl.Text;
            settings.twitchStreamKey = swStreamKey.Text;
            settings.videoBitrate = 500;
            settings.audioDevice = swAudioDevice.SelectedValue.ToString();
            settings.drawMouse = swDrawMouse.Checked;

            var temp = Task.Run(() => feeble.Stream(settings));
        }
    }
}
