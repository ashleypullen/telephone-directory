namespace telephone_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] names = new string[20];
        string[] numbers = new string[20];

        private void btnFind_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool found = false;
            string wanted = txtName.Text;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == wanted)
                {
                    found = true;
                    index = i;
                }
            }

            if (found)
            {
                lblNumber.Text = "Number is: " + numbers[index];
            }
            else
            {
                lblNumber.Text = "Name NOT found";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            names[0] = "Alex";
            numbers[0] = "07767207174";

            names[1] = "Megan";
            numbers[1] = "0786229914";
        }
    }
}