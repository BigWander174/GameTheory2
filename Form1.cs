using GameTheory2.Model;

namespace GameTheory2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var value = (int)((NumericUpDown)sender).Value;
            dataGridView1.RowCount = value;
            dataGridView2.RowCount = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = $"A{i + 1}";
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var value = (int)((NumericUpDown)sender).Value;
            dataGridView1.ColumnCount = value;
            dataGridView2.ColumnCount = value;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Value = $"Ï{i + 1}";
                dataGridView2.Columns[i].HeaderCell.Value = $"q{i + 1}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix();
            matrix.Work(dataGridView1);

            var constant = Convert.ToDouble(textBox1.Text);
            Calculation calculation = new Calculation(matrix, dataGridView2, constant);

            textBox2.Text = calculation.Info;
        }
    }
}