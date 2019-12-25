using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class ConfirmationForm : Form {
		StepSchedulerEntities entities = null;
		List<Requests> requests;
		public ConfirmationForm() {
			InitializeComponent();
			entities = new StepSchedulerEntities();
			comboBoxCategories.Items.AddRange(new string[] { "Занятие", "Консультауия", "Меорприятие" }); //инициализация содержимого comboBoxCategories
			comboBoxUsers.DataSource = null;
			comboBoxLessonNumber.DataSource = null;
			comboBoxLessonNumber.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });  //инициализация содержимого comboBoxLessonNumber
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			requests = entities.Requests.ToList();
			UpdateList();
		}	

		private void UpdateList() {
			var list = requests.Where(w => w.Status != 0).Select(q => new {
				Дата_занятия = q.ClassDate,
				Номер_пары = q.LessonNumber,
				Количество_студентов = q.CountOfVisitors,
				Номер_аудитории = entities.ClassRooms.Where(n => n.ClassRoomId == q.ClassRoomId).FirstOrDefault().Number,
				Преподователь = entities.Users.Where(u => u.UserId == q.UserId).Select(c => c.Surname + " " + c.Name).FirstOrDefault(),
				Статус = (q.Status == 1) ? "подтверждено" : "отклонено"
			}).ToList();

			dataGridView2.DataSource = null;
			dataGridView2.DataSource = list;
		}

		private void checkBoxUsers_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxUsers.Checked) {
				comboBoxCategories.Enabled = false;
				dateTimePicker1.Enabled = false; ;
				comboBoxUsers.Enabled = true;
				comboBoxLessonNumber.Enabled = false;
				entities.Users.Load();
				comboBoxUsers.DataSource = entities.Users.Local.ToList();
				comboBoxUsers.DisplayMember = "SurName";
				comboBoxUsers.ValueMember = "UserId";
			}
		}

		private void checkBoxCategories_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxCategories.Checked) {
				comboBoxCategories.Enabled = true;
				comboBoxLessonNumber.Enabled = false;
				dateTimePicker1.Enabled = false;
				comboBoxUsers.Enabled = false;
				entities.ReservedRooms.Load();
			}
		}

		private void checkBoxDate_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxDate.Checked) {
				comboBoxLessonNumber.Enabled = false;
				comboBoxCategories.Enabled = false;
				dateTimePicker1.Enabled = true;
				comboBoxUsers.Enabled = false;
				dateTimePicker1.Value = DateTime.Now.Date;
			}
		}

		private void checkBoxLessonNumber_CheckedChanged(object sender, EventArgs e) {
			if (checkBoxLessonNumber.Checked) {
				comboBoxLessonNumber.Enabled = true;
				comboBoxCategories.Enabled = false;
				dateTimePicker1.Enabled = false;
				comboBoxUsers.Enabled = false;
			}
		}

		private void buttonSerch_Click(object sender, EventArgs e) {
			if (checkBoxCategories.Checked) {
				SearchCategories();
			}
			if (checkBoxDate.Checked) {
				SearchDate();
			}
			if (checkBoxUsers.Checked) {
				SearchUsers();
			}
			if (checkBoxLessonNumber.Checked) {
				SearchLessonNumber();
			};

			UpdateList();
		}

		private void SearchCategories() {
			if (comboBoxCategories.SelectedIndex != -1) {
				requests = (from req in entities.Requests
						 join rr in entities.ReservedRooms on req.RequestId equals rr.RequestId
						 where rr.EventType == comboBoxCategories.SelectedIndex
						 select req).ToList();
			}
		}

		private void SearchDate() {
			requests = requests.Where(x => x.ClassDate == dateTimePicker1.Value.Date).ToList();
		}

		private void SearchUsers() {
			if (comboBoxUsers.SelectedIndex != -1) {
				int id = Convert.ToInt32(comboBoxUsers.SelectedValue);
				requests = requests.Where(x => x.UserId == id).ToList();
			}
		}

		private void SearchLessonNumber() {
			if (comboBoxLessonNumber.SelectedIndex != -1) {
				requests = requests.Where(x => x.LessonNumber == comboBoxLessonNumber.SelectedIndex + 1).ToList();
			}
		}

		private void saveLoad_Queries() { //сохранение и обновление данных в базе и гридвью
			DateTime nowDate = DateTime.Now;
			entities.SaveChanges();
			// получаем сам запрос     
			var list = (from req in requests
						join us in entities.Users on req.UserId equals us.UserId
						join clas in entities.ClassRooms on req.ClassRoomId equals clas.ClassRoomId
						where req.ClassDate > nowDate
						select new { req.RequestId, req.ClassDate, req.LessonNumber, req.CountOfVisitors, clas.ClassRoomId, UserName = us.Name + " " + us.Surname, req.Status }).ToList();
			dataGridView1.DataSource = list;
		}

		private void BT_confirm_Click(object sender, EventArgs e) {
			for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) {
				//получаем id нашей записи(нашего запроса)
				int id = Convert.ToInt32(dataGridView1[0, dataGridView1.SelectedRows[i].Index].Value);
				// получаем сам запрос
				var selReq = requests.Where(r => r.RequestId == id).FirstOrDefault();
				selReq.Status = 1;
				saveLoad_Queries();
			}
		}

		private void BT_denial_Click(object sender, EventArgs e) {
			for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) {
				//получаем id нашей записи(нашего запроса)
				int id = Convert.ToInt32(dataGridView1[0, dataGridView1.SelectedRows[i].Index].Value);
				// получаем сам запрос
				var selReq = requests.Where(r => r.RequestId == id).FirstOrDefault();
				selReq.Status = 0;
				saveLoad_Queries();
			}
		}

		private void ConfirmationForm_Load(object sender, EventArgs e) {
			saveLoad_Queries();
		}
	}
}
