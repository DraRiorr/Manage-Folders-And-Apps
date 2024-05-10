using System.IO;
using System.Windows.Forms.VisualStyles;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string masir = txt.Text;
            listBox.Items.Clear();
            string[] Dires = Directory.GetDirectories(masir);
            foreach (string dir in Dires)
            {
                listBox.Items.Add(Path.GetFileName(dir));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masir = txt.Text; 
            listBox.Items.Clear();
            string[] Dires = Directory.GetFiles(masir);
            foreach(string dir in Dires)
            {
                listBox.Items.Add(Path.GetFileName(dir)); 
            }
        }
    }
}
