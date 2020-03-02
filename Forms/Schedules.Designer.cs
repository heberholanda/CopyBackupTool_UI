namespace CopyBackupToolUI.Forms
{
    partial class Schedules
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
            this.dataGridViewSchedulesConfigs = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckBoxColumn_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn_copyAndPaste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn_compressFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataGridViewTextBoxColumn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fileModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedulesConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedulesConfigs
            // 
            this.dataGridViewSchedulesConfigs.AllowUserToOrderColumns = true;
            this.dataGridViewSchedulesConfigs.AutoGenerateColumns = false;
            this.dataGridViewSchedulesConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedulesConfigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn_title,
            this.DataGridViewCheckBoxColumn_status,
            this.DataGridViewTextBoxColumn_copyAndPaste,
            this.DataGridViewTextBoxColumn_compressFolder,
            this.DataGridViewTextBoxColumn_Update,
            this.DataGridViewTextBoxColumn_Delete});
            this.dataGridViewSchedulesConfigs.DataSource = this.fileModelBindingSource;
            this.dataGridViewSchedulesConfigs.Location = new System.Drawing.Point(7, 56);
            this.dataGridViewSchedulesConfigs.Name = "dataGridViewSchedulesConfigs";
            this.dataGridViewSchedulesConfigs.Size = new System.Drawing.Size(643, 272);
            this.dataGridViewSchedulesConfigs.TabIndex = 0;
            this.dataGridViewSchedulesConfigs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedulesConfigs_CellContentClick);
            // 
            // DataGridViewTextBoxColumn_title
            // 
            this.DataGridViewTextBoxColumn_title.DataPropertyName = "Title";
            this.DataGridViewTextBoxColumn_title.HeaderText = "Title";
            this.DataGridViewTextBoxColumn_title.Name = "DataGridViewTextBoxColumn_title";
            // 
            // DataGridViewCheckBoxColumn_status
            // 
            this.DataGridViewCheckBoxColumn_status.DataPropertyName = "Status";
            this.DataGridViewCheckBoxColumn_status.HeaderText = "Status";
            this.DataGridViewCheckBoxColumn_status.Name = "DataGridViewCheckBoxColumn_status";
            // 
            // DataGridViewTextBoxColumn_copyAndPaste
            // 
            this.DataGridViewTextBoxColumn_copyAndPaste.DataPropertyName = "CopyAndPaste";
            this.DataGridViewTextBoxColumn_copyAndPaste.HeaderText = "CopyAndPaste";
            this.DataGridViewTextBoxColumn_copyAndPaste.Name = "DataGridViewTextBoxColumn_copyAndPaste";
            // 
            // DataGridViewTextBoxColumn_compressFolder
            // 
            this.DataGridViewTextBoxColumn_compressFolder.DataPropertyName = "CompressFolder";
            this.DataGridViewTextBoxColumn_compressFolder.HeaderText = "CompressFolder";
            this.DataGridViewTextBoxColumn_compressFolder.Name = "DataGridViewTextBoxColumn_compressFolder";
            // 
            // DataGridViewTextBoxColumn_Update
            // 
            this.DataGridViewTextBoxColumn_Update.HeaderText = "Update";
            this.DataGridViewTextBoxColumn_Update.Name = "DataGridViewTextBoxColumn_Update";
            this.DataGridViewTextBoxColumn_Update.ReadOnly = true;
            this.DataGridViewTextBoxColumn_Update.Text = "Update";
            this.DataGridViewTextBoxColumn_Update.UseColumnTextForButtonValue = true;
            // 
            // DataGridViewTextBoxColumn_Delete
            // 
            this.DataGridViewTextBoxColumn_Delete.HeaderText = "Delete";
            this.DataGridViewTextBoxColumn_Delete.Name = "DataGridViewTextBoxColumn_Delete";
            this.DataGridViewTextBoxColumn_Delete.ReadOnly = true;
            this.DataGridViewTextBoxColumn_Delete.Text = "Delete";
            this.DataGridViewTextBoxColumn_Delete.UseColumnTextForButtonValue = true;
            // 
            // fileModelBindingSource
            // 
            this.fileModelBindingSource.DataSource = typeof(CopyBackupToolUI.Models.FileModel);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(195, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(250, 28);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Backups Configurations";
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 338);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewSchedulesConfigs);
            this.Name = "Schedules";
            this.Text = "Schedules";
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedulesConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedulesConfigs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn_title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn_copyAndPaste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn_compressFolder;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewTextBoxColumn_Update;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewTextBoxColumn_Delete;
        private System.Windows.Forms.BindingSource fileModelBindingSource;
        private System.Windows.Forms.Label labelTitle;
    }
}