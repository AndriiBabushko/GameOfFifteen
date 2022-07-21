namespace CourseWork
{
    partial class RACCOON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RACCOON));
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.textBox_clicks = new System.Windows.Forms.TextBox();
            this.label_click_on_raccoon = new System.Windows.Forms.Label();
            this.RaccoonPic = new System.Windows.Forms.PictureBox();
            this.groupBox_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RaccoonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_menu.Controls.Add(this.textBox_clicks);
            this.groupBox_menu.Controls.Add(this.label_click_on_raccoon);
            this.groupBox_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.groupBox_menu, "groupBox_menu");
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.TabStop = false;
            // 
            // textBox_clicks
            // 
            resources.ApplyResources(this.textBox_clicks, "textBox_clicks");
            this.textBox_clicks.Name = "textBox_clicks";
            // 
            // label_click_on_raccoon
            // 
            resources.ApplyResources(this.label_click_on_raccoon, "label_click_on_raccoon");
            this.label_click_on_raccoon.Name = "label_click_on_raccoon";
            // 
            // RaccoonPic
            // 
            resources.ApplyResources(this.RaccoonPic, "RaccoonPic");
            this.RaccoonPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RaccoonPic.Name = "RaccoonPic";
            this.RaccoonPic.TabStop = false;
            this.RaccoonPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RACCOON
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RaccoonPic);
            this.Controls.Add(this.groupBox_menu);
            this.Name = "RACCOON";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RACOON_FormClosed);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RaccoonPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.TextBox textBox_clicks;
        private System.Windows.Forms.Label label_click_on_raccoon;
        private System.Windows.Forms.PictureBox RaccoonPic;
    }
}