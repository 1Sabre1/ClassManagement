using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement.Admin {
	public partial class FormViewAudience : Form {
		StepSchedulerEntities bd = null; // создаем объект entity framework       
		ClassRooms cr = null;
		public FormViewAudience(ClassRooms cr) {
			InitializeComponent();
			bd = new StepSchedulerEntities();
			this.cr = cr;
			InitAud();
		}

		private void InitAud() {
			bd.ClassRooms.Load(); // при загрузке формы мы грузим таблицу classrooms
			dataGridView.DataSource = bd.ClassRooms.Local.ToBindingList(); // привязываем таблицу classrooms к елементу dgv
			dataGridView.Columns["Requests"].Visible = false; // не даем таблице requests вывестись в dgv
		}

		private void toolStripButtonAdd_Click(object sender, EventArgs e) {
			cr = new ClassRooms();
			AudienceForm form = new AudienceForm(cr);
			form.Show();
		}

		private void toolStripButtonEdit_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count > 0) {// проверяем что хотя бы 1 строка выделена
				int index = dataGridView.SelectedRows[0].Index; // присваиваем переменной значение выделенной строки 
				int Id = 0;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false) { return; }
				cr = bd.ClassRooms.Find(Id); // находим запись
				AudienceForm af = new AudienceForm(cr); // открываем форму добавления
				if (af.ShowDialog() == DialogResult.OK) // проверяем что все было сделано
				{ bd.SaveChanges(); dataGridView.Refresh(); MessageBox.Show("Editted"); } // сохраняем изменения и обновляем вид dgv
			}
		}

		private void toolStripButtonShow_Click(object sender, EventArgs e) {
			InitAud();
		}

		private void toolStripButtonBlock_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count > 0) {
				int index = dataGridView.SelectedRows[0].Index;
				int Id = 0;
				bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out Id);
				if (converted == false) { return; }
				cr = bd.ClassRooms.Find(Id);
				cr.IsAvailable = true; // меняем поле на значение "заблокировано"
				bd.SaveChanges();
				dataGridView.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;
				dataGridView.Update();
				dataGridView.Refresh();
				MessageBox.Show("Audience is blocked now");
			}
			else {
				MessageBox.Show("Не удалось заблокировать данные!");
			}
		}

		private void checkBoxBlock_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxBlock.Checked) {
				bd = new StepSchedulerEntities();
				bd.ClassRooms.Load();
				var query = bd.ClassRooms.Local.Where(x => x.IsAvailable == true).ToList();
				dataGridView.DataSource = null;
				dataGridView.DataSource = query;
				dataGridView.Columns["Requests"].Visible = false;
			}
		}
	}
}
