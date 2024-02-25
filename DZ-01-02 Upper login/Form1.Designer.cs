namespace DZ_01_02_Upper_login
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
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.entrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 179);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Tlogin
            // 
            this.Tlogin.Location = new System.Drawing.Point(89, 58);
            this.Tlogin.Multiline = true;
            this.Tlogin.Name = "Tlogin";
            this.Tlogin.Size = new System.Drawing.Size(183, 23);
            this.Tlogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(89, 128);
            this.Tpassword.Multiline = true;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(183, 23);
            this.Tpassword.TabIndex = 2;
            // 
            // entrance
            // 
            this.entrance.Location = new System.Drawing.Point(276, 179);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(75, 23);
            this.entrance.TabIndex = 0;
            this.entrance.Text = "Вход";
            this.entrance.UseVisualStyleBackColor = true;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 207);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Button entrance;
    }
}

