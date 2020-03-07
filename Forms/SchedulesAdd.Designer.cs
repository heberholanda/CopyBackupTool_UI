namespace CopyBackupToolUI
{
    partial class SchedulesAdd
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulesAdd));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.imageButtonTools = new System.Windows.Forms.Button();
            this.imageButtonCopyPaste = new System.Windows.Forms.Button();
            this.checkBoxCopyPasteStatus = new System.Windows.Forms.CheckBox();
            this.labelCopyPasteStatus = new System.Windows.Forms.Label();
            this.imageButtonZip = new System.Windows.Forms.Button();
            this.textBoxCopyPasteSourcePath = new System.Windows.Forms.TextBox();
            this.labelCopyPasteSourcePath = new System.Windows.Forms.Label();
            this.checkBoxCopyPasteOverwrite = new System.Windows.Forms.CheckBox();
            this.labelCopyPasteOverwrite = new System.Windows.Forms.Label();
            this.labelCopyPasteDestinationPath = new System.Windows.Forms.Label();
            this.textBoxCopyPasteDestinationPath = new System.Windows.Forms.TextBox();
            this.textBoxCopyPasteIgnoreFiles = new System.Windows.Forms.TextBox();
            this.labelCopyPasteIgnoreFiles = new System.Windows.Forms.Label();
            this.panelCopyPasteIgnoreModal = new System.Windows.Forms.Panel();
            this.textBoxCopyPasteIgnoreFolders = new System.Windows.Forms.TextBox();
            this.labelCopyPasteIgnoreFolders = new System.Windows.Forms.Label();
            this.textBoxCompressIgnoreFiles = new System.Windows.Forms.TextBox();
            this.labelCompressIgnoreFiles = new System.Windows.Forms.Label();
            this.labelCompressDestinationPath = new System.Windows.Forms.Label();
            this.textBoxCompressDestinationPath = new System.Windows.Forms.TextBox();
            this.labelCompressSourcePath = new System.Windows.Forms.Label();
            this.textBoxCompressSourcePath = new System.Windows.Forms.TextBox();
            this.checkBoxCompressStatus = new System.Windows.Forms.CheckBox();
            this.labelCompressStatus = new System.Windows.Forms.Label();
            this.panelCompressIgnoreModal = new System.Windows.Forms.Panel();
            this.textBoxCompressIgnoreFolders = new System.Windows.Forms.TextBox();
            this.labelCompressIgnoreFolders = new System.Windows.Forms.Label();
            this.textBoxCompressTitle = new System.Windows.Forms.TextBox();
            this.labelCompressTitle = new System.Windows.Forms.Label();
            this.panelSecond = new System.Windows.Forms.Panel();
            this.panelFirst = new System.Windows.Forms.Panel();
            this.panelThree = new System.Windows.Forms.Panel();
            this.labelCopyAndPaste = new System.Windows.Forms.Label();
            this.labelCompressMode = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCopyPasteIgnoreModal.SuspendLayout();
            this.panelCompressIgnoreModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(241, 493);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 25);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Save";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(97, 493);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(125, 25);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(100, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(177, 22);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextField_Validating);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(100, 51);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(176, 51);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(59, 17);
            this.checkBoxStatus.TabIndex = 2;
            this.checkBoxStatus.Text = "Enable";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // imageButtonTools
            // 
            this.imageButtonTools.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonTools.FlatAppearance.BorderSize = 0;
            this.imageButtonTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.imageButtonTools.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageButtonTools.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonTools.Image")));
            this.imageButtonTools.Location = new System.Drawing.Point(21, 14);
            this.imageButtonTools.Margin = new System.Windows.Forms.Padding(0);
            this.imageButtonTools.Name = "imageButtonTools";
            this.imageButtonTools.Size = new System.Drawing.Size(64, 64);
            this.imageButtonTools.TabIndex = 25;
            this.imageButtonTools.TabStop = false;
            this.imageButtonTools.UseVisualStyleBackColor = false;
            // 
            // imageButtonCopyPaste
            // 
            this.imageButtonCopyPaste.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonCopyPaste.FlatAppearance.BorderSize = 0;
            this.imageButtonCopyPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.imageButtonCopyPaste.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageButtonCopyPaste.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCopyPaste.Image")));
            this.imageButtonCopyPaste.Location = new System.Drawing.Point(21, 118);
            this.imageButtonCopyPaste.Margin = new System.Windows.Forms.Padding(0);
            this.imageButtonCopyPaste.Name = "imageButtonCopyPaste";
            this.imageButtonCopyPaste.Size = new System.Drawing.Size(64, 64);
            this.imageButtonCopyPaste.TabIndex = 24;
            this.imageButtonCopyPaste.TabStop = false;
            this.imageButtonCopyPaste.UseVisualStyleBackColor = false;
            // 
            // checkBoxCopyPasteStatus
            // 
            this.checkBoxCopyPasteStatus.AutoSize = true;
            this.checkBoxCopyPasteStatus.Location = new System.Drawing.Point(176, 110);
            this.checkBoxCopyPasteStatus.Name = "checkBoxCopyPasteStatus";
            this.checkBoxCopyPasteStatus.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCopyPasteStatus.TabIndex = 3;
            this.checkBoxCopyPasteStatus.Text = "Enable";
            this.checkBoxCopyPasteStatus.UseVisualStyleBackColor = true;
            // 
            // labelCopyPasteStatus
            // 
            this.labelCopyPasteStatus.AutoSize = true;
            this.labelCopyPasteStatus.Location = new System.Drawing.Point(100, 110);
            this.labelCopyPasteStatus.Name = "labelCopyPasteStatus";
            this.labelCopyPasteStatus.Size = new System.Drawing.Size(37, 13);
            this.labelCopyPasteStatus.TabIndex = 23;
            this.labelCopyPasteStatus.Text = "Status";
            // 
            // imageButtonZip
            // 
            this.imageButtonZip.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonZip.FlatAppearance.BorderSize = 0;
            this.imageButtonZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.imageButtonZip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageButtonZip.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonZip.Image")));
            this.imageButtonZip.Location = new System.Drawing.Point(21, 292);
            this.imageButtonZip.Margin = new System.Windows.Forms.Padding(0);
            this.imageButtonZip.Name = "imageButtonZip";
            this.imageButtonZip.Size = new System.Drawing.Size(64, 64);
            this.imageButtonZip.TabIndex = 22;
            this.imageButtonZip.TabStop = false;
            this.imageButtonZip.UseVisualStyleBackColor = false;
            // 
            // textBoxCopyPasteSourcePath
            // 
            this.textBoxCopyPasteSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyPasteSourcePath.Location = new System.Drawing.Point(176, 134);
            this.textBoxCopyPasteSourcePath.Name = "textBoxCopyPasteSourcePath";
            this.textBoxCopyPasteSourcePath.Size = new System.Drawing.Size(250, 20);
            this.textBoxCopyPasteSourcePath.TabIndex = 5;
            this.textBoxCopyPasteSourcePath.DoubleClick += new System.EventHandler(this.textBoxCopyPaste_SourcePath_Click);
            this.textBoxCopyPasteSourcePath.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredFolderField_Validating);
            // 
            // labelCopyPasteSourcePath
            // 
            this.labelCopyPasteSourcePath.AutoSize = true;
            this.labelCopyPasteSourcePath.Location = new System.Drawing.Point(100, 137);
            this.labelCopyPasteSourcePath.Name = "labelCopyPasteSourcePath";
            this.labelCopyPasteSourcePath.Size = new System.Drawing.Size(41, 13);
            this.labelCopyPasteSourcePath.TabIndex = 21;
            this.labelCopyPasteSourcePath.Text = "Source";
            this.labelCopyPasteSourcePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxCopyPasteOverwrite
            // 
            this.checkBoxCopyPasteOverwrite.AutoSize = true;
            this.checkBoxCopyPasteOverwrite.Location = new System.Drawing.Point(367, 111);
            this.checkBoxCopyPasteOverwrite.Name = "checkBoxCopyPasteOverwrite";
            this.checkBoxCopyPasteOverwrite.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCopyPasteOverwrite.TabIndex = 4;
            this.checkBoxCopyPasteOverwrite.Text = "Enable";
            this.checkBoxCopyPasteOverwrite.UseVisualStyleBackColor = true;
            // 
            // labelCopyPasteOverwrite
            // 
            this.labelCopyPasteOverwrite.AutoSize = true;
            this.labelCopyPasteOverwrite.Location = new System.Drawing.Point(298, 111);
            this.labelCopyPasteOverwrite.Name = "labelCopyPasteOverwrite";
            this.labelCopyPasteOverwrite.Size = new System.Drawing.Size(52, 13);
            this.labelCopyPasteOverwrite.TabIndex = 20;
            this.labelCopyPasteOverwrite.Text = "Overwrite";
            // 
            // labelCopyPasteDestinationPath
            // 
            this.labelCopyPasteDestinationPath.AutoSize = true;
            this.labelCopyPasteDestinationPath.Location = new System.Drawing.Point(100, 165);
            this.labelCopyPasteDestinationPath.Name = "labelCopyPasteDestinationPath";
            this.labelCopyPasteDestinationPath.Size = new System.Drawing.Size(60, 13);
            this.labelCopyPasteDestinationPath.TabIndex = 19;
            this.labelCopyPasteDestinationPath.Text = "Destination";
            this.labelCopyPasteDestinationPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCopyPasteDestinationPath
            // 
            this.textBoxCopyPasteDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyPasteDestinationPath.Location = new System.Drawing.Point(176, 162);
            this.textBoxCopyPasteDestinationPath.Name = "textBoxCopyPasteDestinationPath";
            this.textBoxCopyPasteDestinationPath.Size = new System.Drawing.Size(250, 20);
            this.textBoxCopyPasteDestinationPath.TabIndex = 6;
            this.textBoxCopyPasteDestinationPath.DoubleClick += new System.EventHandler(this.textBoxCopyPaste_DestinationPath_Click);
            this.textBoxCopyPasteDestinationPath.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredFolderField_Validating);
            // 
            // textBoxCopyPasteIgnoreFiles
            // 
            this.textBoxCopyPasteIgnoreFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyPasteIgnoreFiles.Location = new System.Drawing.Point(177, 196);
            this.textBoxCopyPasteIgnoreFiles.Name = "textBoxCopyPasteIgnoreFiles";
            this.textBoxCopyPasteIgnoreFiles.Size = new System.Drawing.Size(249, 20);
            this.textBoxCopyPasteIgnoreFiles.TabIndex = 7;
            // 
            // labelCopyPasteIgnoreFiles
            // 
            this.labelCopyPasteIgnoreFiles.AutoSize = true;
            this.labelCopyPasteIgnoreFiles.Location = new System.Drawing.Point(100, 199);
            this.labelCopyPasteIgnoreFiles.Name = "labelCopyPasteIgnoreFiles";
            this.labelCopyPasteIgnoreFiles.Size = new System.Drawing.Size(61, 13);
            this.labelCopyPasteIgnoreFiles.TabIndex = 18;
            this.labelCopyPasteIgnoreFiles.Text = "Ignore Files";
            // 
            // panelCopyPasteIgnoreModal
            // 
            this.panelCopyPasteIgnoreModal.BackColor = System.Drawing.Color.Transparent;
            this.panelCopyPasteIgnoreModal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCopyPasteIgnoreModal.Controls.Add(this.textBoxCopyPasteIgnoreFolders);
            this.panelCopyPasteIgnoreModal.Controls.Add(this.labelCopyPasteIgnoreFolders);
            this.panelCopyPasteIgnoreModal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCopyPasteIgnoreModal.Location = new System.Drawing.Point(95, 189);
            this.panelCopyPasteIgnoreModal.Name = "panelCopyPasteIgnoreModal";
            this.panelCopyPasteIgnoreModal.Size = new System.Drawing.Size(346, 61);
            this.panelCopyPasteIgnoreModal.TabIndex = 7;
            // 
            // textBoxCopyPasteIgnoreFolders
            // 
            this.textBoxCopyPasteIgnoreFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyPasteIgnoreFolders.Location = new System.Drawing.Point(81, 32);
            this.textBoxCopyPasteIgnoreFolders.Name = "textBoxCopyPasteIgnoreFolders";
            this.textBoxCopyPasteIgnoreFolders.Size = new System.Drawing.Size(249, 20);
            this.textBoxCopyPasteIgnoreFolders.TabIndex = 8;
            // 
            // labelCopyPasteIgnoreFolders
            // 
            this.labelCopyPasteIgnoreFolders.AutoSize = true;
            this.labelCopyPasteIgnoreFolders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCopyPasteIgnoreFolders.Location = new System.Drawing.Point(4, 35);
            this.labelCopyPasteIgnoreFolders.Name = "labelCopyPasteIgnoreFolders";
            this.labelCopyPasteIgnoreFolders.Size = new System.Drawing.Size(74, 13);
            this.labelCopyPasteIgnoreFolders.TabIndex = 9;
            this.labelCopyPasteIgnoreFolders.Text = "Ignore Folders";
            // 
            // textBoxCompressIgnoreFiles
            // 
            this.textBoxCompressIgnoreFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompressIgnoreFiles.Location = new System.Drawing.Point(176, 398);
            this.textBoxCompressIgnoreFiles.Name = "textBoxCompressIgnoreFiles";
            this.textBoxCompressIgnoreFiles.Size = new System.Drawing.Size(249, 20);
            this.textBoxCompressIgnoreFiles.TabIndex = 13;
            // 
            // labelCompressIgnoreFiles
            // 
            this.labelCompressIgnoreFiles.AutoSize = true;
            this.labelCompressIgnoreFiles.Location = new System.Drawing.Point(100, 401);
            this.labelCompressIgnoreFiles.Name = "labelCompressIgnoreFiles";
            this.labelCompressIgnoreFiles.Size = new System.Drawing.Size(61, 13);
            this.labelCompressIgnoreFiles.TabIndex = 14;
            this.labelCompressIgnoreFiles.Text = "Ignore Files";
            // 
            // labelCompressDestinationPath
            // 
            this.labelCompressDestinationPath.AutoSize = true;
            this.labelCompressDestinationPath.Location = new System.Drawing.Point(100, 367);
            this.labelCompressDestinationPath.Name = "labelCompressDestinationPath";
            this.labelCompressDestinationPath.Size = new System.Drawing.Size(60, 13);
            this.labelCompressDestinationPath.TabIndex = 15;
            this.labelCompressDestinationPath.Text = "Destination";
            this.labelCompressDestinationPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCompressDestinationPath
            // 
            this.textBoxCompressDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompressDestinationPath.Location = new System.Drawing.Point(176, 362);
            this.textBoxCompressDestinationPath.Name = "textBoxCompressDestinationPath";
            this.textBoxCompressDestinationPath.Size = new System.Drawing.Size(250, 20);
            this.textBoxCompressDestinationPath.TabIndex = 12;
            this.textBoxCompressDestinationPath.DoubleClick += new System.EventHandler(this.textBoxCompressDestinationPath_Click);
            this.textBoxCompressDestinationPath.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredFolderField_Validating);
            // 
            // labelCompressSourcePath
            // 
            this.labelCompressSourcePath.AutoSize = true;
            this.labelCompressSourcePath.Location = new System.Drawing.Point(100, 339);
            this.labelCompressSourcePath.Name = "labelCompressSourcePath";
            this.labelCompressSourcePath.Size = new System.Drawing.Size(41, 13);
            this.labelCompressSourcePath.TabIndex = 16;
            this.labelCompressSourcePath.Text = "Source";
            this.labelCompressSourcePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCompressSourcePath
            // 
            this.textBoxCompressSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompressSourcePath.Location = new System.Drawing.Point(176, 336);
            this.textBoxCompressSourcePath.Name = "textBoxCompressSourcePath";
            this.textBoxCompressSourcePath.Size = new System.Drawing.Size(250, 20);
            this.textBoxCompressSourcePath.TabIndex = 11;
            this.textBoxCompressSourcePath.DoubleClick += new System.EventHandler(this.textBoxCompressSourcePath_Click);
            this.textBoxCompressSourcePath.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredFolderField_Validating);
            // 
            // checkBoxCompressStatus
            // 
            this.checkBoxCompressStatus.AutoSize = true;
            this.checkBoxCompressStatus.Location = new System.Drawing.Point(176, 289);
            this.checkBoxCompressStatus.Name = "checkBoxCompressStatus";
            this.checkBoxCompressStatus.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCompressStatus.TabIndex = 9;
            this.checkBoxCompressStatus.Text = "Enable";
            this.checkBoxCompressStatus.UseVisualStyleBackColor = true;
            // 
            // labelCompressStatus
            // 
            this.labelCompressStatus.AutoSize = true;
            this.labelCompressStatus.Location = new System.Drawing.Point(100, 289);
            this.labelCompressStatus.Name = "labelCompressStatus";
            this.labelCompressStatus.Size = new System.Drawing.Size(37, 13);
            this.labelCompressStatus.TabIndex = 17;
            this.labelCompressStatus.Text = "Status";
            // 
            // panelCompressIgnoreModal
            // 
            this.panelCompressIgnoreModal.BackColor = System.Drawing.Color.Transparent;
            this.panelCompressIgnoreModal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompressIgnoreModal.Controls.Add(this.textBoxCompressIgnoreFolders);
            this.panelCompressIgnoreModal.Controls.Add(this.labelCompressIgnoreFolders);
            this.panelCompressIgnoreModal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCompressIgnoreModal.Location = new System.Drawing.Point(95, 391);
            this.panelCompressIgnoreModal.Name = "panelCompressIgnoreModal";
            this.panelCompressIgnoreModal.Size = new System.Drawing.Size(346, 61);
            this.panelCompressIgnoreModal.TabIndex = 13;
            // 
            // textBoxCompressIgnoreFolders
            // 
            this.textBoxCompressIgnoreFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompressIgnoreFolders.Location = new System.Drawing.Point(80, 32);
            this.textBoxCompressIgnoreFolders.Name = "textBoxCompressIgnoreFolders";
            this.textBoxCompressIgnoreFolders.Size = new System.Drawing.Size(249, 20);
            this.textBoxCompressIgnoreFolders.TabIndex = 14;
            // 
            // labelCompressIgnoreFolders
            // 
            this.labelCompressIgnoreFolders.AutoSize = true;
            this.labelCompressIgnoreFolders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCompressIgnoreFolders.Location = new System.Drawing.Point(4, 35);
            this.labelCompressIgnoreFolders.Name = "labelCompressIgnoreFolders";
            this.labelCompressIgnoreFolders.Size = new System.Drawing.Size(74, 13);
            this.labelCompressIgnoreFolders.TabIndex = 15;
            this.labelCompressIgnoreFolders.Text = "Ignore Folders";
            // 
            // textBoxCompressTitle
            // 
            this.textBoxCompressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompressTitle.Location = new System.Drawing.Point(175, 310);
            this.textBoxCompressTitle.Name = "textBoxCompressTitle";
            this.textBoxCompressTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxCompressTitle.TabIndex = 10;
            this.textBoxCompressTitle.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextField_Validating);
            // 
            // labelCompressTitle
            // 
            this.labelCompressTitle.AutoSize = true;
            this.labelCompressTitle.Location = new System.Drawing.Point(100, 313);
            this.labelCompressTitle.Name = "labelCompressTitle";
            this.labelCompressTitle.Size = new System.Drawing.Size(27, 13);
            this.labelCompressTitle.TabIndex = 11;
            this.labelCompressTitle.Text = "Title";
            // 
            // panelSecond
            // 
            this.panelSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSecond.Location = new System.Drawing.Point(-7, 267);
            this.panelSecond.Name = "panelSecond";
            this.panelSecond.Size = new System.Drawing.Size(489, 4);
            this.panelSecond.TabIndex = 2;
            // 
            // panelFirst
            // 
            this.panelFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFirst.Location = new System.Drawing.Point(2, 92);
            this.panelFirst.Name = "panelFirst";
            this.panelFirst.Size = new System.Drawing.Size(475, 4);
            this.panelFirst.TabIndex = 1;
            // 
            // panelThree
            // 
            this.panelThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelThree.Location = new System.Drawing.Point(2, 468);
            this.panelThree.Name = "panelThree";
            this.panelThree.Size = new System.Drawing.Size(475, 4);
            this.panelThree.TabIndex = 0;
            // 
            // labelCopyAndPaste
            // 
            this.labelCopyAndPaste.AutoSize = true;
            this.labelCopyAndPaste.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyAndPaste.Location = new System.Drawing.Point(12, 100);
            this.labelCopyAndPaste.Name = "labelCopyAndPaste";
            this.labelCopyAndPaste.Size = new System.Drawing.Size(89, 16);
            this.labelCopyAndPaste.TabIndex = 26;
            this.labelCopyAndPaste.Text = "Copy and Paste";
            // 
            // labelCompressMode
            // 
            this.labelCompressMode.AutoSize = true;
            this.labelCompressMode.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompressMode.Location = new System.Drawing.Point(6, 274);
            this.labelCompressMode.Name = "labelCompressMode";
            this.labelCompressMode.Size = new System.Drawing.Size(93, 16);
            this.labelCompressMode.TabIndex = 27;
            this.labelCompressMode.Text = "Compress Mode";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // SchedulesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 541);
            this.Controls.Add(this.panelThree);
            this.Controls.Add(this.panelFirst);
            this.Controls.Add(this.panelSecond);
            this.Controls.Add(this.textBoxCompressTitle);
            this.Controls.Add(this.labelCompressTitle);
            this.Controls.Add(this.textBoxCompressIgnoreFiles);
            this.Controls.Add(this.labelCompressIgnoreFiles);
            this.Controls.Add(this.labelCompressDestinationPath);
            this.Controls.Add(this.textBoxCompressDestinationPath);
            this.Controls.Add(this.labelCompressSourcePath);
            this.Controls.Add(this.textBoxCompressSourcePath);
            this.Controls.Add(this.checkBoxCompressStatus);
            this.Controls.Add(this.labelCompressStatus);
            this.Controls.Add(this.panelCompressIgnoreModal);
            this.Controls.Add(this.textBoxCopyPasteIgnoreFiles);
            this.Controls.Add(this.labelCopyPasteIgnoreFiles);
            this.Controls.Add(this.labelCopyPasteDestinationPath);
            this.Controls.Add(this.textBoxCopyPasteDestinationPath);
            this.Controls.Add(this.checkBoxCopyPasteOverwrite);
            this.Controls.Add(this.labelCopyPasteOverwrite);
            this.Controls.Add(this.labelCopyPasteSourcePath);
            this.Controls.Add(this.textBoxCopyPasteSourcePath);
            this.Controls.Add(this.imageButtonZip);
            this.Controls.Add(this.checkBoxCopyPasteStatus);
            this.Controls.Add(this.labelCopyPasteStatus);
            this.Controls.Add(this.imageButtonCopyPaste);
            this.Controls.Add(this.imageButtonTools);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelCopyPasteIgnoreModal);
            this.Controls.Add(this.labelCopyAndPaste);
            this.Controls.Add(this.labelCompressMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchedulesAdd";
            this.Text = "Schedules Add";
            this.Load += new System.EventHandler(this.Schedules_Load);
            this.panelCopyPasteIgnoreModal.ResumeLayout(false);
            this.panelCopyPasteIgnoreModal.PerformLayout();
            this.panelCompressIgnoreModal.ResumeLayout(false);
            this.panelCompressIgnoreModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        #region #Components
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button imageButtonTools;
        private System.Windows.Forms.Button imageButtonCopyPaste;
        private System.Windows.Forms.CheckBox checkBoxCopyPasteStatus;
        private System.Windows.Forms.Label labelCopyPasteStatus;
        private System.Windows.Forms.Button imageButtonZip;
        private System.Windows.Forms.TextBox textBoxCopyPasteSourcePath;
        private System.Windows.Forms.Label labelCopyPasteSourcePath;
        private System.Windows.Forms.CheckBox checkBoxCopyPasteOverwrite;
        private System.Windows.Forms.Label labelCopyPasteOverwrite;
        private System.Windows.Forms.Label labelCopyPasteDestinationPath;
        private System.Windows.Forms.TextBox textBoxCopyPasteDestinationPath;
        private System.Windows.Forms.TextBox textBoxCopyPasteIgnoreFiles;
        private System.Windows.Forms.Label labelCopyPasteIgnoreFiles;
        private System.Windows.Forms.Panel panelCopyPasteIgnoreModal;
        private System.Windows.Forms.TextBox textBoxCopyPasteIgnoreFolders;
        private System.Windows.Forms.Label labelCopyPasteIgnoreFolders;
        private System.Windows.Forms.TextBox textBoxCompressIgnoreFiles;
        private System.Windows.Forms.Label labelCompressIgnoreFiles;
        private System.Windows.Forms.Label labelCompressDestinationPath;
        private System.Windows.Forms.TextBox textBoxCompressDestinationPath;
        private System.Windows.Forms.Label labelCompressSourcePath;
        private System.Windows.Forms.TextBox textBoxCompressSourcePath;
        private System.Windows.Forms.CheckBox checkBoxCompressStatus;
        private System.Windows.Forms.Label labelCompressStatus;
        private System.Windows.Forms.Panel panelCompressIgnoreModal;
        private System.Windows.Forms.TextBox textBoxCompressIgnoreFolders;
        private System.Windows.Forms.Label labelCompressIgnoreFolders;
        private System.Windows.Forms.TextBox textBoxCompressTitle;
        private System.Windows.Forms.Label labelCompressTitle;
        private System.Windows.Forms.Panel panelSecond;
        private System.Windows.Forms.Panel panelFirst;
        private System.Windows.Forms.Panel panelThree;
        private System.Windows.Forms.Label labelCopyAndPaste;
        private System.Windows.Forms.Label labelCompressMode;
        private System.Windows.Forms.ErrorProvider errorProvider;
        #endregion
    }
}