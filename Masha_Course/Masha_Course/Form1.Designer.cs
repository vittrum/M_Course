namespace Masha_Course {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabStaffClient = new System.Windows.Forms.TabPage();
            this.tabTrainer = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.rbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.dgvShowClients = new System.Windows.Forms.DataGridView();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabStaffClient.SuspendLayout();
            this.tabTrainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabStaffClient);
            this.tabControl1.Controls.Add(this.tabTrainer);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.comboBox1);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.textBox3);
            this.tabLogin.Controls.Add(this.textBox1);
            this.tabLogin.Location = new System.Drawing.Point(4, 26);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1037, 613);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabStaffClient
            // 
            this.tabStaffClient.Controls.Add(this.btnCreateClient);
            this.tabStaffClient.Controls.Add(this.label8);
            this.tabStaffClient.Controls.Add(this.label7);
            this.tabStaffClient.Controls.Add(this.label6);
            this.tabStaffClient.Controls.Add(this.label5);
            this.tabStaffClient.Controls.Add(this.label4);
            this.tabStaffClient.Controls.Add(this.rbLastName);
            this.tabStaffClient.Controls.Add(this.tbPatr);
            this.tabStaffClient.Controls.Add(this.tbNumber);
            this.tabStaffClient.Controls.Add(this.tbEmail);
            this.tabStaffClient.Controls.Add(this.tbName);
            this.tabStaffClient.Location = new System.Drawing.Point(4, 26);
            this.tabStaffClient.Name = "tabStaffClient";
            this.tabStaffClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffClient.Size = new System.Drawing.Size(1037, 613);
            this.tabStaffClient.TabIndex = 1;
            this.tabStaffClient.Text = "Register client";
            this.tabStaffClient.UseVisualStyleBackColor = true;
            // 
            // tabTrainer
            // 
            this.tabTrainer.Controls.Add(this.btnShowClients);
            this.tabTrainer.Controls.Add(this.dgvShowClients);
            this.tabTrainer.Location = new System.Drawing.Point(4, 26);
            this.tabTrainer.Name = "tabTrainer";
            this.tabTrainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainer.Size = new System.Drawing.Size(1037, 613);
            this.tabTrainer.TabIndex = 2;
            this.tabTrainer.Text = "Trainer";
            this.tabTrainer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 613);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1037, 613);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 25);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Роль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пороль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(109, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 25);
            this.comboBox1.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 25);
            this.tbName.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(124, 244);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(165, 25);
            this.tbEmail.TabIndex = 1;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(124, 197);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(165, 25);
            this.tbNumber.TabIndex = 2;
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(124, 145);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(165, 25);
            this.tbPatr.TabIndex = 3;
            // 
            // rbLastName
            // 
            this.rbLastName.Location = new System.Drawing.Point(124, 95);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(165, 25);
            this.rbLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Patronymic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lastname";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(32, 291);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(257, 36);
            this.btnCreateClient.TabIndex = 10;
            this.btnCreateClient.Text = "Create client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // dgvShowClients
            // 
            this.dgvShowClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowClients.Location = new System.Drawing.Point(88, 223);
            this.dgvShowClients.Name = "dgvShowClients";
            this.dgvShowClients.RowHeadersWidth = 51;
            this.dgvShowClients.RowTemplate.Height = 27;
            this.dgvShowClients.Size = new System.Drawing.Size(568, 282);
            this.dgvShowClients.TabIndex = 0;
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(88, 524);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(247, 45);
            this.btnShowClients.TabIndex = 1;
            this.btnShowClients.Text = "Показать";
            this.btnShowClients.UseVisualStyleBackColor = true;
            this.btnShowClients.Click += new System.EventHandler(this.BtnShowClients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabStaffClient.ResumeLayout(false);
            this.tabStaffClient.PerformLayout();
            this.tabTrainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabStaffClient;
        private System.Windows.Forms.TabPage tabTrainer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rbLastName;
        private System.Windows.Forms.TextBox tbPatr;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.DataGridView dgvShowClients;
    }
}

