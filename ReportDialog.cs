using System;
using System.Drawing;
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
        Size = new System.Drawing.Size(1000, 800);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.White;

        // Create the text box for user input
        textBox = new TextBox();
        textBox.Multiline = true;
        textBox.Dock = DockStyle.Fill;
        textBox.Font = new Font("Segoe UI", 12f);

        // Create a panel for buttons
        buttonPanel = new FlowLayoutPanel();
        buttonPanel.Dock = DockStyle.Bottom;
        buttonPanel.Height = 200;

        // Create buttons for each letter
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Button button = new Button();
            button.Text = c.ToString();
            button.Font = new Font("Segoe UI", 10f);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(240, 240, 240);
            button.Margin = new Padding(5);
            button.Size = new Size(50, 50);
            button.Click += Button_Click;
            buttonPanel.Controls.Add(button);
        }

        // Add space and backspace buttons
        Button spaceButton = new Button();
        spaceButton.Text = "Space";
        spaceButton.Font = new Font("Segoe UI", 10f);
        spaceButton.FlatStyle = FlatStyle.Flat;
        spaceButton.FlatAppearance.BorderSize = 0;
        spaceButton.BackColor = Color.FromArgb(240, 240, 240);
        spaceButton.Margin = new Padding(5);
        spaceButton.Size = new Size(110, 50);
        spaceButton.Click += SpaceButton_Click;
        buttonPanel.Controls.Add(spaceButton);

        Button backspaceButton = new Button();
        backspaceButton.Text = "Backspace";
        backspaceButton.Font = new Font("Segoe UI", 10f);
        backspaceButton.FlatStyle = FlatStyle.Flat;
        backspaceButton.FlatAppearance.BorderSize = 0;
        backspaceButton.BackColor = Color.FromArgb(240, 240, 240);
        backspaceButton.Margin = new Padding(5);
        backspaceButton.Size = new Size(110, 50);
        backspaceButton.Click += BackspaceButton_Click;
        buttonPanel.Controls.Add(backspaceButton);

        // Add controls to the form
        Controls.Add(textBox);
        Controls.Add(buttonPanel);

        // Create and add submit button
        // Create and add submit button
        submitButton = new Button();
        submitButton.Text = "Submit";
        submitButton.Font = new Font("Segoe UI", 10f);
        submitButton.FlatStyle = FlatStyle.Flat;
        submitButton.FlatAppearance.BorderSize = 0;
        submitButton.BackColor = Color.FromArgb(63, 81, 181);
        submitButton.ForeColor = Color.White;
        submitButton.Margin = new Padding(5);
        submitButton.Size = new Size(110, 50);

      

        submitButton.Click += SubmitButton_Click;
        Controls.Add(submitButton);

        // Position the submit button beside space and backspace buttons
        buttonPanel.Controls.Add(submitButton);



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

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // ReportDialog
            // 
            this.ClientSize = new System.Drawing.Size(408, 364);
            this.Name = "ReportDialog";
            this.ResumeLayout(false);

    }
}
