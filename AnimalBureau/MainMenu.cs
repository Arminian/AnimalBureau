using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace AnimalBureau
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.AppDomain.CurrentDomain.BaseDirectory + "AnimalDB.mdf" + ";Integrated Security=True;Connect Timeout=30");
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into UsrTable values('" + speciesBox.Text + "', '" + genusBox.Text + "','" + familyBox.Text + "','" + orderBox.Text + "','" + classBox.Text + "','" + phylumBox.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Entry Added");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Cannot add entry");
            }
        }

        void pop()
        {
            try
            {
                connection.Open();
                string showQuery = "Select * from UsrTable";
                SqlDataAdapter adapter = new SqlDataAdapter(showQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dset = new DataSet();
                adapter.Fill(dset);
                userGV.DataSource = dset.Tables[0];
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error while loading table");
            }
        }

        void search()
        {
            try
            {
                connection.Open();
                string showQuery = "Select * from UsrTable where species='" + searchBox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(showQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dset = new DataSet();
                adapter.Fill(dset);
                userGV.DataSource = dset.Tables[0];
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error while searching");
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            pop();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            pop();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (speciesBox.Text == "")
            {
                MessageBox.Show("Enter species name in the text box 'species'");
            }
            else
            {
                connection.Open();
                string deleteQuery = "Delete from UsrTable where species='" + speciesBox.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Deleted");
                connection.Close();
            }
        }

        private void userGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                phylumBox.Text = userGV.CurrentRow.Cells[5].Value.ToString();
                classBox.Text = userGV.CurrentRow.Cells[4].Value.ToString();
                orderBox.Text = userGV.CurrentRow.Cells[3].Value.ToString();
                familyBox.Text = userGV.CurrentRow.Cells[2].Value.ToString();
                genusBox.Text = userGV.CurrentRow.Cells[1].Value.ToString();
                speciesBox.Text = userGV.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error while selecting row");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            phylumBox.Text = "";
            classBox.Text = "";
            orderBox.Text = "";
            familyBox.Text = "";
            genusBox.Text = "";
            speciesBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpPage help = new helpPage();
            help.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutPage about = new aboutPage();
            about.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update UsrTable set genus='" + genusBox.Text + "',family='" + familyBox.Text + "',orders='" + orderBox.Text + "',class='" + classBox.Text + "',phylum='" + phylumBox.Text + "' where species='" + speciesBox.Text + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Updated");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Cannot update entry");
            }
        }
    }
}