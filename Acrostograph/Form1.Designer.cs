
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
            this.lbl_saving_imges_folder = new System.Windows.Forms.Label();
            this.pcbx_split_images = new System.Windows.Forms.PictureBox();
            this.btn_image_maker_rtxbx_clear = new System.Windows.Forms.Button();
            this.lbl_video_to_split = new System.Windows.Forms.Label();
            this.rchtxbx_splitting_video_output = new System.Windows.Forms.RichTextBox();
            this.btn_video_to_split = new System.Windows.Forms.Button();
            this.btn_split_video = new System.Windows.Forms.Button();
            this.tab_video_maker = new System.Windows.Forms.TabPage();
            this.rchtxtbx_make_video_output = new System.Windows.Forms.RichTextBox();
            this.btn_video_creater = new System.Windows.Forms.Button();
            this.btn_play_created_video = new System.Windows.Forms.Button();
            this.tab_modify_frames = new System.Windows.Forms.TabPage();
            this.rchtxbx_modify_frames_output = new System.Windows.Forms.RichTextBox();
            this.btn_list_files = new System.Windows.Forms.Button();
            this.flowlayoutpnl_modfy_frames = new System.Windows.Forms.FlowLayoutPanel();
            this.picbx_choosen_image = new System.Windows.Forms.PictureBox();
            this.lbl_choosen_image = new System.Windows.Forms.Label();
            this.btn_movelineup_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_movelinedown_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_deleteline_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_clear_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_split_images)).BeginInit();
            this.tab_video_maker.SuspendLayout();
            this.tab_modify_frames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_choosen_image)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tab_modify_frames);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 644);
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
            this.tabPage1.Size = new System.Drawing.Size(989, 574);
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
            this.tab_video_player.Size = new System.Drawing.Size(989, 574);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 568);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WinMediaPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 482);
            this.panel1.TabIndex = 0;
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(977, 482);
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
            this.panel2.Location = new System.Drawing.Point(3, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 74);
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
            this.btn_close_video.Location = new System.Drawing.Point(868, 34);
            this.btn_close_video.Name = "btn_close_video";
            this.btn_close_video.Size = new System.Drawing.Size(106, 37);
            this.btn_close_video.TabIndex = 9;
            this.btn_close_video.Text = "Close Video";
            this.btn_close_video.UseVisualStyleBackColor = true;
            this.btn_close_video.Click += new System.EventHandler(this.btn_close_video_Click);
            // 
            // btn_open_video
            // 
            this.btn_open_video.Location = new System.Drawing.Point(868, 0);
            this.btn_open_video.Name = "btn_open_video";
            this.btn_open_video.Size = new System.Drawing.Size(109, 28);
            this.btn_open_video.TabIndex = 1;
            this.btn_open_video.Text = "Open Video";
            this.btn_open_video.UseVisualStyleBackColor = true;
            this.btn_open_video.Click += new System.EventHandler(this.btn_open_video_Click);
            // 
            // tab_image_maker
            // 
            this.tab_image_maker.Controls.Add(this.lbl_saving_imges_folder);
            this.tab_image_maker.Controls.Add(this.pcbx_split_images);
            this.tab_image_maker.Controls.Add(this.btn_image_maker_rtxbx_clear);
            this.tab_image_maker.Controls.Add(this.lbl_video_to_split);
            this.tab_image_maker.Controls.Add(this.rchtxbx_splitting_video_output);
            this.tab_image_maker.Controls.Add(this.btn_video_to_split);
            this.tab_image_maker.Controls.Add(this.btn_split_video);
            this.tab_image_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_image_maker.Name = "tab_image_maker";
            this.tab_image_maker.Size = new System.Drawing.Size(989, 574);
            this.tab_image_maker.TabIndex = 2;
            this.tab_image_maker.Text = "Image maker";
            this.tab_image_maker.UseVisualStyleBackColor = true;
            // 
            // lbl_saving_imges_folder
            // 
            this.lbl_saving_imges_folder.AutoSize = true;
            this.lbl_saving_imges_folder.Location = new System.Drawing.Point(45, 504);
            this.lbl_saving_imges_folder.Name = "lbl_saving_imges_folder";
            this.lbl_saving_imges_folder.Size = new System.Drawing.Size(41, 20);
            this.lbl_saving_imges_folder.TabIndex = 6;
            this.lbl_saving_imges_folder.Text = "........";
            // 
            // pcbx_split_images
            // 
            this.pcbx_split_images.Location = new System.Drawing.Point(523, 59);
            this.pcbx_split_images.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbx_split_images.Name = "pcbx_split_images";
            this.pcbx_split_images.Size = new System.Drawing.Size(402, 341);
            this.pcbx_split_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbx_split_images.TabIndex = 5;
            this.pcbx_split_images.TabStop = false;
            // 
            // btn_image_maker_rtxbx_clear
            // 
            this.btn_image_maker_rtxbx_clear.Location = new System.Drawing.Point(440, 436);
            this.btn_image_maker_rtxbx_clear.Name = "btn_image_maker_rtxbx_clear";
            this.btn_image_maker_rtxbx_clear.Size = new System.Drawing.Size(121, 47);
            this.btn_image_maker_rtxbx_clear.TabIndex = 4;
            this.btn_image_maker_rtxbx_clear.Text = "Clear";
            this.btn_image_maker_rtxbx_clear.UseVisualStyleBackColor = true;
            this.btn_image_maker_rtxbx_clear.Click += new System.EventHandler(this.btn_image_maker_rtxbx_clear_Click);
            // 
            // lbl_video_to_split
            // 
            this.lbl_video_to_split.AutoSize = true;
            this.lbl_video_to_split.Location = new System.Drawing.Point(45, 20);
            this.lbl_video_to_split.Name = "lbl_video_to_split";
            this.lbl_video_to_split.Size = new System.Drawing.Size(41, 20);
            this.lbl_video_to_split.TabIndex = 3;
            this.lbl_video_to_split.Text = "........";
            // 
            // rchtxbx_splitting_video_output
            // 
            this.rchtxbx_splitting_video_output.Location = new System.Drawing.Point(49, 59);
            this.rchtxbx_splitting_video_output.Name = "rchtxbx_splitting_video_output";
            this.rchtxbx_splitting_video_output.Size = new System.Drawing.Size(387, 341);
            this.rchtxbx_splitting_video_output.TabIndex = 2;
            this.rchtxbx_splitting_video_output.Text = "";
            // 
            // btn_video_to_split
            // 
            this.btn_video_to_split.Location = new System.Drawing.Point(49, 436);
            this.btn_video_to_split.Name = "btn_video_to_split";
            this.btn_video_to_split.Size = new System.Drawing.Size(121, 47);
            this.btn_video_to_split.TabIndex = 1;
            this.btn_video_to_split.Text = "Choose Video";
            this.btn_video_to_split.UseVisualStyleBackColor = true;
            this.btn_video_to_split.Click += new System.EventHandler(this.btn_video_to_split_Click);
            // 
            // btn_split_video
            // 
            this.btn_split_video.Location = new System.Drawing.Point(258, 436);
            this.btn_split_video.Name = "btn_split_video";
            this.btn_split_video.Size = new System.Drawing.Size(121, 47);
            this.btn_split_video.TabIndex = 0;
            this.btn_split_video.Text = "split";
            this.btn_split_video.UseVisualStyleBackColor = true;
            this.btn_split_video.Click += new System.EventHandler(this.btn_split_video_Click);
            // 
            // tab_video_maker
            // 
            this.tab_video_maker.Controls.Add(this.btn_play_created_video);
            this.tab_video_maker.Controls.Add(this.rchtxtbx_make_video_output);
            this.tab_video_maker.Controls.Add(this.btn_video_creater);
            this.tab_video_maker.Location = new System.Drawing.Point(4, 29);
            this.tab_video_maker.Name = "tab_video_maker";
            this.tab_video_maker.Size = new System.Drawing.Size(989, 574);
            this.tab_video_maker.TabIndex = 3;
            this.tab_video_maker.Text = "Video Maker";
            this.tab_video_maker.UseVisualStyleBackColor = true;
            // 
            // rchtxtbx_make_video_output
            // 
            this.rchtxtbx_make_video_output.Location = new System.Drawing.Point(65, 33);
            this.rchtxtbx_make_video_output.Name = "rchtxtbx_make_video_output";
            this.rchtxtbx_make_video_output.Size = new System.Drawing.Size(835, 309);
            this.rchtxtbx_make_video_output.TabIndex = 1;
            this.rchtxtbx_make_video_output.Text = "";
            // 
            // btn_video_creater
            // 
            this.btn_video_creater.Location = new System.Drawing.Point(768, 493);
            this.btn_video_creater.Name = "btn_video_creater";
            this.btn_video_creater.Size = new System.Drawing.Size(132, 40);
            this.btn_video_creater.TabIndex = 0;
            this.btn_video_creater.Text = "Create Video";
            this.btn_video_creater.UseVisualStyleBackColor = true;
            this.btn_video_creater.Click += new System.EventHandler(this.btn_video_maker_Click);
            // 
            // btn_play_created_video
            // 
            this.btn_play_created_video.Location = new System.Drawing.Point(550, 493);
            this.btn_play_created_video.Name = "btn_play_created_video";
            this.btn_play_created_video.Size = new System.Drawing.Size(170, 40);
            this.btn_play_created_video.TabIndex = 2;
            this.btn_play_created_video.Text = "Play Created Video";
            this.btn_play_created_video.UseVisualStyleBackColor = true;
            // 
            // tab_modify_frames
            // 
            this.tab_modify_frames.Controls.Add(this.btn_clear_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_deleteline_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_movelinedown_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_movelineup_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.lbl_choosen_image);
            this.tab_modify_frames.Controls.Add(this.picbx_choosen_image);
            this.tab_modify_frames.Controls.Add(this.flowlayoutpnl_modfy_frames);
            this.tab_modify_frames.Controls.Add(this.btn_list_files);
            this.tab_modify_frames.Controls.Add(this.rchtxbx_modify_frames_output);
            this.tab_modify_frames.Location = new System.Drawing.Point(4, 29);
            this.tab_modify_frames.Name = "tab_modify_frames";
            this.tab_modify_frames.Size = new System.Drawing.Size(1146, 611);
            this.tab_modify_frames.TabIndex = 4;
            this.tab_modify_frames.Text = "Modify Frames";
            this.tab_modify_frames.UseVisualStyleBackColor = true;
            // 
            // rchtxbx_modify_frames_output
            // 
            this.rchtxbx_modify_frames_output.Location = new System.Drawing.Point(31, 29);
            this.rchtxbx_modify_frames_output.Name = "rchtxbx_modify_frames_output";
            this.rchtxbx_modify_frames_output.Size = new System.Drawing.Size(503, 182);
            this.rchtxbx_modify_frames_output.TabIndex = 0;
            this.rchtxbx_modify_frames_output.Text = "";
            this.rchtxbx_modify_frames_output.WordWrap = false;
            // 
            // btn_list_files
            // 
            this.btn_list_files.Location = new System.Drawing.Point(495, 520);
            this.btn_list_files.Name = "btn_list_files";
            this.btn_list_files.Size = new System.Drawing.Size(120, 38);
            this.btn_list_files.TabIndex = 1;
            this.btn_list_files.Text = "List Files";
            this.btn_list_files.UseVisualStyleBackColor = true;
            this.btn_list_files.Click += new System.EventHandler(this.btn_list_files_Click);
            // 
            // flowlayoutpnl_modfy_frames
            // 
            this.flowlayoutpnl_modfy_frames.AutoScroll = true;
            this.flowlayoutpnl_modfy_frames.Location = new System.Drawing.Point(652, 3);
            this.flowlayoutpnl_modfy_frames.Name = "flowlayoutpnl_modfy_frames";
            this.flowlayoutpnl_modfy_frames.Size = new System.Drawing.Size(491, 605);
            this.flowlayoutpnl_modfy_frames.TabIndex = 2;
            // 
            // picbx_choosen_image
            // 
            this.picbx_choosen_image.Location = new System.Drawing.Point(31, 219);
            this.picbx_choosen_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_choosen_image.Name = "picbx_choosen_image";
            this.picbx_choosen_image.Size = new System.Drawing.Size(584, 293);
            this.picbx_choosen_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_choosen_image.TabIndex = 6;
            this.picbx_choosen_image.TabStop = false;
            // 
            // lbl_choosen_image
            // 
            this.lbl_choosen_image.AutoSize = true;
            this.lbl_choosen_image.Location = new System.Drawing.Point(315, 529);
            this.lbl_choosen_image.Name = "lbl_choosen_image";
            this.lbl_choosen_image.Size = new System.Drawing.Size(33, 20);
            this.lbl_choosen_image.TabIndex = 7;
            this.lbl_choosen_image.Text = "......";
            // 
            // btn_movelineup_modify_frames_output_rchtxbx
            // 
            this.btn_movelineup_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movelineup_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 31);
            this.btn_movelineup_modify_frames_output_rchtxbx.Name = "btn_movelineup_modify_frames_output_rchtxbx";
            this.btn_movelineup_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 35);
            this.btn_movelineup_modify_frames_output_rchtxbx.TabIndex = 8;
            this.btn_movelineup_modify_frames_output_rchtxbx.Text = "↑";
            this.btn_movelineup_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_movelineup_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_movelineup_modify_frames_output_rchtxbx_Click);
            // 
            // btn_movelinedown_modify_frames_output_rchtxbx
            // 
            this.btn_movelinedown_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movelinedown_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 72);
            this.btn_movelinedown_modify_frames_output_rchtxbx.Name = "btn_movelinedown_modify_frames_output_rchtxbx";
            this.btn_movelinedown_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 35);
            this.btn_movelinedown_modify_frames_output_rchtxbx.TabIndex = 9;
            this.btn_movelinedown_modify_frames_output_rchtxbx.Text = "↓";
            this.btn_movelinedown_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_movelinedown_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_movelinedown_modify_frames_output_rchtxbx_Click);
            // 
            // btn_deleteline_modify_frames_output_rchtxbx
            // 
            this.btn_deleteline_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteline_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 113);
            this.btn_deleteline_modify_frames_output_rchtxbx.Name = "btn_deleteline_modify_frames_output_rchtxbx";
            this.btn_deleteline_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 35);
            this.btn_deleteline_modify_frames_output_rchtxbx.TabIndex = 10;
            this.btn_deleteline_modify_frames_output_rchtxbx.Text = "→";
            this.btn_deleteline_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_deleteline_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_deleteline_modify_frames_output_rchtxbx_Click);
            // 
            // btn_clear_modify_frames_output_rchtxbx
            // 
            this.btn_clear_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(540, 176);
            this.btn_clear_modify_frames_output_rchtxbx.Name = "btn_clear_modify_frames_output_rchtxbx";
            this.btn_clear_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(75, 35);
            this.btn_clear_modify_frames_output_rchtxbx.TabIndex = 11;
            this.btn_clear_modify_frames_output_rchtxbx.Text = "Clear";
            this.btn_clear_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_split_images)).EndInit();
            this.tab_video_maker.ResumeLayout(false);
            this.tab_modify_frames.ResumeLayout(false);
            this.tab_modify_frames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_choosen_image)).EndInit();
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
        private System.Windows.Forms.Button btn_video_creater;
        private System.Windows.Forms.Button btn_image_maker_rtxbx_clear;
        private System.Windows.Forms.PictureBox pcbx_split_images;
        private System.Windows.Forms.Label lbl_saving_imges_folder;
        private System.Windows.Forms.Button btn_play_created_video;
        private System.Windows.Forms.TabPage tab_modify_frames;
        private System.Windows.Forms.Button btn_list_files;
        private System.Windows.Forms.RichTextBox rchtxbx_modify_frames_output;
        private System.Windows.Forms.FlowLayoutPanel flowlayoutpnl_modfy_frames;
        private System.Windows.Forms.PictureBox picbx_choosen_image;
        private System.Windows.Forms.Label lbl_choosen_image;
        private System.Windows.Forms.Button btn_clear_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_deleteline_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_movelinedown_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_movelineup_modify_frames_output_rchtxbx;
    }
}

