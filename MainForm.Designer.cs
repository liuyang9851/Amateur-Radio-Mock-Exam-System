namespace HAM
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuScrip = new System.Windows.Forms.MenuStrip();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonA = new System.Windows.Forms.ToolStripMenuItem();
            this.BAP = new System.Windows.Forms.ToolStripMenuItem();
            this.APContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.APPositive = new System.Windows.Forms.ToolStripMenuItem();
            this.APRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.APNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.BAE = new System.Windows.Forms.ToolStripMenuItem();
            this.AEContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.AENew = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonB = new System.Windows.Forms.ToolStripMenuItem();
            this.BBP = new System.Windows.Forms.ToolStripMenuItem();
            this.BPContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.BPPositive = new System.Windows.Forms.ToolStripMenuItem();
            this.BPRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.BPNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.BBE = new System.Windows.Forms.ToolStripMenuItem();
            this.BEContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.BENew = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonC = new System.Windows.Forms.ToolStripMenuItem();
            this.BCP = new System.Windows.Forms.ToolStripMenuItem();
            this.CPContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.CPPositive = new System.Windows.Forms.ToolStripMenuItem();
            this.CPRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.CPNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.BPE = new System.Windows.Forms.ToolStripMenuItem();
            this.CEContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.CENew = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonD = new System.Windows.Forms.ToolStripMenuItem();
            this.DPContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.DPPositive = new System.Windows.Forms.ToolStripMenuItem();
            this.DPRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.DPNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CheckAnsButton = new System.Windows.Forms.Button();
            this.NextQuebutton = new System.Windows.Forms.Button();
            this.ChoDTextBox = new System.Windows.Forms.TextBox();
            this.ChoCTextBox = new System.Windows.Forms.TextBox();
            this.ChoBTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.QuePicBox = new System.Windows.Forms.PictureBox();
            this.QueTextBox = new System.Windows.Forms.RichTextBox();
            this.ChoATextBox = new System.Windows.Forms.TextBox();
            this.LastQueButton = new System.Windows.Forms.Button();
            this.QueChoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuScrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuScrip
            // 
            this.MenuScrip.Font = new System.Drawing.Font("等线 Light", 20F);
            this.MenuScrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuScrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.ButtonA,
            this.ButtonB,
            this.ButtonC,
            this.ButtonD,
            this.ButtonAbout});
            this.MenuScrip.Location = new System.Drawing.Point(0, 0);
            this.MenuScrip.Name = "MenuScrip";
            this.MenuScrip.Size = new System.Drawing.Size(1578, 49);
            this.MenuScrip.TabIndex = 3;
            this.MenuScrip.Text = "menuStrip1";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(270, 45);
            this.Save.Text = "保存当前进度";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ButtonA
            // 
            this.ButtonA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BAP,
            this.BAE});
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(175, 45);
            this.ButtonA.Text = "A类题库";
            // 
            // BAP
            // 
            this.BAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.APContinue,
            this.APPositive,
            this.APRandom,
            this.APNegative});
            this.BAP.Name = "BAP";
            this.BAP.Size = new System.Drawing.Size(256, 46);
            this.BAP.Text = "练习";
            // 
            // APContinue
            // 
            this.APContinue.Name = "APContinue";
            this.APContinue.Size = new System.Drawing.Size(256, 46);
            this.APContinue.Text = "继续练习";
            this.APContinue.Click += new System.EventHandler(this.PContinue_Click);
            // 
            // APPositive
            // 
            this.APPositive.Name = "APPositive";
            this.APPositive.Size = new System.Drawing.Size(256, 46);
            this.APPositive.Text = "正序练习";
            this.APPositive.Click += new System.EventHandler(this.PPositive_Click);
            // 
            // APRandom
            // 
            this.APRandom.Name = "APRandom";
            this.APRandom.Size = new System.Drawing.Size(256, 46);
            this.APRandom.Text = "随机练习";
            this.APRandom.Click += new System.EventHandler(this.PRandom_Click);
            // 
            // APNegative
            // 
            this.APNegative.Name = "APNegative";
            this.APNegative.Size = new System.Drawing.Size(256, 46);
            this.APNegative.Text = "倒序练习";
            this.APNegative.Click += new System.EventHandler(this.PNegaitve_Click);
            // 
            // BAE
            // 
            this.BAE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AEContinue,
            this.AENew});
            this.BAE.Name = "BAE";
            this.BAE.Size = new System.Drawing.Size(256, 46);
            this.BAE.Text = "模拟考试";
            // 
            // AEContinue
            // 
            this.AEContinue.Name = "AEContinue";
            this.AEContinue.Size = new System.Drawing.Size(256, 46);
            this.AEContinue.Text = "继续考试";
            this.AEContinue.Click += new System.EventHandler(this.EContinue_Click);
            // 
            // AENew
            // 
            this.AENew.Name = "AENew";
            this.AENew.Size = new System.Drawing.Size(256, 46);
            this.AENew.Text = "新的考试";
            this.AENew.Click += new System.EventHandler(this.ENew_Click);
            // 
            // ButtonB
            // 
            this.ButtonB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBP,
            this.BBE});
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(172, 45);
            this.ButtonB.Text = "B类题库";
            // 
            // BBP
            // 
            this.BBP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BPContinue,
            this.BPPositive,
            this.BPRandom,
            this.BPNegative});
            this.BBP.Name = "BBP";
            this.BBP.Size = new System.Drawing.Size(256, 46);
            this.BBP.Text = "练习";
            // 
            // BPContinue
            // 
            this.BPContinue.Name = "BPContinue";
            this.BPContinue.Size = new System.Drawing.Size(256, 46);
            this.BPContinue.Text = "继续练习";
            this.BPContinue.Click += new System.EventHandler(this.PContinue_Click);
            // 
            // BPPositive
            // 
            this.BPPositive.Name = "BPPositive";
            this.BPPositive.Size = new System.Drawing.Size(256, 46);
            this.BPPositive.Text = "正序练习";
            this.BPPositive.Click += new System.EventHandler(this.PPositive_Click);
            // 
            // BPRandom
            // 
            this.BPRandom.Name = "BPRandom";
            this.BPRandom.Size = new System.Drawing.Size(256, 46);
            this.BPRandom.Text = "随机练习";
            this.BPRandom.Click += new System.EventHandler(this.PRandom_Click);
            // 
            // BPNegative
            // 
            this.BPNegative.Name = "BPNegative";
            this.BPNegative.Size = new System.Drawing.Size(256, 46);
            this.BPNegative.Text = "倒序练习";
            this.BPNegative.Click += new System.EventHandler(this.PNegaitve_Click);
            // 
            // BBE
            // 
            this.BBE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BEContinue,
            this.BENew});
            this.BBE.Name = "BBE";
            this.BBE.Size = new System.Drawing.Size(256, 46);
            this.BBE.Text = "模拟考试";
            // 
            // BEContinue
            // 
            this.BEContinue.Name = "BEContinue";
            this.BEContinue.Size = new System.Drawing.Size(256, 46);
            this.BEContinue.Text = "继续考试";
            this.BEContinue.Click += new System.EventHandler(this.EContinue_Click);
            // 
            // BENew
            // 
            this.BENew.Name = "BENew";
            this.BENew.Size = new System.Drawing.Size(256, 46);
            this.BENew.Text = "新的考试";
            this.BENew.Click += new System.EventHandler(this.ENew_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BCP,
            this.BPE});
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(175, 45);
            this.ButtonC.Text = "C类题库";
            // 
            // BCP
            // 
            this.BCP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CPContinue,
            this.CPPositive,
            this.CPRandom,
            this.CPNegative});
            this.BCP.Name = "BCP";
            this.BCP.Size = new System.Drawing.Size(256, 46);
            this.BCP.Text = "练习";
            // 
            // CPContinue
            // 
            this.CPContinue.Name = "CPContinue";
            this.CPContinue.Size = new System.Drawing.Size(256, 46);
            this.CPContinue.Text = "继续练习";
            this.CPContinue.Click += new System.EventHandler(this.PContinue_Click);
            // 
            // CPPositive
            // 
            this.CPPositive.Name = "CPPositive";
            this.CPPositive.Size = new System.Drawing.Size(256, 46);
            this.CPPositive.Text = "正序练习";
            this.CPPositive.Click += new System.EventHandler(this.PPositive_Click);
            // 
            // CPRandom
            // 
            this.CPRandom.Name = "CPRandom";
            this.CPRandom.Size = new System.Drawing.Size(256, 46);
            this.CPRandom.Text = "随机练习";
            this.CPRandom.Click += new System.EventHandler(this.PRandom_Click);
            // 
            // CPNegative
            // 
            this.CPNegative.Name = "CPNegative";
            this.CPNegative.Size = new System.Drawing.Size(256, 46);
            this.CPNegative.Text = "倒序练习";
            this.CPNegative.Click += new System.EventHandler(this.PNegaitve_Click);
            // 
            // BPE
            // 
            this.BPE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CEContinue,
            this.CENew});
            this.BPE.Name = "BPE";
            this.BPE.Size = new System.Drawing.Size(256, 46);
            this.BPE.Text = "模拟考试";
            // 
            // CEContinue
            // 
            this.CEContinue.Name = "CEContinue";
            this.CEContinue.Size = new System.Drawing.Size(256, 46);
            this.CEContinue.Text = "继续考试";
            this.CEContinue.Click += new System.EventHandler(this.EContinue_Click);
            // 
            // CENew
            // 
            this.CENew.Name = "CENew";
            this.CENew.Size = new System.Drawing.Size(256, 46);
            this.CENew.Text = "新的考试";
            this.CENew.Click += new System.EventHandler(this.ENew_Click);
            // 
            // ButtonD
            // 
            this.ButtonD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DPContinue,
            this.DPPositive,
            this.DPRandom,
            this.DPNegative});
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(150, 45);
            this.ButtonD.Text = "总题库";
            // 
            // DPContinue
            // 
            this.DPContinue.Name = "DPContinue";
            this.DPContinue.Size = new System.Drawing.Size(256, 46);
            this.DPContinue.Text = "继续练习";
            this.DPContinue.Click += new System.EventHandler(this.PContinue_Click);
            // 
            // DPPositive
            // 
            this.DPPositive.Name = "DPPositive";
            this.DPPositive.Size = new System.Drawing.Size(256, 46);
            this.DPPositive.Text = "正序练习";
            this.DPPositive.Click += new System.EventHandler(this.PPositive_Click);
            // 
            // DPRandom
            // 
            this.DPRandom.Name = "DPRandom";
            this.DPRandom.Size = new System.Drawing.Size(256, 46);
            this.DPRandom.Text = "随机练习";
            this.DPRandom.Click += new System.EventHandler(this.PRandom_Click);
            // 
            // DPNegative
            // 
            this.DPNegative.Name = "DPNegative";
            this.DPNegative.Size = new System.Drawing.Size(256, 46);
            this.DPNegative.Text = "倒序练习";
            this.DPNegative.Click += new System.EventHandler(this.PNegaitve_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(110, 45);
            this.ButtonAbout.Text = "关于";
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CheckAnsButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NextQuebutton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ChoDTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ChoCTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ChoBTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChoATextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LastQueButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.QueChoPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1578, 1095);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitButton.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.Location = new System.Drawing.Point(1281, 998);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(294, 94);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CheckAnsButton
            // 
            this.CheckAnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckAnsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckAnsButton.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckAnsButton.Location = new System.Drawing.Point(1281, 898);
            this.CheckAnsButton.Name = "CheckAnsButton";
            this.CheckAnsButton.Size = new System.Drawing.Size(294, 94);
            this.CheckAnsButton.TabIndex = 12;
            this.CheckAnsButton.Text = "确定";
            this.CheckAnsButton.UseVisualStyleBackColor = true;
            this.CheckAnsButton.Click += new System.EventHandler(this.CheckAnsButton_Click);
            // 
            // NextQuebutton
            // 
            this.NextQuebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextQuebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextQuebutton.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextQuebutton.Location = new System.Drawing.Point(1281, 798);
            this.NextQuebutton.Name = "NextQuebutton";
            this.NextQuebutton.Size = new System.Drawing.Size(294, 94);
            this.NextQuebutton.TabIndex = 11;
            this.NextQuebutton.Text = "下一题";
            this.NextQuebutton.UseVisualStyleBackColor = true;
            this.NextQuebutton.Click += new System.EventHandler(this.NextQuebutton_Click);
            // 
            // ChoDTextBox
            // 
            this.ChoDTextBox.BackColor = System.Drawing.Color.White;
            this.ChoDTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoDTextBox.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoDTextBox.Location = new System.Drawing.Point(3, 998);
            this.ChoDTextBox.Multiline = true;
            this.ChoDTextBox.Name = "ChoDTextBox";
            this.ChoDTextBox.ReadOnly = true;
            this.ChoDTextBox.Size = new System.Drawing.Size(1272, 94);
            this.ChoDTextBox.TabIndex = 8;
            this.ChoDTextBox.TabStop = false;
            this.ChoDTextBox.Click += new System.EventHandler(this.ChoTextBox_Click);
            // 
            // ChoCTextBox
            // 
            this.ChoCTextBox.BackColor = System.Drawing.Color.White;
            this.ChoCTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoCTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoCTextBox.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoCTextBox.Location = new System.Drawing.Point(3, 898);
            this.ChoCTextBox.Multiline = true;
            this.ChoCTextBox.Name = "ChoCTextBox";
            this.ChoCTextBox.ReadOnly = true;
            this.ChoCTextBox.Size = new System.Drawing.Size(1272, 94);
            this.ChoCTextBox.TabIndex = 6;
            this.ChoCTextBox.TabStop = false;
            this.ChoCTextBox.Click += new System.EventHandler(this.ChoTextBox_Click);
            // 
            // ChoBTextBox
            // 
            this.ChoBTextBox.BackColor = System.Drawing.Color.White;
            this.ChoBTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoBTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoBTextBox.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoBTextBox.Location = new System.Drawing.Point(3, 798);
            this.ChoBTextBox.Multiline = true;
            this.ChoBTextBox.Name = "ChoBTextBox";
            this.ChoBTextBox.ReadOnly = true;
            this.ChoBTextBox.Size = new System.Drawing.Size(1272, 94);
            this.ChoBTextBox.TabIndex = 4;
            this.ChoBTextBox.TabStop = false;
            this.ChoBTextBox.Click += new System.EventHandler(this.ChoTextBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 689);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.QuePicBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.QueTextBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1272, 689);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // QuePicBox
            // 
            this.QuePicBox.BackColor = System.Drawing.Color.White;
            this.QuePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuePicBox.Location = new System.Drawing.Point(893, 3);
            this.QuePicBox.Name = "QuePicBox";
            this.QuePicBox.Size = new System.Drawing.Size(376, 683);
            this.QuePicBox.TabIndex = 1;
            this.QuePicBox.TabStop = false;
            // 
            // QueTextBox
            // 
            this.QueTextBox.DetectUrls = false;
            this.QueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueTextBox.Font = new System.Drawing.Font("等线 Light", 20F);
            this.QueTextBox.Location = new System.Drawing.Point(3, 3);
            this.QueTextBox.Name = "QueTextBox";
            this.QueTextBox.ReadOnly = true;
            this.QueTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QueTextBox.Size = new System.Drawing.Size(884, 683);
            this.QueTextBox.TabIndex = 2;
            this.QueTextBox.TabStop = false;
            this.QueTextBox.Text = "";
            // 
            // ChoATextBox
            // 
            this.ChoATextBox.BackColor = System.Drawing.Color.White;
            this.ChoATextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoATextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoATextBox.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoATextBox.Location = new System.Drawing.Point(3, 698);
            this.ChoATextBox.Multiline = true;
            this.ChoATextBox.Name = "ChoATextBox";
            this.ChoATextBox.ReadOnly = true;
            this.ChoATextBox.Size = new System.Drawing.Size(1272, 94);
            this.ChoATextBox.TabIndex = 1;
            this.ChoATextBox.TabStop = false;
            this.ChoATextBox.Click += new System.EventHandler(this.ChoTextBox_Click);
            // 
            // LastQueButton
            // 
            this.LastQueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastQueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastQueButton.Font = new System.Drawing.Font("等线 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastQueButton.Location = new System.Drawing.Point(1281, 698);
            this.LastQueButton.Name = "LastQueButton";
            this.LastQueButton.Size = new System.Drawing.Size(294, 94);
            this.LastQueButton.TabIndex = 9;
            this.LastQueButton.Text = "上一题";
            this.LastQueButton.UseVisualStyleBackColor = true;
            this.LastQueButton.Click += new System.EventHandler(this.LastQueButton_Click);
            // 
            // QueChoPanel
            // 
            this.QueChoPanel.AutoScroll = true;
            this.QueChoPanel.BackColor = System.Drawing.Color.White;
            this.QueChoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueChoPanel.Location = new System.Drawing.Point(1281, 3);
            this.QueChoPanel.Name = "QueChoPanel";
            this.QueChoPanel.Size = new System.Drawing.Size(294, 689);
            this.QueChoPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuScrip);
            this.MainMenuStrip = this.MenuScrip;
            this.MinimumSize = new System.Drawing.Size(1600, 1200);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无线电刷题软件";
            this.MenuScrip.ResumeLayout(false);
            this.MenuScrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuScrip;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem ButtonA;
        private System.Windows.Forms.ToolStripMenuItem BAP;
        private System.Windows.Forms.ToolStripMenuItem APContinue;
        private System.Windows.Forms.ToolStripMenuItem APPositive;
        private System.Windows.Forms.ToolStripMenuItem BAE;
        private System.Windows.Forms.ToolStripMenuItem ButtonB;
        private System.Windows.Forms.ToolStripMenuItem ButtonC;
        private System.Windows.Forms.ToolStripMenuItem ButtonD;
        private System.Windows.Forms.ToolStripMenuItem ButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem APRandom;
        private System.Windows.Forms.ToolStripMenuItem APNegative;
        private System.Windows.Forms.ToolStripMenuItem AEContinue;
        private System.Windows.Forms.ToolStripMenuItem AENew;
        private System.Windows.Forms.ToolStripMenuItem BBP;
        private System.Windows.Forms.ToolStripMenuItem BPContinue;
        private System.Windows.Forms.ToolStripMenuItem BPPositive;
        private System.Windows.Forms.ToolStripMenuItem BPRandom;
        private System.Windows.Forms.ToolStripMenuItem BPNegative;
        private System.Windows.Forms.ToolStripMenuItem BBE;
        private System.Windows.Forms.ToolStripMenuItem BEContinue;
        private System.Windows.Forms.ToolStripMenuItem BENew;
        private System.Windows.Forms.ToolStripMenuItem BCP;
        private System.Windows.Forms.ToolStripMenuItem CPContinue;
        private System.Windows.Forms.ToolStripMenuItem BPE;
        private System.Windows.Forms.ToolStripMenuItem CEContinue;
        private System.Windows.Forms.ToolStripMenuItem CENew;
        private System.Windows.Forms.ToolStripMenuItem CPPositive;
        private System.Windows.Forms.ToolStripMenuItem CPRandom;
        private System.Windows.Forms.ToolStripMenuItem CPNegative;
        private System.Windows.Forms.ToolStripMenuItem DPContinue;
        private System.Windows.Forms.ToolStripMenuItem DPPositive;
        private System.Windows.Forms.ToolStripMenuItem DPRandom;
        private System.Windows.Forms.ToolStripMenuItem DPNegative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox QuePicBox;
        private System.Windows.Forms.RichTextBox QueTextBox;
        private System.Windows.Forms.TextBox ChoDTextBox;
        private System.Windows.Forms.TextBox ChoCTextBox;
        private System.Windows.Forms.TextBox ChoBTextBox;
        private System.Windows.Forms.TextBox ChoATextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CheckAnsButton;
        private System.Windows.Forms.Button NextQuebutton;
        private System.Windows.Forms.Button LastQueButton;
        private System.Windows.Forms.FlowLayoutPanel QueChoPanel;
    }
}

