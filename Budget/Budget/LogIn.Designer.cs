namespace Budget
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNameBox = new System.Windows.Forms.TextBox();
            this.AccountIDBox = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account ID: ";
            // 
            // AccountNameBox
            // 
            this.AccountNameBox.Location = new System.Drawing.Point(104, 25);
            this.AccountNameBox.Name = "AccountNameBox";
            this.AccountNameBox.Size = new System.Drawing.Size(141, 20);
            this.AccountNameBox.TabIndex = 2;
            // 
            // AccountIDBox
            // 
            this.AccountIDBox.Location = new System.Drawing.Point(104, 56);
            this.AccountIDBox.Name = "AccountIDBox";
            this.AccountIDBox.Size = new System.Drawing.Size(141, 20);
            this.AccountIDBox.TabIndex = 3;
            // 
            // LogInbutton
            // 
            this.LogInbutton.Location = new System.Drawing.Point(170, 82);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 23);
            this.LogInbutton.TabIndex = 4;
            this.LogInbutton.Text = "Login";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.AccountIDBox);
            this.Controls.Add(this.AccountNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountNameBox;
        private System.Windows.Forms.TextBox AccountIDBox;
        private System.Windows.Forms.Button LogInbutton;
    }
}

