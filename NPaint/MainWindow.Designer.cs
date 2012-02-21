namespace NPaint
{
    partial class MainWindow
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSMINew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSMIOpe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSMISaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(868, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status strip";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSMIFile,
            this.dToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(868, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Main menu";
            // 
            // toolSMIFile
            // 
            this.toolSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSMINew,
            this.toolSMIOpe,
            this.toolSMISave,
            this.toolSMISaveAs,
            this.toolStripSeparator1,
            this.toolSMIExit});
            this.toolSMIFile.Name = "toolSMIFile";
            this.toolSMIFile.Size = new System.Drawing.Size(38, 20);
            this.toolSMIFile.Text = global::NPaint.Properties.Resources.FileMenu;
            // 
            // toolSMINew
            // 
            this.toolSMINew.Name = "toolSMINew";
            this.toolSMINew.Size = new System.Drawing.Size(152, 22);
            this.toolSMINew.Text = global::NPaint.Properties.Resources.NewMenuItem;
            // 
            // toolSMIOpe
            // 
            this.toolSMIOpe.Name = "toolSMIOpe";
            this.toolSMIOpe.Size = new System.Drawing.Size(152, 22);
            this.toolSMIOpe.Text = global::NPaint.Properties.Resources.OpenMenuItem;
            // 
            // toolSMISave
            // 
            this.toolSMISave.Name = "toolSMISave";
            this.toolSMISave.Size = new System.Drawing.Size(152, 22);
            this.toolSMISave.Text = global::NPaint.Properties.Resources.SaveMenuItem;
            // 
            // toolSMISaveAs
            // 
            this.toolSMISaveAs.Name = "toolSMISaveAs";
            this.toolSMISaveAs.Size = new System.Drawing.Size(152, 22);
            this.toolSMISaveAs.Text = global::NPaint.Properties.Resources.SaveAsMenuItem;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolSMIExit
            // 
            this.toolSMIExit.Name = "toolSMIExit";
            this.toolSMIExit.Size = new System.Drawing.Size(152, 22);
            this.toolSMIExit.Text = global::NPaint.Properties.Resources.ExitMenuItem;
            this.toolSMIExit.Click += new System.EventHandler(this.toolSMIExit_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dToolStripMenuItem.Text = global::NPaint.Properties.Resources.EditMenu;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanelTopButtons, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 2;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(868, 416);
            this.tableLayoutPanelBottom.TabIndex = 2;
            // 
            // tableLayoutPanelTopButtons
            // 
            this.tableLayoutPanelTopButtons.ColumnCount = 2;
            this.tableLayoutPanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTopButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTopButtons.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTopButtons.Name = "tableLayoutPanelTopButtons";
            this.tableLayoutPanelTopButtons.RowCount = 7;
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTopButtons.Size = new System.Drawing.Size(67, 202);
            this.tableLayoutPanelTopButtons.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPaint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolSMIFile;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolSMINew;
        private System.Windows.Forms.ToolStripMenuItem toolSMIOpe;
        private System.Windows.Forms.ToolStripMenuItem toolSMISave;
        private System.Windows.Forms.ToolStripMenuItem toolSMISaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolSMIExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopButtons;
    }
}

