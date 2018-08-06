namespace WindowsFormsApplication1
{
    partial class login_form
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
            this.login_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(17, 16);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(60, 17);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login ID";
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(88, 15);
            this.login_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(273, 22);
            this.login_textbox.TabIndex = 1;
            this.login_textbox.TextChanged += new System.EventHandler(this.login_textbox_TextChanged);
            this.login_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_textbox_KeyDown);
            this.login_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_textbox_KeyPress);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(9, 66);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(69, 17);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(88, 63);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(273, 22);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            this.password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textbox_KeyDown);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(131, 95);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(125, 43);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 148);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.login_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login_form";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
    }
}

