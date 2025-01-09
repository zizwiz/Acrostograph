
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_open_image = new System.Windows.Forms.Button();
            this.btn_change_colour = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_modify_colours = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_Original = new System.Windows.Forms.PictureBox();
            this.picbx_result = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_filters = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_ColourFiltersData = new System.Windows.Forms.DataGridView();
            this.dgv_ColourFiltersData_RedByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ColourFiltersData_GreenByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ColourFiltersData_BlueByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ColourFiltersData_AlphaByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ColourFiltersData_Brightness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmbobx_ColourFilters = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkbx_Superimpose = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_apply_filter = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chkbx_save_history = new System.Windows.Forms.CheckBox();
            this.lbl_filter_name = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_delete_filter = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_update_filter = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_add_filter = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btn_adjust = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txtbx_adjust_value = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btn_backup_images = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tab_history = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.dgv_history_RedByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_GreenByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_BlueByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_AlphaByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_Brightness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_FilterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_Superimpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel29 = new System.Windows.Forms.Panel();
            this.btn_open_history_file = new System.Windows.Forms.Button();
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
            this.btn_play_created_video = new System.Windows.Forms.Button();
            this.rchtxtbx_make_video_output = new System.Windows.Forms.RichTextBox();
            this.btn_video_creater = new System.Windows.Forms.Button();
            this.tab_modify_frames = new System.Windows.Forms.TabPage();
            this.btn_create_modified_video = new System.Windows.Forms.Button();
            this.lstbx_modify_frames_output = new System.Windows.Forms.ListBox();
            this.btn_clear_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_deleteline_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_movelinedown_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.btn_movelineup_modify_frames_output_rchtxbx = new System.Windows.Forms.Button();
            this.lbl_choosen_image = new System.Windows.Forms.Label();
            this.picbx_choosen_image = new System.Windows.Forms.PictureBox();
            this.flowlayoutpnl_modfy_frames = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_list_files = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_modify_colours.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tab_filters.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tab_history.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.panel29.SuspendLayout();
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
            // btn_open_image
            // 
            this.btn_open_image.Location = new System.Drawing.Point(98, 6);
            this.btn_open_image.Name = "btn_open_image";
            this.btn_open_image.Size = new System.Drawing.Size(141, 42);
            this.btn_open_image.TabIndex = 6;
            this.btn_open_image.Text = "Open Image";
            this.btn_open_image.UseVisualStyleBackColor = true;
            this.btn_open_image.Click += new System.EventHandler(this.btn_open_image_Click);
            // 
            // btn_change_colour
            // 
            this.btn_change_colour.Location = new System.Drawing.Point(91, -3);
            this.btn_change_colour.Name = "btn_change_colour";
            this.btn_change_colour.Size = new System.Drawing.Size(141, 42);
            this.btn_change_colour.TabIndex = 7;
            this.btn_change_colour.Text = "Change colour";
            this.btn_change_colour.UseVisualStyleBackColor = true;
            this.btn_change_colour.Click += new System.EventHandler(this.btn_change_colour_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_modify_colours);
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
            // tab_modify_colours
            // 
            this.tab_modify_colours.Controls.Add(this.tableLayoutPanel3);
            this.tab_modify_colours.Location = new System.Drawing.Point(4, 29);
            this.tab_modify_colours.Name = "tab_modify_colours";
            this.tab_modify_colours.Padding = new System.Windows.Forms.Padding(3);
            this.tab_modify_colours.Size = new System.Drawing.Size(1146, 611);
            this.tab_modify_colours.TabIndex = 0;
            this.tab_modify_colours.Text = "Modify Colours";
            this.tab_modify_colours.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1140, 605);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.picbx_Original, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.picbx_result, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 307);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1132, 293);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // picbx_Original
            // 
            this.picbx_Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_Original.InitialImage = global::Acrostograph.Properties.Resources.image;
            this.picbx_Original.Location = new System.Drawing.Point(4, 5);
            this.picbx_Original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_Original.Name = "picbx_Original";
            this.picbx_Original.Size = new System.Drawing.Size(558, 283);
            this.picbx_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_Original.TabIndex = 3;
            this.picbx_Original.TabStop = false;
            // 
            // picbx_result
            // 
            this.picbx_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_result.Location = new System.Drawing.Point(570, 5);
            this.picbx_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_result.Name = "picbx_result";
            this.picbx_result.Size = new System.Drawing.Size(558, 283);
            this.picbx_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_result.TabIndex = 4;
            this.picbx_result.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_filters);
            this.tabControl2.Controls.Add(this.tab_history);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1134, 296);
            this.tabControl2.TabIndex = 2;
            // 
            // tab_filters
            // 
            this.tab_filters.Controls.Add(this.tableLayoutPanel5);
            this.tab_filters.Location = new System.Drawing.Point(4, 29);
            this.tab_filters.Name = "tab_filters";
            this.tab_filters.Padding = new System.Windows.Forms.Padding(3);
            this.tab_filters.Size = new System.Drawing.Size(1126, 263);
            this.tab_filters.TabIndex = 1;
            this.tab_filters.Text = "Filters";
            this.tab_filters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel16, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1120, 257);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_ColourFiltersData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 191);
            this.panel3.TabIndex = 0;
            // 
            // dgv_ColourFiltersData
            // 
            this.dgv_ColourFiltersData.AllowUserToAddRows = false;
            this.dgv_ColourFiltersData.AllowUserToDeleteRows = false;
            this.dgv_ColourFiltersData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ColourFiltersData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ColourFiltersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ColourFiltersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ColourFiltersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_ColourFiltersData_RedByte,
            this.dgv_ColourFiltersData_GreenByte,
            this.dgv_ColourFiltersData_BlueByte,
            this.dgv_ColourFiltersData_AlphaByte,
            this.dgv_ColourFiltersData_Brightness});
            this.dgv_ColourFiltersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ColourFiltersData.Location = new System.Drawing.Point(0, 0);
            this.dgv_ColourFiltersData.Name = "dgv_ColourFiltersData";
            this.dgv_ColourFiltersData.RowHeadersWidth = 62;
            this.dgv_ColourFiltersData.RowTemplate.Height = 28;
            this.dgv_ColourFiltersData.Size = new System.Drawing.Size(666, 191);
            this.dgv_ColourFiltersData.TabIndex = 0;
            // 
            // dgv_ColourFiltersData_RedByte
            // 
            this.dgv_ColourFiltersData_RedByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ColourFiltersData_RedByte.HeaderText = "Red Byte";
            this.dgv_ColourFiltersData_RedByte.MinimumWidth = 8;
            this.dgv_ColourFiltersData_RedByte.Name = "dgv_ColourFiltersData_RedByte";
            this.dgv_ColourFiltersData_RedByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_ColourFiltersData_GreenByte
            // 
            this.dgv_ColourFiltersData_GreenByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ColourFiltersData_GreenByte.HeaderText = "Green Byte";
            this.dgv_ColourFiltersData_GreenByte.MinimumWidth = 8;
            this.dgv_ColourFiltersData_GreenByte.Name = "dgv_ColourFiltersData_GreenByte";
            this.dgv_ColourFiltersData_GreenByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_ColourFiltersData_BlueByte
            // 
            this.dgv_ColourFiltersData_BlueByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ColourFiltersData_BlueByte.HeaderText = "Blue Byte";
            this.dgv_ColourFiltersData_BlueByte.MinimumWidth = 8;
            this.dgv_ColourFiltersData_BlueByte.Name = "dgv_ColourFiltersData_BlueByte";
            this.dgv_ColourFiltersData_BlueByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_ColourFiltersData_AlphaByte
            // 
            this.dgv_ColourFiltersData_AlphaByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ColourFiltersData_AlphaByte.HeaderText = "Alpha Byte";
            this.dgv_ColourFiltersData_AlphaByte.MinimumWidth = 8;
            this.dgv_ColourFiltersData_AlphaByte.Name = "dgv_ColourFiltersData_AlphaByte";
            this.dgv_ColourFiltersData_AlphaByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_ColourFiltersData_Brightness
            // 
            this.dgv_ColourFiltersData_Brightness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_ColourFiltersData_Brightness.HeaderText = "Brightness";
            this.dgv_ColourFiltersData_Brightness.MinimumWidth = 8;
            this.dgv_ColourFiltersData_Brightness.Name = "dgv_ColourFiltersData_Brightness";
            this.dgv_ColourFiltersData_Brightness.ReadOnly = true;
            this.dgv_ColourFiltersData_Brightness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(675, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 191);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(442, 191);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel15);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 32);
            this.panel5.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cmbobx_ColourFilters);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(436, 32);
            this.panel15.TabIndex = 0;
            // 
            // cmbobx_ColourFilters
            // 
            this.cmbobx_ColourFilters.FormattingEnabled = true;
            this.cmbobx_ColourFilters.Location = new System.Drawing.Point(3, 0);
            this.cmbobx_ColourFilters.Name = "cmbobx_ColourFilters";
            this.cmbobx_ColourFilters.Size = new System.Drawing.Size(423, 28);
            this.cmbobx_ColourFilters.Sorted = true;
            this.cmbobx_ColourFilters.TabIndex = 0;
            this.cmbobx_ColourFilters.SelectedIndexChanged += new System.EventHandler(this.cmbobx_ColourFilters_SelectedIndexChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel7.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel9, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.panel10, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel11, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel12, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.panel26, 5, 4);
            this.tableLayoutPanel7.Controls.Add(this.panel27, 3, 4);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(436, 147);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chkbx_Superimpose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(294, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 39);
            this.panel6.TabIndex = 6;
            // 
            // chkbx_Superimpose
            // 
            this.chkbx_Superimpose.AutoSize = true;
            this.chkbx_Superimpose.Location = new System.Drawing.Point(3, 11);
            this.chkbx_Superimpose.Name = "chkbx_Superimpose";
            this.chkbx_Superimpose.Size = new System.Drawing.Size(129, 24);
            this.chkbx_Superimpose.TabIndex = 3;
            this.chkbx_Superimpose.Text = "Superimpose";
            this.chkbx_Superimpose.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_apply_filter);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(8, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(132, 39);
            this.panel7.TabIndex = 7;
            // 
            // btn_apply_filter
            // 
            this.btn_apply_filter.Location = new System.Drawing.Point(3, 1);
            this.btn_apply_filter.Name = "btn_apply_filter";
            this.btn_apply_filter.Size = new System.Drawing.Size(126, 35);
            this.btn_apply_filter.TabIndex = 7;
            this.btn_apply_filter.Text = "Apply Filter";
            this.btn_apply_filter.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_reset);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(151, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(132, 39);
            this.panel8.TabIndex = 8;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(17, 8);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 28);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.chkbx_save_history);
            this.panel9.Controls.Add(this.lbl_filter_name);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(8, 103);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(132, 41);
            this.panel9.TabIndex = 9;
            // 
            // chkbx_save_history
            // 
            this.chkbx_save_history.AutoSize = true;
            this.chkbx_save_history.Location = new System.Drawing.Point(3, 8);
            this.chkbx_save_history.Name = "chkbx_save_history";
            this.chkbx_save_history.Size = new System.Drawing.Size(124, 24);
            this.chkbx_save_history.TabIndex = 4;
            this.chkbx_save_history.Text = "Save History";
            this.chkbx_save_history.UseVisualStyleBackColor = true;
            // 
            // lbl_filter_name
            // 
            this.lbl_filter_name.AutoSize = true;
            this.lbl_filter_name.Location = new System.Drawing.Point(65, 19);
            this.lbl_filter_name.Name = "lbl_filter_name";
            this.lbl_filter_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_filter_name.TabIndex = 2;
            this.lbl_filter_name.Text = "label1";
            this.lbl_filter_name.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_delete_filter);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(294, 53);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(132, 39);
            this.panel10.TabIndex = 10;
            // 
            // btn_delete_filter
            // 
            this.btn_delete_filter.Location = new System.Drawing.Point(0, 3);
            this.btn_delete_filter.Name = "btn_delete_filter";
            this.btn_delete_filter.Size = new System.Drawing.Size(117, 36);
            this.btn_delete_filter.TabIndex = 4;
            this.btn_delete_filter.Text = "Delete Filter";
            this.btn_delete_filter.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_update_filter);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(151, 53);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(132, 39);
            this.panel11.TabIndex = 11;
            // 
            // btn_update_filter
            // 
            this.btn_update_filter.Location = new System.Drawing.Point(17, 8);
            this.btn_update_filter.Name = "btn_update_filter";
            this.btn_update_filter.Size = new System.Drawing.Size(93, 28);
            this.btn_update_filter.TabIndex = 5;
            this.btn_update_filter.Text = "Update Filter";
            this.btn_update_filter.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_add_filter);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(8, 53);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(132, 39);
            this.panel12.TabIndex = 12;
            // 
            // btn_add_filter
            // 
            this.btn_add_filter.Location = new System.Drawing.Point(3, 8);
            this.btn_add_filter.Name = "btn_add_filter";
            this.btn_add_filter.Size = new System.Drawing.Size(129, 35);
            this.btn_add_filter.TabIndex = 3;
            this.btn_add_filter.Text = "Add Filter";
            this.btn_add_filter.UseVisualStyleBackColor = true;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btn_adjust);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(294, 103);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(132, 41);
            this.panel26.TabIndex = 13;
            // 
            // btn_adjust
            // 
            this.btn_adjust.Location = new System.Drawing.Point(4, 1);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(113, 37);
            this.btn_adjust.TabIndex = 5;
            this.btn_adjust.Text = "Adjust";
            this.btn_adjust.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txtbx_adjust_value);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(151, 103);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(132, 41);
            this.panel27.TabIndex = 14;
            // 
            // txtbx_adjust_value
            // 
            this.txtbx_adjust_value.Location = new System.Drawing.Point(14, 8);
            this.txtbx_adjust_value.Name = "txtbx_adjust_value";
            this.txtbx_adjust_value.Size = new System.Drawing.Size(110, 26);
            this.txtbx_adjust_value.TabIndex = 0;
            this.txtbx_adjust_value.Text = "0";
            // 
            // panel16
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.panel16, 2);
            this.panel16.Controls.Add(this.tableLayoutPanel8);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 200);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1114, 54);
            this.panel16.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel19, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1114, 54);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btn_open_image);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(362, 48);
            this.panel17.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_backup_images);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(376, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(362, 48);
            this.panel18.TabIndex = 1;
            // 
            // btn_backup_images
            // 
            this.btn_backup_images.Location = new System.Drawing.Point(117, 6);
            this.btn_backup_images.Name = "btn_backup_images";
            this.btn_backup_images.Size = new System.Drawing.Size(141, 42);
            this.btn_backup_images.TabIndex = 8;
            this.btn_backup_images.Text = "Backup Images";
            this.btn_backup_images.UseVisualStyleBackColor = true;
            this.btn_backup_images.Click += new System.EventHandler(this.btn_backup_images_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btn_change_colour);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(749, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(362, 48);
            this.panel19.TabIndex = 2;
            // 
            // tab_history
            // 
            this.tab_history.Controls.Add(this.tableLayoutPanel12);
            this.tab_history.Location = new System.Drawing.Point(4, 29);
            this.tab_history.Name = "tab_history";
            this.tab_history.Padding = new System.Windows.Forms.Padding(3);
            this.tab_history.Size = new System.Drawing.Size(1126, 263);
            this.tab_history.TabIndex = 0;
            this.tab_history.Text = "History";
            this.tab_history.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel12.Controls.Add(this.panel28, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.panel29, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1120, 257);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.dgv_history);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(3, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(666, 251);
            this.panel28.TabIndex = 0;
            // 
            // dgv_history
            // 
            this.dgv_history.AllowUserToAddRows = false;
            this.dgv_history.AllowUserToDeleteRows = false;
            this.dgv_history.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_history.ColumnHeadersHeight = 34;
            this.dgv_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_history_RedByte,
            this.dgv_history_GreenByte,
            this.dgv_history_BlueByte,
            this.dgv_history_AlphaByte,
            this.dgv_history_Brightness,
            this.dgv_history_FilterName,
            this.dgv_history_Superimpose});
            this.dgv_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_history.Location = new System.Drawing.Point(0, 0);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowHeadersWidth = 62;
            this.dgv_history.RowTemplate.Height = 28;
            this.dgv_history.Size = new System.Drawing.Size(666, 251);
            this.dgv_history.TabIndex = 1;
            // 
            // dgv_history_RedByte
            // 
            this.dgv_history_RedByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_RedByte.HeaderText = "Red Byte";
            this.dgv_history_RedByte.MinimumWidth = 8;
            this.dgv_history_RedByte.Name = "dgv_history_RedByte";
            this.dgv_history_RedByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_history_GreenByte
            // 
            this.dgv_history_GreenByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_GreenByte.HeaderText = "Green Byte";
            this.dgv_history_GreenByte.MinimumWidth = 8;
            this.dgv_history_GreenByte.Name = "dgv_history_GreenByte";
            this.dgv_history_GreenByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_history_BlueByte
            // 
            this.dgv_history_BlueByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_BlueByte.HeaderText = "Blue Byte";
            this.dgv_history_BlueByte.MinimumWidth = 8;
            this.dgv_history_BlueByte.Name = "dgv_history_BlueByte";
            this.dgv_history_BlueByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_history_AlphaByte
            // 
            this.dgv_history_AlphaByte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_AlphaByte.HeaderText = "Alpha Byte";
            this.dgv_history_AlphaByte.MinimumWidth = 8;
            this.dgv_history_AlphaByte.Name = "dgv_history_AlphaByte";
            this.dgv_history_AlphaByte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_history_Brightness
            // 
            this.dgv_history_Brightness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_Brightness.HeaderText = "Brightness";
            this.dgv_history_Brightness.MinimumWidth = 8;
            this.dgv_history_Brightness.Name = "dgv_history_Brightness";
            this.dgv_history_Brightness.ReadOnly = true;
            this.dgv_history_Brightness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_history_FilterName
            // 
            this.dgv_history_FilterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_FilterName.HeaderText = "Filter Name";
            this.dgv_history_FilterName.MinimumWidth = 8;
            this.dgv_history_FilterName.Name = "dgv_history_FilterName";
            // 
            // dgv_history_Superimpose
            // 
            this.dgv_history_Superimpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_history_Superimpose.HeaderText = "Superimpose";
            this.dgv_history_Superimpose.MinimumWidth = 8;
            this.dgv_history_Superimpose.Name = "dgv_history_Superimpose";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.btn_open_history_file);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(675, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(442, 251);
            this.panel29.TabIndex = 1;
            // 
            // btn_open_history_file
            // 
            this.btn_open_history_file.Location = new System.Drawing.Point(62, 74);
            this.btn_open_history_file.Name = "btn_open_history_file";
            this.btn_open_history_file.Size = new System.Drawing.Size(88, 37);
            this.btn_open_history_file.TabIndex = 0;
            this.btn_open_history_file.Text = "Open";
            this.btn_open_history_file.UseVisualStyleBackColor = true;
            // 
            // tab_video_player
            // 
            this.tab_video_player.Controls.Add(this.tableLayoutPanel1);
            this.tab_video_player.Location = new System.Drawing.Point(4, 29);
            this.tab_video_player.Name = "tab_video_player";
            this.tab_video_player.Padding = new System.Windows.Forms.Padding(3);
            this.tab_video_player.Size = new System.Drawing.Size(1146, 611);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 605);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WinMediaPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 519);
            this.panel1.TabIndex = 0;
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(1134, 519);
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
            this.panel2.Location = new System.Drawing.Point(3, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 74);
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
            this.tab_image_maker.Size = new System.Drawing.Size(1146, 611);
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
            this.tab_video_maker.Size = new System.Drawing.Size(1146, 611);
            this.tab_video_maker.TabIndex = 3;
            this.tab_video_maker.Text = "Video Maker";
            this.tab_video_maker.UseVisualStyleBackColor = true;
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
            // tab_modify_frames
            // 
            this.tab_modify_frames.Controls.Add(this.btn_create_modified_video);
            this.tab_modify_frames.Controls.Add(this.lstbx_modify_frames_output);
            this.tab_modify_frames.Controls.Add(this.btn_clear_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_deleteline_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_movelinedown_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.btn_movelineup_modify_frames_output_rchtxbx);
            this.tab_modify_frames.Controls.Add(this.lbl_choosen_image);
            this.tab_modify_frames.Controls.Add(this.picbx_choosen_image);
            this.tab_modify_frames.Controls.Add(this.flowlayoutpnl_modfy_frames);
            this.tab_modify_frames.Controls.Add(this.btn_list_files);
            this.tab_modify_frames.Location = new System.Drawing.Point(4, 29);
            this.tab_modify_frames.Name = "tab_modify_frames";
            this.tab_modify_frames.Size = new System.Drawing.Size(1146, 611);
            this.tab_modify_frames.TabIndex = 4;
            this.tab_modify_frames.Text = "Modify Frames";
            this.tab_modify_frames.UseVisualStyleBackColor = true;
            // 
            // btn_create_modified_video
            // 
            this.btn_create_modified_video.Location = new System.Drawing.Point(495, 564);
            this.btn_create_modified_video.Name = "btn_create_modified_video";
            this.btn_create_modified_video.Size = new System.Drawing.Size(120, 38);
            this.btn_create_modified_video.TabIndex = 13;
            this.btn_create_modified_video.Text = "Create Video";
            this.btn_create_modified_video.UseVisualStyleBackColor = true;
            this.btn_create_modified_video.Click += new System.EventHandler(this.btn_create_modified_video_Click);
            // 
            // lstbx_modify_frames_output
            // 
            this.lstbx_modify_frames_output.FormattingEnabled = true;
            this.lstbx_modify_frames_output.ItemHeight = 20;
            this.lstbx_modify_frames_output.Location = new System.Drawing.Point(40, 28);
            this.lstbx_modify_frames_output.Name = "lstbx_modify_frames_output";
            this.lstbx_modify_frames_output.Size = new System.Drawing.Size(494, 164);
            this.lstbx_modify_frames_output.TabIndex = 12;
            // 
            // btn_clear_modify_frames_output_rchtxbx
            // 
            this.btn_clear_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(540, 176);
            this.btn_clear_modify_frames_output_rchtxbx.Name = "btn_clear_modify_frames_output_rchtxbx";
            this.btn_clear_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(75, 35);
            this.btn_clear_modify_frames_output_rchtxbx.TabIndex = 11;
            this.btn_clear_modify_frames_output_rchtxbx.Text = "Clear";
            this.btn_clear_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_clear_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_clear_modify_frames_output_rchtxbx_Click);
            // 
            // btn_deleteline_modify_frames_output_rchtxbx
            // 
            this.btn_deleteline_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteline_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 125);
            this.btn_deleteline_modify_frames_output_rchtxbx.Name = "btn_deleteline_modify_frames_output_rchtxbx";
            this.btn_deleteline_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 45);
            this.btn_deleteline_modify_frames_output_rchtxbx.TabIndex = 10;
            this.btn_deleteline_modify_frames_output_rchtxbx.Text = "→";
            this.btn_deleteline_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_deleteline_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_deleteline_modify_frames_output_rchtxbx_Click);
            // 
            // btn_movelinedown_modify_frames_output_rchtxbx
            // 
            this.btn_movelinedown_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movelinedown_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 74);
            this.btn_movelinedown_modify_frames_output_rchtxbx.Name = "btn_movelinedown_modify_frames_output_rchtxbx";
            this.btn_movelinedown_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 45);
            this.btn_movelinedown_modify_frames_output_rchtxbx.TabIndex = 9;
            this.btn_movelinedown_modify_frames_output_rchtxbx.Text = "↓";
            this.btn_movelinedown_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_movelinedown_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_movelinedown_modify_frames_output_rchtxbx_Click);
            // 
            // btn_movelineup_modify_frames_output_rchtxbx
            // 
            this.btn_movelineup_modify_frames_output_rchtxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movelineup_modify_frames_output_rchtxbx.Location = new System.Drawing.Point(556, 23);
            this.btn_movelineup_modify_frames_output_rchtxbx.Name = "btn_movelineup_modify_frames_output_rchtxbx";
            this.btn_movelineup_modify_frames_output_rchtxbx.Size = new System.Drawing.Size(45, 45);
            this.btn_movelineup_modify_frames_output_rchtxbx.TabIndex = 8;
            this.btn_movelineup_modify_frames_output_rchtxbx.Text = "↑";
            this.btn_movelineup_modify_frames_output_rchtxbx.UseVisualStyleBackColor = true;
            this.btn_movelineup_modify_frames_output_rchtxbx.Click += new System.EventHandler(this.btn_movelineup_modify_frames_output_rchtxbx_Click);
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
            // flowlayoutpnl_modfy_frames
            // 
            this.flowlayoutpnl_modfy_frames.AutoScroll = true;
            this.flowlayoutpnl_modfy_frames.Location = new System.Drawing.Point(652, 28);
            this.flowlayoutpnl_modfy_frames.Name = "flowlayoutpnl_modfy_frames";
            this.flowlayoutpnl_modfy_frames.Size = new System.Drawing.Size(491, 580);
            this.flowlayoutpnl_modfy_frames.TabIndex = 2;
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
            this.tabControl1.ResumeLayout(false);
            this.tab_modify_colours.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tab_filters.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColourFiltersData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.tab_history.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.panel29.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_open_image;
        private System.Windows.Forms.Button btn_change_colour;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_modify_colours;
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
        private System.Windows.Forms.FlowLayoutPanel flowlayoutpnl_modfy_frames;
        private System.Windows.Forms.PictureBox picbx_choosen_image;
        private System.Windows.Forms.Label lbl_choosen_image;
        private System.Windows.Forms.Button btn_clear_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_deleteline_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_movelinedown_modify_frames_output_rchtxbx;
        private System.Windows.Forms.Button btn_movelineup_modify_frames_output_rchtxbx;
        private System.Windows.Forms.ListBox lstbx_modify_frames_output;
        private System.Windows.Forms.Button btn_create_modified_video;
        private System.Windows.Forms.Button btn_backup_images;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox picbx_Original;
        private System.Windows.Forms.PictureBox picbx_result;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_filters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_ColourFiltersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ColourFiltersData_RedByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ColourFiltersData_GreenByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ColourFiltersData_BlueByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ColourFiltersData_AlphaByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ColourFiltersData_Brightness;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox cmbobx_ColourFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkbx_Superimpose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_apply_filter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox chkbx_save_history;
        private System.Windows.Forms.Label lbl_filter_name;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_delete_filter;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_update_filter;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_add_filter;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btn_adjust;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txtbx_adjust_value;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TabPage tab_history;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_RedByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_GreenByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_BlueByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_AlphaByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_Brightness;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_FilterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_history_Superimpose;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Button btn_open_history_file;
    }
}

