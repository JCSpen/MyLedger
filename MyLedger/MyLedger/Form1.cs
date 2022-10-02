namespace MyLedger
{
    public partial class LedgerUI : Form
    {
        //Declare Classes
        TimeManagement Chron = new TimeManagement();
        FileChanger FileChanger = new FileChanger();
         public LedgerUI()
        {
            InitializeComponent();
            FileChanger.fileName = Chron.convertDT(); //Gets todays date ready
        }

        // Used to call the write function from filechanger class
        // Allows user to write to txt file
        private void submitBtn_Click(object sender, EventArgs e)
        {
            FileChanger.fileName = Chron.convertDT();
            FileChanger.Write(writeBox.Text);
        }

        // Calls read function that allows users to read their old inputs (Forward)
        private void nextBtn_Click(object sender, EventArgs e)
        {
            readBox.Clear();
            FileChanger.fileName = Chron.nextDay();
            readBox.Text = FileChanger.Read();
        }

        // Calls read function that allows users to read their old inputs (Backward)
        private void previousBtn_Click(object sender, EventArgs e)
        {
            readBox.Clear();
            FileChanger.fileName = Chron.lastDay();
            readBox.Text = FileChanger.Read();
        }
    }
}