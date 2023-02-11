namespace DBGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.domainUpDown_select_Instance = new System.Windows.Forms.DomainUpDown();
            this.label_domainUpDown = new System.Windows.Forms.Label();
            this.label_Folder = new System.Windows.Forms.Label();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.textBox_Folder = new System.Windows.Forms.TextBox();
            this.label_db_name = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBox_database_name = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDatabase.Location = new System.Drawing.Point(118, 151);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(104, 23);
            this.btnCreateDatabase.TabIndex = 0;
            this.btnCreateDatabase.Text = "Create Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // domainUpDown_select_Instance
            // 
            this.domainUpDown_select_Instance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown_select_Instance.Location = new System.Drawing.Point(102, 12);
            this.domainUpDown_select_Instance.Name = "domainUpDown_select_Instance";
            this.domainUpDown_select_Instance.ReadOnly = true;
            this.domainUpDown_select_Instance.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown_select_Instance.TabIndex = 2;
            // 
            // label_domainUpDown
            // 
            this.label_domainUpDown.AutoSize = true;
            this.label_domainUpDown.Location = new System.Drawing.Point(12, 14);
            this.label_domainUpDown.Name = "label_domainUpDown";
            this.label_domainUpDown.Size = new System.Drawing.Size(83, 13);
            this.label_domainUpDown.TabIndex = 3;
            this.label_domainUpDown.Text = "Select Server(?)";
            this.toolTip1.SetToolTip(this.label_domainUpDown, "Make sure you have \"SQL Server\" installed.");
            // 
            // label_Folder
            // 
            this.label_Folder.AutoSize = true;
            this.label_Folder.Location = new System.Drawing.Point(15, 47);
            this.label_Folder.Name = "label_Folder";
            this.label_Folder.Size = new System.Drawing.Size(104, 13);
            this.label_Folder.TabIndex = 4;
            this.label_Folder.Text = "Installation Folder (?)";
            this.toolTip1.SetToolTip(this.label_Folder, resources.GetString("label_Folder.ToolTip"));
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select_folder.Location = new System.Drawing.Point(147, 42);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_select_folder.TabIndex = 5;
            this.btn_select_folder.Text = "specify..";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // textBox_Folder
            // 
            this.textBox_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Folder.Enabled = false;
            this.textBox_Folder.Location = new System.Drawing.Point(12, 71);
            this.textBox_Folder.Name = "textBox_Folder";
            this.textBox_Folder.Size = new System.Drawing.Size(210, 20);
            this.textBox_Folder.TabIndex = 6;
            // 
            // label_db_name
            // 
            this.label_db_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_db_name.AutoSize = true;
            this.label_db_name.Location = new System.Drawing.Point(57, 100);
            this.label_db_name.Name = "label_db_name";
            this.label_db_name.Size = new System.Drawing.Size(133, 13);
            this.label_db_name.TabIndex = 7;
            this.label_db_name.Text = "Type name of Database(?)";
            this.toolTip1.SetToolTip(this.label_db_name, "The Name must be unique for both the folder and the server.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // maskedTextBox_database_name
            // 
            this.maskedTextBox_database_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_database_name.Location = new System.Drawing.Point(12, 116);
            this.maskedTextBox_database_name.Name = "maskedTextBox_database_name";
            this.maskedTextBox_database_name.Size = new System.Drawing.Size(210, 20);
            this.maskedTextBox_database_name.TabIndex = 8;
            this.maskedTextBox_database_name.TextChanged += new System.EventHandler(this.maskedTextBox_database_name_TextChanged);
            this.maskedTextBox_database_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_database_name_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 186);
            this.Controls.Add(this.maskedTextBox_database_name);
            this.Controls.Add(this.label_db_name);
            this.Controls.Add(this.textBox_Folder);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.label_Folder);
            this.Controls.Add(this.label_domainUpDown);
            this.Controls.Add(this.domainUpDown_select_Instance);
            this.Controls.Add(this.btnCreateDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.DomainUpDown domainUpDown_select_Instance;
        private System.Windows.Forms.Label label_domainUpDown;
        private System.Windows.Forms.Label label_Folder;
        private System.Windows.Forms.Button btn_select_folder;
        private System.Windows.Forms.TextBox textBox_Folder;
        private System.Windows.Forms.Label label_db_name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_database_name;
    }
}

