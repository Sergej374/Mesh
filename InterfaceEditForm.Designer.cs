namespace Mesh
{
    partial class InterfaceEditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.displaySourcesBox = new System.Windows.Forms.CheckBox();
            this.displayTargetsButton = new System.Windows.Forms.CheckBox();
            this.displayNodesBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.displayTypeBox = new System.Windows.Forms.CheckBox();
            this.displayRadiusValBox = new System.Windows.Forms.CheckBox();
            this.displayIDBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displaySourcesBox);
            this.panel1.Controls.Add(this.displayTargetsButton);
            this.panel1.Controls.Add(this.displayNodesBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 114);
            this.panel1.TabIndex = 0;
            // 
            // displaySourcesBox
            // 
            this.displaySourcesBox.AutoSize = true;
            this.displaySourcesBox.Location = new System.Drawing.Point(8, 58);
            this.displaySourcesBox.Name = "displaySourcesBox";
            this.displaySourcesBox.Size = new System.Drawing.Size(65, 17);
            this.displaySourcesBox.TabIndex = 6;
            this.displaySourcesBox.Text = "Sources";
            this.displaySourcesBox.UseVisualStyleBackColor = true;
            this.displaySourcesBox.CheckedChanged += new System.EventHandler(this.displaySourcesBox_CheckedChanged);
            // 
            // displayTargetsButton
            // 
            this.displayTargetsButton.AutoSize = true;
            this.displayTargetsButton.Location = new System.Drawing.Point(8, 81);
            this.displayTargetsButton.Name = "displayTargetsButton";
            this.displayTargetsButton.Size = new System.Drawing.Size(62, 17);
            this.displayTargetsButton.TabIndex = 5;
            this.displayTargetsButton.Text = "Targets";
            this.displayTargetsButton.UseVisualStyleBackColor = true;
            this.displayTargetsButton.CheckedChanged += new System.EventHandler(this.displayTargetsButton_CheckedChanged);
            // 
            // displayNodesBox
            // 
            this.displayNodesBox.AutoSize = true;
            this.displayNodesBox.Location = new System.Drawing.Point(8, 35);
            this.displayNodesBox.Name = "displayNodesBox";
            this.displayNodesBox.Size = new System.Drawing.Size(57, 17);
            this.displayNodesBox.TabIndex = 4;
            this.displayNodesBox.Text = "Nodes";
            this.displayNodesBox.UseVisualStyleBackColor = true;
            this.displayNodesBox.CheckedChanged += new System.EventHandler(this.displayNodesBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nodes parts";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.displayTypeBox);
            this.panel2.Controls.Add(this.displayRadiusValBox);
            this.panel2.Controls.Add(this.displayIDBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(128, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 114);
            this.panel2.TabIndex = 1;
            // 
            // displayTypeBox
            // 
            this.displayTypeBox.AutoSize = true;
            this.displayTypeBox.Location = new System.Drawing.Point(6, 58);
            this.displayTypeBox.Name = "displayTypeBox";
            this.displayTypeBox.Size = new System.Drawing.Size(50, 17);
            this.displayTypeBox.TabIndex = 3;
            this.displayTypeBox.Text = "Type";
            this.displayTypeBox.UseVisualStyleBackColor = true;
            this.displayTypeBox.CheckedChanged += new System.EventHandler(this.displayTypeBox_CheckedChanged);
            // 
            // displayRadiusValBox
            // 
            this.displayRadiusValBox.AutoSize = true;
            this.displayRadiusValBox.Location = new System.Drawing.Point(6, 81);
            this.displayRadiusValBox.Name = "displayRadiusValBox";
            this.displayRadiusValBox.Size = new System.Drawing.Size(88, 17);
            this.displayRadiusValBox.TabIndex = 2;
            this.displayRadiusValBox.Text = "Radius value";
            this.displayRadiusValBox.UseVisualStyleBackColor = true;
            this.displayRadiusValBox.CheckedChanged += new System.EventHandler(this.displayRadiusValBox_CheckedChanged);
            // 
            // displayIDBox
            // 
            this.displayIDBox.AutoSize = true;
            this.displayIDBox.Location = new System.Drawing.Point(6, 35);
            this.displayIDBox.Name = "displayIDBox";
            this.displayIDBox.Size = new System.Drawing.Size(37, 17);
            this.displayIDBox.TabIndex = 1;
            this.displayIDBox.Text = "ID";
            this.displayIDBox.UseVisualStyleBackColor = true;
            this.displayIDBox.CheckedChanged += new System.EventHandler(this.displayIDBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Additional interface";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(249, 103);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // InterfaceEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 134);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InterfaceEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox displaySourcesBox;
        private System.Windows.Forms.CheckBox displayTargetsButton;
        private System.Windows.Forms.CheckBox displayNodesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox displayTypeBox;
        private System.Windows.Forms.CheckBox displayRadiusValBox;
        private System.Windows.Forms.CheckBox displayIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
    }
}