using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Operator_Simulation.View.Class
{
    public class CheckWindow : Form
    {
        private Label label2;

        public CheckWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Неправильно введены данные";
            // 
            // CheckWindow
            // 
            this.ClientSize = new System.Drawing.Size(568, 365);
            this.Controls.Add(this.label2);
            this.Name = "CheckWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
