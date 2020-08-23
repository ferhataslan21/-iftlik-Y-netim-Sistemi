using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CYSLAU.Genel;
using CYSLAU.DB;

namespace CYSLAU.Formlar.Veteriner
{
    public partial class frmVeterinerList : DevExpress.XtraEditors.XtraForm
    {
        public frmVeterinerList()
        {
            InitializeComponent();
            VeterinerleriGetir();
        }

        public void VeterinerleriGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.VETERINER.Select(x => x).ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVeteriner frm = new frmVeteriner(null, this);
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVeteriner frm = new frmVeteriner(gridView1.GetFocusedRow() as VETERINER, this);
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VETERINER veteriner = gridView1.GetFocusedRow() as VETERINER;
            if (veteriner == null) return;

            try
            {
                if (XtraMessageBox.Show("Veteriner kaydı silinsin mi?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    CYS.model.VETERINER.Remove(veteriner);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Veteriner kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VeterinerleriGetir();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VETERINER veteriner = gridView1.GetFocusedRow() as VETERINER;
            if (veteriner == null) return;

            frmMuayene frm = new frmMuayene(veteriner);
            frm.ShowDialog();
        }
    }
}