namespace Assingment1
{
    public partial class Form1 : Form
    {
        const double PAY_PER_HR = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_Firstname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Lastname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Hrsworked_Click(object sender, EventArgs e)
        {

        }

        private void Txt_FirstnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_LastnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_HoursworkedInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Sum_Click(object sender, EventArgs e)
        {
            int hrs=0;  
            try
            {
                hrs = int.Parse(Txt_HoursworkedInput.Text);
            }
            catch
            {
                Lbl_Results.ForeColor = Color.Red;
                Lbl_Results.Text = "Invalidate Input";
                return;
            }
            double totalHours = hrs * PAY_PER_HR;
            Lbl_Results.ForeColor = Color.Black;

            Lbl_Results.Text = $"{Txt_FirstnameInput.Text} {Txt_LastnameInput.Text} worked {Txt_HoursworkedInput.Text} hours at {PAY_PER_HR.ToString("C")} an hour for the total of {totalHours.ToString("C")}";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_FirstnameInput.Clear();
            Txt_LastnameInput.Clear();
            Txt_HoursworkedInput.Clear();
            Lbl_Results.Text = "";
        }

        private void Lbl_Results_Click(object sender, EventArgs e)
        {
         
        }
    }
}
