using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ClassManagement {
	public partial class AudienceForm : Form {
		StepSchedulerEntities ss = null;
		ClassRooms cr = null;
		public AudienceForm(ClassRooms cr) {
			InitializeComponent();
			ss = new StepSchedulerEntities();
			this.cr = cr;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			cr.Number = int.Parse(textBox1.Text); // присваиваем значение textbox1.text к переменной number таблицы classrooms
			cr.WorkPlacesCount = int.Parse(numericUpDown1.Text); // присваиваем значение numericUpDown1.Text к переменной workplacescount
			cr.Description = textBox3.Text; // присваиваем значение textbox2.text к перменной description
			DialogResult = DialogResult.OK;
		}

		private void AudienceForm_Load(object sender, System.EventArgs e) {
			ss.ClassRooms.Load(); // загружиаем данные таблицы classrooms
			List<ClassRooms> c = ss.ClassRooms.ToList<ClassRooms>(); // создаем список данных таблицы classrooms

			foreach (ClassRooms i in c) { // проходимся циклом в списке 
				if (cr.Number == i.Number) { // находим совпадение(для редактирования)
					textBox1.Text = i.Number.ToString(); break; // присваиваем значение
				}
			}


			foreach (ClassRooms i in c) {
				if (cr.Description == i.Description) { textBox3.Text = i.Description.ToString(); break; }
			}
		}
	}
}
