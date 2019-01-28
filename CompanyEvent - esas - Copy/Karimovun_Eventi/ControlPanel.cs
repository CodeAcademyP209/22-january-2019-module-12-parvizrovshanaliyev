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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            #region LOG IN WORKER NAME SURNAME
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            var query = "select * from Workers where WorkerId =(select WorkerId from Logs where LogStatus=1)";
            var adapter = new SqlDataAdapter(query, connection);
            DataSet dsLogs = new DataSet();
            adapter.Fill(dsLogs);
            lblNameSurname.Text = dsLogs.Tables[0].Rows[0]["WorkerName"].ToString() + " " + dsLogs.Tables[0].Rows[0]["WorkerSurname"].ToString();
            var command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            #endregion
            #region CONTROL PANEL FORMUNDA ICLASLAR OLAN DATAGRIDVIEW
            var ControlpanelQuery = "select  Meetings.MeetingInfo, Meetings.MeetingStartTime, Meetings.MeetingEndTime, Workers.WorkerName, Workers.WorkerSurname from Meetings join Workers on Meetings.MeetingOrganiserId=Workers.WorkerId";
            var adapterctrl = new SqlDataAdapter(ControlpanelQuery, connection);
            DataSet ctrl = new DataSet();
            adapterctrl.Fill(ctrl);
            dgvControlPanel.DataSource = ctrl.Tables[0];
            #endregion
            connection.Close();

        }



        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            var addWorkerPanel_Open = new AddWorker();
            addWorkerPanel_Open.Show();
        }

        private void btnAddWorkerPanel_Click(object sender, EventArgs e)
        {
            var eventPanel_Open = new EventRoomReserve();
            eventPanel_Open.Show();
        }

        #region LOG OUT BUTTON 
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            // var query = "Select * from Workers where WorkerId =(select WorkerId from Logs where LogStatus=1)";
            var UpLogOut = "Update Logs set Log_OUT=GETDATE() where LogStatus=1";
            var command = new SqlCommand(UpLogOut, connection);
            command.ExecuteNonQuery();
            var UpStatus = "Update Logs set LogStatus=0 where LogStatus=1";
            var commandTwo = new SqlCommand(UpStatus, connection);
            commandTwo.ExecuteNonQuery();
            // new SqlCommand("Update Logs set Log_OUT=GETDATE() where LogStatus=1", connection).ExecuteNonQuery();
            //  new SqlCommand("Update Logs set LogStatus=0 where LogStatus=1", connection).ExecuteNonQuery();

            this.Hide();
            connection.Close();
        }
        #endregion ///// LOG OUT  ///// LOG OUT



        #region FORMUN CLOSE EVENTI
        private void ControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            // var query = "Select * from Workers where WorkerId =(select WorkerId from Logs where LogStatus=1)";
            var UpLogOut = "Update Logs set Log_OUT=GETDATE() where LogStatus=1";
            var command = new SqlCommand(UpLogOut, connection);
            command.ExecuteNonQuery();
            var UpStatus = "Update Logs set LogStatus=0 where LogStatus=1";
            var commandTwo = new SqlCommand(UpStatus, connection);
            commandTwo.ExecuteNonQuery();
            // new SqlCommand("Update Logs set Log_OUT=GETDATE() where LogStatus=1", connection).ExecuteNonQuery();
            //  new SqlCommand("Update Logs set LogStatus=0 where LogStatus=1", connection).ExecuteNonQuery();

            this.Hide();
            connection.Close();
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            var ControlpanelQuery = "select Meetings.Meetingid, Meetings.MeetingInfo, Meetings.MeetingStartTime, Meetings.MeetingEndTime, Workers.WorkerName, Workers.WorkerSurname from Meetings join Workers on Meetings.MeetingOrganiserId=Workers.WorkerId";
            var adapterctrl = new SqlDataAdapter(ControlpanelQuery, connection);
            DataSet ctrl = new DataSet();
            adapterctrl.Fill(ctrl);
            var upsource = new BindingSource();
            upsource.DataSource = ctrl.Tables[0];
            dgvControlPanel.DataSource = upsource;
            connection.Close();
        }
    }
}
