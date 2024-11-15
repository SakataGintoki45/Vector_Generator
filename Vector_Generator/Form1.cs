namespace Vector_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void btnGenerate_Click(object sender, EventArgs e)
        {
            int vectorSize;
            if (int.TryParse(txtSize.Text, out vectorSize) && vectorSize > 0)
            {
                int[] vector = new int[vectorSize];
                
                lstVector.Items.Clear();

                for (int i = 0; i < vectorSize; i++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"Enter the value for index {i}:", "Data Entry", "0");
                    if (int.TryParse(input, out int value))
                    {
                        vector[i] = value;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number.");
                        return;
                    }
                }
                foreach (var item in vector)
                {
                    lstVector.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid vector size.");
            }
        }
    }
}
