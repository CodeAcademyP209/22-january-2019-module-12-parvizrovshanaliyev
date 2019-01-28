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
    public partial class EventRoomReserve : Form
    {
        public EventRoomReserve()
        {
            InitializeComponent();
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            var query = "select * from Workers where WorkerId =(select WorkerId from Logs where LogStatus=1)";
            var adapter = new SqlDataAdapter(query, connection);
            DataSet dsLogs = new DataSet();
            adapter.Fill(dsLogs);
            lblNmSrnm.Text = dsLogs.Tables[0].Rows[0]["WorkerName"].ToString() + " " + dsLogs.Tables[0].Rows[0]["WorkerSurname"].ToString();
            //int loggedInId = Convert.ToInt32(dsLogs.Tables[0].Rows[0]["WorkerId"]);
            WorkerID.Text = dsLogs.Tables[0].Rows[0]["WorkerId"].ToString();
            WorkerID.Visible = true;
            var command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            #region Room Reserve event  FORMUNDA ICLASLAR OLAN DATAGRIDVIEW
            var ControlpanelQuery = "select MeetingId, Meetings.MeetingInfo, Meetings.MeetingStartTime, Meetings.MeetingEndTime, Workers.WorkerName, Workers.WorkerSurname from Meetings join Workers on Meetings.MeetingOrganiserId=Workers.WorkerId";
            var adapterctrl = new SqlDataAdapter(ControlpanelQuery, connection);
            DataSet ctrl = new DataSet();
            adapterctrl.Fill(ctrl);
            dgvReserveRoom.DataSource = ctrl.Tables[0];
            #endregion
            connection.Close();
        }



        private void btnAddEventToBase_Click(object sender, EventArgs e)
        {

            var eventInfo = tbxEventInfo.Text;
            var date = dtpDate.Value.ToShortDateString();
            var startTime = dtpStart.Value.ToShortTimeString();
            var endTime = dtpEnd.Value.ToShortTimeString();

            MessageBox.Show(startTime.ToString());
            //  MessageBox.Show(dtpDate.Value.ToShortDateString());

            var adapter = new SqlDataAdapter("select * from Meetings", new SqlConnection(Properties.Settings.Default.constr));
            DataSet dsMeetings = new DataSet();
            adapter.Fill(dsMeetings);

            foreach (DataRow item in dsMeetings.Tables[0].Rows)
            {
                DataList.meetings.Add(new Meetings()
                {
                    MeetingId = Convert.ToInt32(item["MeetingId"]),
                    MeetingInfo = item["MeetingInfo"].ToString(),
                    MeetingDate = Convert.ToDateTime(item["Meetingdate"]),
                    MeetingStartTime = Convert.ToDateTime(item["MeetingStartTime"].ToString()),
                    MeetingEndTime = Convert.ToDateTime(item["MeetingEndTime"].ToString()),
                    MeetingOrganiserId = Convert.ToInt32(item["MeetingOrganiserId"])
                });
            }


            int workerId = Convert.ToInt32(WorkerID.Text);
            var connection = new SqlConnection(Properties.Settings.Default.constr);
            connection.Open();
            var command = new SqlCommand($"insert into Meetings(MeetingInfo,MeetingDate,MeetingStartTime,MeetingEndTime,MeetingOrganiserId)" +
                $" values('{eventInfo}',Convert(date,'{date}',101), CONVERT(time,'{startTime}',108),CONVERT(time,'{endTime}',108), {workerId})", connection);
            command.ExecuteNonQuery();
            connection.Close();







        }
    }
}
