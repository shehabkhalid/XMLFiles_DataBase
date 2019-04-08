using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FlieProjectFinal
{
    public partial class Create_table : Form
    {
        private void Update_combo(ComboBox x)
        {
            x.Items.Clear();
            foreach (var col in Linker.Rule)
            {
                x.Items.Add(col.Key);
            }

        }
        
        private bool IsCellEmpty(int r , int c)
        {
            return (string.IsNullOrEmpty(table.Rows[r].Cells[c].Value as string));
        }
        private void Update_Grid()
        {
            
            foreach (var col in Linker.Rule)
            {
                if(!table.Columns.Contains(col.Key))
                    table.Columns.Add(col.Key, col.Key);
            }

            NumOfCol.Text = NumOfCol.Text.Split(':')[0] + ": " + table.ColumnCount.ToString();
            NumOfRows.Text = NumOfRows.Text.Split(':')[0] + ": " + table.Rows.Count.ToString();

            
        }

        public bool Priamry(string a)
        {
           

            HashSet<string> checker = new HashSet<string>();
            bool done = false;
            foreach (DataGridViewColumn col in table.Columns)
            {

             
                if (Linker.Rule[col.Name.ToString()] ==a )
                {
                
                    bool stop = false;
                    foreach (DataGridViewRow row in table.Rows)
                    {

                        if (string.IsNullOrEmpty(row.Cells[col.Index].Value as string))
                        {
                            MessageBox.Show("please make sure that cell " + row.Cells[col.Index].RowIndex + " in " + col.Name + " is not Empty");
                            stop = true;
                            break;
                        }
                        checker.Add(row.Cells[col.Index].Value.ToString());
                    }
                    if (stop)
                    {
                        done = false;
                        break;
                        
                    }

                    if (checker.Count == table.Rows.Count)
                    {
                        done = true;
                    }
                    else
                    {
                        
                        done = false;
                    }

                }
            }
                

            return done;
        }
        public bool NoEmpty()
        {
            bool noempty = true;
            foreach (DataGridViewRow row in table.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(string.IsNullOrEmpty(cell.Value as string)||cell.Value.ToString()==""||cell.Value==null)
                    {
                        MessageBox.Show("Please make sure every row does't have any empty cell");
                        noempty = false;
                        break;
                    }
                    if (!noempty)
                        break;
                }
            }
            return noempty;
        }
        public Create_table()
        {
            InitializeComponent();
            constraints.SelectedIndex = 2;
        }

        private void NumOfCol_Click(object sender, EventArgs e)
        {

           

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (colname.Text == "")
            {
                MessageBox.Show("Please Add a Column Name");
            }
            else
            {
               
               

                    if (Linker.Rule.ContainsKey(colname.Text))
                    {
                        MessageBox.Show("This column is already added");
                    }
                    else
                    {
                        Linker.Rule.Add(colname.Text, constraints.SelectedItem.ToString());
                    
                    }

                

                constraints.Visible = true;
                constraints.SelectedIndex = 2;
                colname.Text = "";
                Update_combo(deletecombo);
                Update_Grid();
                Update_combo(primaryselect);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Linker.Rule.Count != 0)
            {
                if (!Linker.Rule.ContainsValue("Primary Key"))
                {
                    MessageBox.Show("Please select a primary key");
                }
                else if (Priamry("Primary Key"))
                {
                   
                    if (NoEmpty())
                    {

                        DataTable dt = new DataTable("Member");
                        DataSet dataSet = new DataSet("Team");
                        FileStream xmlf = new FileStream("myXml.xml", FileMode.Create);
                        foreach (DataGridViewColumn col in table.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }
                        foreach (DataGridViewRow row in table.Rows)
                        {

                            DataRow drow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                drow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(drow);

                        }
                        dataSet.Tables.Add(dt);
                        dataSet.WriteXml(xmlf, XmlWriteMode.IgnoreSchema);
                        xmlf.Close();
                        MessageBox.Show("Saved");
                    }
                   
                }
                else
                    MessageBox.Show("A7A");
              
            }
            else
                MessageBox.Show("Add columns First");

        }

        private void isPrimary_CheckedChanged(object sender, EventArgs e)
        {
            constraints.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Row_Click(object sender, EventArgs e)
        {

            if (table.Columns.Count != 0)
            {
                
                table.Rows.Add();
            }
            else
                MessageBox.Show("Add Cloumns First");

            Update_Grid();
            
        }

      

        private void del_button_Click(object sender, EventArgs e)
        {
            if(deletecombo.Text=="")
            {
                MessageBox.Show("Please select a column to delete");
            }
            else if(!Linker.Rule.ContainsKey(deletecombo.Text))
            {
                MessageBox.Show("Not Found Enter Valid Column or select");
                deletecombo.Text = "";
            }
            else
            {
                DialogResult R = MessageBox.Show("Are you sure ?","Waring", MessageBoxButtons.YesNo);

                if(R==DialogResult.Yes)
                {


                    table.Columns.Remove(deletecombo.SelectedItem.ToString());
                    Linker.Rule.Remove(deletecombo.SelectedItem.ToString());
                    Update_combo(deletecombo);
                    deletecombo.Text = "";
                    Update_Grid();
                    Update_combo(primaryselect);
                }
            }
        }

        
     
       

        private void button2_Click(object sender, EventArgs e)
        {
            HashSet<string> checker = new HashSet<string>();
            foreach (DataGridViewColumn col in table.Columns)
            {
                
                if(col.Name.ToString()==primaryselect.SelectedItem.ToString())
                {
                    bool stop = false;
                    foreach (DataGridViewRow row in table.Rows)
                    {
                      
                        if(string.IsNullOrEmpty (row.Cells[col.Index].Value as string))
                        {
                            MessageBox.Show("please make sure that cell " + row.Cells[col.Index].RowIndex + " in " + col.Name + " is not Empty");
                            stop = true;
                            break;
                        }
                        checker.Add(row.Cells[col.Index].Value.ToString());
                    }
                    if (stop)
                        break;
                    
                    if(checker.Count==table.Rows.Count)
                    {
                        Linker.Rule[col.Name.ToString()] = "Primary Key";
                    }
                    else
                    {
                        MessageBox.Show("Please make sure that this column values are uniqe");
                    }

                    break;
                }
            }
          
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
            //Primary key;
            #region
            if (Linker.Rule[table.Columns[e.ColumnIndex].Name]=="Primary Key")
            {

                    HashSet<string> checker = new HashSet<string>();
                foreach (DataGridViewRow row in table.Rows)
                {
                    if (IsCellEmpty(e.RowIndex, e.ColumnIndex)|| row.Cells[e.ColumnIndex].Value == null)
                    { MessageBox.Show("please make sure that cell " + row.Cells[e.ColumnIndex].RowIndex + " is not Empty"); break; }

                    
                   
                    if (checker.Count != 0 && checker.Contains(row.Cells[e.ColumnIndex].Value.ToString()))
                    {
                        MessageBox.Show("Please make sure that cell"+ row.Cells[e.ColumnIndex].RowIndex  + "value is uniqe");
                       
                    }
                    else
                    {
                       
                        checker.Add(row.Cells[e.ColumnIndex].Value.ToString());
                    }


                }
                
            }
            #endregion


            else if(Linker.Rule[table.Columns[e.ColumnIndex].Name] == "Gender")
            {
               
                if (IsCellEmpty(e.RowIndex, e.ColumnIndex))
                    MessageBox.Show("please make sure that cell " + table.Rows[e.RowIndex].Cells[e.ColumnIndex].RowIndex + " is not Empty");
                else if (table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "Male" && table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "Female")
                {
                    MessageBox.Show("please make sure that this cell is Male or Female");
                    table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                }
                      



            }
        }
    }
}
