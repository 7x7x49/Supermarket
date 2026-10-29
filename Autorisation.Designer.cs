namespace Supermarket
{
    partial class Autorisation : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.exit_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.info_pb = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.info_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.SeaShell;
            this.login_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_tb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.login_tb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.login_tb.Location = new System.Drawing.Point(65, 90);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(211, 34);
            this.login_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.SeaShell;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.password_tb.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.password_tb.Location = new System.Drawing.Point(65, 174);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '✻';
            this.password_tb.Size = new System.Drawing.Size(211, 30);
            this.password_tb.TabIndex = 1;
            // 
            // exit_b
            // 
            this.exit_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            this.exit_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F);
            this.exit_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exit_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_b.Location = new System.Drawing.Point(65, 350);
            this.exit_b.Name = "exit_b";
            this.exit_b.Size = new System.Drawing.Size(211, 48);
            this.exit_b.TabIndex = 2;
            this.exit_b.Text = "Завершить работу";
            this.exit_b.UseVisualStyleBackColor = false;
            this.exit_b.Click += new System.EventHandler(this.exit_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(134, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // enter_b
            // 
            this.enter_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.enter_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_b.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.enter_b.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enter_b.Location = new System.Drawing.Point(65, 261);
            this.enter_b.Name = "enter_b";
            this.enter_b.Size = new System.Drawing.Size(211, 61);
            this.enter_b.TabIndex = 5;
            this.enter_b.Text = "Войти в систему";
            this.enter_b.UseVisualStyleBackColor = false;
            this.enter_b.Click += new System.EventHandler(this.enter_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(128, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // info_pb
            // 
            this.info_pb.BackColor = System.Drawing.Color.Transparent;
            this.info_pb.Image = ((System.Drawing.Image)(resources.GetObject("info_pb.Image")));
            this.info_pb.Location = new System.Drawing.Point(326, 411);
            this.info_pb.Name = "info_pb";
            this.info_pb.Size = new System.Drawing.Size(24, 22);
            this.info_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_pb.TabIndex = 7;
            this.info_pb.TabStop = false;
            this.toolTip1.SetToolTip(this.info_pb, "Забыли данные? Обратитесь к администратору");
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Supermarket.Properties.Resources.blue_pastel_pink_gradient_background_961004_7696;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.info_pb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_b);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorisation";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.info_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button exit_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox info_pb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}