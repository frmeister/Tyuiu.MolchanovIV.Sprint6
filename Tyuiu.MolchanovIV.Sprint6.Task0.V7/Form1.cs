using Tyuiu.MolchanovIV.Sprint6.Task0.V7.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task0.V7
{
    public partial class FormMain_MIV : Form
    {
        public FormMain_MIV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxGeneral_MIV_Click(object sender, EventArgs e)
        {

        }

        private void inputText_MIV_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputText_MIV_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDone_MIV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                outputText_MIV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(inputText_MIV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonQuestion_MIV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППБ-25-1 Молчанов Иван Владимирович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
