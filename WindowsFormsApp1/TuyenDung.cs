﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class TuyenDung : UserControl
    {
        public TuyenDung()
        {
            InitializeComponent();
        }

        private void TuyenDung_Load(object sender, EventArgs e)
        {
            DataConnection dc = new DataConnection();
            SqlConnection connect = dc.getConnect();
            connect.Open();

            string sql = "select * from BangKeHoachTuyenDung";


            SqlDataAdapter sqlad = new SqlDataAdapter(sql, connect);

            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
