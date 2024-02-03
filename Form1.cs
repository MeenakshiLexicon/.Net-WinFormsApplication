using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class AddressBook : Form
    {
        string textfile = "C:\\Users\\Meenakshi\\OneDrive\\Desktop\\" + "data.txt";
        public List<Address> addresses = new List<Address>();


        public AddressBook()
        {
            InitializeComponent();
            LoadAddressesFromFile();
        }

        private void LoadAddressesFromFile()
        {
            if (File.Exists(textfile))
            {
                addresses = File.ReadAllLines(textfile).Select(line => Address.FromCsv(line)).ToList();

            }
        }
        private void SaveAddressesToFile()
        {
            File.WriteAllLines(textfile, addresses.Select(address => address.ToCsv()));

        }

        //------ADD DATA IN TEXT FILE--------------------//
        private void button5_Click(object sender, EventArgs e)
        {
            textContent1.Clear();
            var newAddress = new Address
            {

                Name = txtName.Text,
                TextAddress = txtAddress.Text,
                PostalCode = txtPostNo.Text,
                PostalAddress = txtPostOrt.Text,
                Telephone = txtPhone.Text,
                Email = txtEmail.Text
            };
            if (txtName.Text == "" || txtAddress.Text == "" || txtPostNo.Text == ""
                || txtPostOrt.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {

                MessageBox.Show("All fields are mandatory to be filled in");

            }
            else
            {
                addresses.Add(newAddress);
                SaveAddressesToFile();

                ClearTextBoxes();
                MessageBox.Show("Content added successfully.");
            }

        }

        //-------------------- CLEAR DATA FROM TEXTFORM-------------------//
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        




        //------------------UPDATE FILE WITH UPDATERA ------------------------//
        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            textContent1.Clear();
            if (txtAddress.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please provide Name and Gatuadress to update");
            }
            else
            {
                string TextLineToUpdate = txtName.Text + "," + txtAddress.Text;

                var addressToUpdate = addresses.FirstOrDefault(a => a.Name + "," + a.TextAddress == TextLineToUpdate);



                if (addressToUpdate != null)
                {

                    addressToUpdate.PostalCode = txtPostNo.Text;
                    addressToUpdate.PostalAddress = txtPostOrt.Text;
                    addressToUpdate.Telephone = txtPhone.Text;
                    addressToUpdate.Email = txtEmail.Text;


                    SaveAddressesToFile();

                    ClearTextBoxes();
                    MessageBox.Show("Address Updated successfully.");
                }
                else
                {
                    MessageBox.Show("Provide Name and Address not found. Please check");
                }
            }
        }

        //---------------USING CLASSES, PROPERTIES, METHODES-----------------//
        public class Address
        {
            public string Name { get; set; }
            public string TextAddress { get; set; }
            public string PostalCode { get; set; }
            public string PostalAddress { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }



            //------------USING CSV (COMMA SEPERATED VALUE)------------------//
            public static Address FromCsv(string csvLine)
            {
                string[] values = csvLine.Split(',');
                if (values.Length != 6)
                {
                    MessageBox.Show("Invalid CSV format");
                }

                return new Address
                {
                    Name = values[0],
                    TextAddress = values[1],
                    PostalCode = values[2],
                    PostalAddress = values[3],
                    Telephone = values[4],
                    Email = values[5]
                };
            }

            public string ToCsv()
            {
                return $"{Name},{TextAddress},{PostalCode},{PostalAddress},{Telephone},{Email}";
            }
        }

        //----------------------DELETE DATA FROM FILE-------------------------------//
        private void buttonDelete_Click(object sender, EventArgs e)

        {
            if (txtAddress.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please provide Name and Gatuadress to Delete");
            }
            else
            {

                string TextLineToDelete = txtName.Text + "," + txtAddress.Text;
                var addressToDelete = addresses.FirstOrDefault(a => a.Name + "," + a.TextAddress == TextLineToDelete);

                if (addressToDelete != null)
                {
                    addresses.Remove(addressToDelete);
                    SaveAddressesToFile();

                    ClearTextBoxes();
                    MessageBox.Show("Content Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Name and Address not found. Please check");
                }
            }
        }

        //-----------------------SEARCH DATA FROM TEXTFILE-----------------------//
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textContent1.Clear();
            string searchText = textSearch.Text;


            if (File.Exists(textfile))
            {
                string datafound = "";

                string[] lines = File.ReadAllLines(textfile);
                textSearch.Clear();

                foreach (string line in lines)
                {
                    if (line.Contains(searchText + ","))
                    {
                        string[] values = line.Split(',');
                        if (values[1] == searchText || values[0] == searchText)
                        {
                            textContent1.AppendText(line + Environment.NewLine);
                            datafound = "yes";


                        }


                    }

                }
                if (datafound != "yes")
                {
                    MessageBox.Show("Given address not found.");
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        //-----Read data from text file----//
        private void button1_Click_1(object sender, EventArgs e)
        {
            textContent1.Clear();

            StreamReader sr = new StreamReader(textfile);


            // Clear the RichTextBox
            textContent1.Clear();


            textContent1.Text = sr.ReadToEnd();

            sr.Close();

        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContent_TextChanged(object sender, EventArgs e)
        {







        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textContent1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}