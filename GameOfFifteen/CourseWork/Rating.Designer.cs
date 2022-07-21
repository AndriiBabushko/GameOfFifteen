namespace CourseWork
{
    partial class Rating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating));
            this.textBox_rating_no_level = new System.Windows.Forms.TextBox();
            this.groupBox_rating = new System.Windows.Forms.GroupBox();
            this.label_level = new System.Windows.Forms.Label();
            this.label_no_level = new System.Windows.Forms.Label();
            this.textBox_rating_level = new System.Windows.Forms.TextBox();
            this.label_rating = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_from_rating_to_menu = new System.Windows.Forms.Button();
            this.groupBox_rating.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_rating_no_level
            // 
            resources.ApplyResources(this.textBox_rating_no_level, "textBox_rating_no_level");
            this.textBox_rating_no_level.BackColor = System.Drawing.Color.Silver;
            this.textBox_rating_no_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_rating_no_level.Name = "textBox_rating_no_level";
            this.textBox_rating_no_level.ReadOnly = true;
            // 
            // groupBox_rating
            // 
            resources.ApplyResources(this.groupBox_rating, "groupBox_rating");
            this.groupBox_rating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_rating.Controls.Add(this.label_level);
            this.groupBox_rating.Controls.Add(this.label_no_level);
            this.groupBox_rating.Controls.Add(this.textBox_rating_level);
            this.groupBox_rating.Controls.Add(this.textBox_rating_no_level);
            this.groupBox_rating.Name = "groupBox_rating";
            this.groupBox_rating.TabStop = false;
            // 
            // label_level
            // 
            resources.ApplyResources(this.label_level, "label_level");
            this.label_level.Name = "label_level";
            // 
            // label_no_level
            // 
            resources.ApplyResources(this.label_no_level, "label_no_level");
            this.label_no_level.Name = "label_no_level";
            // 
            // textBox_rating_level
            // 
            resources.ApplyResources(this.textBox_rating_level, "textBox_rating_level");
            this.textBox_rating_level.BackColor = System.Drawing.Color.Silver;
            this.textBox_rating_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_rating_level.Name = "textBox_rating_level";
            this.textBox_rating_level.ReadOnly = true;
            // 
            // label_rating
            // 
            resources.ApplyResources(this.label_rating, "label_rating");
            this.label_rating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_rating.Name = "label_rating";
            // 
            // button_refresh
            // 
            resources.ApplyResources(this.button_refresh, "button_refresh");
            this.button_refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_from_rating_to_menu
            // 
            resources.ApplyResources(this.button_from_rating_to_menu, "button_from_rating_to_menu");
            this.button_from_rating_to_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_from_rating_to_menu.Name = "button_from_rating_to_menu";
            this.button_from_rating_to_menu.UseVisualStyleBackColor = false;
            this.button_from_rating_to_menu.Click += new System.EventHandler(this.button_from_rating_to_menu_Click);
            // 
            // Rating
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_from_rating_to_menu);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.groupBox_rating);
            this.Name = "Rating";
            this.Load += new System.EventHandler(this.Rating_Load);
            this.groupBox_rating.ResumeLayout(false);
            this.groupBox_rating.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_rating_no_level;
        private System.Windows.Forms.GroupBox groupBox_rating;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_from_rating_to_menu;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_no_level;
        private System.Windows.Forms.TextBox textBox_rating_level;
    }
}