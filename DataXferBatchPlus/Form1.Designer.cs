namespace DataXferBatchPlus
{
    partial class DataXferForm
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
            this.sourcetbx = new System.Windows.Forms.TextBox();
            this.targettbx = new System.Windows.Forms.TextBox();
            this.sbox = new System.Windows.Forms.CheckBox();
            this.BrowseSource = new System.Windows.Forms.Button();
            this.BrowseTarget = new System.Windows.Forms.Button();
            this.sourcelbl = new System.Windows.Forms.Label();
            this.targetlbl = new System.Windows.Forms.Label();
            this.transferbtn = new System.Windows.Forms.Button();
            this.nbox = new System.Windows.Forms.CheckBox();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.ybox = new System.Windows.Forms.CheckBox();
            this.fbox = new System.Windows.Forms.CheckBox();
            this.jbox = new System.Windows.Forms.CheckBox();
            this.qbox = new System.Windows.Forms.CheckBox();
            this.ubox = new System.Windows.Forms.CheckBox();
            this.lBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sourcetbx
            // 
            this.sourcetbx.Location = new System.Drawing.Point(55, 32);
            this.sourcetbx.Name = "sourcetbx";
            this.sourcetbx.Size = new System.Drawing.Size(202, 20);
            this.sourcetbx.TabIndex = 0;
            this.sourcetbx.TextChanged += new System.EventHandler(this.sourcetbx_TextChanged);
            // 
            // targettbx
            // 
            this.targettbx.Location = new System.Drawing.Point(55, 67);
            this.targettbx.Name = "targettbx";
            this.targettbx.Size = new System.Drawing.Size(202, 20);
            this.targettbx.TabIndex = 1;
            this.targettbx.TextChanged += new System.EventHandler(this.targettbx_TextChanged);
            // 
            // sbox
            // 
            this.sbox.AutoSize = true;
            this.sbox.Checked = true;
            this.sbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sbox.Location = new System.Drawing.Point(17, 93);
            this.sbox.Name = "sbox";
            this.sbox.Size = new System.Drawing.Size(88, 17);
            this.sbox.TabIndex = 2;
            this.sbox.Text = "File Structure";
            this.sbox.UseVisualStyleBackColor = true;
            // 
            // BrowseSource
            // 
            this.BrowseSource.Location = new System.Drawing.Point(263, 30);
            this.BrowseSource.Name = "BrowseSource";
            this.BrowseSource.Size = new System.Drawing.Size(75, 23);
            this.BrowseSource.TabIndex = 3;
            this.BrowseSource.Text = "Browse...";
            this.BrowseSource.UseVisualStyleBackColor = true;
            this.BrowseSource.Click += new System.EventHandler(this.BrowseSource_Click);
            // 
            // BrowseTarget
            // 
            this.BrowseTarget.Location = new System.Drawing.Point(263, 65);
            this.BrowseTarget.Name = "BrowseTarget";
            this.BrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.BrowseTarget.TabIndex = 4;
            this.BrowseTarget.Text = "Browse...";
            this.BrowseTarget.UseVisualStyleBackColor = true;
            this.BrowseTarget.Click += new System.EventHandler(this.BrowseTarget_Click);
            // 
            // sourcelbl
            // 
            this.sourcelbl.AutoSize = true;
            this.sourcelbl.Location = new System.Drawing.Point(14, 35);
            this.sourcelbl.Name = "sourcelbl";
            this.sourcelbl.Size = new System.Drawing.Size(41, 13);
            this.sourcelbl.TabIndex = 5;
            this.sourcelbl.Text = "Source";
            // 
            // targetlbl
            // 
            this.targetlbl.AutoSize = true;
            this.targetlbl.Location = new System.Drawing.Point(14, 69);
            this.targetlbl.Name = "targetlbl";
            this.targetlbl.Size = new System.Drawing.Size(38, 13);
            this.targetlbl.TabIndex = 6;
            this.targetlbl.Text = "Target";
            // 
            // transferbtn
            // 
            this.transferbtn.Location = new System.Drawing.Point(146, 227);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(75, 23);
            this.transferbtn.TabIndex = 7;
            this.transferbtn.Text = "Transfer";
            this.transferbtn.UseVisualStyleBackColor = true;
            this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
            // 
            // nbox
            // 
            this.nbox.AutoSize = true;
            this.nbox.Checked = true;
            this.nbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nbox.Location = new System.Drawing.Point(17, 116);
            this.nbox.Name = "nbox";
            this.nbox.Size = new System.Drawing.Size(99, 17);
            this.nbox.TabIndex = 8;
            this.nbox.Text = "Shorten Names";
            this.nbox.UseVisualStyleBackColor = true;
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Checked = true;
            this.cbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbox.Location = new System.Drawing.Point(17, 139);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(86, 17);
            this.cbox.TabIndex = 9;
            this.cbox.Text = "Ignore Errors";
            this.cbox.UseVisualStyleBackColor = true;
            // 
            // ybox
            // 
            this.ybox.AutoSize = true;
            this.ybox.Checked = true;
            this.ybox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ybox.Location = new System.Drawing.Point(17, 162);
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(79, 17);
            this.ybox.TabIndex = 10;
            this.ybox.Text = "Agree to all";
            this.ybox.UseVisualStyleBackColor = true;
            // 
            // fbox
            // 
            this.fbox.AutoSize = true;
            this.fbox.Checked = true;
            this.fbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbox.Location = new System.Drawing.Point(16, 185);
            this.fbox.Name = "fbox";
            this.fbox.Size = new System.Drawing.Size(100, 17);
            this.fbox.TabIndex = 11;
            this.fbox.Text = "Display full path";
            this.fbox.UseVisualStyleBackColor = true;
            this.fbox.CheckedChanged += new System.EventHandler(this.fbox_CheckedChanged);
            // 
            // jbox
            // 
            this.jbox.AutoSize = true;
            this.jbox.Checked = true;
            this.jbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jbox.Location = new System.Drawing.Point(16, 208);
            this.jbox.Name = "jbox";
            this.jbox.Size = new System.Drawing.Size(112, 17);
            this.jbox.TabIndex = 12;
            this.jbox.Text = "Unbuffered output";
            this.jbox.UseVisualStyleBackColor = true;
            // 
            // qbox
            // 
            this.qbox.AutoSize = true;
            this.qbox.Location = new System.Drawing.Point(177, 93);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(75, 17);
            this.qbox.TabIndex = 13;
            this.qbox.Text = "No display";
            this.qbox.UseVisualStyleBackColor = true;
            this.qbox.CheckedChanged += new System.EventHandler(this.qbox_CheckedChanged);
            // 
            // ubox
            // 
            this.ubox.AutoSize = true;
            this.ubox.Location = new System.Drawing.Point(177, 116);
            this.ubox.Name = "ubox";
            this.ubox.Size = new System.Drawing.Size(85, 17);
            this.ubox.TabIndex = 14;
            this.ubox.Text = "Update Only";
            this.ubox.UseVisualStyleBackColor = true;
            // 
            // lBox
            // 
            this.lBox.AutoSize = true;
            this.lBox.Location = new System.Drawing.Point(177, 208);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(71, 17);
            this.lBox.TabIndex = 15;
            this.lBox.Text = "Test Only";
            this.lBox.UseVisualStyleBackColor = true;
            // 
            // DataXferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.ubox);
            this.Controls.Add(this.qbox);
            this.Controls.Add(this.jbox);
            this.Controls.Add(this.fbox);
            this.Controls.Add(this.ybox);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.nbox);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.targetlbl);
            this.Controls.Add(this.sourcelbl);
            this.Controls.Add(this.BrowseTarget);
            this.Controls.Add(this.BrowseSource);
            this.Controls.Add(this.sbox);
            this.Controls.Add(this.targettbx);
            this.Controls.Add(this.sourcetbx);
            this.Name = "DataXferForm";
            this.Text = "Data Transfer Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcetbx;
        private System.Windows.Forms.TextBox targettbx;
        private System.Windows.Forms.CheckBox sbox;
        private System.Windows.Forms.Button BrowseSource;
        private System.Windows.Forms.Button BrowseTarget;
        private System.Windows.Forms.Label sourcelbl;
        private System.Windows.Forms.Label targetlbl;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.CheckBox nbox;
        private System.Windows.Forms.CheckBox cbox;
        private System.Windows.Forms.CheckBox ybox;
        private System.Windows.Forms.CheckBox fbox;
        private System.Windows.Forms.CheckBox jbox;
        private System.Windows.Forms.CheckBox qbox;
        private System.Windows.Forms.CheckBox ubox;
        private System.Windows.Forms.CheckBox lBox;
    }
}

