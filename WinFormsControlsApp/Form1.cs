using System.Text.RegularExpressions;

namespace WinFormsControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection names = new()
            {
                "Bobby",
                "Mickael",
                "Phillip",
                "Whiliame",
                "Jimmy",
                "Mark",
                "Baniphacy"
            };
            txtBoxHello.AutoCompleteCustomSource = names;
            lblTablo.Text = "";
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {txtBoxHello.Text}");
        }

        private void txtBoxHello_TextChanged(object sender, EventArgs e)
        {
            lblTablo.Text = "Hello " + txtBoxHello.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TextBox box = (TextBox)sender;

            Regex email = new Regex(@"\w+@\w+\.\w+");
            if (!email.IsMatch(textBoxEmail.Text))
                textBoxEmail.BackColor = Color.LightPink;
            else
                textBoxEmail.BackColor = SystemColors.Window;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            string msg = $"Checked = {check.Checked}, CheckState = {check.CheckState}";
            MessageBox.Show(msg);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                string msg = $"Your choise: {radio.Text}";
                MessageBox.Show(msg);
            }

        }
    }
}