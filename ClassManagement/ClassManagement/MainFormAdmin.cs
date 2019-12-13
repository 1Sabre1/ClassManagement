using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace ClassManagement {
	public partial class MainFormAdmin : Form {
		/*	 1 : принят запрос
		 *	 0 : на рассмотрении
		 *	-1 : запрос отклонен	*/

		Color busy = Color.Salmon;      //занятые аудитории помечены красным цветом
		Color free = Color.Green;       //свободные аудитории помечены зеленым цветом
		Color pretend = Color.Yellow;   //аудитории, на которые претендуют преподователи, помечены желтым цветом

		Random rnd = new Random();

		public MainFormAdmin() {
			InitializeComponent();
			dataGridView1.RowCount = 15;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1[0, i].Value = $"{i + 1} ауд.";
            }
            dataGridView1[0, dataGridView1.RowCount - 1].Value = "Конф. зал";
            for (int i = 1; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Style.BackColor = free;
                }
            }
            //Thread SetInfo = new Thread(new ThreadStart(RefreshDataGrid));
            //SetInfo.Start();
            RefreshDataGrid();


            //int temp = rnd.Next(15);
            //int r = 0, c = 1;
            //while (r < 15 && c < 8) {
            //	if (r % 2 == 0 || c % 2 != 0) dataGridView1[c, r].Style.BackColor = free;
            //	else dataGridView1[c, r].Style.BackColor = pretend;
            //	r++; c++;
            //}
        }

        public void RefreshDataGrid()//Обновляет содержимое dataGridView 
        {
            if (dataGridView1.InvokeRequired)
            {
                BeginInvoke(new Action(RefreshDataGrid));
            }
            else
            { 
                using (StepSchedulerEntities1 db = new StepSchedulerEntities1())
                {
                    IQueryable<ReservedRoom> Querry = from t1 in db.ReservedRooms //достаем зарезервированные аудитории где дата проведения равна дате в dateTimePicker1 
                                                      join t2 in db.Requests on t1.RequestId equals t2.RequestId
                                                      where(t2.Status!=-1)
                                                      select t1;
                    foreach (ReservedRoom item in Querry)
                    {

                        string ShortFormatItem = item.Request.ClassDate.ToShortDateString();
                        string SelectedShortFormat = dateTimePicker1.Value.ToShortDateString();
                        if (ShortFormatItem == SelectedShortFormat)
                        {
                            if (item.Request.Status == 1)
                            {
                                dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Style.BackColor = busy;
                                if (item.EventType == 0)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Value = "З";
                                }
                                if (item.EventType == 1)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Value = "К";
                                }
                                if (item.EventType == 2)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Value = "М";
                                }
                            }
                            else
                            {
                                dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Style.BackColor = pretend;
                                if (item.EventType == 0)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Value = "З";
                                }
                                if (item.EventType == 1)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number-1].Value = "К";
                                }
                                if (item.EventType == 2)
                                {
                                    dataGridView1[item.Request.LessonNumber, item.Request.ClassRoom.Number].Value = "М";
                                }
                            }
                        }
                    }
                }
            }
        }
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) {
			LessonForm form = new LessonForm();
			form.Show();
		}

		private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e) {
			LessonForm form = new LessonForm();
			form.Show();
		}

		private void заблокироватьToolStripMenuItem_Click(object sender, EventArgs e) {
			LessonForm form = new LessonForm();
			form.Show();
		}

		private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e) {
			TeacherInfoForm form = new TeacherInfoForm();
			form.Show();
		}

		private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e) {
			TeacherInfoForm form = new TeacherInfoForm();
			form.Show();
		}

		private void заблокироватьToolStripMenuItem1_Click(object sender, EventArgs e) {
			TeacherInfoForm form = new TeacherInfoForm();
			form.Show();
		}

		private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e) {
			AudienceForm form = new AudienceForm();
			form.Show();
		}

		private void редактироватьToolStripMenuItem2_Click(object sender, EventArgs e) {
			AudienceForm form = new AudienceForm();
			form.Show();
		}

		private void заблокироватьToolStripMenuItem2_Click(object sender, EventArgs e) {
			AudienceForm form = new AudienceForm();
			form.Show();
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//значение в dateTimePicker1 изменилось ,обновляю dataGridView 
        {
            Thread SetInfo = new Thread(new ThreadStart(RefreshDataGrid));
            SetInfo.Start();
        }
    }
}
