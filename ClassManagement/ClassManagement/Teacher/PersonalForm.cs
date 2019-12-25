using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class PersonalForm : Form {
		StepSchedulerEntities db;
		List<Requests> requests = null;
		public PersonalForm() {
			InitializeComponent();
			comboBox1.Items.Add("Все запросы");
			comboBox1.Items.Add("Подтвержденные");
			comboBox1.Items.Add("Отклоненные");
			comboBox1.Items.Add("Ожидают ответа");

			db = new StepSchedulerEntities();
			requests = db.Requests.ToList();
			comboBox1.SelectedIndex = 0;

			//заполнение двух datagridview
			FillNew();
			FillHistory();
		}
		//заполнение datagridview с новыми (текущими) сообщениями
		private void FillNew() {
			var n = requests.Select(x => new {
				Дата_занятия = x.ClassDate,
				Номер_пары = x.LessonNumber,
				Номер_аудитории = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
				Статус = Choise(x.Status)
			}).ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = n;
		}
		//заполнение datagridview с историей
		private void FillHistory() {
			var history = requests.Where(s => s.Status != 0 && s.ClassDate < DateTime.Now.Date).
					  Select(x => new {
						  Дата_занятия = x.ClassDate,
						  Номер_пары = x.LessonNumber,
						  Номер_аудитории = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
						  Статус = (x.Status == 1) ? "подтверждено" : "отклонено"
					  }).ToList();

			dataGridView2.DataSource = null;
			dataGridView2.DataSource = history;
		}

		private object Choise(int? status) {
			return (status == 1) ? "подтверждено" : (status == -1) ? "отклонено" : "ожидают ответа";
		}
		//заполнение datagridview с новыми (текущими) сообщениями с учетом статуса
		private void GetNewListFromBD(int status) {
			var n = requests.Where(s => s.Status == 1).Select(x => new {
				ид = x.RequestId,
				Дата_занятия = x.ClassDate,
				Номер_пары = x.LessonNumber,
				Номер_аудитории = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
				Статус = Choise(status)
			}).ToList();

			dataGridView1.DataSource = null;
			dataGridView1.Columns["ид"].Visible = false;
			dataGridView1.DataSource = n;
		}
		//заполнение datagridview с историей с учетом статуса
		private void GetHistoryListFromBD(int status) {
			var history = requests.Where(s => s.Status == status && s.ClassDate < DateTime.Now.Date).
						Select(x => new {
							Дата_занятия = x.ClassDate,
							Номер_пары = x.LessonNumber,
							Номер_аудитории = (db.ClassRooms.Where(c => c.ClassRoomId == x.ClassRoomId).FirstOrDefault().Number),
							Статус = Choise(status)
						}).ToList();

			dataGridView2.DataSource = null;
			dataGridView2.DataSource = history;
		}
		// выбор статуса
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			//button1.Visible = (tabControl1.SelectedIndex == 0)? true : false;
			if (comboBox1.SelectedItem.ToString() == "Подтвержденные") {
				if (tabControl1.SelectedIndex == 0)
					GetNewListFromBD(1);
				else
					GetHistoryListFromBD(1);
			}

			else if (comboBox1.SelectedItem.ToString() == "Отклоненные") {
				if (tabControl1.SelectedIndex == 0)
					GetNewListFromBD(-1);
				else
					GetHistoryListFromBD(-1);
			}

			else if (comboBox1.SelectedItem.ToString() == "Ожидают ответа") {
				if (tabControl1.SelectedIndex == 0)
					GetNewListFromBD(0);
				else
					GetHistoryListFromBD(0);
			}

			else {
				if (tabControl1.SelectedIndex == 0)
					FillNew();
				else
					FillHistory();
			}
		}
		//код кнопки отмена
		private void button1_Click(object sender, EventArgs e) {
			if (dataGridView1.SelectedRows.Count == 1) {
				int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
				var select = requests.Where(r => r.RequestId == id).FirstOrDefault();

				db.Requests.Remove(select);
				select.Status = -1;
				db.Requests.Add(select);
				db.SaveChanges();
			}
		}
	}
}
