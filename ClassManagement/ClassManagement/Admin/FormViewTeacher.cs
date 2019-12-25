using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class FormViewTeacher : Form {
		StepSchedulerEntities bd = null; // создаем объект entity framework
		Users user = null;
		public FormViewTeacher(Users u) {
			InitializeComponent();
			bd = new StepSchedulerEntities();
			toolStripButton4.Image = Image.FromFile(@"search.png");
			this.user = u;
			InitUser();
		}

		private void InitUser() {
			bd.Users.Load(); //подключаемся к базе к таб.User
			dataGridView.DataSource = null;
			dataGridView.DataSource = bd.Users.Local.ToBindingList();//выводим данные в dataGrid
			dataGridView.Columns["Requests"].Visible = false;//убираем колонки таблицы Requests
			dataGridView.Columns["UserId"].Visible = false;
			dataGridView.Columns["Photo"].Visible = false;
			dataGridView.Columns["Login"].Visible = false;
			dataGridView.Columns["Password"].Visible = false;
			dataGridView.Columns["IsAdmin"].Visible = false;
			dataGridView.Columns["IsBlocked"].Visible = false;
		}

		private void checkBoxBlock_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxBlock.Checked) {
				ShowBlockTeachers();
			}
		}

		private void ShowBlockTeachers() {
			if (dataGridView.SelectedRows.Count == 1) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false)
					return;
				user = bd.Users.Find(Id);
				user.IsBlocked = true;
				bd.SaveChanges();
				//выделяем пользователя красным цветом
				dataGridView.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;

				dataGridView.Update();
				dataGridView.Refresh();
				MessageBox.Show("Пользователь заблокирован!");
			}
			else {
				MessageBox.Show("Не удалось заблокировать данные!");
			}
		}

		private void toolStripButtonAdd_Click(object sender, EventArgs e) {
			user = new Users();
			TeacherInfoForm form = new TeacherInfoForm(user);
			form.Show();
		}

		private void toolStripButtonEdit_Click(object sender, EventArgs e) {
			int index = dataGridView.SelectedRows[0].Index;
			int Id;
			bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
			if (converted == false)
				return;
			user = bd.Users.Find(Id);//находим по индексу значение
			TeacherInfoForm f = new TeacherInfoForm(user);//открываем доп. форму

			if (f.ShowDialog() == DialogResult.OK) {
				bd.SaveChanges();//сохраняем изменения
				dataGridView.Update();//обновляем отредактированые данные
				dataGridView.Refresh();
				MessageBox.Show("Данные отредактированные!");
			}
			else {
				MessageBox.Show("Не удалось отредактировать данные!");
			}
		}

		private void toolStripButtonBlock_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 1) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false)
					return;
				user = bd.Users.Find(Id);
				user.IsBlocked = true;
				bd.SaveChanges();
				//выделяем пользователя красным цветом
				dataGridView.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;

				dataGridView.Update();
				dataGridView.Refresh();
				MessageBox.Show("Пользователь заблокирован!");
			}
			else {
				MessageBox.Show("Не удалось заблокировать данные!");
			}
		}

		private void toolStripButtonClear_Click(object sender, EventArgs e) {
			bd = new StepSchedulerEntities();
			bd.Users.Load(); //подключаемся к базе к таб.User
			dataGridView.DataSource = null;
			dataGridView.DataSource = bd.Users.Local.ToBindingList();//выводим данные в dataGrid
			dataGridView.Columns["Requests"].Visible = false;//убираем колонки таблицы Requests           
			dataGridView.Columns["Photo"].Visible = false;
		}
	}
}
