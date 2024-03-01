using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_Operator_Simulation.View.Interface
{
    public interface IView
    {
        public Chart _chart { get; set; }
        public Button InputButton { set; }
        public RadioButton[] radioButtons { get; set; }
        public TextBox[] getValue { get; set; }
        public string stop { set; }
    }
}
