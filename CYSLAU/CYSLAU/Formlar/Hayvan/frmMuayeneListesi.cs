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
using CYSLAU.Formlar.Veteriner;
using CYSLAU.DB;
using CYSLAU.Genel;

namespace CYSLAU.Formlar.Hayvan
{
    public partial class frmMuayeneListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmMuayeneListesi()
        {
            InitializeComponent();
            MuayeneGetir();
        }

        private void MuayeneGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.SAGLIK.Select(x => x).ToList();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuayene frm = new frmMuayene(null, null, null, this);
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAGLIK muayene = gridView1.GetFocusedRow() as SAGLIK;
            frmMuayene frm = new frmMuayene(null, null, muayene, this);
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAGLIK muayene = gridView1.GetFocusedRow() as SAGLIK;
            if (muayene == null) return;

            frmMuayeneIlac frm = new frmMuayeneIlac(muayene);
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAGLIK muayene = gridView1.GetFocusedRow() as SAGLIK;
            if (muayene == null) return;

            frmMuayeneAsi frm = new frmMuayeneAsi(muayene);
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SAGLIK muayene = gridView1.GetFocusedRow() as SAGLIK;
            if (muayene == null) return;

            if (XtraMessageBox.Show("Muayene kaydını silmek istediğinizden emin misiniz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CYS.model.SAGLIK.Remove(muayene);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MuayeneGetir();
            }
        }
    }
}