﻿namespace PrjHikariwoAnim
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Images");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cells");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Motion", 2, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panel_PreView = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exports = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpNowFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpCellList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpNowAttribute = new System.Windows.Forms.ToolStripMenuItem();
            this.ウインドウToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ImageList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Control = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Attribute = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CellList = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ToolBase = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AlingForm = new System.Windows.Forms.Button();
            this.checkBox_CellList = new System.Windows.Forms.CheckBox();
            this.checkBox_Attribute = new System.Windows.Forms.CheckBox();
            this.checkBox_Control = new System.Windows.Forms.CheckBox();
            this.checkBox_ImageList = new System.Windows.Forms.CheckBox();
            this.Spaceer1 = new System.Windows.Forms.Panel();
            this.checkBox_Snap = new System.Windows.Forms.CheckBox();
            this.HScrollBar_ZoomLevel = new System.Windows.Forms.HScrollBar();
            this.numericUpDown_Grid = new System.Windows.Forms.NumericUpDown();
            this.button_GridColor = new System.Windows.Forms.Button();
            this.checkBox_GridCheck = new System.Windows.Forms.CheckBox();
            this.button_CrossColor = new System.Windows.Forms.Button();
            this.checkBox_CrossBar = new System.Windows.Forms.CheckBox();
            this.panel_ProjectTree_base = new System.Windows.Forms.Panel();
            this.panel_Project_Bottom = new System.Windows.Forms.Panel();
            this.botton_Test = new System.Windows.Forms.Button();
            this.treeView_Project = new System.Windows.Forms.TreeView();
            this.imageList_Thumb = new System.Windows.Forms.ImageList(this.components);
            this.panel_ProjectTopBase = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SubMenu_Prpject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_BackColor = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_ToolBase.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grid)).BeginInit();
            this.panel_ProjectTree_base.SuspendLayout();
            this.panel_Project_Bottom.SuspendLayout();
            this.panel_ProjectTopBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.StatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 503);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(943, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(27, 17);
            this.StatusLabel.Text = "Test";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.StatusLabel2.Text = "Pos2";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // panel_PreView
            // 
            this.panel_PreView.AllowDrop = true;
            this.panel_PreView.BackColor = System.Drawing.Color.Black;
            this.panel_PreView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PreView.Location = new System.Drawing.Point(0, 30);
            this.panel_PreView.Margin = new System.Windows.Forms.Padding(0);
            this.panel_PreView.Name = "panel_PreView";
            this.panel_PreView.Size = new System.Drawing.Size(754, 449);
            this.panel_PreView.TabIndex = 2;
            this.panel_PreView.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelPreView_DragDrop);
            this.panel_PreView.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelPreView_DragEnter);
            this.panel_PreView.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPreView_Paint);
            this.panel_PreView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelPreView_MouseDown);
            this.panel_PreView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelPreView_MouseMove);
            this.panel_PreView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelPreView_MouseUp);
            this.panel_PreView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PanelPreView_MouseWheel);
            this.panel_PreView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PanelPreView_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ウインドウToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_New,
            this.ToolStripMenuItem_Load,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_exports});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ToolStripMenuItem_New
            // 
            this.ToolStripMenuItem_New.Name = "ToolStripMenuItem_New";
            this.ToolStripMenuItem_New.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_New.Text = "新規プロジェクト";
            // 
            // ToolStripMenuItem_Load
            // 
            this.ToolStripMenuItem_Load.Name = "ToolStripMenuItem_Load";
            this.ToolStripMenuItem_Load.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Load.Text = "プロジェクト読込";
            this.ToolStripMenuItem_Load.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Save.Text = "プロジェクト保存";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // ToolStripMenuItem_exports
            // 
            this.ToolStripMenuItem_exports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ExpNowFrame,
            this.ToolStripMenuItem_ExpCellList,
            this.ToolStripMenuItem_ExpNowAttribute});
            this.ToolStripMenuItem_exports.Name = "ToolStripMenuItem_exports";
            this.ToolStripMenuItem_exports.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_exports.Text = "Exports";
            // 
            // ToolStripMenuItem_ExpNowFrame
            // 
            this.ToolStripMenuItem_ExpNowFrame.Name = "ToolStripMenuItem_ExpNowFrame";
            this.ToolStripMenuItem_ExpNowFrame.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_ExpNowFrame.Text = "NowFrame";
            // 
            // ToolStripMenuItem_ExpCellList
            // 
            this.ToolStripMenuItem_ExpCellList.Name = "ToolStripMenuItem_ExpCellList";
            this.ToolStripMenuItem_ExpCellList.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_ExpCellList.Text = "CellList";
            // 
            // ToolStripMenuItem_ExpNowAttribute
            // 
            this.ToolStripMenuItem_ExpNowAttribute.Name = "ToolStripMenuItem_ExpNowAttribute";
            this.ToolStripMenuItem_ExpNowAttribute.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_ExpNowAttribute.Text = "NowAttribute";
            // 
            // ウインドウToolStripMenuItem
            // 
            this.ウインドウToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ImageList,
            this.ToolStripMenuItem_Control,
            this.ToolStripMenuItem_Attribute,
            this.ToolStripMenuItem_CellList});
            this.ウインドウToolStripMenuItem.Name = "ウインドウToolStripMenuItem";
            this.ウインドウToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ウインドウToolStripMenuItem.Text = "ウインドウ";
            // 
            // ToolStripMenuItem_ImageList
            // 
            this.ToolStripMenuItem_ImageList.CheckOnClick = true;
            this.ToolStripMenuItem_ImageList.Name = "ToolStripMenuItem_ImageList";
            this.ToolStripMenuItem_ImageList.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_ImageList.Text = "ImageList";
            this.ToolStripMenuItem_ImageList.Click += new System.EventHandler(this.TSMenu_ImageList_Click);
            // 
            // ToolStripMenuItem_Control
            // 
            this.ToolStripMenuItem_Control.CheckOnClick = true;
            this.ToolStripMenuItem_Control.Name = "ToolStripMenuItem_Control";
            this.ToolStripMenuItem_Control.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Control.Text = "Control";
            this.ToolStripMenuItem_Control.Click += new System.EventHandler(this.TSMenu_Control_Click);
            // 
            // ToolStripMenuItem_Attribute
            // 
            this.ToolStripMenuItem_Attribute.CheckOnClick = true;
            this.ToolStripMenuItem_Attribute.Name = "ToolStripMenuItem_Attribute";
            this.ToolStripMenuItem_Attribute.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Attribute.Text = "Attribute";
            this.ToolStripMenuItem_Attribute.Click += new System.EventHandler(this.TSMenu_Attribute_Click);
            // 
            // ToolStripMenuItem_CellList
            // 
            this.ToolStripMenuItem_CellList.Name = "ToolStripMenuItem_CellList";
            this.ToolStripMenuItem_CellList.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_CellList.Text = "CellList";
            this.ToolStripMenuItem_CellList.Click += new System.EventHandler(this.TSMenu_CellList_Click);
            // 
            // panel_ToolBase
            // 
            this.panel_ToolBase.BackColor = System.Drawing.SystemColors.Control;
            this.panel_ToolBase.Controls.Add(this.panel1);
            this.panel_ToolBase.Controls.Add(this.checkBox_Snap);
            this.panel_ToolBase.Controls.Add(this.HScrollBar_ZoomLevel);
            this.panel_ToolBase.Controls.Add(this.numericUpDown_Grid);
            this.panel_ToolBase.Controls.Add(this.button_GridColor);
            this.panel_ToolBase.Controls.Add(this.checkBox_GridCheck);
            this.panel_ToolBase.Controls.Add(this.button_CrossColor);
            this.panel_ToolBase.Controls.Add(this.checkBox_CrossBar);
            this.panel_ToolBase.Controls.Add(this.button_BackColor);
            this.panel_ToolBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ToolBase.Location = new System.Drawing.Point(0, 0);
            this.panel_ToolBase.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ToolBase.Name = "panel_ToolBase";
            this.panel_ToolBase.Size = new System.Drawing.Size(754, 30);
            this.panel_ToolBase.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_AlingForm);
            this.panel1.Controls.Add(this.checkBox_CellList);
            this.panel1.Controls.Add(this.checkBox_Attribute);
            this.panel1.Controls.Add(this.checkBox_Control);
            this.panel1.Controls.Add(this.checkBox_ImageList);
            this.panel1.Controls.Add(this.Spaceer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 30);
            this.panel1.TabIndex = 8;
            // 
            // button_AlingForm
            // 
            this.button_AlingForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AlingForm.Image = global::PrjHikariwoAnim.Properties.Resources.alingment;
            this.button_AlingForm.Location = new System.Drawing.Point(130, 0);
            this.button_AlingForm.Margin = new System.Windows.Forms.Padding(0);
            this.button_AlingForm.Name = "button_AlingForm";
            this.button_AlingForm.Size = new System.Drawing.Size(30, 30);
            this.button_AlingForm.TabIndex = 5;
            this.button_AlingForm.UseVisualStyleBackColor = true;
            this.button_AlingForm.Click += new System.EventHandler(this.Botton_AlingForm_Click);
            // 
            // checkBox_CellList
            // 
            this.checkBox_CellList.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_CellList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_CellList.Checked = true;
            this.checkBox_CellList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CellList.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_CellList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_CellList.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_CellList.Image = global::PrjHikariwoAnim.Properties.Resources.partslist;
            this.checkBox_CellList.Location = new System.Drawing.Point(100, 0);
            this.checkBox_CellList.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_CellList.Name = "checkBox_CellList";
            this.checkBox_CellList.Size = new System.Drawing.Size(30, 30);
            this.checkBox_CellList.TabIndex = 4;
            this.checkBox_CellList.UseVisualStyleBackColor = false;
            this.checkBox_CellList.CheckedChanged += new System.EventHandler(this.CB_CellList_CheckedChanged);
            // 
            // checkBox_Attribute
            // 
            this.checkBox_Attribute.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Attribute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_Attribute.Checked = true;
            this.checkBox_Attribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Attribute.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Attribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Attribute.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Attribute.Image = global::PrjHikariwoAnim.Properties.Resources.property;
            this.checkBox_Attribute.Location = new System.Drawing.Point(70, 0);
            this.checkBox_Attribute.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Attribute.Name = "checkBox_Attribute";
            this.checkBox_Attribute.Size = new System.Drawing.Size(30, 30);
            this.checkBox_Attribute.TabIndex = 3;
            this.checkBox_Attribute.UseVisualStyleBackColor = false;
            this.checkBox_Attribute.CheckedChanged += new System.EventHandler(this.CB_Attribute_CheckedChanged);
            // 
            // checkBox_Control
            // 
            this.checkBox_Control.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Control.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_Control.Checked = true;
            this.checkBox_Control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Control.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Control.Image = global::PrjHikariwoAnim.Properties.Resources.control;
            this.checkBox_Control.Location = new System.Drawing.Point(40, 0);
            this.checkBox_Control.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Control.Name = "checkBox_Control";
            this.checkBox_Control.Size = new System.Drawing.Size(30, 30);
            this.checkBox_Control.TabIndex = 2;
            this.checkBox_Control.UseVisualStyleBackColor = false;
            this.checkBox_Control.CheckedChanged += new System.EventHandler(this.CB_Control_CheckedChanged);
            // 
            // checkBox_ImageList
            // 
            this.checkBox_ImageList.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_ImageList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_ImageList.Checked = true;
            this.checkBox_ImageList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ImageList.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_ImageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ImageList.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_ImageList.Location = new System.Drawing.Point(10, 0);
            this.checkBox_ImageList.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_ImageList.Name = "checkBox_ImageList";
            this.checkBox_ImageList.Size = new System.Drawing.Size(30, 30);
            this.checkBox_ImageList.TabIndex = 0;
            this.checkBox_ImageList.Text = "絵";
            this.checkBox_ImageList.UseVisualStyleBackColor = false;
            this.checkBox_ImageList.CheckedChanged += new System.EventHandler(this.CB_ImageList_CheckedChanged);
            // 
            // Spaceer1
            // 
            this.Spaceer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Spaceer1.Location = new System.Drawing.Point(0, 0);
            this.Spaceer1.Name = "Spaceer1";
            this.Spaceer1.Size = new System.Drawing.Size(10, 30);
            this.Spaceer1.TabIndex = 1;
            // 
            // checkBox_Snap
            // 
            this.checkBox_Snap.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Snap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_Snap.BackgroundImage = global::PrjHikariwoAnim.Properties.Resources.magnet2;
            this.checkBox_Snap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox_Snap.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Snap.Location = new System.Drawing.Point(191, 0);
            this.checkBox_Snap.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Snap.Name = "checkBox_Snap";
            this.checkBox_Snap.Size = new System.Drawing.Size(30, 30);
            this.checkBox_Snap.TabIndex = 7;
            this.checkBox_Snap.UseVisualStyleBackColor = false;
            // 
            // HScrollBar_ZoomLevel
            // 
            this.HScrollBar_ZoomLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HScrollBar_ZoomLevel.LargeChange = 1;
            this.HScrollBar_ZoomLevel.Location = new System.Drawing.Point(674, 0);
            this.HScrollBar_ZoomLevel.Maximum = 80;
            this.HScrollBar_ZoomLevel.Minimum = 2;
            this.HScrollBar_ZoomLevel.Name = "HScrollBar_ZoomLevel";
            this.HScrollBar_ZoomLevel.Size = new System.Drawing.Size(80, 30);
            this.HScrollBar_ZoomLevel.TabIndex = 6;
            this.HScrollBar_ZoomLevel.Value = 10;
            this.HScrollBar_ZoomLevel.ValueChanged += new System.EventHandler(this.ZoomLevel_ValueChanged);
            // 
            // numericUpDown_Grid
            // 
            this.numericUpDown_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_Grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDown_Grid.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown_Grid.Location = new System.Drawing.Point(150, 0);
            this.numericUpDown_Grid.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown_Grid.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_Grid.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_Grid.Name = "numericUpDown_Grid";
            this.numericUpDown_Grid.Size = new System.Drawing.Size(41, 27);
            this.numericUpDown_Grid.TabIndex = 3;
            this.numericUpDown_Grid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Grid.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_GridColor
            // 
            this.button_GridColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_GridColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_GridColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GridColor.Location = new System.Drawing.Point(120, 0);
            this.button_GridColor.Name = "button_GridColor";
            this.button_GridColor.Size = new System.Drawing.Size(30, 30);
            this.button_GridColor.TabIndex = 5;
            this.button_GridColor.UseVisualStyleBackColor = false;
            this.button_GridColor.Click += new System.EventHandler(this.Button_Color_Click);
            // 
            // checkBox_GridCheck
            // 
            this.checkBox_GridCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_GridCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_GridCheck.BackgroundImage = global::PrjHikariwoAnim.Properties.Resources.grid;
            this.checkBox_GridCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox_GridCheck.Checked = true;
            this.checkBox_GridCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_GridCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_GridCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_GridCheck.Location = new System.Drawing.Point(90, 0);
            this.checkBox_GridCheck.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_GridCheck.Name = "checkBox_GridCheck";
            this.checkBox_GridCheck.Size = new System.Drawing.Size(30, 30);
            this.checkBox_GridCheck.TabIndex = 2;
            this.checkBox_GridCheck.UseVisualStyleBackColor = false;
            this.checkBox_GridCheck.Click += new System.EventHandler(this.CrossBarCheck_Click);
            // 
            // button_CrossColor
            // 
            this.button_CrossColor.BackColor = System.Drawing.Color.DarkRed;
            this.button_CrossColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CrossColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CrossColor.Location = new System.Drawing.Point(60, 0);
            this.button_CrossColor.Name = "button_CrossColor";
            this.button_CrossColor.Size = new System.Drawing.Size(30, 30);
            this.button_CrossColor.TabIndex = 4;
            this.button_CrossColor.UseVisualStyleBackColor = false;
            this.button_CrossColor.Click += new System.EventHandler(this.Button_Color_Click);
            // 
            // checkBox_CrossBar
            // 
            this.checkBox_CrossBar.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_CrossBar.AutoSize = true;
            this.checkBox_CrossBar.BackColor = System.Drawing.Color.Black;
            this.checkBox_CrossBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox_CrossBar.Checked = true;
            this.checkBox_CrossBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CrossBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_CrossBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_CrossBar.Image = global::PrjHikariwoAnim.Properties.Resources.cross;
            this.checkBox_CrossBar.Location = new System.Drawing.Point(30, 0);
            this.checkBox_CrossBar.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_CrossBar.Name = "checkBox_CrossBar";
            this.checkBox_CrossBar.Size = new System.Drawing.Size(30, 30);
            this.checkBox_CrossBar.TabIndex = 1;
            this.checkBox_CrossBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_CrossBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBox_CrossBar.UseVisualStyleBackColor = false;
            this.checkBox_CrossBar.Click += new System.EventHandler(this.CrossBarCheck_Click);
            // 
            // panel_ProjectTree_base
            // 
            this.panel_ProjectTree_base.BackColor = System.Drawing.Color.Black;
            this.panel_ProjectTree_base.Controls.Add(this.panel_Project_Bottom);
            this.panel_ProjectTree_base.Controls.Add(this.treeView_Project);
            this.panel_ProjectTree_base.Controls.Add(this.panel_ProjectTopBase);
            this.panel_ProjectTree_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ProjectTree_base.Location = new System.Drawing.Point(0, 0);
            this.panel_ProjectTree_base.Name = "panel_ProjectTree_base";
            this.panel_ProjectTree_base.Size = new System.Drawing.Size(185, 479);
            this.panel_ProjectTree_base.TabIndex = 5;
            // 
            // panel_Project_Bottom
            // 
            this.panel_Project_Bottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_Project_Bottom.Controls.Add(this.botton_Test);
            this.panel_Project_Bottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Project_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Project_Bottom.Location = new System.Drawing.Point(0, 345);
            this.panel_Project_Bottom.Name = "panel_Project_Bottom";
            this.panel_Project_Bottom.Size = new System.Drawing.Size(185, 134);
            this.panel_Project_Bottom.TabIndex = 2;
            // 
            // botton_Test
            // 
            this.botton_Test.Location = new System.Drawing.Point(3, 3);
            this.botton_Test.Name = "botton_Test";
            this.botton_Test.Size = new System.Drawing.Size(78, 23);
            this.botton_Test.TabIndex = 0;
            this.botton_Test.Text = "Img+Test";
            this.botton_Test.UseVisualStyleBackColor = true;
            this.botton_Test.Click += new System.EventHandler(this.BottonTest_Click);
            // 
            // treeView_Project
            // 
            this.treeView_Project.BackColor = System.Drawing.Color.Black;
            this.treeView_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Project.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeView_Project.ForeColor = System.Drawing.Color.White;
            this.treeView_Project.FullRowSelect = true;
            this.treeView_Project.HotTracking = true;
            this.treeView_Project.ImageIndex = 0;
            this.treeView_Project.ImageList = this.imageList_Thumb;
            this.treeView_Project.LabelEdit = true;
            this.treeView_Project.Location = new System.Drawing.Point(0, 30);
            this.treeView_Project.Name = "treeView_Project";
            treeNode1.Name = "Images";
            treeNode1.Text = "Images";
            treeNode2.Name = "Cells";
            treeNode2.Text = "Cells";
            treeNode3.Name = "ProjectName";
            treeNode3.Text = "Project";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Motion";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Tag = "1";
            treeNode4.Text = "Motion";
            this.treeView_Project.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView_Project.SelectedImageIndex = 0;
            this.treeView_Project.ShowRootLines = false;
            this.treeView_Project.Size = new System.Drawing.Size(185, 449);
            this.treeView_Project.TabIndex = 1;
            this.treeView_Project.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_Project_AfterLabelEdit);
            this.treeView_Project.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Project_NodeMouseClick);
            // 
            // imageList_Thumb
            // 
            this.imageList_Thumb.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Thumb.ImageStream")));
            this.imageList_Thumb.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Thumb.Images.SetKeyName(0, "cells.PNG");
            this.imageList_Thumb.Images.SetKeyName(1, "image.PNG");
            this.imageList_Thumb.Images.SetKeyName(2, "motion.PNG");
            this.imageList_Thumb.Images.SetKeyName(3, "elements.PNG");
            this.imageList_Thumb.Images.SetKeyName(4, "elements2.PNG");
            // 
            // panel_ProjectTopBase
            // 
            this.panel_ProjectTopBase.Controls.Add(this.button1);
            this.panel_ProjectTopBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ProjectTopBase.Location = new System.Drawing.Point(0, 0);
            this.panel_ProjectTopBase.Name = "panel_ProjectTopBase";
            this.panel_ProjectTopBase.Size = new System.Drawing.Size(185, 30);
            this.panel_ProjectTopBase.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "+Motion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_MotionAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_ProjectTree_base);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_PreView);
            this.splitContainer1.Panel2.Controls.Add(this.panel_ToolBase);
            this.splitContainer1.Size = new System.Drawing.Size(943, 479);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 6;
            // 
            // SubMenu_Prpject
            // 
            this.SubMenu_Prpject.Name = "SubMenu_Prpject";
            this.SubMenu_Prpject.ShowImageMargin = false;
            this.SubMenu_Prpject.Size = new System.Drawing.Size(36, 4);
            // 
            // button_BackColor
            // 
            this.button_BackColor.BackColor = System.Drawing.Color.Black;
            this.button_BackColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_BackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackColor.Location = new System.Drawing.Point(0, 0);
            this.button_BackColor.Name = "button_BackColor";
            this.button_BackColor.Size = new System.Drawing.Size(30, 30);
            this.button_BackColor.TabIndex = 9;
            this.button_BackColor.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 525);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::PrjHikariwoAnim.Properties.Settings.Default, "FormMainLocate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = global::PrjHikariwoAnim.Properties.Settings.Default.FormMainLocate;
            this.Name = "FormMain";
            this.Text = "PrjHikariwoAnim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_ToolBase.ResumeLayout(false);
            this.panel_ToolBase.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grid)).EndInit();
            this.panel_ProjectTree_base.ResumeLayout(false);
            this.panel_Project_Bottom.ResumeLayout(false);
            this.panel_ProjectTopBase.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Panel panel_PreView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ウインドウToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ImageList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Control;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Attribute;
        private System.Windows.Forms.Panel panel_ToolBase;
        private System.Windows.Forms.CheckBox checkBox_Snap;
        private System.Windows.Forms.HScrollBar HScrollBar_ZoomLevel;
        private System.Windows.Forms.NumericUpDown numericUpDown_Grid;
        private System.Windows.Forms.Button button_GridColor;
        private System.Windows.Forms.CheckBox checkBox_GridCheck;
        private System.Windows.Forms.Button button_CrossColor;
        private System.Windows.Forms.CheckBox checkBox_CrossBar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CellList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Spaceer1;
        private System.Windows.Forms.Button button_AlingForm;
        private System.Windows.Forms.Panel panel_ProjectTree_base;
        private System.Windows.Forms.Panel panel_Project_Bottom;
        private System.Windows.Forms.TreeView treeView_Project;
        private System.Windows.Forms.Panel panel_ProjectTopBase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip SubMenu_Prpject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Load;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button botton_Test;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ImageList imageList_Thumb;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exports;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpNowFrame;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpCellList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpNowAttribute;
        public System.Windows.Forms.CheckBox checkBox_CellList;
        public System.Windows.Forms.CheckBox checkBox_Attribute;
        public System.Windows.Forms.CheckBox checkBox_Control;
        public System.Windows.Forms.CheckBox checkBox_ImageList;
        private System.Windows.Forms.Button button_BackColor;
    }
}

