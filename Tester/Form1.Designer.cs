namespace Tester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ffmpegLocation = new System.Windows.Forms.TextBox();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cdAudioDevice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cdHozRes = new System.Windows.Forms.TextBox();
            this.cdVerRes = new System.Windows.Forms.TextBox();
            this.cdYOffset = new System.Windows.Forms.TextBox();
            this.cdXOffSet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cdDrawRegion = new System.Windows.Forms.CheckBox();
            this.cdDrawMouse = new System.Windows.Forms.CheckBox();
            this.cwDrawMouse = new System.Windows.Forms.CheckBox();
            this.cwWindowTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cwAudioDevice = new System.Windows.Forms.ComboBox();
            this.sdDrawMouse = new System.Windows.Forms.CheckBox();
            this.sdDrawRegion = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sdXOffSet = new System.Windows.Forms.TextBox();
            this.sdYOffset = new System.Windows.Forms.TextBox();
            this.sdVerRes = new System.Windows.Forms.TextBox();
            this.sdHozRes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sdAudioDevice = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.sdBroadcastUrl = new System.Windows.Forms.TextBox();
            this.sdStreamKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.swAudioDevice = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.swWindowTitle = new System.Windows.Forms.TextBox();
            this.swDrawMouse = new System.Windows.Forms.CheckBox();
            this.swStreamKey = new System.Windows.Forms.TextBox();
            this.swBroadcastUrl = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cdOutputFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cwOutputFile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Caputre Desktop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.captureDesktop);
            // 
            // ffmpegLocation
            // 
            this.ffmpegLocation.Location = new System.Drawing.Point(12, 34);
            this.ffmpegLocation.Name = "ffmpegLocation";
            this.ffmpegLocation.Size = new System.Drawing.Size(333, 20);
            this.ffmpegLocation.TabIndex = 1;
            this.ffmpegLocation.Text = "C:\\Users\\sburgess\\Downloads\\ffmpeg-20161122-d316b21-win64-static\\ffmpeg-20161122-" +
    "d316b21-win64-static\\bin\\ffmpeg";
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(12, 83);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(333, 20);
            this.saveLocation.TabIndex = 2;
            this.saveLocation.Text = "C:\\Users\\sburgess\\Downloads\\ffmpeg-20161122-d316b21-win64-static\\ffmpeg-20161122-" +
    "d316b21-win64-static\\bin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ffmpeg location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save location";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 92);
            this.button2.TabIndex = 9;
            this.button2.Text = "Caputre Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.captureWindow);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(712, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 92);
            this.button5.TabIndex = 12;
            this.button5.Text = "Stream Desktop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.streamDesktop);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(365, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 655);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(535, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 655);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(705, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 655);
            this.panel3.TabIndex = 21;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(882, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 92);
            this.button10.TabIndex = 22;
            this.button10.Text = "Stream Window";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.streamWindow);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(875, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 655);
            this.panel4.TabIndex = 22;
            // 
            // cdAudioDevice
            // 
            this.cdAudioDevice.FormattingEnabled = true;
            this.cdAudioDevice.Location = new System.Drawing.Point(376, 132);
            this.cdAudioDevice.Name = "cdAudioDevice";
            this.cdAudioDevice.Size = new System.Drawing.Size(121, 21);
            this.cdAudioDevice.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Audio Device";
            // 
            // cdHozRes
            // 
            this.cdHozRes.Location = new System.Drawing.Point(376, 172);
            this.cdHozRes.Name = "cdHozRes";
            this.cdHozRes.Size = new System.Drawing.Size(121, 20);
            this.cdHozRes.TabIndex = 25;
            // 
            // cdVerRes
            // 
            this.cdVerRes.Location = new System.Drawing.Point(376, 211);
            this.cdVerRes.Name = "cdVerRes";
            this.cdVerRes.Size = new System.Drawing.Size(121, 20);
            this.cdVerRes.TabIndex = 26;
            // 
            // cdYOffset
            // 
            this.cdYOffset.Location = new System.Drawing.Point(376, 289);
            this.cdYOffset.Name = "cdYOffset";
            this.cdYOffset.Size = new System.Drawing.Size(121, 20);
            this.cdYOffset.TabIndex = 27;
            // 
            // cdXOffSet
            // 
            this.cdXOffSet.Location = new System.Drawing.Point(376, 250);
            this.cdXOffSet.Name = "cdXOffSet";
            this.cdXOffSet.Size = new System.Drawing.Size(121, 20);
            this.cdXOffSet.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Hoz Res";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ver Res";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "X Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Y Offset";
            // 
            // cdDrawRegion
            // 
            this.cdDrawRegion.AutoSize = true;
            this.cdDrawRegion.Location = new System.Drawing.Point(376, 315);
            this.cdDrawRegion.Name = "cdDrawRegion";
            this.cdDrawRegion.Size = new System.Drawing.Size(128, 17);
            this.cdDrawRegion.TabIndex = 33;
            this.cdDrawRegion.Text = "Draw Capture Region";
            this.cdDrawRegion.UseVisualStyleBackColor = true;
            // 
            // cdDrawMouse
            // 
            this.cdDrawMouse.AutoSize = true;
            this.cdDrawMouse.Location = new System.Drawing.Point(376, 338);
            this.cdDrawMouse.Name = "cdDrawMouse";
            this.cdDrawMouse.Size = new System.Drawing.Size(119, 17);
            this.cdDrawMouse.TabIndex = 34;
            this.cdDrawMouse.Text = "Draw Mouse Cursor";
            this.cdDrawMouse.UseVisualStyleBackColor = true;
            // 
            // cwDrawMouse
            // 
            this.cwDrawMouse.AutoSize = true;
            this.cwDrawMouse.Location = new System.Drawing.Point(547, 200);
            this.cwDrawMouse.Name = "cwDrawMouse";
            this.cwDrawMouse.Size = new System.Drawing.Size(119, 17);
            this.cwDrawMouse.TabIndex = 35;
            this.cwDrawMouse.Text = "Draw Mouse Cursor";
            this.cwDrawMouse.UseVisualStyleBackColor = true;
            // 
            // cwWindowTitle
            // 
            this.cwWindowTitle.Location = new System.Drawing.Point(545, 174);
            this.cwWindowTitle.Name = "cwWindowTitle";
            this.cwWindowTitle.Size = new System.Drawing.Size(121, 20);
            this.cwWindowTitle.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Window Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Audio Device";
            // 
            // cwAudioDevice
            // 
            this.cwAudioDevice.FormattingEnabled = true;
            this.cwAudioDevice.Location = new System.Drawing.Point(545, 134);
            this.cwAudioDevice.Name = "cwAudioDevice";
            this.cwAudioDevice.Size = new System.Drawing.Size(121, 21);
            this.cwAudioDevice.TabIndex = 38;
            // 
            // sdDrawMouse
            // 
            this.sdDrawMouse.AutoSize = true;
            this.sdDrawMouse.Location = new System.Drawing.Point(715, 340);
            this.sdDrawMouse.Name = "sdDrawMouse";
            this.sdDrawMouse.Size = new System.Drawing.Size(119, 17);
            this.sdDrawMouse.TabIndex = 51;
            this.sdDrawMouse.Text = "Draw Mouse Cursor";
            this.sdDrawMouse.UseVisualStyleBackColor = true;
            // 
            // sdDrawRegion
            // 
            this.sdDrawRegion.AutoSize = true;
            this.sdDrawRegion.Location = new System.Drawing.Point(715, 317);
            this.sdDrawRegion.Name = "sdDrawRegion";
            this.sdDrawRegion.Size = new System.Drawing.Size(128, 17);
            this.sdDrawRegion.TabIndex = 50;
            this.sdDrawRegion.Text = "Draw Capture Region";
            this.sdDrawRegion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(715, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Y Offset";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "X Offset";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(715, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Ver Res";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(712, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Hoz Res";
            // 
            // sdXOffSet
            // 
            this.sdXOffSet.Location = new System.Drawing.Point(715, 252);
            this.sdXOffSet.Name = "sdXOffSet";
            this.sdXOffSet.Size = new System.Drawing.Size(121, 20);
            this.sdXOffSet.TabIndex = 45;
            // 
            // sdYOffset
            // 
            this.sdYOffset.Location = new System.Drawing.Point(715, 291);
            this.sdYOffset.Name = "sdYOffset";
            this.sdYOffset.Size = new System.Drawing.Size(121, 20);
            this.sdYOffset.TabIndex = 44;
            // 
            // sdVerRes
            // 
            this.sdVerRes.Location = new System.Drawing.Point(715, 213);
            this.sdVerRes.Name = "sdVerRes";
            this.sdVerRes.Size = new System.Drawing.Size(121, 20);
            this.sdVerRes.TabIndex = 43;
            // 
            // sdHozRes
            // 
            this.sdHozRes.Location = new System.Drawing.Point(715, 174);
            this.sdHozRes.Name = "sdHozRes";
            this.sdHozRes.Size = new System.Drawing.Size(121, 20);
            this.sdHozRes.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(712, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Audio Device";
            // 
            // sdAudioDevice
            // 
            this.sdAudioDevice.FormattingEnabled = true;
            this.sdAudioDevice.Location = new System.Drawing.Point(715, 134);
            this.sdAudioDevice.Name = "sdAudioDevice";
            this.sdAudioDevice.Size = new System.Drawing.Size(121, 21);
            this.sdAudioDevice.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(715, 385);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Twitch Broadcast URL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(715, 434);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Twitch Stream Key";
            // 
            // sdBroadcastUrl
            // 
            this.sdBroadcastUrl.Location = new System.Drawing.Point(715, 401);
            this.sdBroadcastUrl.Name = "sdBroadcastUrl";
            this.sdBroadcastUrl.Size = new System.Drawing.Size(121, 20);
            this.sdBroadcastUrl.TabIndex = 54;
            this.sdBroadcastUrl.Text = "live.twitch.tv";
            // 
            // sdStreamKey
            // 
            this.sdStreamKey.Location = new System.Drawing.Point(715, 450);
            this.sdStreamKey.Name = "sdStreamKey";
            this.sdStreamKey.Size = new System.Drawing.Size(121, 20);
            this.sdStreamKey.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(882, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 60;
            this.label19.Text = "Audio Device";
            // 
            // swAudioDevice
            // 
            this.swAudioDevice.FormattingEnabled = true;
            this.swAudioDevice.Location = new System.Drawing.Point(885, 134);
            this.swAudioDevice.Name = "swAudioDevice";
            this.swAudioDevice.Size = new System.Drawing.Size(121, 21);
            this.swAudioDevice.TabIndex = 59;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(884, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Window Title";
            // 
            // swWindowTitle
            // 
            this.swWindowTitle.Location = new System.Drawing.Point(885, 174);
            this.swWindowTitle.Name = "swWindowTitle";
            this.swWindowTitle.Size = new System.Drawing.Size(121, 20);
            this.swWindowTitle.TabIndex = 57;
            // 
            // swDrawMouse
            // 
            this.swDrawMouse.AutoSize = true;
            this.swDrawMouse.Location = new System.Drawing.Point(887, 200);
            this.swDrawMouse.Name = "swDrawMouse";
            this.swDrawMouse.Size = new System.Drawing.Size(119, 17);
            this.swDrawMouse.TabIndex = 56;
            this.swDrawMouse.Text = "Draw Mouse Cursor";
            this.swDrawMouse.UseVisualStyleBackColor = true;
            // 
            // swStreamKey
            // 
            this.swStreamKey.Location = new System.Drawing.Point(884, 297);
            this.swStreamKey.Name = "swStreamKey";
            this.swStreamKey.Size = new System.Drawing.Size(121, 20);
            this.swStreamKey.TabIndex = 64;
            // 
            // swBroadcastUrl
            // 
            this.swBroadcastUrl.Location = new System.Drawing.Point(884, 248);
            this.swBroadcastUrl.Name = "swBroadcastUrl";
            this.swBroadcastUrl.Size = new System.Drawing.Size(121, 20);
            this.swBroadcastUrl.TabIndex = 63;
            this.swBroadcastUrl.Text = "live.twitch.tv";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(884, 281);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 62;
            this.label21.Text = "Twitch Stream Key";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(884, 232);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "Twitch Broadcast URL";
            // 
            // cdOutputFile
            // 
            this.cdOutputFile.Location = new System.Drawing.Point(376, 388);
            this.cdOutputFile.Name = "cdOutputFile";
            this.cdOutputFile.Size = new System.Drawing.Size(145, 20);
            this.cdOutputFile.TabIndex = 65;
            this.cdOutputFile.Text = "output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Output file name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(544, 236);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "Output file name";
            // 
            // cwOutputFile
            // 
            this.cwOutputFile.Location = new System.Drawing.Point(547, 252);
            this.cwOutputFile.Name = "cwOutputFile";
            this.cwOutputFile.Size = new System.Drawing.Size(145, 20);
            this.cwOutputFile.TabIndex = 67;
            this.cwOutputFile.Text = "output";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 73);
            this.button3.TabIndex = 69;
            this.button3.Text = "Stop Recording";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.stopRecording);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 684);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cwOutputFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cdOutputFile);
            this.Controls.Add(this.swStreamKey);
            this.Controls.Add(this.swBroadcastUrl);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.swAudioDevice);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.swWindowTitle);
            this.Controls.Add(this.swDrawMouse);
            this.Controls.Add(this.sdStreamKey);
            this.Controls.Add(this.sdBroadcastUrl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.sdDrawMouse);
            this.Controls.Add(this.sdDrawRegion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sdXOffSet);
            this.Controls.Add(this.sdYOffset);
            this.Controls.Add(this.sdVerRes);
            this.Controls.Add(this.sdHozRes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sdAudioDevice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cwAudioDevice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cwWindowTitle);
            this.Controls.Add(this.cwDrawMouse);
            this.Controls.Add(this.cdDrawMouse);
            this.Controls.Add(this.cdDrawRegion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cdXOffSet);
            this.Controls.Add(this.cdYOffset);
            this.Controls.Add(this.cdVerRes);
            this.Controls.Add(this.cdHozRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdAudioDevice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.ffmpegLocation);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Feeble Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ffmpegLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cdAudioDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cdHozRes;
        private System.Windows.Forms.TextBox cdVerRes;
        private System.Windows.Forms.TextBox cdYOffset;
        private System.Windows.Forms.TextBox cdXOffSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cdDrawRegion;
        private System.Windows.Forms.CheckBox cdDrawMouse;
        private System.Windows.Forms.CheckBox cwDrawMouse;
        private System.Windows.Forms.TextBox cwWindowTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cwAudioDevice;
        private System.Windows.Forms.CheckBox sdDrawMouse;
        private System.Windows.Forms.CheckBox sdDrawRegion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox sdXOffSet;
        private System.Windows.Forms.TextBox sdYOffset;
        private System.Windows.Forms.TextBox sdVerRes;
        private System.Windows.Forms.TextBox sdHozRes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox sdAudioDevice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sdBroadcastUrl;
        private System.Windows.Forms.TextBox sdStreamKey;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox swAudioDevice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox swWindowTitle;
        private System.Windows.Forms.CheckBox swDrawMouse;
        private System.Windows.Forms.TextBox swStreamKey;
        private System.Windows.Forms.TextBox swBroadcastUrl;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox cdOutputFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox cwOutputFile;
        private System.Windows.Forms.Button button3;
    }
}

