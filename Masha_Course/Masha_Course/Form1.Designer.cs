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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabStaffClient = new System.Windows.Forms.TabPage();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLastName = new System.Windows.Forms.TextBox();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tabTrainer = new System.Windows.Forms.TabPage();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.dgvShowClients = new System.Windows.Forms.DataGridView();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmpCreate = new System.Windows.Forms.Button();
            this.dateEmpExp = new System.Windows.Forms.DateTimePicker();
            this.dateEmpIss = new System.Windows.Forms.DateTimePicker();
            this.comboEmpPos = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmpPass = new System.Windows.Forms.TextBox();
            this.tbEmpService = new System.Windows.Forms.TextBox();
            this.tbEmpMail = new System.Windows.Forms.TextBox();
            this.tbEmpPhone = new System.Windows.Forms.TextBox();
            this.tbEmpPatr = new System.Windows.Forms.TextBox();
            this.tbEmpLname = new System.Windows.Forms.TextBox();
            this.tbEmpFname = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabStaffClient.SuspendLayout();
            this.tabTrainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).BeginInit();
            this.tabAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabStaffClient);
            this.tabControl1.Controls.Add(this.tabTrainer);
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.textBox3);
            this.tabLogin.Controls.Add(this.textBox1);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tabLogin.Size = new System.Drawing.Size(776, 466);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(71, 104);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 27);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пороль";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 68);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
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
            this.tabStaffClient.Location = new System.Drawing.Point(4, 22);
            this.tabStaffClient.Margin = new System.Windows.Forms.Padding(2);
            this.tabStaffClient.Name = "tabStaffClient";
            this.tabStaffClient.Padding = new System.Windows.Forms.Padding(2);
            this.tabStaffClient.Size = new System.Drawing.Size(776, 466);
            this.tabStaffClient.TabIndex = 1;
            this.tabStaffClient.Text = "Register client";
            this.tabStaffClient.UseVisualStyleBackColor = true;
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(24, 223);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(193, 28);
            this.btnCreateClient.TabIndex = 10;
            this.btnCreateClient.Text = "Create client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Patronymic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // rbLastName
            // 
            this.rbLastName.Location = new System.Drawing.Point(93, 73);
            this.rbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(125, 20);
            this.rbLastName.TabIndex = 4;
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(93, 111);
            this.tbPatr.Margin = new System.Windows.Forms.Padding(2);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(125, 20);
            this.tbPatr.TabIndex = 3;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(93, 151);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(125, 20);
            this.tbNumber.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(93, 187);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(125, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(93, 36);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 20);
            this.tbName.TabIndex = 0;
            // 
            // tabTrainer
            // 
            this.tabTrainer.Controls.Add(this.btnShowClients);
            this.tabTrainer.Controls.Add(this.dgvShowClients);
            this.tabTrainer.Location = new System.Drawing.Point(4, 22);
            this.tabTrainer.Margin = new System.Windows.Forms.Padding(2);
            this.tabTrainer.Name = "tabTrainer";
            this.tabTrainer.Padding = new System.Windows.Forms.Padding(2);
            this.tabTrainer.Size = new System.Drawing.Size(776, 466);
            this.tabTrainer.TabIndex = 2;
            this.tabTrainer.Text = "Trainer";
            this.tabTrainer.UseVisualStyleBackColor = true;
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(66, 401);
            this.btnShowClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(185, 34);
            this.btnShowClients.TabIndex = 1;
            this.btnShowClients.Text = "Показать";
            this.btnShowClients.UseVisualStyleBackColor = true;
            this.btnShowClients.Click += new System.EventHandler(this.BtnShowClients_Click);
            // 
            // dgvShowClients
            // 
            this.dgvShowClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowClients.Location = new System.Drawing.Point(66, 171);
            this.dgvShowClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShowClients.Name = "dgvShowClients";
            this.dgvShowClients.RowHeadersWidth = 51;
            this.dgvShowClients.RowTemplate.Height = 27;
            this.dgvShowClients.Size = new System.Drawing.Size(426, 216);
            this.dgvShowClients.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.groupBox2);
            this.tabAdmin.Controls.Add(this.groupBox1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Size = new System.Drawing.Size(951, 583);
            this.tabAdmin.TabIndex = 3;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(349, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add service";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmpCreate);
            this.groupBox1.Controls.Add(this.dateEmpExp);
            this.groupBox1.Controls.Add(this.dateEmpIss);
            this.groupBox1.Controls.Add(this.comboEmpPos);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmpPass);
            this.groupBox1.Controls.Add(this.tbEmpService);
            this.groupBox1.Controls.Add(this.tbEmpMail);
            this.groupBox1.Controls.Add(this.tbEmpPhone);
            this.groupBox1.Controls.Add(this.tbEmpPatr);
            this.groupBox1.Controls.Add(this.tbEmpLname);
            this.groupBox1.Controls.Add(this.tbEmpFname);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register employee";
            // 
            // btnEmpCreate
            // 
            this.btnEmpCreate.Location = new System.Drawing.Point(68, 318);
            this.btnEmpCreate.Name = "btnEmpCreate";
            this.btnEmpCreate.Size = new System.Drawing.Size(130, 37);
            this.btnEmpCreate.TabIndex = 23;
            this.btnEmpCreate.Text = "Create";
            this.btnEmpCreate.UseVisualStyleBackColor = true;
            this.btnEmpCreate.Click += new System.EventHandler(this.btnEmpCreate_Click);
            // 
            // dateEmpExp
            // 
            this.dateEmpExp.Location = new System.Drawing.Point(98, 244);
            this.dateEmpExp.Name = "dateEmpExp";
            this.dateEmpExp.Size = new System.Drawing.Size(200, 20);
            this.dateEmpExp.TabIndex = 22;
            // 
            // dateEmpIss
            // 
            this.dateEmpIss.Location = new System.Drawing.Point(98, 218);
            this.dateEmpIss.Name = "dateEmpIss";
            this.dateEmpIss.Size = new System.Drawing.Size(200, 20);
            this.dateEmpIss.TabIndex = 21;
            // 
            // comboEmpPos
            // 
            this.comboEmpPos.FormattingEnabled = true;
            this.comboEmpPos.Location = new System.Drawing.Point(98, 191);
            this.comboEmpPos.Name = "comboEmpPos";
            this.comboEmpPos.Size = new System.Drawing.Size(121, 21);
            this.comboEmpPos.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "pass";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "service";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "exp date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Iss date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "pos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Patr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fname";
            // 
            // tbEmpPass
            // 
            this.tbEmpPass.Location = new System.Drawing.Point(98, 292);
            this.tbEmpPass.Name = "tbEmpPass";
            this.tbEmpPass.Size = new System.Drawing.Size(100, 20);
            this.tbEmpPass.TabIndex = 9;
            // 
            // tbEmpService
            // 
            this.tbEmpService.Location = new System.Drawing.Point(98, 266);
            this.tbEmpService.Name = "tbEmpService";
            this.tbEmpService.Size = new System.Drawing.Size(100, 20);
            this.tbEmpService.TabIndex = 8;
            // 
            // tbEmpMail
            // 
            this.tbEmpMail.Location = new System.Drawing.Point(98, 162);
            this.tbEmpMail.Name = "tbEmpMail";
            this.tbEmpMail.Size = new System.Drawing.Size(100, 20);
            this.tbEmpMail.TabIndex = 4;
            // 
            // tbEmpPhone
            // 
            this.tbEmpPhone.Location = new System.Drawing.Point(98, 136);
            this.tbEmpPhone.Name = "tbEmpPhone";
            this.tbEmpPhone.Size = new System.Drawing.Size(100, 20);
            this.tbEmpPhone.TabIndex = 3;
            // 
            // tbEmpPatr
            // 
            this.tbEmpPatr.Location = new System.Drawing.Point(98, 110);
            this.tbEmpPatr.Name = "tbEmpPatr";
            this.tbEmpPatr.Size = new System.Drawing.Size(100, 20);
            this.tbEmpPatr.TabIndex = 2;
            // 
            // tbEmpLname
            // 
            this.tbEmpLname.Location = new System.Drawing.Point(98, 84);
            this.tbEmpLname.Name = "tbEmpLname";
            this.tbEmpLname.Size = new System.Drawing.Size(100, 20);
            this.tbEmpLname.TabIndex = 1;
            // 
            // tbEmpFname
            // 
            this.tbEmpFname.Location = new System.Drawing.Point(98, 49);
            this.tbEmpFname.Name = "tbEmpFname";
            this.tbEmpFname.Size = new System.Drawing.Size(100, 20);
            this.tbEmpFname.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(776, 466);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 620);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabStaffClient.ResumeLayout(false);
            this.tabStaffClient.PerformLayout();
            this.tabTrainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).EndInit();
            this.tabAdmin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabStaffClient;
        private System.Windows.Forms.TabPage tabTrainer;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmpCreate;
        private System.Windows.Forms.DateTimePicker dateEmpExp;
        private System.Windows.Forms.DateTimePicker dateEmpIss;
        private System.Windows.Forms.ComboBox comboEmpPos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmpPass;
        private System.Windows.Forms.TextBox tbEmpService;
        private System.Windows.Forms.TextBox tbEmpMail;
        private System.Windows.Forms.TextBox tbEmpPhone;
        private System.Windows.Forms.TextBox tbEmpPatr;
        private System.Windows.Forms.TextBox tbEmpLname;
        private System.Windows.Forms.TextBox tbEmpFname;
    }
}

