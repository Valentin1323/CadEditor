﻿namespace CadEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bigBlocks = new System.Windows.Forms.ImageList(this.components);
            this.blocksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mapScreen = new System.Windows.Forms.PictureBox();
            this.activeBlock = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbActiveBlock = new System.Windows.Forms.Label();
            this.smallBlocks = new System.Windows.Forms.ImageList(this.components);
            this.btEdit = new System.Windows.Forms.Button();
            this.btEditObjs = new System.Windows.Forms.Button();
            this.btEditLayout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbScreenNo = new System.Windows.Forms.ComboBox();
            this.btEditEnemy = new System.Windows.Forms.Button();
            this.cbShowNeighborns = new System.Windows.Forms.CheckBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.pnGeneric = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaletteNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBlockNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBigBlockNo = new System.Windows.Forms.ComboBox();
            this.cbVideoNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCad = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDoor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.cbViewType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnEditors = new System.Windows.Forms.Panel();
            this.btEditMap = new System.Windows.Forms.Button();
            this.btVideo = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.cbShowAxis = new System.Windows.Forms.CheckBox();
            this.btHex = new System.Windows.Forms.Button();
            this.smallBlocks1 = new System.Windows.Forms.ImageList(this.components);
            this.smallBlocks2 = new System.Windows.Forms.ImageList(this.components);
            this.smallBlocks3 = new System.Windows.Forms.ImageList(this.components);
            this.smallBlocks4 = new System.Windows.Forms.ImageList(this.components);
            this.pnView = new System.Windows.Forms.Panel();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCoords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBlock)).BeginInit();
            this.pnGeneric.SuspendLayout();
            this.pnCad.SuspendLayout();
            this.pnEditors.SuspendLayout();
            this.pnView.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigBlocks
            // 
            this.bigBlocks.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.bigBlocks.ImageSize = new System.Drawing.Size(64, 64);
            this.bigBlocks.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // blocksPanel
            // 
            this.blocksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blocksPanel.AutoScroll = true;
            this.blocksPanel.Location = new System.Drawing.Point(12, 12);
            this.blocksPanel.Name = "blocksPanel";
            this.blocksPanel.Size = new System.Drawing.Size(324, 503);
            this.blocksPanel.TabIndex = 2;
            // 
            // mapScreen
            // 
            this.mapScreen.Location = new System.Drawing.Point(0, 0);
            this.mapScreen.Name = "mapScreen";
            this.mapScreen.Size = new System.Drawing.Size(640, 512);
            this.mapScreen.TabIndex = 4;
            this.mapScreen.TabStop = false;
            this.mapScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.mapScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseClick);
            this.mapScreen.MouseLeave += new System.EventHandler(this.mapScreen_MouseLeave);
            this.mapScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapScreen_MouseMove);
            // 
            // activeBlock
            // 
            this.activeBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeBlock.Location = new System.Drawing.Point(339, 28);
            this.activeBlock.Name = "activeBlock";
            this.activeBlock.Size = new System.Drawing.Size(64, 64);
            this.activeBlock.TabIndex = 5;
            this.activeBlock.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.Location = new System.Drawing.Point(12, 521);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(64, 22);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbActiveBlock
            // 
            this.lbActiveBlock.AutoSize = true;
            this.lbActiveBlock.Location = new System.Drawing.Point(339, 12);
            this.lbActiveBlock.Name = "lbActiveBlock";
            this.lbActiveBlock.Size = new System.Drawing.Size(49, 13);
            this.lbActiveBlock.TabIndex = 16;
            this.lbActiveBlock.Text = "Active: ()";
            // 
            // smallBlocks
            // 
            this.smallBlocks.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.smallBlocks.ImageSize = new System.Drawing.Size(16, 16);
            this.smallBlocks.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(3, 0);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(64, 34);
            this.btEdit.TabIndex = 18;
            this.btEdit.Text = "edit macro blocks";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // btEditObjs
            // 
            this.btEditObjs.Location = new System.Drawing.Point(3, 33);
            this.btEditObjs.Name = "btEditObjs";
            this.btEditObjs.Size = new System.Drawing.Size(64, 34);
            this.btEditObjs.TabIndex = 19;
            this.btEditObjs.Text = "edit blocks";
            this.btEditObjs.UseVisualStyleBackColor = true;
            this.btEditObjs.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // btEditLayout
            // 
            this.btEditLayout.Location = new System.Drawing.Point(3, 66);
            this.btEditLayout.Name = "btEditLayout";
            this.btEditLayout.Size = new System.Drawing.Size(64, 22);
            this.btEditLayout.TabIndex = 25;
            this.btEditLayout.Text = "edit layout";
            this.btEditLayout.UseVisualStyleBackColor = true;
            this.btEditLayout.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Screen No:";
            // 
            // cbScreenNo
            // 
            this.cbScreenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreenNo.FormattingEnabled = true;
            this.cbScreenNo.Location = new System.Drawing.Point(339, 111);
            this.cbScreenNo.Name = "cbScreenNo";
            this.cbScreenNo.Size = new System.Drawing.Size(64, 21);
            this.cbScreenNo.TabIndex = 27;
            this.cbScreenNo.SelectedIndexChanged += new System.EventHandler(this.cbScreenNo_SelectedIndexChanged);
            // 
            // btEditEnemy
            // 
            this.btEditEnemy.Location = new System.Drawing.Point(3, 87);
            this.btEditEnemy.Name = "btEditEnemy";
            this.btEditEnemy.Size = new System.Drawing.Size(64, 39);
            this.btEditEnemy.TabIndex = 31;
            this.btEditEnemy.Text = "edit enemies";
            this.btEditEnemy.UseVisualStyleBackColor = true;
            this.btEditEnemy.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // cbShowNeighborns
            // 
            this.cbShowNeighborns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowNeighborns.AutoSize = true;
            this.cbShowNeighborns.Checked = true;
            this.cbShowNeighborns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowNeighborns.Location = new System.Drawing.Point(936, 530);
            this.cbShowNeighborns.Name = "cbShowNeighborns";
            this.cbShowNeighborns.Size = new System.Drawing.Size(108, 17);
            this.cbShowNeighborns.TabIndex = 32;
            this.cbShowNeighborns.Text = "Show neighborns";
            this.cbShowNeighborns.UseVisualStyleBackColor = true;
            this.cbShowNeighborns.CheckedChanged += new System.EventHandler(this.cbShowNeighborns_CheckedChanged);
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpen.Location = new System.Drawing.Point(82, 521);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(63, 22);
            this.btOpen.TabIndex = 41;
            this.btOpen.Text = "open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // pnGeneric
            // 
            this.pnGeneric.Controls.Add(this.label9);
            this.pnGeneric.Controls.Add(this.cbPaletteNo);
            this.pnGeneric.Controls.Add(this.label8);
            this.pnGeneric.Controls.Add(this.cbBlockNo);
            this.pnGeneric.Controls.Add(this.label5);
            this.pnGeneric.Controls.Add(this.cbBigBlockNo);
            this.pnGeneric.Controls.Add(this.cbVideoNo);
            this.pnGeneric.Controls.Add(this.label1);
            this.pnGeneric.Location = new System.Drawing.Point(337, 178);
            this.pnGeneric.Name = "pnGeneric";
            this.pnGeneric.Size = new System.Drawing.Size(72, 162);
            this.pnGeneric.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Pallete:";
            // 
            // cbPaletteNo
            // 
            this.cbPaletteNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteNo.FormattingEnabled = true;
            this.cbPaletteNo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbPaletteNo.Location = new System.Drawing.Point(6, 139);
            this.cbPaletteNo.Name = "cbPaletteNo";
            this.cbPaletteNo.Size = new System.Drawing.Size(64, 21);
            this.cbPaletteNo.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Block:";
            // 
            // cbBlockNo
            // 
            this.cbBlockNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlockNo.FormattingEnabled = true;
            this.cbBlockNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbBlockNo.Location = new System.Drawing.Point(6, 99);
            this.cbBlockNo.Name = "cbBlockNo";
            this.cbBlockNo.Size = new System.Drawing.Size(64, 21);
            this.cbBlockNo.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "BigBlock:";
            // 
            // cbBigBlockNo
            // 
            this.cbBigBlockNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBigBlockNo.FormattingEnabled = true;
            this.cbBigBlockNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbBigBlockNo.Location = new System.Drawing.Point(6, 59);
            this.cbBigBlockNo.Name = "cbBigBlockNo";
            this.cbBigBlockNo.Size = new System.Drawing.Size(64, 21);
            this.cbBigBlockNo.TabIndex = 43;
            // 
            // cbVideoNo
            // 
            this.cbVideoNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoNo.FormattingEnabled = true;
            this.cbVideoNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbVideoNo.Location = new System.Drawing.Point(5, 19);
            this.cbVideoNo.Name = "cbVideoNo";
            this.cbVideoNo.Size = new System.Drawing.Size(64, 21);
            this.cbVideoNo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "VideoBlock:";
            // 
            // pnCad
            // 
            this.pnCad.Controls.Add(this.label7);
            this.pnCad.Controls.Add(this.cbDoor);
            this.pnCad.Controls.Add(this.label2);
            this.pnCad.Controls.Add(this.cbLevel);
            this.pnCad.Location = new System.Drawing.Point(337, 178);
            this.pnCad.Name = "pnCad";
            this.pnCad.Size = new System.Drawing.Size(72, 93);
            this.pnCad.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Door:";
            // 
            // cbDoor
            // 
            this.cbDoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoor.FormattingEnabled = true;
            this.cbDoor.Items.AddRange(new object[] {
            "None",
            "Door 1",
            "Door 2",
            "Door 3",
            "Door 4",
            "Door 5",
            "Door 6",
            "Door 7",
            "Door 8",
            "Door 9",
            "Door A",
            "Door B",
            "Door C",
            "Door D",
            "Door E",
            "Door F",
            "Door 10",
            "Door 11",
            "Door 12",
            "Door 13",
            "Door 14",
            "Door 15",
            "Door 16",
            "Door 17",
            "Door 18",
            "Door 19"});
            this.cbDoor.Location = new System.Drawing.Point(7, 61);
            this.cbDoor.Name = "cbDoor";
            this.cbDoor.Size = new System.Drawing.Size(64, 21);
            this.cbDoor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "View as:";
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Level 0",
            "Level A",
            "Level B",
            "Level C",
            "Level D",
            "Level E",
            "Level F",
            "Level G",
            "Level H",
            "Level I",
            "Level J"});
            this.cbLevel.Location = new System.Drawing.Point(6, 21);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(64, 21);
            this.cbLevel.TabIndex = 31;
            // 
            // cbViewType
            // 
            this.cbViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewType.DropDownWidth = 128;
            this.cbViewType.FormattingEnabled = true;
            this.cbViewType.Items.AddRange(new object[] {
            "Tiles",
            "Obj types",
            "Obj numbers"});
            this.cbViewType.Location = new System.Drawing.Point(339, 151);
            this.cbViewType.Name = "cbViewType";
            this.cbViewType.Size = new System.Drawing.Size(64, 21);
            this.cbViewType.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "View type:";
            // 
            // pnEditors
            // 
            this.pnEditors.Controls.Add(this.btEditMap);
            this.pnEditors.Controls.Add(this.btVideo);
            this.pnEditors.Controls.Add(this.btEdit);
            this.pnEditors.Controls.Add(this.btEditObjs);
            this.pnEditors.Controls.Add(this.btEditLayout);
            this.pnEditors.Controls.Add(this.btEditEnemy);
            this.pnEditors.Location = new System.Drawing.Point(338, 346);
            this.pnEditors.Name = "pnEditors";
            this.pnEditors.Size = new System.Drawing.Size(72, 198);
            this.pnEditors.TabIndex = 46;
            // 
            // btEditMap
            // 
            this.btEditMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditMap.Location = new System.Drawing.Point(3, 161);
            this.btEditMap.Name = "btEditMap";
            this.btEditMap.Size = new System.Drawing.Size(62, 22);
            this.btEditMap.TabIndex = 57;
            this.btEditMap.Text = "edit map";
            this.btEditMap.UseVisualStyleBackColor = true;
            this.btEditMap.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // btVideo
            // 
            this.btVideo.Location = new System.Drawing.Point(3, 125);
            this.btVideo.Name = "btVideo";
            this.btVideo.Size = new System.Drawing.Size(64, 34);
            this.btVideo.TabIndex = 32;
            this.btVideo.Text = "view video";
            this.btVideo.UseVisualStyleBackColor = true;
            this.btVideo.Click += new System.EventHandler(this.btSubeditor_Click);
            // 
            // btExport
            // 
            this.btExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExport.Location = new System.Drawing.Point(193, 521);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(64, 22);
            this.btExport.TabIndex = 49;
            this.btExport.Text = "export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImport.Location = new System.Drawing.Point(263, 521);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(64, 22);
            this.btImport.TabIndex = 50;
            this.btImport.Text = "import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // cbShowAxis
            // 
            this.cbShowAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowAxis.AutoSize = true;
            this.cbShowAxis.Checked = true;
            this.cbShowAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowAxis.Location = new System.Drawing.Point(856, 530);
            this.cbShowAxis.Name = "cbShowAxis";
            this.cbShowAxis.Size = new System.Drawing.Size(74, 17);
            this.cbShowAxis.TabIndex = 51;
            this.cbShowAxis.Text = "Show axis";
            this.cbShowAxis.UseVisualStyleBackColor = true;
            this.cbShowAxis.CheckedChanged += new System.EventHandler(this.cbShowAxis_CheckedChanged);
            // 
            // btHex
            // 
            this.btHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btHex.Location = new System.Drawing.Point(684, 526);
            this.btHex.Name = "btHex";
            this.btHex.Size = new System.Drawing.Size(96, 22);
            this.btHex.TabIndex = 52;
            this.btHex.Text = "open hex editor";
            this.btHex.UseVisualStyleBackColor = true;
            this.btHex.Click += new System.EventHandler(this.btHex_Click);
            // 
            // smallBlocks1
            // 
            this.smallBlocks1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.smallBlocks1.ImageSize = new System.Drawing.Size(16, 16);
            this.smallBlocks1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallBlocks2
            // 
            this.smallBlocks2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.smallBlocks2.ImageSize = new System.Drawing.Size(16, 16);
            this.smallBlocks2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallBlocks3
            // 
            this.smallBlocks3.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.smallBlocks3.ImageSize = new System.Drawing.Size(16, 16);
            this.smallBlocks3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallBlocks4
            // 
            this.smallBlocks4.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.smallBlocks4.ImageSize = new System.Drawing.Size(16, 16);
            this.smallBlocks4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnView
            // 
            this.pnView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnView.AutoScroll = true;
            this.pnView.Controls.Add(this.mapScreen);
            this.pnView.Location = new System.Drawing.Point(412, 12);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(640, 512);
            this.pnView.TabIndex = 53;
            // 
            // cbScale
            // 
            this.cbScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScale.DropDownWidth = 128;
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbScale.Location = new System.Drawing.Point(495, 527);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(29, 21);
            this.cbScale.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Scale:";
            // 
            // lbCoords
            // 
            this.lbCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoords.AutoSize = true;
            this.lbCoords.Location = new System.Drawing.Point(530, 530);
            this.lbCoords.Name = "lbCoords";
            this.lbCoords.Size = new System.Drawing.Size(64, 13);
            this.lbCoords.TabIndex = 56;
            this.lbCoords.Text = "Coords:(0,0)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 552);
            this.Controls.Add(this.lbCoords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbScale);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.btHex);
            this.Controls.Add(this.cbShowAxis);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.pnEditors);
            this.Controls.Add(this.cbViewType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnGeneric);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.cbShowNeighborns);
            this.Controls.Add(this.cbScreenNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbActiveBlock);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.activeBlock);
            this.Controls.Add(this.blocksPanel);
            this.Controls.Add(this.pnCad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CAD Editor v2.4.1 by spiiin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBlock)).EndInit();
            this.pnGeneric.ResumeLayout(false);
            this.pnGeneric.PerformLayout();
            this.pnCad.ResumeLayout(false);
            this.pnCad.PerformLayout();
            this.pnEditors.ResumeLayout(false);
            this.pnView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel blocksPanel;
        private System.Windows.Forms.PictureBox mapScreen;
        private System.Windows.Forms.PictureBox activeBlock;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbActiveBlock;
        private System.Windows.Forms.ImageList bigBlocks;
        private System.Windows.Forms.ImageList smallBlocks;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btEditObjs;
        private System.Windows.Forms.Button btEditLayout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbScreenNo;
        private System.Windows.Forms.Button btEditEnemy;
        private System.Windows.Forms.CheckBox cbShowNeighborns;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Panel pnGeneric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPaletteNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBlockNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBigBlockNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVideoNo;
        private System.Windows.Forms.Panel pnCad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDoor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.ComboBox cbViewType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnEditors;
        private System.Windows.Forms.Button btVideo;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.CheckBox cbShowAxis;
        private System.Windows.Forms.Button btHex;
        private System.Windows.Forms.ImageList smallBlocks1;
        private System.Windows.Forms.ImageList smallBlocks2;
        private System.Windows.Forms.ImageList smallBlocks3;
        private System.Windows.Forms.ImageList smallBlocks4;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.ComboBox cbScale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCoords;
        private System.Windows.Forms.Button btEditMap;
    }
}

