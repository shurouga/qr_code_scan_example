namespace QRScanExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbCameraCapture = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txbScanResult = new System.Windows.Forms.TextBox();
            this.cbCameraList = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // pbCameraCapture
            // 
            this.pbCameraCapture.Location = new System.Drawing.Point(46, 75);
            this.pbCameraCapture.Margin = new System.Windows.Forms.Padding(2);
            this.pbCameraCapture.Name = "pbCameraCapture";
            this.pbCameraCapture.Size = new System.Drawing.Size(383, 291);
            this.pbCameraCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCameraCapture.TabIndex = 2;
            this.pbCameraCapture.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(456, 75);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Scan";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txbScanResult
            // 
            this.txbScanResult.Location = new System.Drawing.Point(456, 175);
            this.txbScanResult.Margin = new System.Windows.Forms.Padding(2);
            this.txbScanResult.Multiline = true;
            this.txbScanResult.Name = "txbScanResult";
            this.txbScanResult.ReadOnly = true;
            this.txbScanResult.Size = new System.Drawing.Size(182, 92);
            this.txbScanResult.TabIndex = 5;
            // 
            // cbCameraList
            // 
            this.cbCameraList.FormattingEnabled = true;
            this.cbCameraList.Location = new System.Drawing.Point(180, 34);
            this.cbCameraList.Margin = new System.Windows.Forms.Padding(2);
            this.cbCameraList.Name = "cbCameraList";
            this.cbCameraList.Size = new System.Drawing.Size(251, 21);
            this.cbCameraList.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCameraList);
            this.Controls.Add(this.txbScanResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbCameraCapture);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCameraCapture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txbScanResult;
        private System.Windows.Forms.ComboBox cbCameraList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

