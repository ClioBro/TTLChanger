

namespace ClioOFF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_WindowsTTL = new System.Windows.Forms.Button();
            this.button_PhoneTTL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Chk_ttl = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Chk_h = new System.Windows.Forms.ComboBox();
            this.Chk_s = new System.Windows.Forms.ComboBox();
            this.Chk_m = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Chk_IPv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выключить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShutdownPC);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Часы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минуты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Секунды:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Перезагрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RebootPC);
            // 
            // button_WindowsTTL
            // 
            this.button_WindowsTTL.Location = new System.Drawing.Point(125, 15);
            this.button_WindowsTTL.Margin = new System.Windows.Forms.Padding(4);
            this.button_WindowsTTL.Name = "button_WindowsTTL";
            this.button_WindowsTTL.Size = new System.Drawing.Size(101, 52);
            this.button_WindowsTTL.TabIndex = 10;
            this.button_WindowsTTL.Text = "Windows (128)";
            this.button_WindowsTTL.UseVisualStyleBackColor = true;
            this.button_WindowsTTL.Click += new System.EventHandler(this.SetTTL128);
            // 
            // button_PhoneTTL
            // 
            this.button_PhoneTTL.Location = new System.Drawing.Point(16, 15);
            this.button_PhoneTTL.Margin = new System.Windows.Forms.Padding(4);
            this.button_PhoneTTL.Name = "button_PhoneTTL";
            this.button_PhoneTTL.Size = new System.Drawing.Size(101, 52);
            this.button_PhoneTTL.TabIndex = 11;
            this.button_PhoneTTL.Text = "Android, IOS (65)";
            this.button_PhoneTTL.UseVisualStyleBackColor = true;
            this.button_PhoneTTL.Click += new System.EventHandler(this.SetTTL65);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "TTL =";
            // 
            // Chk_ttl
            // 
            this.Chk_ttl.Location = new System.Drawing.Point(177, 92);
            this.Chk_ttl.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_ttl.Name = "Chk_ttl";
            this.Chk_ttl.Size = new System.Drawing.Size(48, 22);
            this.Chk_ttl.TabIndex = 13;
            this.Chk_ttl.Text = "128";
            this.Chk_ttl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGreen;
            this.button6.Location = new System.Drawing.Point(241, 74);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 52);
            this.button6.TabIndex = 14;
            this.button6.Text = "Использовать значение  TTL";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ApplyValueTTL);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(241, 16);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 50);
            this.button7.TabIndex = 15;
            this.button7.Text = "Узнать текущий TTL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ShowCurrentTTLStats);
            // 
            // Chk_h
            // 
            this.Chk_h.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chk_h.FormattingEnabled = true;
            this.Chk_h.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.Chk_h.Location = new System.Drawing.Point(79, 39);
            this.Chk_h.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_h.Name = "Chk_h";
            this.Chk_h.Size = new System.Drawing.Size(84, 24);
            this.Chk_h.TabIndex = 16;
            // 
            // Chk_s
            // 
            this.Chk_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chk_s.FormattingEnabled = true;
            this.Chk_s.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.Chk_s.Location = new System.Drawing.Point(79, 103);
            this.Chk_s.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_s.Name = "Chk_s";
            this.Chk_s.Size = new System.Drawing.Size(84, 24);
            this.Chk_s.TabIndex = 17;
            // 
            // Chk_m
            // 
            this.Chk_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chk_m.FormattingEnabled = true;
            this.Chk_m.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.Chk_m.Location = new System.Drawing.Point(79, 71);
            this.Chk_m.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_m.Name = "Chk_m";
            this.Chk_m.Size = new System.Drawing.Size(84, 24);
            this.Chk_m.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "IPv";
            // 
            // Chk_IPv
            // 
            this.Chk_IPv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chk_IPv.FormattingEnabled = true;
            this.Chk_IPv.Location = new System.Drawing.Point(43, 91);
            this.Chk_IPv.Margin = new System.Windows.Forms.Padding(4);
            this.Chk_IPv.Name = "Chk_IPv";
            this.Chk_IPv.Size = new System.Drawing.Size(73, 24);
            this.Chk_IPv.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Таймер:  Выключение / Перезагрузка ПК";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 17);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToGitHub);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Chk_h);
            this.panel1.Controls.Add(this.Chk_m);
            this.panel1.Controls.Add(this.Chk_s);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 141);
            this.panel1.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Chk_IPv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Chk_ttl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_PhoneTTL);
            this.Controls.Add(this.button_WindowsTTL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ClioTime 1.1.3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_WindowsTTL;
        private System.Windows.Forms.Button button_PhoneTTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Chk_ttl;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox Chk_h;
        private System.Windows.Forms.ComboBox Chk_s;
        private System.Windows.Forms.ComboBox Chk_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Chk_IPv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

