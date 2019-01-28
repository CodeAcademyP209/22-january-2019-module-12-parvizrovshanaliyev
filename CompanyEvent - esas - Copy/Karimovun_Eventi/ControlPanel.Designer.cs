namespace Karimovun_Eventi
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.btnAddWorkerPanel = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.dgvControlPanel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxIclas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWorkerPanel
            // 
            this.btnAddWorkerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddWorkerPanel.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorkerPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddWorkerPanel.Location = new System.Drawing.Point(890, 430);
            this.btnAddWorkerPanel.Name = "btnAddWorkerPanel";
            this.btnAddWorkerPanel.Size = new System.Drawing.Size(151, 26);
            this.btnAddWorkerPanel.TabIndex = 0;
            this.btnAddWorkerPanel.Text = "Add Event";
            this.btnAddWorkerPanel.UseVisualStyleBackColor = false;
            this.btnAddWorkerPanel.Click += new System.EventHandler(this.btnAddWorkerPanel_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEvent.Location = new System.Drawing.Point(890, 471);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(151, 27);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Go to Event Room";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddWorker.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddWorker.Location = new System.Drawing.Point(890, 389);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(151, 26);
            this.btnAddWorker.TabIndex = 2;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // dgvControlPanel
            // 
            this.dgvControlPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvControlPanel.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvControlPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlPanel.Location = new System.Drawing.Point(25, 68);
            this.dgvControlPanel.Name = "dgvControlPanel";
            this.dgvControlPanel.Size = new System.Drawing.Size(604, 211);
            this.dgvControlPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mövcud olan İclaslar\r\n";
            // 
            // listBoxIclas
            // 
            this.listBoxIclas.BackColor = System.Drawing.Color.LightGray;
            this.listBoxIclas.FormattingEnabled = true;
            this.listBoxIclas.Location = new System.Drawing.Point(25, 364);
            this.listBoxIclas.Name = "listBoxIclas";
            this.listBoxIclas.Size = new System.Drawing.Size(606, 134);
            this.listBoxIclas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(193, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Istirak Etmeli oldugunuz \"Iclaslar\"";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNameSurname.Location = new System.Drawing.Point(755, 16);
            this.lblNameSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(178, 26);
            this.lblNameSurname.TabIndex = 8;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(928, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(104, 32);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(531, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1073, 582);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxIclas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvControlPanel);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnAddWorkerPanel);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorkerPanel;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.DataGridView dgvControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxIclas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdate;
    }
}