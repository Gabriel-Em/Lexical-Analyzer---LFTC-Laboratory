namespace Analizator_Lexical
{
    partial class UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.rchSursa = new System.Windows.Forms.RichTextBox();
            this.lbltxtSursa = new System.Windows.Forms.Label();
            this.FIPDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFIP = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.rchErrorList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FIPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(12, 22);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(91, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Fisier sursa:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Black;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(959, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(108, 35);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(100, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(853, 25);
            this.txtPath.TabIndex = 2;
            // 
            // rchSursa
            // 
            this.rchSursa.BackColor = System.Drawing.Color.Black;
            this.rchSursa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchSursa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchSursa.ForeColor = System.Drawing.Color.White;
            this.rchSursa.Location = new System.Drawing.Point(16, 79);
            this.rchSursa.Name = "rchSursa";
            this.rchSursa.ReadOnly = true;
            this.rchSursa.Size = new System.Drawing.Size(580, 295);
            this.rchSursa.TabIndex = 3;
            this.rchSursa.Text = "";
            // 
            // lbltxtSursa
            // 
            this.lbltxtSursa.AutoSize = true;
            this.lbltxtSursa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtSursa.ForeColor = System.Drawing.Color.White;
            this.lbltxtSursa.Location = new System.Drawing.Point(12, 59);
            this.lbltxtSursa.Name = "lbltxtSursa";
            this.lbltxtSursa.Size = new System.Drawing.Size(81, 20);
            this.lbltxtSursa.TabIndex = 4;
            this.lbltxtSursa.Text = "Cod sursa:";
            // 
            // FIPDataGridView
            // 
            this.FIPDataGridView.AllowUserToResizeColumns = false;
            this.FIPDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIPDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FIPDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FIPDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FIPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FIPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnCardName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FIPDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FIPDataGridView.EnableHeadersVisualStyles = false;
            this.FIPDataGridView.Location = new System.Drawing.Point(617, 78);
            this.FIPDataGridView.Name = "FIPDataGridView";
            this.FIPDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FIPDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FIPDataGridView.RowHeadersVisible = false;
            this.FIPDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIPDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FIPDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FIPDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FIPDataGridView.Size = new System.Drawing.Size(224, 421);
            this.FIPDataGridView.TabIndex = 33;
            // 
            // ColumnNo
            // 
            this.ColumnNo.HeaderText = "Cod Atom";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCardName
            // 
            this.ColumnCardName.HeaderText = "Adresa TS";
            this.ColumnCardName.Name = "ColumnCardName";
            this.ColumnCardName.ReadOnly = true;
            this.ColumnCardName.Width = 120;
            // 
            // TSDataGridView
            // 
            this.TSDataGridView.AllowUserToResizeColumns = false;
            this.TSDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TSDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TSDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.TSDataGridView.EnableHeadersVisualStyles = false;
            this.TSDataGridView.Location = new System.Drawing.Point(864, 78);
            this.TSDataGridView.Name = "TSDataGridView";
            this.TSDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TSDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TSDataGridView.RowHeadersVisible = false;
            this.TSDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TSDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TSDataGridView.Size = new System.Drawing.Size(203, 421);
            this.TSDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nume Atom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblFIP
            // 
            this.lblFIP.AutoSize = true;
            this.lblFIP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIP.ForeColor = System.Drawing.Color.White;
            this.lblFIP.Location = new System.Drawing.Point(613, 59);
            this.lblFIP.Name = "lblFIP";
            this.lblFIP.Size = new System.Drawing.Size(35, 20);
            this.lblFIP.TabIndex = 35;
            this.lblFIP.Text = "FIP:";
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTS.ForeColor = System.Drawing.Color.White;
            this.lblTS.Location = new System.Drawing.Point(860, 59);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(30, 20);
            this.lblTS.TabIndex = 36;
            this.lblTS.Text = "TS:";
            // 
            // rchErrorList
            // 
            this.rchErrorList.BackColor = System.Drawing.Color.White;
            this.rchErrorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchErrorList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchErrorList.ForeColor = System.Drawing.Color.Black;
            this.rchErrorList.Location = new System.Drawing.Point(16, 400);
            this.rchErrorList.Name = "rchErrorList";
            this.rchErrorList.ReadOnly = true;
            this.rchErrorList.Size = new System.Drawing.Size(580, 99);
            this.rchErrorList.TabIndex = 37;
            this.rchErrorList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lista de erori:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1079, 511);
            this.Controls.Add(this.rchSursa);
            this.Controls.Add(this.rchErrorList);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.lblFIP);
            this.Controls.Add(this.TSDataGridView);
            this.Controls.Add(this.FIPDataGridView);
            this.Controls.Add(this.lbltxtSursa);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UI";
            this.Text = "Analizator Lexical";
            ((System.ComponentModel.ISupportInitialize)(this.FIPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox rchSursa;
        private System.Windows.Forms.Label lbltxtSursa;
        private System.Windows.Forms.DataGridView FIPDataGridView;
        private System.Windows.Forms.DataGridView TSDataGridView;
        private System.Windows.Forms.Label lblFIP;
        private System.Windows.Forms.Label lblTS;
        private System.Windows.Forms.RichTextBox rchErrorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

