using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using CYSLAU.Genel;
using System.Linq;

namespace CYSLAU.Raporlar
{
    public partial class rptMuayeneListesi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptMuayeneListesi()
        {
            InitializeComponent();
            bindingSource1.DataSource = CYS.model.SAGLIK.Select(x => x).ToList();
        }

    }
}
