using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace separator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var texts = richTextBox1.Text.Split("\n");

                List<string> listStrg = new List<string>();

                var newFormattedString = string.Empty;

                foreach (var text in texts)
                {
                    if (radioButton2.Checked)
                    {
                        newFormattedString = "'" + text + "'";
                    }

                    if (radioButton1.Checked)
                    {
                        newFormattedString = '"' + text + '"';
                    }

                    if (radioButton3.Checked)
                    {
                        newFormattedString = text;
                    }

                    listStrg.Add(newFormattedString);

                    richTextBox2.Text = string.Join(textBox1.Text, listStrg);

                    button2.Text = "Copy";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());

            }
          
            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(richTextBox2.Text == "")
                {
                    MessageBox.Show("Nothing to copy", "Separator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Clipboard.SetText(richTextBox2.Text);
                    button2.Text = "Copied";
                }
                    
                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}