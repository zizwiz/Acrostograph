
namespace Acrostograph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbx_Original = new System.Windows.Forms.PictureBox();
            this.picbx_result = new System.Windows.Forms.PictureBox();
            this.btn_open_image = new System.Windows.Forms.Button();
            this.btn_change_colour = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_video_player = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WinMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tot_video_time = new System.Windows.Forms.Label();
            this.lbl_video_path = new System.Windows.Forms.Label();
            this.btn_close_video = new System.Windows.Forms.Button();
            this.btn_open_video = new System.Windows.Forms.Button();
            this.tab_image_maker = new System.Windows.Forms.TabPage();
            this.lbl_video_to_split = new System.Windows.Forms.Label();
            this.rchtxbx_splitting_video_output = new System.Windows.Forms.RichTextBox();
            this.btn_video_to_split = new System.Windows.Forms.Button();
            this.btn_split_video = new System.Windows.Forms.Button();
            this.tab_video_maker = new System.Windows.Forms.TabPage();
            this.btn_video_maker = new System.Windows.Forms.Button();
            this.rchtxtbx_make_video_output = new System.Windows.Forms.RichTextBox();
            this.btn_image_maker_rtxbx_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_video_player.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab_image_maker.SuspendLayout();
            this.tab_video_maker.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbx_Original
            // 
            this.picbx_Original.Location = new System.Drawing.Point(48, 26);
            this.picbx_Original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_Original.Name = "picbx_Original";
            this.picbx_Original.Size = new System.Drawing.Size(307, 318);
            this.picbx_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_Original.TabIndex = 4;
            this.picbx_Original.TabStop = false;
            // 
            // picbx_result
            // 
            this.picbx_result.Location = new System.Drawing.Point(496, 26);
            this.picbx_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_result.Name = "picbx_result";
            this.picbx_result.Size = new System.Drawing.Size(302, 318);
            this.picbx_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_result.TabIndex = 5;
            this.picbx_result.TabStop = false;
            // 
            // btn_open_image
            // 
            this.btn_open_image.Location = new System.Drawing.Point(84, 454);
            this.btn_open_image.Name = "btn_open_image";
            this.btn_open_image.Size = new System.Drawing.Size(141, 42);
            this.btn_open_image.TabIndex = 6;
            this.btn_open_image.Text = "Open Image";
            this.btn_open_image.UseVisualStyleBackColor = true;
            this.btn_open_image.Click += new System.EventHandler(this.btn_open_image_Click);
            // 
            // btn_change_colour
            // 
            this.btn_change_colour.Location = new System.Drawing.Point(510, 423);
            this.btn_change_colour.Name = "btn_change_colour";
            this.btn_change_colour.Size = new System.Drawing.Size(141, 42);
            this.btn_change_colour.TabIndex = 7;
            this.btn_change_colour.Text = "Change colour";
            this.btn_change_colour.UseVisualStyleBackColor = true;
            this.btn_change_colour.Click += new System.EventHandler(this.btn_change_colour_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab_video_player);
            this.tabControl1.Controls.Add(this.tab_image_maker);
            this.tabControl1.Controls.Add(this.tab_video_maker);
            this.tabControl1.Location = new System.Drawing.Point(96, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 569);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picbx_result);
            this.tabPage1.Controls.Add(this.btn_open_image);
            this.tabPage1.Controls.Add(this.btn_change_colour);
            this.tabPage1.Controls.Add(this.picbx_Original);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_video_player
            // 
            this.tab_video_player.Controls.Add(this.tableLayoutPanel1);
            this.tab_video_player.Location = new System.Drawing.Point(4, 29);
            this.tab_video_player.Name = "tab_video_player";
            this.tab_video_player.Padding = new System.Windows.Forms.Padding(3);
            this.tab_video_player.Size = new System.Drawing.Size(953, 536);
            this.tab_video_player.TabIndex = 1;
            this.tab_video_player.Text = "Video Player";
            this.tab_video_player.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 530);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WinMediaPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 444);
            this.panel1.TabIndex = 0;
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(941, 444);
            this.WinMediaPlayer.TabIndex = 0;
            this.WinMediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.WinMediaPlayer_MediaError);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_tot_video_time);
            this.panel2.Controls.Add(this.lbl_video_path);
            this.panel2.Controls.Add(this.btn_close_video);
            this.panel2.Controls.Add(this.btn_open_video);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 74);
            this.panel2.TabIndex = 1;
            // 
            // lbl_tot_video_time
            // 
            this.lbl_tot_video_time.AutoSize = true;
            this.lbl_tot_video_time.Location = new System.Drawing.Point(3, 34);
            this.lbl_tot_video_time.Name = "lbl_tot_video_time";
            this.lbl_tot_video_time.Size = new System.Drawing.Size(51, 20);
            this.lbl_tot_video_time.TabIndex = 11;
            this.lbl_tot_video_time.Text = "label1";
            // 
            // lbl_video_path
            // 
            this.lbl_video_path.AutoSize = true;
            this.lbl_video_path.Location = new System.Drawing.Point(3, 3);
            this.lbl_video_path.Name = "lbl_video_path";
            this.lbl_video_path.Size = new System.Drawing.Size(51, 20);
            this.lbl_video_path.TabIndex = 10;
            this.lbl_video_path.Text = "label1";
            // 
            // btn_close_video
            // 
            this.btn_close_video.Location = new System.Drawing.Point(672, 3);
            this.btn_close_video.Name = "btn_close_video";
            this.btn_close_video.Size = new System.Drawing.Size(171, 51);
            this.btn_close_video.TabIndex = 9;
            this.btn_close_video.Text = "Close Video";
            this.btn_close_video.UseVisualStyleBackColor = true;
            this.btn_close_video.Click += new System.EventHandler(this.btn_close_video_Click);
            // 
            // btn_open_video
            // 
            this.btn_open_video.Location = new System.Drawing.Point(471, 3);
            this.btn_open_video.Name = "btn_open_video";
            this.btn_open_video.Size = new System.Drawing.Size(171, 51);
            this.btn_open_video.TabIndex = 1;
            this.btn_open_video.Text = "Open Video";
            this.btn_open_video.UseVisualStyleBackColor = true;
            this.btn_open_video.Click += new System.EventHandler(this.btn_open_video_Click);
            // 
            // tab_image_maker
            // 
            this.tab_image_maker.Controls.Add(this.btn_image_maker_rtxbx_clear);
            this.tab_image_maker.Controls.Add(this.lbl_video_to_split);
            this.tab_image_maker.Controls.Add(this.rchtxbx_splitting_video_output);
            this.tab_image_maker.Controls.Add(this.btn_video_to_split);
            this.tab_image_maker.Controls.Add(this.btn_split_video);
            this.tab_image_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_image_maker.Name = "tab_image_maker";
            this.tab_image_maker.Size = new System.Drawing.Size(953, 536);
            this.tab_image_maker.TabIndex = 2;
            this.tab_image_maker.Text = "Image maker";
            this.tab_image_maker.UseVisualStyleBackColor = true;
            // 
            // lbl_video_to_split
            // 
            this.lbl_video_to_split.AutoSize = true;
            this.lbl_video_to_split.Location = new System.Drawing.Point(63, 456);
            this.lbl_video_to_split.Name = "lbl_video_to_split";
            this.lbl_video_to_split.Size = new System.Drawing.Size(41, 20);
            this.lbl_video_to_split.TabIndex = 3;
            this.lbl_video_to_split.Text = "........";
            // 
            // rchtxbx_splitting_video_output
            // 
            this.rchtxbx_splitting_video_output.Location = new System.Drawing.Point(49, 59);
            this.rchtxbx_splitting_video_output.Name = "rchtxbx_splitting_video_output";
            this.rchtxbx_splitting_video_output.Size = new System.Drawing.Size(330, 341);
            this.rchtxbx_splitting_video_output.TabIndex = 2;
            this.rchtxbx_splitting_video_output.Text = "";
            // 
            // btn_video_to_split
            // 
            this.btn_video_to_split.Location = new System.Drawing.Point(562, 146);
            this.btn_video_to_split.Name = "btn_video_to_split";
            this.btn_video_to_split.Size = new System.Drawing.Size(121, 47);
            this.btn_video_to_split.TabIndex = 1;
            this.btn_video_to_split.Text = "Choose Video";
            this.btn_video_to_split.UseVisualStyleBackColor = true;
            this.btn_video_to_split.Click += new System.EventHandler(this.btn_video_to_split_Click);
            // 
            // btn_split_video
            // 
            this.btn_split_video.Location = new System.Drawing.Point(562, 245);
            this.btn_split_video.Name = "btn_split_video";
            this.btn_split_video.Size = new System.Drawing.Size(121, 47);
            this.btn_split_video.TabIndex = 0;
            this.btn_split_video.Text = "split";
            this.btn_split_video.UseVisualStyleBackColor = true;
            this.btn_split_video.Click += new System.EventHandler(this.btn_split_video_Click);
            // 
            // tab_video_maker
            // 
            this.tab_video_maker.Controls.Add(this.rchtxtbx_make_video_output);
            this.tab_video_maker.Controls.Add(this.btn_video_maker);
            this.tab_video_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_video_maker.Name = "tab_video_maker";
            this.tab_video_maker.Size = new System.Drawing.Size(953, 536);
            this.tab_video_maker.TabIndex = 3;
            this.tab_video_maker.Text = "Video Maker";
            this.tab_video_maker.UseVisualStyleBackColor = true;
            // 
            // btn_video_maker
            // 
            this.btn_video_maker.Location = new System.Drawing.Point(404, 220);
            this.btn_video_maker.Name = "btn_video_maker";
            this.btn_video_maker.Size = new System.Drawing.Size(132, 40);
            this.btn_video_maker.TabIndex = 0;
            this.btn_video_maker.Text = "Make Video";
            this.btn_video_maker.UseVisualStyleBackColor = true;
            this.btn_video_maker.Click += new System.EventHandler(this.btn_video_maker_Click);
            // 
            // rchtxtbx_make_video_output
            // 
            this.rchtxtbx_make_video_output.Location = new System.Drawing.Point(65, 74);
            this.rchtxtbx_make_video_output.Name = "rchtxtbx_make_video_output";
            this.rchtxtbx_make_video_output.Size = new System.Drawing.Size(264, 309);
            this.rchtxtbx_make_video_output.TabIndex = 1;
            this.rchtxtbx_make_video_output.Text = "";
            // 
            // btn_image_maker_rtxbx_clear
            // 
            this.btn_image_maker_rtxbx_clear.Location = new System.Drawing.Point(562, 344);
            this.btn_image_maker_rtxbx_clear.Name = "btn_image_maker_rtxbx_clear";
            this.btn_image_maker_rtxbx_clear.Size = new System.Drawing.Size(121, 47);
            this.btn_image_maker_rtxbx_clear.TabIndex = 4;
            this.btn_image_maker_rtxbx_clear.Text = "Clear";
            this.btn_image_maker_rtxbx_clear.UseVisualStyleBackColor = true;
            this.btn_image_maker_rtxbx_clear.Click += new System.EventHandler(this.btn_image_maker_rtxbx_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 738);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Acrostograph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tab_video_player.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_image_maker.ResumeLayout(false);
            this.tab_image_maker.PerformLayout();
            this.tab_video_maker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_Original;
        private System.Windows.Forms.PictureBox picbx_result;
        private System.Windows.Forms.Button btn_open_image;
        private System.Windows.Forms.Button btn_change_colour;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_video_player;
        private AxWMPLib.AxWindowsMediaPlayer WinMediaPlayer;
        private System.Windows.Forms.Button btn_open_video;
        private System.Windows.Forms.Button btn_close_video;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_video_path;
        private System.Windows.Forms.Label lbl_tot_video_time;
        private System.Windows.Forms.TabPage tab_image_maker;
        private System.Windows.Forms.Label lbl_video_to_split;
        private System.Windows.Forms.RichTextBox rchtxbx_splitting_video_output;
        private System.Windows.Forms.Button btn_video_to_split;
        private System.Windows.Forms.Button btn_split_video;
        private System.Windows.Forms.TabPage tab_video_maker;
        private System.Windows.Forms.RichTextBox rchtxtbx_make_video_output;
        private System.Windows.Forms.Button btn_video_maker;
        private System.Windows.Forms.Button btn_image_maker_rtxbx_clear;
    }
}

