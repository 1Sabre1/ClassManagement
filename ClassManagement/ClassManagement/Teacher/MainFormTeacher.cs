using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class MainFormTeacher : Form {
		StepSchedulerEntities db = new StepSchedulerEntities();
		List<Requests> requests = null;
		/*	 1 : принят запрос
		 *	 0 : на рассмотрении
		 *	-1 : запрос отклонен	*/

		Color busy = Color.Salmon;      //занятые аудитории помечены красным цветом
		Color free = Color.Green;       //свободные аудитории помечены зеленым цветом
		Color pretend = Color.Yellow;   //аудитории, на которые претендуют преподователи, помечены желтым цветом

		public MainFormTeacher() {
			InitializeComponent();
			dataGridView1.RowCount = 15; //К-во аудиторий по умолчанию
			for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
				dataGridView1[0, i].Value = $"{i + 1} ауд."; //Нумерация аудиторий
			}
			dataGridView1[0, dataGridView1.RowCount - 1].Value = "Конф. зал"; //Последней аудиторией оставляем конференц зал

			for (int i = 1; i < dataGridView1.ColumnCount; i++) {
				for (int j = 0; j < dataGridView1.RowCount; j++) {
					dataGridView1[i, j].Style.BackColor = free; //По умолчанию все аудитории свободны
				}
			}

			requests = db.Requests.ToList();
			try {
				pictureBox1.Image = Image.FromFile(@"gmail_false.png");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

			OutputDate(dateTimePicker1.Value);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			BookingForm form = new BookingForm();
			form.Show();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
			OutputDate(dateTimePicker1.Value);
		}

		private void OutputDate(DateTime date) {
			using (StepSchedulerEntities db = new StepSchedulerEntities()) {
				IQueryable<ReservedRooms> Querry = from rr in db.ReservedRooms //достаем информцию о аудиториям по дате
												   join r in db.Requests on rr.RequestId equals r.RequestId
												   where (r.Status != -1)
												   select rr;
				foreach (ReservedRooms item in Querry) {
					string ShortFormatItem = item.Requests.ClassDate.ToShortDateString();
					string SelectedShortFormat = dateTimePicker1.Value.ToShortDateString();
					if (ShortFormatItem == SelectedShortFormat) {
						switch (item.Requests.Status) {
							case -1: dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Style.BackColor = free; break;
							case 0: dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Style.BackColor = pretend; break;
							case 1: dataGridView1[item.Requests.LessonNumber, item.Requests.ClassRooms.Number - 1].Style.BackColor = busy; break;
							default: break;
						}
					}
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			PersonalForm form = new PersonalForm();
			form.Show();
		}
	}
}
