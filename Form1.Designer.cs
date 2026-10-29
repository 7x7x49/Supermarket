namespace Supermarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.back_b = new System.Windows.Forms.Button();
            this.empl_b = new System.Windows.Forms.Button();
            this.providers_b = new System.Windows.Forms.Button();
            this.checks_b = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_b
            // 
            this.back_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.back_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.back_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back_b.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_b.Location = new System.Drawing.Point(128, 407);
            this.back_b.Name = "back_b";
            this.back_b.Size = new System.Drawing.Size(175, 54);
            this.back_b.TabIndex = 0;
            this.back_b.Text = "Выход";
            this.back_b.UseVisualStyleBackColor = false;
            this.back_b.Click += new System.EventHandler(this.back_b_Click);
            // 
            // empl_b
            // 
            this.empl_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.empl_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.empl_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empl_b.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.empl_b.Location = new System.Drawing.Point(19, 21);
            this.empl_b.Name = "empl_b";
            this.empl_b.Size = new System.Drawing.Size(359, 75);
            this.empl_b.TabIndex = 1;
            this.empl_b.Text = "Информация о сотрудниках";
            this.empl_b.UseVisualStyleBackColor = false;
            this.empl_b.Click += new System.EventHandler(this.empl_b_Click);
            // 
            // providers_b
            // 
            this.providers_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.providers_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.providers_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.providers_b.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.providers_b.Location = new System.Drawing.Point(19, 142);
            this.providers_b.Name = "providers_b";
            this.providers_b.Size = new System.Drawing.Size(359, 75);
            this.providers_b.TabIndex = 2;
            this.providers_b.Text = "Поставщики";
            this.providers_b.UseVisualStyleBackColor = false;
            this.providers_b.Click += new System.EventHandler(this.providers_b_Click);
            // 
            // checks_b
            // 
            this.checks_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.checks_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checks_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold);
            this.checks_b.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.checks_b.Location = new System.Drawing.Point(19, 260);
            this.checks_b.Name = "checks_b";
            this.checks_b.Size = new System.Drawing.Size(359, 75);
            this.checks_b.TabIndex = 3;
            this.checks_b.Text = "Чеки";
            this.checks_b.UseVisualStyleBackColor = false;
            this.checks_b.Click += new System.EventHandler(this.checks_b_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.checks_b);
            this.panel1.Controls.Add(this.providers_b);
            this.panel1.Controls.Add(this.empl_b);
            this.panel1.Location = new System.Drawing.Point(21, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 353);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Supermarket.Properties.Resources.blue_pastel_pink_gradient_background_961004_7696;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Справочник кассира";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_b;
        private System.Windows.Forms.Button empl_b;
        private System.Windows.Forms.Button providers_b;
        private System.Windows.Forms.Button checks_b;
        private System.Windows.Forms.Panel panel1;
    }
}

