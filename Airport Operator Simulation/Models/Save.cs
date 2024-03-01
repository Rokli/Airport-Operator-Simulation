using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Airport_Operator_Simulation.Models
{
    public class SaveLoad
    {
        public string[] textSave {  get; set; } = new string[6];
        public void Save(TextBox[] text,string filepath) 
        {
            //getValue = [WeigthOne, WeigthTwo, StopWeigth, NumberTerminal, NumberPeopleOne, NumberPeopleTwo];
            textSave[0] = text[0].Text;
            textSave[1] = text[1].Text;
            textSave[2] = text[2].Text;
            textSave[3] = text[3].Text;
            textSave[4] = text[4].Text;
            textSave[5] = text[5].Text;
            StreamWriter writer = new StreamWriter(filepath, false);
            string json = JsonConvert.SerializeObject(this);
            writer.WriteAsync(json);
            writer.Dispose();
        }
        public TextBox[] Load(TextBox[] text,string filepath) 
        {
            StreamReader reader = new StreamReader(filepath);
            string json = reader.ReadToEnd();
            reader.Dispose();
            SaveLoad tmp = JsonConvert.DeserializeObject<SaveLoad>(json);
            textSave = tmp.textSave;
            text[0].Text = textSave[0];
            text[1].Text = textSave[1];
            text[2].Text = textSave[2];
            text[3].Text = textSave[3];
            text[4].Text = textSave[4];
            text[5].Text = textSave[5];
            return text;
        }
    }
}
