using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


public class ReportDialog : Form
{
    public TextBox textBox;
    private FlowLayoutPanel buttonPanel;
    private Button submitButton;
    private bool reportSubmitted = false; // Flag to track whether report was submitted

    public ReportDialog()
    {
        // Set up the form
        Text = "Report Problem";
        Size = new System.Drawing.Size(900, 500);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;

        // Create the text box for user input
        textBox = new TextBox();
        textBox.Multiline = true;
        textBox.Dock = DockStyle.Fill;

        // Create a panel for buttons
        buttonPanel = new FlowLayoutPanel();
        buttonPanel.Dock = DockStyle.Left;
        buttonPanel.Height = 200;

        // Create buttons for each letter
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Button button = new Button();
            button.Text = c.ToString();
            button.Click += Button_Click;
            buttonPanel.Controls.Add(button);
        }

        // Add space and backspace buttons
        Button spaceButton = new Button();
        spaceButton.Text = "Space";
        spaceButton.Click += SpaceButton_Click;
        buttonPanel.Controls.Add(spaceButton);

        Button backspaceButton = new Button();
        backspaceButton.Text = "Backspace";
        backspaceButton.Click += BackspaceButton_Click;
        buttonPanel.Controls.Add(backspaceButton);

        // Add controls to the form
        Controls.Add(textBox);
        Controls.Add(buttonPanel);

        // Create and add submit button
        submitButton = new Button();
        submitButton.Text = "Submit";
        submitButton.Dock = DockStyle.Bottom;
        submitButton.Click += SubmitButton_Click;
        Controls.Add(submitButton);

        // Handle form closing event
        FormClosing += ReportDialog_FormClosing;

    }

    private void Button_Click(object sender, EventArgs e)
    {
        // Append the clicked button's text to the text box
        Button button = sender as Button;
        textBox.AppendText(button.Text);
    }

    private void SpaceButton_Click(object sender, EventArgs e)
    {
        // Append a space to the text box
        textBox.AppendText(" ");
    }

    private void BackspaceButton_Click(object sender, EventArgs e)
    {
        // Remove the last character from the text box
        if (textBox.Text.Length > 0)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        // Check if the message is empty
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            MessageBox.Show("Please enter a message before submitting.");
            return;
        }

        // Close the form when the submit button is clicked
        reportSubmitted = true; // Set flag indicating report was submitted

        // Insert the message into the database
        string connectionString = "Server=localhost;Port=3306;Database=admin_user;Uid=root;Pwd=;";
        string message = textBox.Text;

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string sql = "INSERT INTO tbl_reports (issue, datetime) VALUES (@issue, NOW())";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@issue", message);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report submitted successfully.");
            }
            catch (Exception ex)
            {
                // Log the error for troubleshooting
                MessageBox.Show($"Error submitting report: {ex.Message}");
            }
        }

        // Close the form
        DialogResult = DialogResult.OK;
        Close();
    }




    private void ReportDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Check if the report was not submitted when the form is closed
        if (!reportSubmitted)
        {
            MessageBox.Show("Report cancelled.");
        }
    }
}



