namespace GetHostIdByWL
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            HardIdEdit = new TextBox();
            btn_send_email = new Button();
            btn_copy = new Button();
            HardIdButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HardIdEdit);
            groupBox1.Controls.Add(btn_send_email);
            groupBox1.Controls.Add(btn_copy);
            groupBox1.Controls.Add(HardIdButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PC Hardware ID";
            // 
            // HardIdEdit
            // 
            HardIdEdit.Location = new Point(142, 24);
            HardIdEdit.Name = "HardIdEdit";
            HardIdEdit.Size = new Size(449, 23);
            HardIdEdit.TabIndex = 1;
            // 
            // btn_send_email
            // 
            btn_send_email.Location = new Point(366, 49);
            btn_send_email.Name = "btn_send_email";
            btn_send_email.Size = new Size(225, 27);
            btn_send_email.TabIndex = 0;
            btn_send_email.Text = "Send eMail";
            btn_send_email.UseVisualStyleBackColor = true;
            btn_send_email.Click += btn_send_email_Click;
            // 
            // btn_copy
            // 
            btn_copy.Location = new Point(142, 49);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(225, 27);
            btn_copy.TabIndex = 0;
            btn_copy.Text = "Copy";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // HardIdButton
            // 
            HardIdButton.Location = new Point(16, 23);
            HardIdButton.Name = "HardIdButton";
            HardIdButton.Size = new Size(120, 24);
            HardIdButton.TabIndex = 0;
            HardIdButton.Text = "Get Hardware ID";
            HardIdButton.UseVisualStyleBackColor = true;
            HardIdButton.Click += HardIdButton_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 106);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "获取计算机硬件ID(专用)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_send_email;
        private Button btn_copy;
        private Button HardIdButton;
        private TextBox HardIdEdit;
    }
}
