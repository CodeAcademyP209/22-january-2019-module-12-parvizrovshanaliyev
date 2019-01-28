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

namespace Karimovun_Eventi
{
    public partial class EventHall : Form
    {
        public EventHall()
        {
            InitializeComponent();
        }

       

        private void btnLog_Click(object sender, EventArgs e)
        {


            var email = tbxEmailLog.Text;
            var pass = tbxPassLog.Text;

            var adapter = new SqlDataAdapter("select * from Workers", new SqlConnection(Properties.Settings.Default.constr));
            DataSet tableWorkers = new DataSet();
            adapter.Fill(tableWorkers);

            foreach (DataRow item in tableWorkers.Tables[0].Rows)
            {
                // MessageBox.Show(item["WorkerSurname"].ToString());
                DataList.workers.Add(new Workers()
                {

                    WorkerId = Convert.ToInt32(item["WorkerId"]),
                    WorkerName = item["WorkerName"].ToString(),
                    WorkerSurname = item["WorkerSurname"].ToString(),
                    WorkerEmail = item["WorkerEmail"].ToString(),
                    WorkerPassword = item["WorkerPassWord"].ToString()



                });

            }

            if (DataList.workers.Any(worker => worker.WorkerEmail == email))
            {

                var workerId = DataList.workers.Where(worker => worker.WorkerEmail == email && worker.WorkerPassword == pass).First().WorkerId;
                var connection = new SqlConnection(Properties.Settings.Default.constr);
                connection.Open();
                var command = new SqlCommand($"insert into Logs(WorkerId,LogStatus,Log_IN) values({workerId},1,GETDATE())", connection);
                command.ExecuteNonQuery();
                var controlPanel_Open = new ControlPanel();
                controlPanel_Open.Show();
                connection.Close();
                //MessageBox.Show(DataList.workers.Any(worker=>worker.WorkerEmail == email).ToString());

            };

        }

        
    }
}
