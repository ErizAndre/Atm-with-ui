namespace atm2
{
    public partial class Form1 : Form
    {
        public string pass = "01010";
        public string inputPass = " ";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btncard_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            this.Hide();
            Form3.ShowDialog();
        }
    }
}
