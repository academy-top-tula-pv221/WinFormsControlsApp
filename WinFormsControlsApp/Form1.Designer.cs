namespace WinFormsControlsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnHello = new Button();
            lblHello = new Label();
            txtBoxHello = new TextBox();
            textBox1 = new TextBox();
            txtBoxPassword = new TextBox();
            lblTablo = new Label();
            textBoxEmail = new TextBox();
            lblEmail = new Label();
            maskedTextBox1 = new MaskedTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.BackgroundImageLayout = ImageLayout.None;
            btnHello.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnHello.Image = (Image)resources.GetObject("btnHello.Image");
            btnHello.Location = new Point(36, 293);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(270, 94);
            btnHello.TabIndex = 0;
            btnHello.Text = "&Button";
            btnHello.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHello.Location = new Point(32, 33);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(110, 30);
            lblHello.TabIndex = 1;
            lblHello.Text = "Say Hello!";
            // 
            // txtBoxHello
            // 
            txtBoxHello.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxHello.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBoxHello.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxHello.Location = new Point(36, 78);
            txtBoxHello.Name = "txtBoxHello";
            txtBoxHello.Size = new Size(270, 36);
            txtBoxHello.TabIndex = 2;
            txtBoxHello.TextChanged += txtBoxHello_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(401, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(313, 169);
            textBox1.TabIndex = 3;
            textBox1.WordWrap = false;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = SystemColors.Info;
            txtBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(36, 139);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '$';
            txtBoxPassword.Size = new Size(270, 36);
            txtBoxPassword.TabIndex = 4;
            // 
            // lblTablo
            // 
            lblTablo.AutoSize = true;
            lblTablo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTablo.Location = new Point(401, 42);
            lblTablo.Name = "lblTablo";
            lblTablo.Size = new Size(71, 30);
            lblTablo.TabIndex = 5;
            lblTablo.Text = "label1";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(36, 231);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 36);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TextChanged += textBox2_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(35, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 30);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Input Email";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(401, 293);
            maskedTextBox1.Mask = "L.L.L?????????????";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(313, 36);
            maskedTextBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(36, 463);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 34);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "C++";
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Indeterminate;
            checkBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(37, 503);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 34);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "PHP";
            checkBox2.ThreeState = true;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            checkBox2.CheckStateChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 430);
            label1.Name = "label1";
            label1.Size = new Size(65, 30);
            label1.TabIndex = 7;
            label1.Text = "Skills:";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(378, 431);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 34);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(378, 472);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(157, 34);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(378, 512);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(157, 34);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 681);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(lblTablo);
            Controls.Add(txtBoxPassword);
            Controls.Add(textBox1);
            Controls.Add(txtBoxHello);
            Controls.Add(lblHello);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private Label lblHello;
        private TextBox txtBoxHello;
        private TextBox textBox1;
        private TextBox txtBoxPassword;
        private Label lblTablo;
        private TextBox textBoxEmail;
        private Label lblEmail;
        private MaskedTextBox maskedTextBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}