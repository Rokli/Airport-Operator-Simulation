using Airport_Operator_Simulation.Models;
using Airport_Operator_Simulation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_Operator_Simulation.View.Class
{
    public class MainWindow : Form, IView
    {
        private Label label1;
        private RadioButton Uniform;
        private RadioButton Exp;
        private Label label2;
        private TextBox WeigthOne;
        private TextBox StopWeigth;
        private Label label3;
        private Label label4;
        private TextBox NumberTerminal;
        private Label label6;
        private Label label7;
        private TextBox WeigthTwo;
        private TextBox NumberPeopleTwo;
        private Label label8;
        private TextBox NumberPeopleOne;
        private Label Weigth;
        private Label label5;
        private Label StopLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public Chart _chart { get; set; }
        public Button InputButton { set => Controls.Add(value); }
        public RadioButton[] radioButtons { get; set; }
        public TextBox[] getValue { get; set; }
        public string stop { set => StopLabel.Text = value; }

        public MainWindow(SaveLoad load)
        {
            InitializeComponent();
            _chart = chart;
            radioButtons = [Uniform, Exp];
            getValue = [WeigthOne, WeigthTwo, StopWeigth, NumberTerminal, NumberPeopleOne, NumberPeopleTwo];
            load.Load(getValue,"C:\\Users\\satal\\source\\repos\\Airport Operator Simulation\\Airport Operator Simulation\\Save\\save.json");
        }

        

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Uniform = new System.Windows.Forms.RadioButton();
            this.Exp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.WeigthOne = new System.Windows.Forms.TextBox();
            this.StopWeigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberTerminal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WeigthTwo = new System.Windows.Forms.TextBox();
            this.NumberPeopleTwo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberPeopleOne = new System.Windows.Forms.TextBox();
            this.Weigth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(13, 13);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Passenger";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(485, 396);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор распределение";
            // 
            // Uniform
            // 
            this.Uniform.AutoSize = true;
            this.Uniform.Location = new System.Drawing.Point(504, 32);
            this.Uniform.Name = "Uniform";
            this.Uniform.Size = new System.Drawing.Size(224, 20);
            this.Uniform.TabIndex = 3;
            this.Uniform.TabStop = true;
            this.Uniform.Text = "Равномерное распределение";
            this.Uniform.UseVisualStyleBackColor = true;
            // 
            // Exp
            // 
            this.Exp.AutoSize = true;
            this.Exp.Location = new System.Drawing.Point(504, 58);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(261, 20);
            this.Exp.TabIndex = 4;
            this.Exp.TabStop = true;
            this.Exp.Text = "Экспоненциальное распределение";
            this.Exp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вес багажа пассажиров";
            // 
            // WeigthOne
            // 
            this.WeigthOne.Location = new System.Drawing.Point(504, 105);
            this.WeigthOne.Name = "WeigthOne";
            this.WeigthOne.Size = new System.Drawing.Size(87, 22);
            this.WeigthOne.TabIndex = 6;
            // 
            // StopWeigth
            // 
            this.StopWeigth.Location = new System.Drawing.Point(504, 149);
            this.StopWeigth.Name = "StopWeigth";
            this.StopWeigth.Size = new System.Drawing.Size(128, 22);
            this.StopWeigth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ограничение по весу багажа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество людей";
            // 
            // NumberTerminal
            // 
            this.NumberTerminal.Location = new System.Drawing.Point(504, 237);
            this.NumberTerminal.Name = "NumberTerminal";
            this.NumberTerminal.Size = new System.Drawing.Size(128, 22);
            this.NumberTerminal.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Количество терминалов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "------";
            // 
            // WeigthTwo
            // 
            this.WeigthTwo.Location = new System.Drawing.Point(634, 105);
            this.WeigthTwo.Name = "WeigthTwo";
            this.WeigthTwo.Size = new System.Drawing.Size(87, 22);
            this.WeigthTwo.TabIndex = 16;
            // 
            // NumberPeopleTwo
            // 
            this.NumberPeopleTwo.Location = new System.Drawing.Point(634, 193);
            this.NumberPeopleTwo.Name = "NumberPeopleTwo";
            this.NumberPeopleTwo.Size = new System.Drawing.Size(87, 22);
            this.NumberPeopleTwo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "------";
            // 
            // NumberPeopleOne
            // 
            this.NumberPeopleOne.Location = new System.Drawing.Point(504, 193);
            this.NumberPeopleOne.Name = "NumberPeopleOne";
            this.NumberPeopleOne.Size = new System.Drawing.Size(87, 22);
            this.NumberPeopleOne.TabIndex = 17;
            // 
            // Weigth
            // 
            this.Weigth.AutoSize = true;
            this.Weigth.Location = new System.Drawing.Point(501, 262);
            this.Weigth.Name = "Weigth";
            this.Weigth.Size = new System.Drawing.Size(235, 16);
            this.Weigth.TabIndex = 20;
            this.Weigth.Text = "Количество не прошедших по весу:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // StopLabel
            // 
            this.StopLabel.AutoSize = true;
            this.StopLabel.Location = new System.Drawing.Point(742, 262);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(14, 16);
            this.StopLabel.TabIndex = 22;
            this.StopLabel.Text = "0";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Weigth);
            this.Controls.Add(this.NumberPeopleTwo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberPeopleOne);
            this.Controls.Add(this.WeigthTwo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberTerminal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopWeigth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeigthOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Uniform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
