using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1
{
    public partial class northwind_datagrid : Form
    {
        public northwind_datagrid()
        {
            InitializeComponent();
        }

        ShipperDAL shipper = new ShipperDAL();

        private void get_all_shippers_btn_Click(object sender, EventArgs e)
        {            
            dataGridView1.DataSource =  shipper.Get_shippers_kayitlar();
        }
    }
}
