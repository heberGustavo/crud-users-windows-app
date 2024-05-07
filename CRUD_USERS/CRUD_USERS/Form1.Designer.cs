namespace CRUD_USERS
{
	partial class Form1
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtBirthday = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(145, 79);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(227, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(145, 197);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(227, 20);
			this.txtAddress.TabIndex = 1;
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(145, 158);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(227, 20);
			this.txtAge.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(145, 120);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(227, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(71, 82);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			this.lblName.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(71, 123);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(58, 13);
			this.lblLastName.TabIndex = 5;
			this.lblLastName.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Age";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(71, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Address";
			// 
			// dtBirthday
			// 
			this.dtBirthday.Location = new System.Drawing.Point(145, 242);
			this.dtBirthday.Name = "dtBirthday";
			this.dtBirthday.Size = new System.Drawing.Size(227, 20);
			this.dtBirthday.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Birthday";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(475, 71);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(475, 100);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Location = new System.Drawing.Point(74, 292);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.Size = new System.Drawing.Size(699, 265);
			this.dataGridViewUsers.TabIndex = 13;
			this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 601);
			this.Controls.Add(this.dataGridViewUsers);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtBirthday);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtBirthday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
	}
}

