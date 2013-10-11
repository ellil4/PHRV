namespace PsychHRV
{
    partial class FlashPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashPanel));
            this.amSendBtn = new System.Windows.Forms.Button();
            this.amTextBox = new System.Windows.Forms.TextBox();
            this.amSendBackTextLabel = new System.Windows.Forms.Label();
            this.amBtnTotalFrame = new System.Windows.Forms.Button();
            this.amBtnCurFrm = new System.Windows.Forms.Button();
            this.amBtnPlay = new System.Windows.Forms.Button();
            this.amTbSpd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amLabelEffi = new System.Windows.Forms.Label();
            this.amFlashCtrl = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.amFlashCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // amSendBtn
            // 
            this.amSendBtn.Location = new System.Drawing.Point(731, 609);
            this.amSendBtn.Name = "amSendBtn";
            this.amSendBtn.Size = new System.Drawing.Size(75, 23);
            this.amSendBtn.TabIndex = 1;
            this.amSendBtn.Text = "Send";
            this.amSendBtn.UseVisualStyleBackColor = true;
            this.amSendBtn.Click += new System.EventHandler(this.amSendBtn_Click);
            // 
            // amTextBox
            // 
            this.amTextBox.Location = new System.Drawing.Point(372, 609);
            this.amTextBox.Name = "amTextBox";
            this.amTextBox.Size = new System.Drawing.Size(343, 21);
            this.amTextBox.TabIndex = 2;
            // 
            // amSendBackTextLabel
            // 
            this.amSendBackTextLabel.AutoSize = true;
            this.amSendBackTextLabel.Location = new System.Drawing.Point(13, 609);
            this.amSendBackTextLabel.Name = "amSendBackTextLabel";
            this.amSendBackTextLabel.Size = new System.Drawing.Size(41, 12);
            this.amSendBackTextLabel.TabIndex = 3;
            this.amSendBackTextLabel.Text = "label1";
            // 
            // amBtnTotalFrame
            // 
            this.amBtnTotalFrame.Location = new System.Drawing.Point(372, 636);
            this.amBtnTotalFrame.Name = "amBtnTotalFrame";
            this.amBtnTotalFrame.Size = new System.Drawing.Size(75, 23);
            this.amBtnTotalFrame.TabIndex = 4;
            this.amBtnTotalFrame.Text = "Total Frm";
            this.amBtnTotalFrame.UseVisualStyleBackColor = true;
            this.amBtnTotalFrame.Click += new System.EventHandler(this.amBtnTotalFrame_Click);
            // 
            // amBtnCurFrm
            // 
            this.amBtnCurFrm.Location = new System.Drawing.Point(453, 636);
            this.amBtnCurFrm.Name = "amBtnCurFrm";
            this.amBtnCurFrm.Size = new System.Drawing.Size(75, 23);
            this.amBtnCurFrm.TabIndex = 5;
            this.amBtnCurFrm.Text = "Cur. Frm.";
            this.amBtnCurFrm.UseVisualStyleBackColor = true;
            this.amBtnCurFrm.Click += new System.EventHandler(this.amBtnCurFrm_Click);
            // 
            // amBtnPlay
            // 
            this.amBtnPlay.Location = new System.Drawing.Point(617, 636);
            this.amBtnPlay.Name = "amBtnPlay";
            this.amBtnPlay.Size = new System.Drawing.Size(75, 23);
            this.amBtnPlay.TabIndex = 6;
            this.amBtnPlay.Text = "play";
            this.amBtnPlay.UseVisualStyleBackColor = true;
            this.amBtnPlay.Click += new System.EventHandler(this.amBtnPlay_Click);
            // 
            // amTbSpd
            // 
            this.amTbSpd.Location = new System.Drawing.Point(731, 638);
            this.amTbSpd.Name = "amTbSpd";
            this.amTbSpd.Size = new System.Drawing.Size(77, 21);
            this.amTbSpd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Spd:";
            // 
            // amLabelEffi
            // 
            this.amLabelEffi.AutoSize = true;
            this.amLabelEffi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amLabelEffi.Location = new System.Drawing.Point(13, 641);
            this.amLabelEffi.Name = "amLabelEffi";
            this.amLabelEffi.Size = new System.Drawing.Size(115, 14);
            this.amLabelEffi.TabIndex = 9;
            this.amLabelEffi.Text = "Efficiency Display";
            // 
            // amFlashCtrl
            // 
            this.amFlashCtrl.Enabled = true;
            this.amFlashCtrl.Location = new System.Drawing.Point(-1, 0);
            this.amFlashCtrl.Name = "amFlashCtrl";
            this.amFlashCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("amFlashCtrl.OcxState")));
            this.amFlashCtrl.Size = new System.Drawing.Size(1350, 603);
            this.amFlashCtrl.TabIndex = 0;
            this.amFlashCtrl.FlashCall += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEventHandler(this.amFlashCtrl_FlashCall);
            // 
            // FlashPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 662);
            this.Controls.Add(this.amLabelEffi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amTbSpd);
            this.Controls.Add(this.amBtnPlay);
            this.Controls.Add(this.amBtnCurFrm);
            this.Controls.Add(this.amBtnTotalFrame);
            this.Controls.Add(this.amSendBackTextLabel);
            this.Controls.Add(this.amTextBox);
            this.Controls.Add(this.amSendBtn);
            this.Controls.Add(this.amFlashCtrl);
            this.Name = "FlashPanel";
            this.Text = "FlashPanel";
            ((System.ComponentModel.ISupportInitialize)(this.amFlashCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash amFlashCtrl;
        private System.Windows.Forms.Button amSendBtn;
        private System.Windows.Forms.TextBox amTextBox;
        private System.Windows.Forms.Label amSendBackTextLabel;
        private System.Windows.Forms.Button amBtnTotalFrame;
        private System.Windows.Forms.Button amBtnCurFrm;
        private System.Windows.Forms.Button amBtnPlay;
        private System.Windows.Forms.TextBox amTbSpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amLabelEffi;
    }
}