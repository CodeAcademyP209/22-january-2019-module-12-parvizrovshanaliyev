using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karimovun_Eventi
{
    public partial class AddWorker : Form
    {
       // test23Entities db = new test23Entities();
        public AddWorker()
        {
            InitializeComponent();

           // dgvAddWorker.DataSource = db.Workers.ToList();
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //Worker wk = new Worker() {

        //    //    WorkerName = tbxName.Text,
        //    //    WorkerSurname=tbxSurname.Text
                
        //    //};
        //    //db.Workers.Add(wk);
        //    //db.SaveChanges();
        //    //BindingSource dgv = new BindingSource();
        //    //dgv.DataSource = db.Workers.ToList();
        //    //dgvAddWorker.DataSource = dgv;

        //}
    }
}
