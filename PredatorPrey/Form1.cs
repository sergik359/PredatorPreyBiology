using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Legends;

namespace PredatorPrey
{
    public partial class Form1 : Form
    {
        private double _nCountPreys;
        private double _cCountPredators;
        private double _rKoefPrey;
        private double _aKoefFind;
        private double _qSpeedDownPredators;
        private double _fKoefReprodPredators;
        private double _deltaTime = 0.1f;
        private double _maxYears = 50f;


        public Form1()
        {
            InitializeComponent();
        }

        private void EnteringNumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(textCountPrey.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _nCountPreys = Convert.ToDouble(textCountPrey.Text);
                _cCountPredators = Convert.ToDouble(textCountPredator.Text);
                _rKoefPrey = Convert.ToDouble(textKoefPrey.Text);
                _aKoefFind = Convert.ToDouble(textKoefFind.Text);
                _qSpeedDownPredators = Convert.ToDouble(textSpeedDownPop.Text);
                _fKoefReprodPredators = Convert.ToDouble(textReprodPredator.Text);
            }
            catch (Exception)
            {
                labelError.Text = "В данных ошибка";
                return;
            }

            DrawGraph();        
        }


        private void DrawGraph()
        {
            var myModel = new PlotModel { Title = "Хищник-жертва" };

            LineSeries preyPoints;
            LineSeries predatorPoints;
            preyPoints = FindPoints(out predatorPoints);
            
            myModel.Series.Add(preyPoints);
            myModel.Series.Add(predatorPoints);
           
            plotView1.Model = myModel;
            plotView1.Model.Legends.Add(new Legend()
            {
                LegendTitle = "Легенда",
                LegendPosition = LegendPosition.TopRight,
            });
        }


        private LineSeries FindPoints(out LineSeries predatorPoints)
        {
            LineSeries preyPoints = new LineSeries
            {
                Title = "Жертвы",
                StrokeThickness = 3,
                LineStyle = LineStyle.Automatic,
                MarkerSize = 5,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Green,
                MarkerStrokeThickness = 1.5,
                Color = OxyColors.Green,
            }; 

            predatorPoints = new LineSeries()
            {
                Title = "Хищники",
                StrokeThickness = 3,
                LineStyle = LineStyle.Automatic,
                MarkerSize = 5,
                MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Red,
                MarkerStrokeThickness = 1.5,
                Color = OxyColors.Red,
            };

            var countYears = 0;

            predatorPoints.Points.Add(new DataPoint(countYears, (int)_cCountPredators));
            preyPoints.Points.Add(new DataPoint(countYears, (int) _nCountPreys));
            
            while (countYears <= _maxYears)
            {
                countYears++;
                _cCountPredators = _cCountPredators + (_fKoefReprodPredators * _aKoefFind * _cCountPredators * _nCountPreys - _qSpeedDownPredators * _cCountPredators) * _deltaTime;
                _nCountPreys = _nCountPreys + (_rKoefPrey * _nCountPreys - _aKoefFind * _cCountPredators * _nCountPreys) * _deltaTime;

                predatorPoints.Points.Add(new DataPoint(countYears, (int)_cCountPredators));
                preyPoints.Points.Add(new DataPoint(countYears, (int)_nCountPreys));
            }

            return preyPoints;
        }
    }
}