namespace WinFormsApp1
{
    partial class AddressBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPostNo = new TextBox();
            txtPostOrt = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            buttonAdd = new Button();
            button1 = new Button();
            textSearch = new TextBox();
            textContent1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "namn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 1;
            label2.Text = "gatuadress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 179);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 2;
            label3.Text = "postnum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 261);
            label4.Name = "label4";
            label4.Size = new Size(100, 31);
            label4.TabIndex = 3;
            label4.Text = "postort";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 345);
            label5.Name = "label5";
            label5.Size = new Size(96, 31);
            label5.TabIndex = 4;
            label5.Text = "telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 430);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 5;
            label6.Text = "epost";
            // 
            // txtName
            // 
            txtName.Location = new Point(225, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(423, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(225, 108);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(423, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtPostNo
            // 
            txtPostNo.Location = new Point(225, 185);
            txtPostNo.Name = "txtPostNo";
            txtPostNo.Size = new Size(423, 27);
            txtPostNo.TabIndex = 8;
            // 
            // txtPostOrt
            // 
            txtPostOrt.Location = new Point(225, 267);
            txtPostOrt.Name = "txtPostOrt";
            txtPostOrt.Size = new Size(423, 27);
            txtPostOrt.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(225, 351);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(423, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(225, 436);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(423, 27);
            txtEmail.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(174, 608);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(146, 52);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(354, 610);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(139, 50);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.Location = new Point(1460, 621);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(126, 49);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(23, 608);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 52);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "Addera";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(529, 608);
            button1.Name = "button1";
            button1.Size = new Size(188, 52);
            button1.TabIndex = 18;
            button1.Text = "Läsa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(1185, 631);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(222, 27);
            textSearch.TabIndex = 19;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // textContent1
            // 
            textContent1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textContent1.Location = new Point(738, 30);
            textContent1.Name = "textContent1";
            textContent1.Size = new Size(848, 438);
            textContent1.TabIndex = 20;
            textContent1.Text = "";
            textContent1.TextChanged += textContent1_TextChanged;
            // 
            // AddressBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1631, 761);
            Controls.Add(textContent1);
            Controls.Add(textSearch);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtPostOrt);
            Controls.Add(txtPostNo);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressBook";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPostNo;
        private TextBox txtPostOrt;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button buttonAdd;
        private Button button1;
        private TextBox textSearch;
        private RichTextBox textContent1;
    }
}