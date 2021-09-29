using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Fe5dmtak.prn
{
    public partial class Form1 : Form
    {
        Fe5dmtak.prn.WebsiteDatabaseProjectDataSet.RequestsRow curentrow;
        WebsiteDatabaseProjectEntities _context = new WebsiteDatabaseProjectEntities();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void requestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.websiteDatabaseProjectDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websiteDatabaseProjectDataSet.Requests' table. You can move, or remove it, as needed.
            this.requestsTableAdapter.Fill(this.websiteDatabaseProjectDataSet.Requests);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.websiteDatabaseProjectDataSet.Requests.Clear();

            this.requestsTableAdapter.FillByPrint(this.websiteDatabaseProjectDataSet.Requests);
            foreach (Fe5dmtak.prn.WebsiteDatabaseProjectDataSet.RequestsRow r in this.websiteDatabaseProjectDataSet.Requests)
            {
                r.Printed_or_not = true;
                curentrow = r;
                //code elprinter hna search for it
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PrintPage;
                //printPreviewControl1.Document = pd;
                //printPreviewDialog1.Document = pd;
                pd.PrinterSettings.Copies = short.Parse(r.No_of_copies.ToString());

                pd.Print();
            }
            this.requestsTableAdapter.Update(this.websiteDatabaseProjectDataSet.Requests);

            timer1.Enabled = true;
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            int reqID = curentrow.Request_ID;
            Request req = _context.Requests.Find(reqID);

            StringBuilder sb = new StringBuilder();

            ////////////////////////////////////////////////////

            if (req.Msl7a_ID == 1 && req.Mostanad_ID == 1)
            {
                sb.AppendLine("مصلحه الاحوال المدنيه");
                sb.AppendLine("");
                sb.AppendLine("شهاده ميلاد");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");

            }
            //if (req.Msl7a_ID == 1 && req.Mostanad_ID == 2)
            //{
            //    sb.AppendLine("مصلحه الاحوال المدنيه");
            //    sb.AppendLine("");
            //    sb.AppendLine("شهاده ميلاد");
            //}
            //if (req.Msl7a_ID == 2 && req.Mostanad_ID == 3)
            //{
            //    sb.AppendLine("مصلحه الاحوال المدنيه");
            //    sb.AppendLine("");
            //    sb.AppendLine("شهاده ميلاد");
            //}
            //if (req.Msl7a_ID == 2 && req.Mostanad_ID == 4)
            //{
            //    sb.AppendLine("مصلحه الاحوال المدنيه");
            //    sb.AppendLine("");
            //    sb.AppendLine("شهاده ميلاد");
            //}
            else
            {

            };

            ///////////////////////////////////////////////////////

            sb.AppendLine(req.Citizen.Citizen_Name.ToString() + " : اسم المواطن");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen_ID.ToString() + " : الرقم القومي");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen.Mother_Name.ToString() + " : اسم الام");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen.Relegion.ToString() + " : الديانه");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen.Nationality.ToString() + " : الجنسيه");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen.BirthDate.ToShortDateString() + " : تاريخ الميلاد");
            sb.AppendLine("");
            sb.AppendLine(req.Citizen.M7l_elmelad.ToString() + " : محل الميلاد");



            e.Graphics.DrawString(sb.ToString(),

                                        new System.Drawing.Font("Arial", 18),
                                        Brushes.Black,
                                        460,
                                        80,

                                        new StringFormat());
        }

    }
}
