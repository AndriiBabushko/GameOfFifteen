namespace CourseWork
{
    partial class MenuSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSettings));
            this.button_language = new System.Windows.Forms.Button();
            this.button_russian = new System.Windows.Forms.Button();
            this.button_ukrainian = new System.Windows.Forms.Button();
            this.button_english = new System.Windows.Forms.Button();
            this.button_from_settings_to_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_language
            // 
            resources.ApplyResources(this.button_language, "button_language");
            this.button_language.Name = "button_language";
            this.button_language.UseVisualStyleBackColor = true;
            this.button_language.Click += new System.EventHandler(this.button_language_Click);
            // 
            // button_russian
            // 
            resources.ApplyResources(this.button_russian, "button_russian");
            this.button_russian.Name = "button_russian";
            this.button_russian.UseVisualStyleBackColor = true;
            this.button_russian.Click += new System.EventHandler(this.button_russian_Click);
            // 
            // button_ukrainian
            // 
            resources.ApplyResources(this.button_ukrainian, "button_ukrainian");
            this.button_ukrainian.Name = "button_ukrainian";
            this.button_ukrainian.UseVisualStyleBackColor = true;
            this.button_ukrainian.Click += new System.EventHandler(this.button_ukrainian_Click);
            // 
            // button_english
            // 
            resources.ApplyResources(this.button_english, "button_english");
            this.button_english.Name = "button_english";
            this.button_english.UseVisualStyleBackColor = true;
            this.button_english.Click += new System.EventHandler(this.button_english_Click);
            // 
            // button_from_settings_to_menu
            // 
            resources.ApplyResources(this.button_from_settings_to_menu, "button_from_settings_to_menu");
            this.button_from_settings_to_menu.Name = "button_from_settings_to_menu";
            this.button_from_settings_to_menu.UseVisualStyleBackColor = true;
            this.button_from_settings_to_menu.Click += new System.EventHandler(this.button_from_settings_to_menu_Click);
            // 
            // MenuSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_from_settings_to_menu);
            this.Controls.Add(this.button_english);
            this.Controls.Add(this.button_ukrainian);
            this.Controls.Add(this.button_russian);
            this.Controls.Add(this.button_language);
            this.Name = "MenuSettings";
            this.Load += new System.EventHandler(this.MenuSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_language;
        private System.Windows.Forms.Button button_russian;
        private System.Windows.Forms.Button button_ukrainian;
        private System.Windows.Forms.Button button_english;
        private System.Windows.Forms.Button button_from_settings_to_menu;
    }
}