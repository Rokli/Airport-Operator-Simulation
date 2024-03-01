using Airport_Operator_Simulation.Models;
using Airport_Operator_Simulation.View.Class;
using Airport_Operator_Simulation.View.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_Operator_Simulation
{
    public class Presenter
    {
        public IView _view { get; set; }
        public Terminal[] terminals { get; set; }
        public Chart _chart { get; set; }
        public Queue<Human> _humans { get; set; } = new Queue<Human>();
        public TextBox[] values { get; set; }
        public Randoms rand {  get; set; }
        public SaveLoad saveLoad { get; set; }
        public Presenter(IView view, SaveLoad save) 
        {
            saveLoad = save;
            _view = view;
            _chart = view._chart;
            values = _view.getValue; 
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            Button button = new Button 
            {
                Text = "Start",
                Size = new System.Drawing.Size(100,50),
                Location = new System.Drawing.Point(500,360)
            };
            button.Click += new EventHandler(StartButton);
            _view.InputButton = button;
            rand = new Randoms(_view.radioButtons);
        }
        private void StartButton(object args, EventArgs e)
        {
            if(!Check())
            {
                CheckWindow window = new CheckWindow();
                window.Show();
            }
            else
            {
                CreateTerminals();
                CreateHumanQueue();
                StartChart();
            }
        }             
        private void StartChart()
        {
            int counter = 0;
            while (_humans.Count > 0) 
            {
                if (terminals.Length == counter)
                    counter = 0;
                terminals[counter].Handler(_humans.Dequeue());
                counter++;
            }
            GraphOutput();
        }
        public void GraphOutput()
        {
            int tmp = 0;
            _chart.Series["Passenger"].Points.Clear();
            for (int i = 0; i < terminals.Length; i++)
            {
                tmp += terminals[i].number;
                _chart.Series["Passenger"].Points.AddXY(i, terminals[i].time);
            }
            _view.stop = tmp.ToString();
            saveLoad.Save(values, "C:\\Users\\satal\\source\\repos\\Airport Operator Simulation\\Airport Operator Simulation\\Save\\save.json");
        }
        public void CreateHumanQueue()
        {
            float tmpSize = rand.Random(Convert.ToInt32(values[4].Text),Convert.ToInt32(values[5].Text));
            for(int i = 0; i< tmpSize; i++)
            {
                float tmpWigth = rand.Random(Convert.ToInt32(values[0].Text), Convert.ToInt32(values[1].Text));
                _humans.Enqueue(new Human(i, tmpWigth));
            }
        }
        public void CreateTerminals()
        {
            float tmp = Convert.ToInt32(values[3].Text);
            terminals = new Terminal[(int)tmp];
            for (int i = 0; i < tmp; i++)
            {
                terminals[i] = new Terminal(rand._rand, Convert.ToInt32(values[2].Text));
            }
        }
        public bool Check()
        {
            if (Convert.ToInt32(values[0].Text) < 0 || Convert.ToInt32(values[0].Text) > Convert.ToInt32(values[1].Text) || Convert.ToInt32(values[1].Text) > 30)
                return false;
            if(Convert.ToInt32(values[2].Text) < 0 || Convert.ToInt32(values[2].Text) > 15)
                return false;
            if(Convert.ToInt32(values[3].Text) < 0 || Convert.ToInt32(values[3].Text) > 20)
                return false;
            if (Convert.ToInt32(values[4].Text) < 0 || Convert.ToInt32(values[4].Text) > Convert.ToInt32(values[5].Text) || Convert.ToInt32(values[5].Text) > 120)
                return false;
            return true;
        }
    }
}
