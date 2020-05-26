namespace Mesh
{
    partial class NodesEditForm
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
            this.nodesLabel = new System.Windows.Forms.Label();
            this.nodesColorButton = new System.Windows.Forms.Button();
            this.sourcesColorButton = new System.Windows.Forms.Button();
            this.sourcesLabel = new System.Windows.Forms.Label();
            this.targetsColorButton = new System.Windows.Forms.Button();
            this.targetsLabel = new System.Windows.Forms.Label();
            this.radiusesColorButton = new System.Windows.Forms.Button();
            this.radiusesLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.colorsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linesThicknessBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.nodesSizeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.colorsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesThicknessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // nodesLabel
            // 
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Location = new System.Drawing.Point(14, 27);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(38, 13);
            this.nodesLabel.TabIndex = 0;
            this.nodesLabel.Text = "Nodes";
            // 
            // nodesColorButton
            // 
            this.nodesColorButton.Location = new System.Drawing.Point(71, 27);
            this.nodesColorButton.Name = "nodesColorButton";
            this.nodesColorButton.Size = new System.Drawing.Size(38, 23);
            this.nodesColorButton.TabIndex = 1;
            this.nodesColorButton.UseVisualStyleBackColor = true;
            this.nodesColorButton.Click += new System.EventHandler(this.nodesColorButton_Click);
            // 
            // sourcesColorButton
            // 
            this.sourcesColorButton.Location = new System.Drawing.Point(71, 56);
            this.sourcesColorButton.Name = "sourcesColorButton";
            this.sourcesColorButton.Size = new System.Drawing.Size(38, 23);
            this.sourcesColorButton.TabIndex = 3;
            this.sourcesColorButton.UseVisualStyleBackColor = true;
            this.sourcesColorButton.Click += new System.EventHandler(this.sourcesColorButton_Click);
            // 
            // sourcesLabel
            // 
            this.sourcesLabel.AutoSize = true;
            this.sourcesLabel.Location = new System.Drawing.Point(14, 56);
            this.sourcesLabel.Name = "sourcesLabel";
            this.sourcesLabel.Size = new System.Drawing.Size(46, 13);
            this.sourcesLabel.TabIndex = 2;
            this.sourcesLabel.Text = "Sources";
            // 
            // targetsColorButton
            // 
            this.targetsColorButton.Location = new System.Drawing.Point(71, 85);
            this.targetsColorButton.Name = "targetsColorButton";
            this.targetsColorButton.Size = new System.Drawing.Size(38, 23);
            this.targetsColorButton.TabIndex = 5;
            this.targetsColorButton.UseVisualStyleBackColor = true;
            this.targetsColorButton.Click += new System.EventHandler(this.targetsColorButton_Click);
            // 
            // targetsLabel
            // 
            this.targetsLabel.AutoSize = true;
            this.targetsLabel.Location = new System.Drawing.Point(14, 85);
            this.targetsLabel.Name = "targetsLabel";
            this.targetsLabel.Size = new System.Drawing.Size(43, 13);
            this.targetsLabel.TabIndex = 4;
            this.targetsLabel.Text = "Targets";
            // 
            // radiusesColorButton
            // 
            this.radiusesColorButton.Location = new System.Drawing.Point(71, 114);
            this.radiusesColorButton.Name = "radiusesColorButton";
            this.radiusesColorButton.Size = new System.Drawing.Size(38, 23);
            this.radiusesColorButton.TabIndex = 7;
            this.radiusesColorButton.UseVisualStyleBackColor = true;
            this.radiusesColorButton.Click += new System.EventHandler(this.radiusesColorButton_Click);
            // 
            // radiusesLabel
            // 
            this.radiusesLabel.AutoSize = true;
            this.radiusesLabel.Location = new System.Drawing.Point(14, 114);
            this.radiusesLabel.Name = "radiusesLabel";
            this.radiusesLabel.Size = new System.Drawing.Size(51, 13);
            this.radiusesLabel.TabIndex = 6;
            this.radiusesLabel.Text = "Radiuses";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(265, 215);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // colorsPanel
            // 
            this.colorsPanel.Controls.Add(this.selectedColorButton);
            this.colorsPanel.Controls.Add(this.label4);
            this.colorsPanel.Controls.Add(this.label3);
            this.colorsPanel.Controls.Add(this.nodesLabel);
            this.colorsPanel.Controls.Add(this.nodesColorButton);
            this.colorsPanel.Controls.Add(this.sourcesLabel);
            this.colorsPanel.Controls.Add(this.radiusesColorButton);
            this.colorsPanel.Controls.Add(this.sourcesColorButton);
            this.colorsPanel.Controls.Add(this.radiusesLabel);
            this.colorsPanel.Controls.Add(this.targetsLabel);
            this.colorsPanel.Controls.Add(this.targetsColorButton);
            this.colorsPanel.Location = new System.Drawing.Point(12, 12);
            this.colorsPanel.Name = "colorsPanel";
            this.colorsPanel.Size = new System.Drawing.Size(125, 176);
            this.colorsPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linesThicknessBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nodesSizeBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 176);
            this.panel1.TabIndex = 11;
            // 
            // linesThicknessBar
            // 
            this.linesThicknessBar.AutoSize = false;
            this.linesThicknessBar.LargeChange = 10;
            this.linesThicknessBar.Location = new System.Drawing.Point(3, 106);
            this.linesThicknessBar.Minimum = 1;
            this.linesThicknessBar.Name = "linesThicknessBar";
            this.linesThicknessBar.Size = new System.Drawing.Size(191, 31);
            this.linesThicknessBar.TabIndex = 3;
            this.linesThicknessBar.Value = 1;
            this.linesThicknessBar.Scroll += new System.EventHandler(this.linesThicknessBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lines thickness";
            // 
            // nodesSizeBar
            // 
            this.nodesSizeBar.AutoSize = false;
            this.nodesSizeBar.LargeChange = 10;
            this.nodesSizeBar.Location = new System.Drawing.Point(3, 38);
            this.nodesSizeBar.Maximum = 80;
            this.nodesSizeBar.Minimum = 2;
            this.nodesSizeBar.Name = "nodesSizeBar";
            this.nodesSizeBar.Size = new System.Drawing.Size(191, 31);
            this.nodesSizeBar.SmallChange = 2;
            this.nodesSizeBar.TabIndex = 1;
            this.nodesSizeBar.Value = 2;
            this.nodesSizeBar.Scroll += new System.EventHandler(this.nodesSizeBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nodes size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colors";
            // 
            // selectedColorButton
            // 
            this.selectedColorButton.Location = new System.Drawing.Point(71, 143);
            this.selectedColorButton.Name = "selectedColorButton";
            this.selectedColorButton.Size = new System.Drawing.Size(38, 23);
            this.selectedColorButton.TabIndex = 10;
            this.selectedColorButton.UseVisualStyleBackColor = true;
            this.selectedColorButton.Click += new System.EventHandler(this.selectedColorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selected";
            // 
            // NodesEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 250);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorsPanel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NodesEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit nodes";
            this.colorsPanel.ResumeLayout(false);
            this.colorsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linesThicknessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSizeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.Button nodesColorButton;
        private System.Windows.Forms.Button sourcesColorButton;
        private System.Windows.Forms.Label sourcesLabel;
        private System.Windows.Forms.Button targetsColorButton;
        private System.Windows.Forms.Label targetsLabel;
        private System.Windows.Forms.Button radiusesColorButton;
        private System.Windows.Forms.Label radiusesLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel colorsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar nodesSizeBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar linesThicknessBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectedColorButton;
        private System.Windows.Forms.Label label4;
    }
}