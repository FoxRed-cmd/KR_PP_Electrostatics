using System;
using System.Windows.Forms;
using Kinematic_tasks;

namespace KR_PP_Electrostatics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			TextBox[] textBoxes = { textBox2, textBox3,textBox4, textBox5, textBox6, textBox7, textBox8 };
			Label[] labels = { label1, label2, label3, label4, label5, label6, label7 };

			groupBox1.Text = "Задачи";
			radioButton1.Text = "Задача 1";
			radioButton2.Text = "Задача 2";
			radioButton3.Text = "Задача 3";
			radioButton4.Text = "Задача 4";
			radioButton5.Text = "Задача 5";
			button1.Text = "Рассчитать";
			radioButton1.CheckedChanged += (s, e) => 
			{
				if (radioButton1.Checked)
				{
					textBox1.Text = "Определить магнитную индукцию в центре кругового проволочного витка радиусом R = 10 см, по которому течет ток I = 1 A.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
						item.Clear();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					textBox4.TextBoxNotVis();
					textBox5.TextBoxNotVis();
					textBox6.TextBoxNotVis();
					textBox7.TextBoxNotVis();
					textBox8.TextBoxNotVis();
					label3.LabelNotVis();
					label4.LabelNotVis();
					label5.LabelNotVis();
					label6.LabelNotVis();
					label7.LabelNotVis();
					label1.Text = "R:";
					label2.Text = "I:";
				}
				else
				{
					textBox1.Clear();
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxNotVis();
					}
					foreach (Label item in labels)
					{
						item.LabelNotVis();
					}
				}
			
			};
			radioButton2.CheckedChanged += (s, e) =>
			{
				if (radioButton2.Checked)
				{
					textBox1.Text = "Электрон, обладая скоростьюv = 1 Мм/с, влетает в однородное магнитное поле под угломα = 60о " +
					"к направлению поля и начинает двигаться по спирали. Напряженность магнитного поляH = 1,5 кА/м. " +
					"Определить: 1) шаг спирали; 2) радиус витка спирали.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
						item.Clear();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					textBox5.TextBoxNotVis();
					textBox6.TextBoxNotVis();
					textBox7.TextBoxNotVis();
					textBox8.TextBoxNotVis();
					label4.LabelNotVis();
					label5.LabelNotVis();
					label6.LabelNotVis();
					label7.LabelNotVis();
					label1.Text = "V:";
					label2.Text = "A:";
					label3.Text = "H:";
				}
				else
				{
					textBox1.Clear();
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxNotVis();
					}
					foreach (Label item in labels)
					{
						item.LabelNotVis();
					}
				}

			};
			radioButton3.CheckedChanged += (s, e) =>
			{
				if (radioButton3.Checked)
				{
					textBox1.Text = "Электрон, обладая скоростью v = 10 Мм/с, влетел в однородное магнитное поле перпендикулярно линиям магнитной индукции. " +
					"Индукция магнитного поля B = 0,1 мТл. " +
					"Определить нормальное и тангенциальное ускорения электрона.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
						item.Clear();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					label1.Text = "V:";
					label2.Text = "B:";
					textBox4.TextBoxNotVis();
					textBox5.TextBoxNotVis();
					textBox6.TextBoxNotVis();
					textBox7.TextBoxNotVis();
					textBox8.TextBoxNotVis();
					label3.LabelNotVis();
					label4.LabelNotVis();
					label5.LabelNotVis();
					label6.LabelNotVis();
					label7.LabelNotVis();
				}
				else
				{
					textBox1.Clear();
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxNotVis();
					}
					foreach (Label item in labels)
					{
						item.LabelNotVis();
					}
				}

			};
			radioButton4.CheckedChanged += (s, e) =>
			{
				if (radioButton4.Checked)
				{
					textBox1.Text = "Тонкий провод (с изоляцией) образует плоскую спираль из N = 100 плотно расположенных витков, " +
					"по которым течет ток I = 8 мА. Радиусы внутреннего и внешнего витков равныa = 50 мм и b = 100 мм. " +
					"Найти: а) индукцию магнитного поля в центре спирали; б) магнитныймо-ментспирали при данном токе.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
						item.Clear();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					textBox4.TextBoxNotVis();
					textBox5.TextBoxNotVis();
					textBox6.TextBoxNotVis();
					textBox7.TextBoxNotVis();
					textBox8.TextBoxNotVis();
					label3.LabelNotVis();
					label4.LabelNotVis();
					label5.LabelNotVis();
					label6.LabelNotVis();
					label7.LabelNotVis();
					label1.Text = "σ1:";
					label2.Text = "σ2:";
				}
				else
				{
					textBox1.Clear();
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxNotVis();
					}
					foreach (Label item in labels)
					{
						item.LabelNotVis();
					}
				}

			};
			radioButton5.CheckedChanged += (s, e) =>
			{
				if (radioButton5.Checked)
				{
					textBox1.Text = "Протон влетает в однородное магнитное поле под углом 30о к направлению поля и движется по винтовой линии, " +
					"радиус которой равен 1,5 см. Индукция магнитного поля равна B = 103 Гс. " +
					"Найти кинетическую энергию протона.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
						item.Clear();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					label1.Text = "R1:";
					label2.Text = "R5:";
					label3.Text = "Q1:";
					label4.Text = "Q5:";
					label5.Text = "r1:";
					label6.Text = "r2:";
					label7.Text = "r3:";
				}
				else
				{
					textBox1.Clear();
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxNotVis();
					}
					foreach (Label item in labels)
					{
						item.LabelNotVis();
					}
				}

			};
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				try
				{
					Task1 task1 = new Task1() { R = Convert.ToDouble(textBox2.Text), I = Convert.ToDouble(textBox3.Text) };
					textBox1.Text = "Результат: " + task1.Decision().ToString() + " мкТл";
				}
				catch (Exception)
				{
					MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}

			if (radioButton2.Checked)
			{
				try
				{
					Task2 task2 = new Task2() {  V = Convert.ToDouble(textBox2.Text),  A = Convert.ToDouble(textBox3.Text), H = Convert.ToDouble(textBox4.Text) };
					textBox1.Text = "Результат: " + Convert.ToInt32(task2.Decision()).ToString() + " В/м";
				}
				catch (Exception)
				{
					MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}

			if (radioButton3.Checked)
			{
				try
				{
					Task3 task3 = new Task3() { V = Convert.ToDouble(textBox2.Text), B = Convert.ToDouble(textBox3.Text)};
					textBox1.Text = "Результат: " + (task3.Decision()).ToString() + " М/с";
				}
				catch (Exception)
				{
					MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}

			if (radioButton4.Checked)
			{
				try
				{
					Task4 task4 = new Task4() { σ1 = Convert.ToDouble(textBox2.Text), σ2 = Convert.ToDouble(textBox3.Text) };
					textBox1.Text = "Результат: " + "E = " + Convert.ToInt32(task4.Decision()).ToString() + " В/м\r\n" + "E = " + 
						Convert.ToInt32(task4.Decision2()).ToString() + "В/м\r\n";
				}
				catch (Exception)
				{
					MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}

			if (radioButton5.Checked)
			{
				try
				{
					Task5 task5 = new Task5()
					{
						Q1 = Convert.ToDouble(textBox2.Text),
						Q5 = Convert.ToDouble(textBox3.Text),
						R1 = Convert.ToDouble(textBox4.Text),
						R5 = Convert.ToDouble(textBox5.Text),
						r1 = Convert.ToDouble(textBox6.Text),
						r2 = Convert.ToDouble(textBox7.Text),
						r3 = Convert.ToDouble(textBox8.Text),
					};
					textBox1.Text = "Результат: \r\n" + "E1 = " + Convert.ToInt32(task5.Decision()).ToString() + " кВм\r\n" + "E2 = " + Convert.ToInt32(task5.Dec2()).ToString() +
						" кВм\r\n" + "E3 = " + (task5.Dec3()).ToString() + " кВм\r\n";

				}
				catch (Exception)
				{
					MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}

		}	
	}
	public static class ChangeVis
	{
		public static void TextBoxVis(this TextBox textBox)
		{
			textBox.Visible = true;
		}
		public static void TextBoxNotVis(this TextBox textBox)
		{
			textBox.Visible = false;
		}
		public static void LabelVis(this Label label)
		{
			label.Visible = true;
		}
		public static void LabelNotVis(this Label label)
		{
			label.Visible = false;
		}
	}
}
