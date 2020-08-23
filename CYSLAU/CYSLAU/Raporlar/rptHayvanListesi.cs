using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using CYSLAU.Genel;
using System.Linq;

namespace CYSLAU.Raporlar
{
    public partial class rptHayvanListesi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHayvanListesi()
        {
            InitializeComponent();
            bindingSource1.DataSource = CYS.model.HAYVAN.Select(x => x).ToList();
        }

    }
}
