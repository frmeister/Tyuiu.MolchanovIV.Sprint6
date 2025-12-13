using Tyuiu.MolchanovIV.Sprint6.Task6.V13.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task6.V13
{
    public partial class FormMain_MIV : Form
    {
        public FormMain_MIV()
        {
            InitializeComponent();
        }

        string openFilePath;

        DataService ds = new DataService();

        private void buttonAbout_MIV_Click(object sender, EventArgs e)
        {
            FormAbout_MIV formAbout = new FormAbout_MIV();
            formAbout.ShowDialog();
        }

        private void buttonOpen_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_MIV.ShowDialog();
                openFilePath = openFileDialog_MIV.FileName;
                textBoxInput_MIV.Text = File.ReadAllText(openFilePath);
                groupBoxOutput.Text = groupBoxOutput.Text + " " + openFileDialog_MIV.FileName;
                buttonPerform_MIV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPerform_MIV_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput_MIV.Text = ds.CollectTextFromFile(openFilePath);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
