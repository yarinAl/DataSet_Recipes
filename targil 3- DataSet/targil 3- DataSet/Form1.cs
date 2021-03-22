using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace targil_3__DataSet
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=DESKTOP-MTGVG7I\SQLEXPRESS;Initial Catalog=DBRecipes;Integrated Security=True";
        string type = "";
        SqlConnection con;
        DataSet dsRecipes;
        DataTable dtRecipes;
        SqlDataAdapter adptr;


        public Form1()
        {
            InitializeComponent();
        }

        private void RecipeType()
        {
            if (rbRegular.Checked) { type = rbRegular.Text; }
            if (rbMeat.Checked) { type = rbMeat.Text; }
            if (rbVegetarian.Checked) { type = rbVegetarian.Text; }
            if (rbVegan.Checked) { type = rbVegan.Text; }
        }
        private bool EmptyFields()
        {
            if (txtName.Text != "" && txtTime.Text != "" && cbCategory.Text != "" && (rbRegular.Checked || rbMeat.Checked || rbVegetarian.Checked || rbVegan.Checked))
                return true;
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            dsRecipes = new DataSet();
            showRecipes();
        }

        private void showRecipes()
        {
         
            adptr = new SqlDataAdapter("exec selection", con);
            dsRecipes.Clear();
            adptr.Fill(dsRecipes, "recipes");
            dtRecipes = dsRecipes.Tables["recipes"];
            dgvRecipes.DataSource = dtRecipes;
        }

      
        private void chooseAction(string choice)
        {
            switch (choice)
            {
                //הכנסה
                case "insert":
                    if (EmptyFields())
                    {
                        RecipeType();
                        SqlCommand com1 = new SqlCommand("Insertion", con);
                        com1.CommandType = CommandType.StoredProcedure;
                        SqlParameter par;
                        string[] strings = new string[] { "@Recipe_Name", "@Recipe_Time", "@Recipe_Type", "@Recipe_Category" };
                        foreach (string str in strings)
                        {
                            par = new SqlParameter();
                            par.ParameterName = str;
                            par.SqlDbType = SqlDbType.NVarChar;                        
                            if (str == "@Recipe_Name") { par.Value = txtName.Text; }
                            else if (str == "@Recipe_Time") { par.Value = txtTime.Text; }
                            else if (str == "@Recipe_Type") { par.Value = type; }
                            else { par.Value = cbCategory.Text; }
                            com1.Parameters.Add(par);
                        }
                        con.Open();
                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: fill all missing parts");
                    }
                    showRecipes();
                    break;

                    //עדכון
                case "update":
                    if (EmptyFields())
                    {
                        RecipeType();
                        SqlCommand com2 = new SqlCommand("RecipeUpdate", con);
                        com2.CommandType = CommandType.StoredProcedure;
                        SqlParameter par2;
                        string[] strings = new string[] { "@Recipe_Id" ,"@Recipe_Name", "@Recipe_Time", "@Recipe_Type", "@Recipe_Category" };
                        foreach (string str in strings)
                        {
                            par2 = new SqlParameter();
                            par2.ParameterName = str;
                            par2.SqlDbType = SqlDbType.NVarChar;
                            if (str == "@Recipe_Id") { par2.Value = txtID.Text; }
                            else if (str == "@Recipe_Name") { par2.Value = txtName.Text; }
                            else if (str == "@Recipe_Time") { par2.Value = txtTime.Text; }
                            else if (str == "@Recipe_Type") { par2.Value = type; }
                            else { par2.Value = cbCategory.Text; }
                            com2.Parameters.Add(par2);
                        }
                        con.Open();
                        com2.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: fill all missing parts");
                    }
                    showRecipes();
                    break;
                //מחיקה
                case "delete":
                    SqlCommand com3 = new SqlCommand("RecipeDelete", con);
                    com3.CommandType = CommandType.StoredProcedure;
                    SqlParameter par3 = new SqlParameter();
                    par3.ParameterName = "@Recipe_Id";
                    par3.Value = int.Parse(txtID.Text);
                    com3.Parameters.Add(par3);
                    con.Open();
                    com3.ExecuteNonQuery();
                    con.Close();
                    showRecipes();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            chooseAction("insert");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            chooseAction("update");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            chooseAction("delete");
        }
        private void UpdateDB()
        {
            new SqlCommandBuilder(adptr);
            adptr.Update(dtRecipes);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateDB();
            showRecipes();
        }

        private void ChooseRecipe_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Selectline", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par.ParameterName = "@Recipe_Id";
            par.SqlDbType = SqlDbType.Int;
            par.Value = txtID.Text;
            com.Parameters.Add(par);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show((string)dr["Recipe_Name"] +"--"+ (string)dr["Recipe_Time"] + "--" + (string)dr["Recipe_Type"] + "--" + (string)dr["Recipe_Category"]);
            }
            con.Close();
        }
    }
}
