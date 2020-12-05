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

			TextBox[] textBoxes = { textBox2, textBox3 };
			Label[] labels = { label1, label2 };

			groupBox1.Text = "Задачи";
			radioButton1.Text = "Задача 1";
			radioButton2.Text = "Задача 2";
			radioButton3.Text = "Задача 3";
			radioButton4.Text = "Задача 4";
			radioButton5.Text = "Задача 5";
			button1.Text = "Расчитать";
			radioButton1.CheckedChanged += (s, e) => 
			{
				if (radioButton1.Checked)
				{
					textBox1.Text = "Определить поток ΦЕ вектора напряженности электростатического поля через сферическую поверхность, " +
					"охватывающую точечные заряды Q1 = 5 нКл и Q2 = -2 нКл.";
					foreach (TextBox item in textBoxes)
					{
						item.TextBoxVis();
					}
					foreach (Label item in labels)
					{
						item.LabelVis();
					}
					label1.Text = "Q1";
					label2.Text = "Q2";
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
					textBox1.Text = "Определить напряженность поля, создаваемого диполем с электрическим моментом " +
					"p = 10 - 9 Кл∙м на расстоянии r = 25 см от центра диполя в направлении, перпендикулярном его оси.";
				}
				else
				{
					textBox1.Clear();
				}

			};
			radioButton3.CheckedChanged += (s, e) =>
			{
				if (radioButton3.Checked)
				{
					textBox1.Text = "Кольцо радиусом r = 5 см из тонкой проволоки равномерно заряжено с линейной плотностью λ = 14 нКл/м. " +
					"Определить напряженность поля на оси, проходящей через центр кольца, в точке A, удаленной на расстояние a = 10 см от плоскости кольца.";
				}
				else
				{
					textBox1.Clear();
				}

			};
			radioButton4.CheckedChanged += (s, e) =>
			{
				if (radioButton4.Checked)
				{
					textBox1.Text = "Электростатическое поле создается двумя бесконеч¬ными параллельными плоскостями, " +
					"равномерно заряженными одноименными зарядами с поверхностной плотностью соответ¬ственно σ1 = 2 нКл/м2 и σ2 = 4 нКл/м2. " +
					"Определить напряжен¬ность электростатического поля: 1) между плоскостями; 2) за пределами плоскостей. " +
					"Построить график изменения напряжен¬ности поля вдоль линии, перпендикулярной плоскостям.";
				}
				else
				{
					textBox1.Clear();
				}

			};
			radioButton5.CheckedChanged += (s, e) =>
			{
				if (radioButton5.Checked)
				{
					textBox1.Text = "Поле создано двумя равномерно заряженными концентрическими сферами с радиусами R1 = 5 см и R5 = 8 см. " +
					"Заряды сфер соответственно равны Q1 = 2 нКл и Q5 =-1 нКл. " +
					"Определить напряженность электрического поля в точках, лежащих от центра сфер на расстояниях: 1) r1 = 3 см; 2) r2 = 6 см; 3) r3 = 10 см";
				}
				else
				{
					textBox1.Clear();
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
					Task1 task1 = new Task1() { Q1 = Convert.ToDouble(textBox2.Text), Q2 = Convert.ToDouble(textBox3.Text) };
					textBox1.Text = "Результат: " + Convert.ToInt32(task1.Decision()).ToString() + " В*м";
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
