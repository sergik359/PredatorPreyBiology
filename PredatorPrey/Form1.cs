namespace PredatorPrey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnteringNumbersKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!double.TryParse(textCountPrey.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double nCountPreys = Convert.ToDouble(textCountPrey.Text);
                double cCountPredators = Convert.ToDouble(textCountPredator.Text);
                double rKoefPrey = Convert.ToDouble(textKoefPrey);
                double aKoefFind = Convert.ToDouble(textKoefFind.Text);
                double qSpeedDownPredators = Convert.ToDouble(textSpeedDownPop);
                double fKoefReprodPredators = Convert.ToDouble(textReprodPredator);
            }
            catch (Exception)
            {
                labelError.Text = "В данных ошибка";
                return;
            }


           
        }
    }
}