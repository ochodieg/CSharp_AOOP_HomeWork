namespace DIvanOchoa2263Ex1;

public partial class FullNameForm : Form
{
   /*
    * D. Ivan Ochoa
    * 1/15/2023
    * 
    * Description: FormApp displays greeting with user input.
    */
    public FullNameForm()
    {
        InitializeComponent();
    }

    // method invoked upon button "click" event
    private void btnGiveResponse_Click(object sender, EventArgs e)
    {
        // when method is invoked, case will be assessed
        // if whitespace-checked string input is empty
        // in either field
        if (txtFirstNameBox.Text.Trim() == "" ||
            txtLastNameBox.Text.Trim() == "")
        {MessageBox.Show("Please enter your full name.");}
        
        // otherwise display interpolated desired output
        else
        {
            MessageBox.Show($"Hello, " +
                $"{txtFirstNameBox.Text.Trim()} {txtLastNameBox.Text.Trim()}");
        }

    }
}
