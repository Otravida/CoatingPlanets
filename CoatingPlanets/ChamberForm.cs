using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CoatingPlanets
{
    public partial class ChamberForm : Form
    {
        public ChamberForm()
        {
            InitializeComponent();
            DataTable criticalTable = CriticalSSRS();
            criticalTable.DefaultView.Sort = "OnHand";
            criticalTable = criticalTable.DefaultView.ToTable();

            DataTable productionTable = ProductionSSRS();

            Console.WriteLine("Test");
        }

        public static DataTable CriticalSSRS()
        {
            string url = "http://hqsql04/ReportServer_SSRSTHO1/Pages/ReportViewer.aspx?%2fInventory%2f" +
                         "Critical+Inventory+on+hand+by+Warehouse&rs:Command=Render" +
                         "&entity=tho" +
                         "&wh=NW" +
                         "&buyer=NovaFin&buyer=NovaCoatFin&buyer=NovaAspheric&buyer=NovaKit&buyer=NovaShop&buyer=NovaCoating&buyer=NovaSinglet" +
                         "&rs:ClearSession=True&rs:Format=XML";

            DataSet criticalSet = new DataSet("criticalSet");
            DataTable criticalTable = new DataTable("criticalTable");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UseDefaultCredentials = true;
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            criticalSet.ReadXml(reader);
            criticalTable = criticalSet.Tables[3];

            return criticalTable;
        }
        public static DataTable ProductionSSRS()
        {
            string url = "http://hqsql04/ReportServer_SSRSTHO1/Pages/ReportViewer.aspx?%2fProduction+Reports%2f" +
                         "Started+Production+Orders&rs:Command=Render" +
                         "&startdate=01/01/2017" +
                         "&enddate=02/01/2017" +
                         "&status=Started" +
                         "&remainstatus=Route+Consumption" +
                         "&buyergroup=NovaCoating&buyergroup=NovaCoatFin" +
                         "&rs:ClearSession=True&rs:Format=XML";

            Console.WriteLine(url);

            DataSet productionSet = new DataSet("productionSet");
            DataTable productionTable = new DataTable("productionTable");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UseDefaultCredentials = true;
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            productionSet.ReadXml(reader);
            productionTable = productionSet.Tables[3];

            return productionTable;
        }
    }
}