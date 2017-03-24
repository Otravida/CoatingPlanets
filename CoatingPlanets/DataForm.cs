using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CoatingPlanets
{
    public partial class DataForm : Form
    {
        string connString = @"Data Source=\\\\thorlabs.local\\NWT\\opticsbu\\Coating\\Planner\\Info.db;Version=3;";

        public DataForm()
        {
            InitializeComponent();
            
            string queryall = "SELECT * FROM parts;";
            SQLiteConnection dbConnection = new SQLiteConnection(connString);
            SQLiteCommand command = new SQLiteCommand(queryall, dbConnection);
            using (dbConnection)
            {
                dbConnection.Open();
                using (command)
                {
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                    dataGridView2.DataSource = dataSet.Tables[0].DefaultView;
                }
            }
            
            partsTab.SelectedIndexChanged += partsTab_SelectedIndexChanged;
        }

        private void addItem_Button_Click(object sender, EventArgs e)
        {

            string insert = "INSERT INTO parts (partname, shape, dimension1, dimension2, coating) VALUES (?,?,?,?,?)";

            string partnumber = partNumber_Text.Text;
            string shape = shape_Box.Text;
            string majordimension = majorDimension_Text.Text;
            string minordimension = minorDimension_Text.Text;
            string coating = coating_Box.Text;

            SQLiteConnection dbConnection = new SQLiteConnection(connString);
            SQLiteCommand command = new SQLiteCommand(insert, dbConnection);

            //Some stuff with error handling - need items to not have blanks

            using (dbConnection)
            {
                dbConnection.Open();
                using (command)
                {
                    command.Parameters.AddWithValue("partname", partnumber);
                    command.Parameters.AddWithValue("shape", shape);
                    command.Parameters.AddWithValue("dimension1", majordimension);
                    command.Parameters.AddWithValue("dimension2", minordimension);
                    command.Parameters.AddWithValue("coating", coating);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item added!");
                    this.Refresh();
                }
            }  
        }
        private void partsTab_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (partsTab.SelectedIndex == 0)
            {
                addItem_Button.Enabled = true;
                deleteItem_Button.Enabled = false; updateItem_Button.Enabled = false;
            } else
            {
                addItem_Button.Enabled = false;
                deleteItem_Button.Enabled = true; updateItem_Button.Enabled = true;
            }
        }

    }
}

