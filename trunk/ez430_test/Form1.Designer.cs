namespace ez430_test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.connectButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AccX = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AccXLabel = new System.Windows.Forms.Label();
            this.AccYLabel = new System.Windows.Forms.Label();
            this.AccY = new System.Windows.Forms.Label();
            this.AccZLabel = new System.Windows.Forms.Label();
            this.AccZ = new System.Windows.Forms.Label();
            this.serializeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.label_data = new System.Windows.Forms.Label();
            this.label_pattern = new System.Windows.Forms.Label();
            this.label_recognitionProcess = new System.Windows.Forms.Label();
            this.label_lastRecognized = new System.Windows.Forms.Label();
            this.button_loadReload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxY = new System.Windows.Forms.PictureBox();
            this.pictureBoxZ = new System.Windows.Forms.PictureBox();
            this.pictureBox_recognitionProcess = new System.Windows.Forms.PictureBox();
            this.pictureBox_lastRecognized = new System.Windows.Forms.PictureBox();
            this.pictureBox_pattern = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognitionProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lastRecognized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pattern)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(404, 59);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(129, 40);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(9, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(37, 13);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Status";
            // 
            // AccX
            // 
            this.AccX.AutoSize = true;
            this.AccX.Location = new System.Drawing.Point(316, 59);
            this.AccX.Name = "AccX";
            this.AccX.Size = new System.Drawing.Size(33, 13);
            this.AccX.TabIndex = 2;
            this.AccX.Text = "AccX";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AccXLabel
            // 
            this.AccXLabel.AutoSize = true;
            this.AccXLabel.Location = new System.Drawing.Point(274, 59);
            this.AccXLabel.Name = "AccXLabel";
            this.AccXLabel.Size = new System.Drawing.Size(36, 13);
            this.AccXLabel.TabIndex = 3;
            this.AccXLabel.Text = "AccX:";
            // 
            // AccYLabel
            // 
            this.AccYLabel.AutoSize = true;
            this.AccYLabel.Location = new System.Drawing.Point(274, 85);
            this.AccYLabel.Name = "AccYLabel";
            this.AccYLabel.Size = new System.Drawing.Size(36, 13);
            this.AccYLabel.TabIndex = 4;
            this.AccYLabel.Text = "AccY:";
            // 
            // AccY
            // 
            this.AccY.AutoSize = true;
            this.AccY.Location = new System.Drawing.Point(316, 85);
            this.AccY.Name = "AccY";
            this.AccY.Size = new System.Drawing.Size(33, 13);
            this.AccY.TabIndex = 5;
            this.AccY.Text = "AccY";
            // 
            // AccZLabel
            // 
            this.AccZLabel.AutoSize = true;
            this.AccZLabel.Location = new System.Drawing.Point(274, 111);
            this.AccZLabel.Name = "AccZLabel";
            this.AccZLabel.Size = new System.Drawing.Size(36, 13);
            this.AccZLabel.TabIndex = 6;
            this.AccZLabel.Text = "AccZ:";
            // 
            // AccZ
            // 
            this.AccZ.AutoSize = true;
            this.AccZ.Location = new System.Drawing.Point(316, 111);
            this.AccZ.Name = "AccZ";
            this.AccZ.Size = new System.Drawing.Size(33, 13);
            this.AccZ.TabIndex = 7;
            this.AccZ.Text = "AccZ";
            // 
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(404, 163);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(129, 40);
            this.serializeButton.TabIndex = 9;
            this.serializeButton.Text = "Serialize";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(404, 242);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(404, 216);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 13;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_data.Location = new System.Drawing.Point(8, 36);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(111, 20);
            this.label_data.TabIndex = 28;
            this.label_data.Text = "Data receving:";
            // 
            // label_pattern
            // 
            this.label_pattern.AutoSize = true;
            this.label_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pattern.Location = new System.Drawing.Point(273, 458);
            this.label_pattern.Name = "label_pattern";
            this.label_pattern.Size = new System.Drawing.Size(65, 20);
            this.label_pattern.TabIndex = 29;
            this.label_pattern.Text = "Pattern:";
            // 
            // label_recognitionProcess
            // 
            this.label_recognitionProcess.AutoSize = true;
            this.label_recognitionProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_recognitionProcess.Location = new System.Drawing.Point(273, 301);
            this.label_recognitionProcess.Name = "label_recognitionProcess";
            this.label_recognitionProcess.Size = new System.Drawing.Size(158, 20);
            this.label_recognitionProcess.TabIndex = 30;
            this.label_recognitionProcess.Text = "Recognition process:";
            // 
            // label_lastRecognized
            // 
            this.label_lastRecognized.AutoSize = true;
            this.label_lastRecognized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_lastRecognized.Location = new System.Drawing.Point(8, 458);
            this.label_lastRecognized.Name = "label_lastRecognized";
            this.label_lastRecognized.Size = new System.Drawing.Size(126, 20);
            this.label_lastRecognized.TabIndex = 32;
            this.label_lastRecognized.Text = "Last recognized:";
            // 
            // button_loadReload
            // 
            this.button_loadReload.Location = new System.Drawing.Point(404, 111);
            this.button_loadReload.Name = "button_loadReload";
            this.button_loadReload.Size = new System.Drawing.Size(129, 40);
            this.button_loadReload.TabIndex = 33;
            this.button_loadReload.Text = "Load";
            this.button_loadReload.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(274, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Count:";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_value.Location = new System.Drawing.Point(316, 144);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(45, 16);
            this.label_value.TabIndex = 36;
            this.label_value.Text = "label1";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count.Location = new System.Drawing.Point(316, 171);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(45, 16);
            this.label_count.TabIndex = 37;
            this.label_count.Text = "label1";
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.Color.White;
            this.pictureBoxX.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(256, 128);
            this.pictureBoxX.TabIndex = 40;
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxX_MouseMove);
            // 
            // pictureBoxY
            // 
            this.pictureBoxY.BackColor = System.Drawing.Color.White;
            this.pictureBoxY.Location = new System.Drawing.Point(12, 193);
            this.pictureBoxY.Name = "pictureBoxY";
            this.pictureBoxY.Size = new System.Drawing.Size(256, 128);
            this.pictureBoxY.TabIndex = 41;
            this.pictureBoxY.TabStop = false;
            // 
            // pictureBoxZ
            // 
            this.pictureBoxZ.BackColor = System.Drawing.Color.White;
            this.pictureBoxZ.Location = new System.Drawing.Point(12, 327);
            this.pictureBoxZ.Name = "pictureBoxZ";
            this.pictureBoxZ.Size = new System.Drawing.Size(256, 128);
            this.pictureBoxZ.TabIndex = 42;
            this.pictureBoxZ.TabStop = false;
            // 
            // pictureBox_recognitionProcess
            // 
            this.pictureBox_recognitionProcess.BackColor = System.Drawing.Color.White;
            this.pictureBox_recognitionProcess.Location = new System.Drawing.Point(277, 327);
            this.pictureBox_recognitionProcess.Name = "pictureBox_recognitionProcess";
            this.pictureBox_recognitionProcess.Size = new System.Drawing.Size(256, 128);
            this.pictureBox_recognitionProcess.TabIndex = 43;
            this.pictureBox_recognitionProcess.TabStop = false;
            // 
            // pictureBox_lastRecognized
            // 
            this.pictureBox_lastRecognized.BackColor = System.Drawing.Color.White;
            this.pictureBox_lastRecognized.Location = new System.Drawing.Point(12, 481);
            this.pictureBox_lastRecognized.Name = "pictureBox_lastRecognized";
            this.pictureBox_lastRecognized.Size = new System.Drawing.Size(256, 128);
            this.pictureBox_lastRecognized.TabIndex = 44;
            this.pictureBox_lastRecognized.TabStop = false;
            // 
            // pictureBox_pattern
            // 
            this.pictureBox_pattern.BackColor = System.Drawing.Color.White;
            this.pictureBox_pattern.Location = new System.Drawing.Point(277, 481);
            this.pictureBox_pattern.Name = "pictureBox_pattern";
            this.pictureBox_pattern.Size = new System.Drawing.Size(256, 128);
            this.pictureBox_pattern.TabIndex = 45;
            this.pictureBox_pattern.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 617);
            this.Controls.Add(this.pictureBox_pattern);
            this.Controls.Add(this.pictureBox_lastRecognized);
            this.Controls.Add(this.pictureBox_recognitionProcess);
            this.Controls.Add(this.pictureBoxZ);
            this.Controls.Add(this.pictureBoxY);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_loadReload);
            this.Controls.Add(this.label_lastRecognized);
            this.Controls.Add(this.label_recognitionProcess);
            this.Controls.Add(this.label_pattern);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.AccZ);
            this.Controls.Add(this.AccZLabel);
            this.Controls.Add(this.AccY);
            this.Controls.Add(this.AccYLabel);
            this.Controls.Add(this.AccXLabel);
            this.Controls.Add(this.AccX);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.connectButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_recognitionProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lastRecognized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pattern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label AccX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AccXLabel;
        private System.Windows.Forms.Label AccYLabel;
        private System.Windows.Forms.Label AccY;
        private System.Windows.Forms.Label AccZLabel;
        private System.Windows.Forms.Label AccZ;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_pattern;
        private System.Windows.Forms.Label label_recognitionProcess;
        private System.Windows.Forms.Label label_lastRecognized;
        private System.Windows.Forms.Button button_loadReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxY;
        private System.Windows.Forms.PictureBox pictureBoxZ;
        private System.Windows.Forms.PictureBox pictureBox_recognitionProcess;
        private System.Windows.Forms.PictureBox pictureBox_lastRecognized;
        private System.Windows.Forms.PictureBox pictureBox_pattern;
    }
}

