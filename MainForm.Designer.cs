namespace Mesh
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.nodesEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.typeChooseButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.nodeTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.targetTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.selectedIDLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedTypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedRadiusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.workPanel = new System.Windows.Forms.Panel();
            this.netsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOnServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.editButton,
            this.toolStripSeparator1,
            this.typeChooseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.netsListToolStripMenuItem,
            this.saveOnServerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodesEditButton,
            this.interfaceEditButton});
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 22);
            this.editButton.Text = "Edit";
            // 
            // nodesEditButton
            // 
            this.nodesEditButton.Name = "nodesEditButton";
            this.nodesEditButton.Size = new System.Drawing.Size(120, 22);
            this.nodesEditButton.Text = "Nodes";
            this.nodesEditButton.Click += new System.EventHandler(this.nodesEditButton_Click);
            // 
            // interfaceEditButton
            // 
            this.interfaceEditButton.Name = "interfaceEditButton";
            this.interfaceEditButton.Size = new System.Drawing.Size(120, 22);
            this.interfaceEditButton.Text = "Interface";
            this.interfaceEditButton.Click += new System.EventHandler(this.interfaceEditButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // typeChooseButton
            // 
            this.typeChooseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.typeChooseButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodeTypeButton,
            this.sourceTypeButton,
            this.targetTypeButton});
            this.typeChooseButton.Enabled = false;
            this.typeChooseButton.Image = ((System.Drawing.Image)(resources.GetObject("typeChooseButton.Image")));
            this.typeChooseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.typeChooseButton.Name = "typeChooseButton";
            this.typeChooseButton.Size = new System.Drawing.Size(44, 22);
            this.typeChooseButton.Text = "Type";
            // 
            // nodeTypeButton
            // 
            this.nodeTypeButton.Name = "nodeTypeButton";
            this.nodeTypeButton.Size = new System.Drawing.Size(110, 22);
            this.nodeTypeButton.Text = "Node";
            this.nodeTypeButton.Click += new System.EventHandler(this.nodeTypeButton_Click);
            // 
            // sourceTypeButton
            // 
            this.sourceTypeButton.Name = "sourceTypeButton";
            this.sourceTypeButton.Size = new System.Drawing.Size(110, 22);
            this.sourceTypeButton.Text = "Source";
            this.sourceTypeButton.Click += new System.EventHandler(this.sourceTypeButton_Click);
            // 
            // targetTypeButton
            // 
            this.targetTypeButton.Name = "targetTypeButton";
            this.targetTypeButton.Size = new System.Drawing.Size(110, 22);
            this.targetTypeButton.Text = "Target";
            this.targetTypeButton.Click += new System.EventHandler(this.targetTypeButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedIDLabel,
            this.selectedTypeLabel,
            this.selectedRadiusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 381);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(617, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // selectedIDLabel
            // 
            this.selectedIDLabel.Name = "selectedIDLabel";
            this.selectedIDLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // selectedTypeLabel
            // 
            this.selectedTypeLabel.Name = "selectedTypeLabel";
            this.selectedTypeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // selectedRadiusLabel
            // 
            this.selectedRadiusLabel.Name = "selectedRadiusLabel";
            this.selectedRadiusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // workPanel
            // 
            this.workPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 25);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(617, 356);
            this.workPanel.TabIndex = 3;
            this.workPanel.SizeChanged += new System.EventHandler(this.workPanel_SizeChanged);
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workPanel_Paint);
            this.workPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseDown);
            this.workPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseMove);
            this.workPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseUp);
            // 
            // netsListToolStripMenuItem
            // 
            this.netsListToolStripMenuItem.Name = "netsListToolStripMenuItem";
            this.netsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.netsListToolStripMenuItem.Text = "Nets list";
            this.netsListToolStripMenuItem.Click += new System.EventHandler(this.netsListToolStripMenuItem_Click);
            // 
            // saveOnServerToolStripMenuItem
            // 
            this.saveOnServerToolStripMenuItem.Name = "saveOnServerToolStripMenuItem";
            this.saveOnServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveOnServerToolStripMenuItem.Text = "Save on server";
            this.saveOnServerToolStripMenuItem.Click += new System.EventHandler(this.saveOnServerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 403);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesh-network";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel selectedIDLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton typeChooseButton;
        private System.Windows.Forms.ToolStripMenuItem nodeTypeButton;
        private System.Windows.Forms.ToolStripMenuItem sourceTypeButton;
        private System.Windows.Forms.ToolStripMenuItem targetTypeButton;
        private System.Windows.Forms.ToolStripDropDownButton editButton;
        private System.Windows.Forms.ToolStripMenuItem nodesEditButton;
        private System.Windows.Forms.ToolStripMenuItem interfaceEditButton;
        public System.Windows.Forms.ToolStripStatusLabel selectedTypeLabel;
        public System.Windows.Forms.ToolStripStatusLabel selectedRadiusLabel;
        private System.Windows.Forms.ToolStripMenuItem netsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOnServerToolStripMenuItem;
    }
}

