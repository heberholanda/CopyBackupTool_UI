using System.Windows.Forms;

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
            dataGridViewSchedulesConfigs = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckBoxColumn_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewTextBoxColumn_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataGridViewTextBoxColumn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fileModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSchedulesAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewSchedulesConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedulesConfigs
            // 
            dataGridViewSchedulesConfigs.AllowUserToOrderColumns = true;
            dataGridViewSchedulesConfigs.AutoGenerateColumns = false;
            dataGridViewSchedulesConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedulesConfigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn_title,
            this.DataGridViewCheckBoxColumn_status,
            this.DataGridViewTextBoxColumn_Update,
            this.DataGridViewTextBoxColumn_Delete});
            dataGridViewSchedulesConfigs.DataSource = this.fileModelBindingSource;
            dataGridViewSchedulesConfigs.Location = new System.Drawing.Point(7, 56);
            dataGridViewSchedulesConfigs.Name = "dataGridViewSchedulesConfigs";
            dataGridViewSchedulesConfigs.Size = new System.Drawing.Size(543, 272);
            dataGridViewSchedulesConfigs.TabIndex = 0;
            dataGridViewSchedulesConfigs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridViewSchedulesConfigs_CellContentClick);
            // 
            // DataGridViewTextBoxColumn_title
            // 
            this.DataGridViewTextBoxColumn_title.DataPropertyName = "Title";
            this.DataGridViewTextBoxColumn_title.FillWeight = 250F;
            this.DataGridViewTextBoxColumn_title.Frozen = true;
            this.DataGridViewTextBoxColumn_title.HeaderText = "Title";
            this.DataGridViewTextBoxColumn_title.Name = "DataGridViewTextBoxColumn_title";
            this.DataGridViewTextBoxColumn_title.Width = 250;
            // 
            // DataGridViewCheckBoxColumn_status
            // 
            this.DataGridViewCheckBoxColumn_status.DataPropertyName = "Status";
            this.DataGridViewCheckBoxColumn_status.FillWeight = 50F;
            this.DataGridViewCheckBoxColumn_status.Frozen = true;
            this.DataGridViewCheckBoxColumn_status.HeaderText = "Status";
            this.DataGridViewCheckBoxColumn_status.Name = "DataGridViewCheckBoxColumn_status";
            this.DataGridViewCheckBoxColumn_status.Width = 50;
            // 
            // DataGridViewTextBoxColumn_Update
            // 
            this.DataGridViewTextBoxColumn_Update.Frozen = true;
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
            this.labelTitle.Location = new System.Drawing.Point(107, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(250, 28);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Backups Configurations";
            // 
            // buttonSchedulesAdd
            // 
            this.buttonSchedulesAdd.AutoEllipsis = true;
            this.buttonSchedulesAdd.Location = new System.Drawing.Point(449, 9);
            this.buttonSchedulesAdd.Name = "buttonSchedulesAdd";
            this.buttonSchedulesAdd.Size = new System.Drawing.Size(92, 38);
            this.buttonSchedulesAdd.TabIndex = 2;
            this.buttonSchedulesAdd.Text = "New";
            this.buttonSchedulesAdd.UseVisualStyleBackColor = true;
            this.buttonSchedulesAdd.Click += new System.EventHandler(this.buttonSchedulesAdd_Click);
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 338);
            this.Controls.Add(this.buttonSchedulesAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(dataGridViewSchedulesConfigs);
            this.Name = "Schedules";
            this.Text = "Schedules";
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewSchedulesConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // KeyDown event - Minimize on press "Esc" or Escape
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(MinimizeFormEscape);
        }

        #endregion
        private System.Windows.Forms.BindingSource fileModelBindingSource;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn_title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn_status;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewTextBoxColumn_Update;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewTextBoxColumn_Delete;
        private System.Windows.Forms.Button buttonSchedulesAdd;
        public static System.Windows.Forms.DataGridView dataGridViewSchedulesConfigs;
    }
}