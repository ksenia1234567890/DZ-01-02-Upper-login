﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DZ_01_02_Upper_login
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void entrance_Click(object sender, EventArgs e)
        {
            try
            {
                
                NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=users");
                string query = "select login from users where login=@login and password=@password";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login", Tlogin.Text);
                cmd.Parameters.AddWithValue("@password", Tpassword.Text);
                con.Open();
                string check = (string)cmd.ExecuteScalar();
                con.Close();
                if (check == Tlogin.Text)
                {
                    Llogin.Text = check;
                    Login.textLogin = check;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_Click(object sender, EventArgs e)
        {
            NewForm nf = new NewForm();
            nf.ShowDialog();
        }
    }
}
