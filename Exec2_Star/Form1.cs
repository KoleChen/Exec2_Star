using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		//靠左三角形Button
		private void LeftButton_Click(object sender, EventArgs e)
		{
			// 取得列數
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// 生成星號三角形
			string stars = LeftStars(rows);

			// 呈現Stars
			DisplayStars(stars);
		}
		//靠右三角形Button
		private void RightButton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// 生成星號三角形
			string stars = RightStars(rows);

			// 呈現Stars
			DisplayStars(stars);
		}
		//等腰三角形Button
		private void IsoscelesButton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// 生成星號三角形
			string stars = IsoscelesStars(rows);

			// 呈現Stars
			DisplayStars(stars);
		}
		private void DisplayStars(string stars)
		{
			ResultTextBox.Text = stars;
			
		}

		private string LeftStars(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private string RightStars(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows - i) + new string('*', i) + "\r\n";
			}
			return result;
		}
		private string IsoscelesStars(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ',rows-i) +new string ('*',i)+new string ('*',i-1) +"\r\n";
			}
			return result;
		}
		private int GetRows()
		{
			string input = RowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);

			//如果輸入非數字無法轉換會顯示請輸入列數
			if (isInt == false)
			{
				throw new Exception("請輸入列數");
			}

			// 判斷列數必需大於零
			if (rows <= 0)
			{
				throw new Exception("列數必需大於零");
			}

			return rows;
		}
	}
}
