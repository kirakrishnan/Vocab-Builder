using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WordsHelper;
using System.Data.SqlClient;



/******************************************************
// Group       :  3               
                            
// Project     :  Vocabulary Management System   
           
// Function    :  Allows user to enter a Spelling, Meaning
//                and a Sample sentence and saves it in a
//                viewable list  & also allows user to seach
//                a word from the list
                                                
// Description :  When user saves a new Spelling, Meaning 
//                and Sentence from DetailsView ,it gets saved
//                in a text file locally which is then read and 
//                shown in the user viewable ListView (CompleteView)
//
// Updates     :  Added a button which turns ON/Off to show new word information 
                  to user by referencing a .dll library

// Version     :  1.1
// Date        :  02/29/2016
************************************************************************************/


namespace VocabBuilder
{
    /********************************************************************************
     * Class : VocabManagerForm
     * 
     * Methods : 
     *          1) Initializer : Initialises when the application loads
     *                           Reads locally saved text file and displays 
     *                           to the listView
     *          
     * Events : 
     *          1) btnSave_Click   : Saves user entered information to text file
     *          2) btnSearch1_Click : Returns searched word to Details View
     *          3) btnExitApp_Click   : Exits the application
     *          4) btnCancelFields_Click : Clears the inputs (DetailsView)
     *          5) btnDelete_Click() : Deletes the item from listView and text file
     *          6) 
     *          
     ********************************************************************************/
    public partial class VocabManagerForm : Form
    {
        //Creating object words as Word-List
       // List<Word> words = new List<Word>();

        //List to search words
        List<Word> words1 = new List<Word>();

        //Declaring path for the text file
       // const string Path = @"..\..\Words.txt";

        //Creating timer
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        
        SqlCommand cmd;
        SqlConnection conn;
        DataSet ds, ds1;

        BindingSource bsource = new BindingSource();

        // !!! please use your own account to access the database!!!
        string connstr = "server=10.158.56.48;uid=net3;pwd=dtbz3;database=notebase3;";
        SqlDataAdapter da = new SqlDataAdapter();

        // approach one: open connection, run commad to fetch system objects with specified name
        // and count the number of such objects
        // note that sysobjects is a system table for sql server
        public string VerifyTableExistence1()
        {
            conn = new SqlConnection(connstr);
           
            
            cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open(); //open the connection

            string text = "Select Count(*) from sysObjects WHERE name = 'all_words_table'"; 
            string secondTableExistence = "Select Count(*) from sysObjects WHERE name = 'flash-word-table'";
 
            //for first table
            cmd.CommandText = text;

            int res = (int)cmd.ExecuteScalar();

            //for second table
            cmd.CommandText = secondTableExistence;

            int res1 = (int)cmd.ExecuteScalar();

            // close the connection
            conn.Close();                       
            if (res <= 0 && res1 <= 0)
            
                return "Exists";
            else
                return "Doesnt exists";
            

           
        }

        //-------------------------------
        // Creates the table in the database
        protected void CreateTable()
        {
            //First table
            StringBuilder builder = new StringBuilder();
            builder.Append("Create Table all_words_table (ID INT IDENTITY(1,1) PRIMARY KEY,");
            builder.Append("Spelling VARCHAR(30),");
            builder.Append("Meaning VARCHAR(80),");
            builder.Append("Example VARCHAR(100),");
            builder.Append("TimeCreated DATETIME,");
            builder.Append("TimeUpdated DATETIME)");

            string sql = builder.ToString();

            //cmd = new SqlCommand(sql);
            cmd = new SqlCommand();
            using (conn = new SqlConnection(connstr))
            {
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }

            //second table
            StringBuilder secondTable = new StringBuilder();
            secondTable.Append("Create Table flash_word_table (ID INT IDENTITY(1,1) PRIMARY KEY,");
            secondTable.Append("Spelling VARCHAR(80),");
            secondTable.Append("Meaning VARCHAR(80),");
            secondTable.Append("Example VARCHAR(200))");


            string sql1 = secondTable.ToString();

            //cmd = new SqlCommand(sql);
            cmd = new SqlCommand();
            using (conn = new SqlConnection(connstr))
            {
                try
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }

            

        }

        

        //-----------------------------------
        // Inserts 2 rows of data into newly created table
        protected void InsertSeedData()
        {
            string sql = "Insert into all_words_table values (@Spelling, @Meaning, @Example, @TimeCreated, @TimeUpdated)";
            
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Spelling", "Fun");
            cmd.Parameters.AddWithValue("@Meaning", "Enjoyment");
            cmd.Parameters.AddWithValue("@Example", "Enjoy your life !!");
            cmd.Parameters.AddWithValue("@TimeCreated", DateTime.Now);
            cmd.Parameters.AddWithValue("@TimeUpdated", DateTime.Now);
          
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                
                // Plug values into parameters for second row
                cmd.Parameters["@Spelling"].Value = "Learn";
                cmd.Parameters[1].Value = "To learn something";
                cmd.Parameters["@Meaning"].Value = "Learn new things everyday";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted into database");
                
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void display_table()
        {
            string sqlstr = "Select * from all_words_table";

            SqlDataAdapter adap = new SqlDataAdapter(sqlstr, connstr);

            DataSet dset = new DataSet();
            adap.Fill(dset, "all_words_table");
            adap.Dispose();

            //DataTable tbl = dset.Tables[0];      // either indexer is ok
            DataTable tbl = dset.Tables["all_words_table"];

            foreach (DataRow row in tbl.Rows)
                Console.WriteLine(row["ID"].ToString() + " " + row["Spelling"].ToString() + " " + row["Meaning"].ToString() + " " + row["Example"].ToString() + " " + row["TimeCreated"].ToString() + " " + row["TimeUpdated"].ToString());

            MessageBox.Show("Number of records: " + tbl.Rows.Count.ToString());
        }



        private void getData()
        {
            //SqlConnection cs = new SqlConnection("Data Source=KRUSH-DELL\\SQLEXPRESS;Initial Catalog=notes;Integrated Security=True");
            SqlConnection cs = new SqlConnection(connstr);
            cs.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from all_words_table", cs);
            ds = new DataSet();
            ds.Clear();
            cmd.Fill(ds);
            dgView.DataSource = ds.Tables[0];

            SqlDataAdapter cmd1 = new SqlDataAdapter("select * from flash_word_table", cs);
            ds1 = new DataSet();
            ds1.Clear();
            cmd1.Fill(ds1);
            dgView2.DataSource = ds1.Tables[0];


            dgViewUpdate();



            //dgView.DataSource = ds.Tables[0];
        }

        /**********************************************************************
        * Function : VocabManagerForm() (Constructor)
        * 
        * Description : Reads the text file,
        *               Creates an array of words splitting them by delimeters,
        *               Adds the words to the wordList 'words',
        *               Adds them to the ListView items (CompleteView)
        *          
        ***********************************************************************/
        public VocabManagerForm()
        {
            //Initialises when the application loads
            InitializeComponent();
            getData();


            if (VerifyTableExistence1() == "Doesnt exists")
            {
                //if (VerifyTableExistence2() == false) {
                MessageBox.Show("table is just being created ...");
                CreateTable();
             
                //InsertSeedData();
                
               // display_table();
            }
            else if(VerifyTableExistence1() == "Exists")
            {
                MessageBox.Show("table already exists...\n");
                MessageBox.Show("table content: ");
                //display_table();
            }
            
          
            myTimer.Enabled = true;
            myTimer.Interval = 1000;

            myTimer.Tick += delegate(object sender, EventArgs e)
            {
                TimeSpan timeNow = DateTime.Now.TimeOfDay;
                TimeSpan trimmedTimeNow = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
                lblTime.Text = "Time: " + trimmedTimeNow.ToString();
            };

           

        }

       

        /*****************************************************************************************
        * Function : btnSave_Click() (Event)
        * 
        * Description : Checks if all the fields are entered or not (form is not empty)
         *              Checks for existence of word in text file by alerting user with MessageBox,
        *               Alerting user about successful save to text file,
        *               Creates a StreamWriter to write to text file,
        *               Adds them to the ListView items (CompleteView),
        *               Adds new words to the wordList 'words',
        *               Clears the DetailsView so that it can be re-used
        *          
        ******************************************************************************************/

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(connstr);
          var s =   tbSpelling.Text;
          var m = tbMeaning.Text;
          var example = tbSentence.Text;

            //Checks if all the fields are entered or not in DetailsView form
            if (s != null && m != null && example != null)
            {
                foreach (DataGridViewRow row in dgView.Rows)
                    {
                        if (row.Cells["Spelling"].Value != null && row.Cells["Meaning"].Value != null &&
                            row.Cells["Example"].Value != null)
                        {
                            if (row.Cells["Spelling"].Value.ToString().Equals(tbSpelling.Text) )
                            {
                                MessageBox.Show("Item already added");
                                tbSpelling.Clear();
                                tbMeaning.Clear();
                                tbSentence.Clear();
                                return;
                            }
                        }
                    }

                //Message Box alert to confirm user wants to save 
                if (MessageBox.Show("Are you sure to Save", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    != DialogResult.OK)
                {
                    return;
                }
                cs.Open();
                cmd = new SqlCommand("insert into all_words_table values('" + tbSpelling.Text + "' ,'" + tbMeaning.Text + "' ,'" + tbSentence.Text + "', @TimeCreated, @TimeUpdated );", cs);
                cmd.Parameters.AddWithValue("@TimeCreated", DateTime.Now);
                cmd.Parameters.AddWithValue("@TimeUpdated", DateTime.Now);

                //count no of rows inserted
                int o = cmd.ExecuteNonQuery();
                MessageBox.Show(o + " :Record has been inserted successfully !!");
                
                
                //Trimming user input to avoid spaces
                string spelling = tbSpelling.Text.Trim();
                string meaning = tbMeaning.Text.Trim();
                string sentence = tbSentence.Text.Trim();

                //words.Add(new Word(spelling, meaning, sentence));

                SqlDataAdapter adap = new SqlDataAdapter("select * from all_words_table", cs);
                ds = new DataSet();

                adap.Fill(ds);
                dgView.DataSource = ds.Tables[0];
                words1.Add(new Word(spelling, meaning, sentence));

                dgViewUpdate();
                cs.Close();  
               
            }
            else
            {
                //Validates all fields entered by user
                MessageBox.Show("Please enter all the fields");
            }

          
            
        }


        /*****************************************************************************************
         * Function : btnSearch_Click_1() (Event)
         * 
         * Description : Trims user entered word to avoid spaces
         *               Creates new instance of Word class,
         *               Searches the word using Search function in Words class,
         *               Fills up the DetailView if word is found in the list,
         *               Alerts user about word not found with a message
         ******************************************************************************************/

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text.Trim();
            int rowIndex = 1;  //this one is depending on the position of cell or column
            //string first_row_data=dataGridView1.Rows[0].Cells[0].Value.ToString() ;

            dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResulet = true;
                foreach (DataGridViewRow row in dgView.Rows)
                {
                    if (row.Cells[rowIndex].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dgView.Rows[rowIndex].Selected = true;
                        try
                        {
                            //bsource.Position = dgView.SelectedRows.Count > 1 ? dgView.SelectedRows[0].Index : dgView.SelectedCells[0].RowIndex;

                            bsource.DataSource = ds.Tables[0];
                            bsource.Position = dgView.Rows[rowIndex].Index;


                            //DataBindings.Clear();

                            if (tbSpelling.DataBindings.Count == 0)
                            {
                                tbSpelling.DataBindings.Add(new Binding("Text", bsource, "Spelling"));
                                tbMeaning.DataBindings.Add(new Binding("Text", bsource, "Meaning"));
                                tbSentence.DataBindings.Add(new Binding("Text", bsource, "Example"));
                            }
                        }
                        catch (Exception ie)
                        {
                            MessageBox.Show(ie.Message);
                        }
                        //tbSpelling.Text = dgView.Rows[rowIndex].Cells["Spelling"].Value.ToString();
                        //tbMeaning.Text = dgView.Rows[rowIndex].Cells["Meaning"].Value.ToString();
                        //tbSentence.Text = dgView.Rows[rowIndex].Cells["Example"].Value.ToString();
                        //rowIndex++;
                        
                        valueResulet = false;
                    }
                }
                if (valueResulet != false)
                {
                    MessageBox.Show("Record is not avalable for this Name" + tbSearch.Text.Trim(), "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }


        /*****************************************
         * Function : btnExit_Click() (Event)
         * 
         * Description : Closes the application     
        ******************************************/
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*****************************************
         * Function : btnCancel_Click() (Event)
         * 
         * Description : Clears the inputs (DetailsView)     
        ******************************************/
        private void btnCancelFields_Click(object sender, EventArgs e)
        {
            // Clears the inputs (DetailsView)   
            tbSpelling.Clear();
            tbMeaning.Clear();
            tbSentence.Clear();
        }


        /*****************************************************************************************
         * Function : VocabManagerForm_Paint() (Event)
         * 
         * Description : Draw a border of 10px and color : BurlyWood in the form
         ******************************************************************************************/
        private void VocabManagerForm_Paint(object sender, PaintEventArgs e)
        {
            //Border with 10px on each side with color: BurlyWood
            ControlPaint.DrawBorder(
                e.Graphics,
                this.ClientRectangle,
                Color.BurlyWood, 10,
                ButtonBorderStyle.Outset,
                Color.BurlyWood, 10,
                ButtonBorderStyle.Outset,
                Color.BurlyWood, 10,
                ButtonBorderStyle.Outset,
                Color.BurlyWood, 10,
                ButtonBorderStyle.Outset);

        }


        /*****************************************************************************************
         * Function : btnDelete_Click() (Event)
         * 
         * Description : Deletes item from Complete View at selected index
         *               Deletes item from Text file at selected index
         ******************************************************************************************/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(connstr);
           // SqlDataAdapter sds = new SqlDataAdapter();
           
            //Message Box alert to confirm the deletion
            if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                != DialogResult.OK)
            {
                return;
            }

                SqlCommand delcmd = new SqlCommand();
                if (dgView.Rows.Count > 1 && dgView.SelectedRows[0].Index != dgView.Rows.Count - 1)
                {
                    delcmd.CommandText = "DELETE FROM all_words_table WHERE ID=" + dgView.SelectedRows[0].Cells[0].Value + "";
                    cs.Open();
                    delcmd.Connection = cs;
                    delcmd.ExecuteNonQuery();
                    cs.Close();
                    dgView.Rows.RemoveAt(dgView.SelectedRows[0].Index);
                    MessageBox.Show("Record Deleted successfully !!");
                }
                else
                {
                    MessageBox.Show("Please select left most cell in row you want to be deleted !!");
                }
               
            getData();
            
        }

        //Instance "displayRandomWords" from class DisplayRandomWords
        DisplayRandomWords displayRandomWords;



        /*****************************************************************************************
         * Function : button1_Click() (Event)
         * 
         * Description : Registers/Installs an event handler 
         *               Unregisters/Remove an the event handler
         ******************************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            //if the words are empty
            if (displayRandomWords == null)
            {
                //when user clicks the button : Text changes to "Turn Words Off"
                btnShow.Text = "Turn Words Off";

                //Instantiating new displayRandomWords
                displayRandomWords = new DisplayRandomWords();

                //Attaching event handler (Registerting an event)
                displayRandomWords.DisplayWord += new EventHandler<WordEventArgs>(displayRandomWords_DisplayWord);
            }
            else
            {
                //when user clicks the button : Text changes to "Turn Words On"
                btnShow.Text = "Turn Words On";

                //Unregistering the event handler
                displayRandomWords.DisplayWord -= new EventHandler<WordEventArgs>(displayRandomWords_DisplayWord);

                //disposing 
                displayRandomWords.Dispose();

                //making it empty
                displayRandomWords = null;
            }
        }


        /*****************************************************************************************
         * Function : displayRandomWords_DisplayWord() (Event)
         * 
         * Description : Shows new words to user from .dll library every 15 seconds
         ******************************************************************************************/
        void displayRandomWords_DisplayWord(object sender, WordEventArgs e)
        {
            SqlConnection cs = new SqlConnection(connstr);

            string spelling = "Spelling : " + e.Word.Spelling;
            string meaning =  "Meaning : " + e.Word.Meaning;
            string example =  "Example : " + e.Word.Example;

            //builds the string builder
            StringBuilder str = new StringBuilder(); 

            //initializes the string array
            string[] strArr = new string[3]; 
            strArr[0] = spelling;
            strArr[1] = meaning;
            strArr[2] = example;

            //loops through the array
            foreach (string selectedItem in strArr) 
            {
                //appends array items to string builder "str"
                str.AppendLine(selectedItem.ToString()); 

            }

            //Show the user new word every 15 seconds
            var result = MessageBox.Show(str.ToString(), "A New Word for you every 15 seconds!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
               
                
                cs.Open();
                cmd = new SqlCommand("insert into flash_word_table values('" + e.Word.Spelling + "' ,'" + e.Word.Meaning + "' ,'" + e.Word.Example + "');", cs);
                

                //count no of rows inserted
                int o = cmd.ExecuteNonQuery();
                MessageBox.Show(o + " :Record has been inserted successfully !!");

                //words.Add(new Word(spelling, meaning, sentence));

                SqlDataAdapter adap = new SqlDataAdapter("select * from flash_word_table", cs);
                
                ds = new DataSet();

                adap.Fill(ds);
                dgView2.DataSource = ds.Tables[0];
               // words1.Add(new Word(e.Word.Spelling, e.Word.Meaning, e.Word.Example));

                //dgViewUpdate();
                cs.Close();  
               

            }
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void VocabManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notebase3DataSet.notebase3' table. You can move, or remove it, as needed.
            this.notebase3TableAdapter.Fill(this.notebase3DataSet.notebase3);

        }


        //edit button event
        private void button1_Click_1(object sender, EventArgs e)
        {
            var spelling = tbSpelling.Text;
            var meaning = tbMeaning.Text;
            var sentence = tbSentence.Text;

            try
            {
                  //bsource.Position = dgView.SelectedRows.Count > 1 ? dgView.SelectedRows[0].Index : dgView.SelectedCells[0].RowIndex;

                bsource.DataSource = ds.Tables[0];
                bsource.Position = dgView.CurrentRow.Index;


                //DataBindings.Clear();

                if (tbSpelling.DataBindings.Count == 0)
                {
                    tbSpelling.DataBindings.Add(new Binding("Text", bsource, "Spelling"));
                    tbMeaning.DataBindings.Add(new Binding("Text", bsource, "Meaning"));
                    tbSentence.DataBindings.Add(new Binding("Text", bsource, "Example"));
                }
            }
            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        //first button event
        private void button2_Click(object sender, EventArgs e)
        {
            bsource.MoveFirst();
            dgViewUpdate();
            //records();
        }

        private void dgViewUpdate()
        {
           // dgView.ClearSelection();
            //dgView.Rows[bsource.Position].Selected = true;

        }

        private void records()
        {
            //lblDetails.Text = "Records " + bsource.Position + " of " + (bsource.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsource.MovePrevious();
            dgViewUpdate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsource.MoveNext();
            dgViewUpdate();
        }

        private void Last_Click(object sender, EventArgs e)
        {
            bsource.MoveLast();
            dgViewUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sds = new SqlDataAdapter();

            var Spelling = tbSpelling.Text;
            var Meaning = tbMeaning.Text;
            var Sentence = tbSentence.Text;


            SqlConnection cs = new SqlConnection(connstr);
            //cs.Open();

            sds.UpdateCommand = new SqlCommand("UPDATE all_words_table SET TimeUpdated = @TimeUpdated, Spelling =@Spelling, Meaning = @Meaning, Example = @Example WHERE ID = @ID", cs);
            sds.UpdateCommand.Parameters.Add("@Spelling", SqlDbType.VarChar).Value = tbSpelling.Text;
            sds.UpdateCommand.Parameters.Add("@Meaning", SqlDbType.VarChar).Value = tbMeaning.Text;
            sds.UpdateCommand.Parameters.Add("@Example", SqlDbType.VarChar).Value = tbSentence.Text;

            // sds.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ds.Tables[0].Rows[bsource.Position][0];
            //sds.UpdateCommand.Parameters["@ID"].Value = ds.Tables[0].Rows[bsource.Position][0];
            sds.UpdateCommand.Parameters.AddWithValue("@ID", ds.Tables[0].Rows[bsource.Position][0]);

            sds.UpdateCommand.Parameters.AddWithValue("@TimeUpdated", DateTime.Now);
            cs.Open();
            sds.UpdateCommand.ExecuteNonQuery();

            cs.Close();

            getData();
        }



        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(connstr);
            //DataGridViewRow row = this.dgView.Rows[e.RowIndex];
            if (e.RowIndex >= 0) // can be >= 0
            {
                DataGridViewRow row = dgView.Rows[e.RowIndex];
                if (row != null)
                
                    tbSpelling.Text = row.Cells["Spelling"].Value.ToString();
                    tbMeaning.Text = row.Cells["Meaning"].Value.ToString();
                    tbSentence.Text = row.Cells["Example"].Value.ToString();
                
            }
        }

        private void dgView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Flash_table_entry_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(connstr);
            // SqlDataAdapter sds = new SqlDataAdapter();

            //Message Box alert to confirm the deletion
            if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                != DialogResult.OK)
            {
                return;
            }

            SqlCommand delcmd1 = new SqlCommand();
            if (dgView2.Rows.Count > 1 && dgView2.SelectedRows[0].Index != dgView2.Rows.Count - 1)
            {
                delcmd1.CommandText = "DELETE FROM flash_word_table WHERE ID=" + dgView2.SelectedRows[0].Cells[0].Value + "";
                cs.Open();
                delcmd1.Connection = cs;
                delcmd1.ExecuteNonQuery();
                cs.Close();
                dgView2.Rows.RemoveAt(dgView2.SelectedRows[0].Index);
                MessageBox.Show("Record Deleted successfully !!");
            }
            else
            {
                MessageBox.Show("Please select whole row to be deleted!!");
            }

            getData();
        }

       
    } //End Class Vocabform

}// End namespace VocabBuilder
