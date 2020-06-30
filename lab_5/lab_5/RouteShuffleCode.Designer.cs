namespace lab_5
{
    partial class RouteShuffleCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteShuffleCode));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.decodeButton = new System.Windows.Forms.RadioButton();
            this.encodeButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.gotoButton = new System.Windows.Forms.Button();
            this.TextInfo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chartButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files|*.txt";
            this.openFileDialog1.Title = "Choose file";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(102, 5);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(110, 30);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.decodeButton);
            this.groupBox.Controls.Add(this.encodeButton);
            this.groupBox.Location = new System.Drawing.Point(12, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 100);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Action";
            // 
            // decodeButton
            // 
            this.decodeButton.AutoSize = true;
            this.decodeButton.Location = new System.Drawing.Point(8, 57);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(76, 21);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // encodeButton
            // 
            this.encodeButton.AutoSize = true;
            this.encodeButton.Checked = true;
            this.encodeButton.Location = new System.Drawing.Point(8, 30);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(76, 21);
            this.encodeButton.TabIndex = 0;
            this.encodeButton.TabStop = true;
            this.encodeButton.Text = "encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original text";
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(12, 155);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(200, 39);
            this.executeButton.TabIndex = 4;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(302, 155);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(248, 39);
            this.gotoButton.TabIndex = 5;
            this.gotoButton.Text = "Go to multiple shuffle code";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // TextInfo
            // 
            this.TextInfo.AutoSize = true;
            this.TextInfo.Location = new System.Drawing.Point(218, 38);
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.Size = new System.Drawing.Size(0, 17);
            this.TextInfo.TabIndex = 6;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Save file";
            // 
            // chartButton
            // 
            this.chartButton.AutoSize = true;
            this.chartButton.Enabled = false;
            this.chartButton.Image = ((System.Drawing.Image)(resources.GetObject("chartButton.Image")));
            this.chartButton.Location = new System.Drawing.Point(221, 155);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(75, 39);
            this.chartButton.TabIndex = 7;
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(218, 12);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 17);
            this.fileName.TabIndex = 8;
            // 
            // RouteShuffleCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 206);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.TextInfo);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.openFileButton);
            this.Name = "RouteShuffleCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RouteShuffleCode";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton decodeButton;
        private System.Windows.Forms.RadioButton encodeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button gotoButton;
        private System.Windows.Forms.Label TextInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Label fileName;
    }
}