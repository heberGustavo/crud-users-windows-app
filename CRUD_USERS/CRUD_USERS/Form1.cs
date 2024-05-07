using CRUD_USERS.Configurations.Context;
using CRUD_USERS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_USERS
{
	public partial class Form1 : Form
	{
		int _idUserCurrent = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PopulateGridViewUser();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var userModel = ModelToSave();

			using (var MyModelEntities = new CRUDAppContext())
			{
				MyModelEntities.Users.Add(userModel);
				MyModelEntities.SaveChanges();
			}

			PopulateGridViewUser();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var userModel = ModelToSave();

			using (var MyModelEntities = new CRUDAppContext())
			{
				MyModelEntities.Entry(userModel).State = System.Data.Entity.EntityState.Modified;
				MyModelEntities.SaveChanges();
			}

			PopulateGridViewUser();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				DataGridViewRow linha = dataGridViewUsers.Rows[e.RowIndex];

				var id = int.Parse(linha.Cells[0].Value.ToString());
				var firstName = linha.Cells[1].Value.ToString();
				var lastName = linha.Cells[2].Value.ToString();
				var age = int.Parse(linha.Cells[3].Value.ToString());
				var address = linha.Cells[4].Value.ToString();
				var birthday = DateTime.Parse(linha.Cells[5].Value.ToString());

				PopulateDataInScreen(id, firstName, lastName, age, address, birthday);
			}
		}

		#region Helper Methods

		private User ModelToSave()
		{
			return new User
			{
				FirstName = txtName.Text,
				LastName = txtLastName.Text,
				Age = int.Parse(txtAge.Text),
				Address = txtAddress.Text,
				Birthday = DateTime.Parse(dtBirthday.Text)
			};
		}

		private void PopulateGridViewUser()
		{
			using (var MyModelEntities = new CRUDAppContext())
			{
				dataGridViewUsers.DataSource = MyModelEntities.Users.ToList();
			}
		}

		private void PopulateDataInScreen(int id, string firstName, string lastName, int age, string address, DateTime birthday)
		{
			_idUserCurrent = id;
			txtName.Text = firstName;
			txtLastName.Text = lastName;
			txtAge.Text = age.ToString();
			txtAddress.Text = address;
			dtBirthday.Text = birthday.ToString();
		}

		#endregion
	}
}
