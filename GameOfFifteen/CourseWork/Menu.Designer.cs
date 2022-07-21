namespace CourseWork
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label_menu = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_rating = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.label_game_name = new System.Windows.Forms.Label();
            this.linkLabel_student = new System.Windows.Forms.LinkLabel();
            this.groupBox_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_menu
            // 
            resources.ApplyResources(this.label_menu, "label_menu");
            this.label_menu.Name = "label_menu";
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_play, "button_play");
            this.button_play.Name = "button_play";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_menu.Controls.Add(this.button_exit);
            this.groupBox_menu.Controls.Add(this.button_rating);
            this.groupBox_menu.Controls.Add(this.button_settings);
            this.groupBox_menu.Controls.Add(this.label_menu);
            this.groupBox_menu.Controls.Add(this.button_play);
            this.groupBox_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.groupBox_menu, "groupBox_menu");
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_rating
            // 
            this.button_rating.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_rating, "button_rating");
            this.button_rating.Name = "button_rating";
            this.button_rating.UseVisualStyleBackColor = false;
            this.button_rating.Click += new System.EventHandler(this.button_rating_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_settings, "button_settings");
            this.button_settings.Name = "button_settings";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // label_game_name
            // 
            resources.ApplyResources(this.label_game_name, "label_game_name");
            this.label_game_name.Name = "label_game_name";
            // 
            // linkLabel_student
            // 
            resources.ApplyResources(this.linkLabel_student, "linkLabel_student");
            this.linkLabel_student.Name = "linkLabel_student";
            this.linkLabel_student.TabStop = true;
            this.linkLabel_student.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_student_LinkClicked);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel_student);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.label_game_name);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_rating;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Label label_game_name;
        private System.Windows.Forms.LinkLabel linkLabel_student;
    }
}

