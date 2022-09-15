using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void correctingDate()
        {
            randomTextBox.Text = randomTextBox.Text.Trim();
            randomTextBox.Text = Regex.Replace(randomTextBox.Text, "[ ]+", " ");
        }

        private bool checkError()
        { 
            try
            {
                string[] nums = randomTextBox.Text.Split(' ');

                for (int i = 0; i < 10; ++i)
                {
                    bool isNumber = int.TryParse(nums[i], out int num);
                    if (!isNumber)
                    {
                        MessageBox.Show("Неккоретная последовательность чисел");
                        return true;
                    }
                }

                if (nums.Length != 10)
                {
                    MessageBox.Show("Неккоретная последовательность чисел");
                    return true;
                }
               
                

                for (int i = 0; i < dataGridView.RowCount; ++i)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; ++j)
                    {
                        bool isNumber = int.TryParse(dataGridView.Rows[i].Cells[j].Value?.ToString(), out int num);
                        if(!isNumber)
                        {
                            MessageBox.Show("Неккоретные числа в матрице");
                            return true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
            
        }

        private void randomNumberBtn_Click(object sender, EventArgs e)
        {
            randomTextBox.Text = "";
            Random rnd = new Random();
            for(int i = 0; i < 10; ++i)
            {
                randomTextBox.Text += rnd.Next(1, 10).ToString() + " ";
            }
        }

        private void randomMatrixBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i = 0; i < dataGridView.RowCount; ++i)
            {
                for (int j = 0; j < dataGridView.ColumnCount; ++j)
                {
                    dataGridView.Rows[i].Cells[j].Value = rnd.Next(1, 25);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnCount = 5;
            dataGridView.RowCount = 5;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            correctingDate();
            if(!checkError())
            {
                string[] nums = randomTextBox.Text.Split(' ');

                for (int i = 0; i < dataGridView.RowCount; ++i)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; ++j)
                    {
                        for (int z = 0; z < nums.Length; ++z)
                        {
                            if (dataGridView.Rows[i].Cells[j].Value.ToString() == nums[z])
                            {
                                dataGridView.Rows[i].Cells[j].Value = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
