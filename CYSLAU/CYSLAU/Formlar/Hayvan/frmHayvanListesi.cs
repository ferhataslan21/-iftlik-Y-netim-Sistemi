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
using CYSLAU.Formlar.Veteriner;

namespace CYSLAU.Formlar.Hayvan
{
    public partial class frmHayvanListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmHayvanListesi()
        {
            InitializeComponent();
            HayvanlariGetir();
        }

        public void HayvanlariGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.HAYVAN.Select(x => x).ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHayvan frm = new frmHayvan(null, this);
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHayvan frm = new frmHayvan(gridView1.GetFocusedRow() as DB.HAYVAN, this);
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Hayvan kartını silmek istediğinizden emin misiniz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    HAYVAN hayvan = gridView1.GetFocusedRow() as HAYVAN;
                    CYS.model.HAYVAN.Remove(hayvan);
                    XtraMessageBox.Show("Hayvan kartı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HayvanlariGetir();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HAYVAN hayvan = gridView1.GetFocusedRow() as HAYVAN;
            if (hayvan == null) return;

            if (hayvan.CINSIYETI.Value==0)
            {
                XtraMessageBox.Show("Sağım işlemi için Dişi hayvan seçilmelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSutSagim frm = new frmSutSagim(hayvan);
            frm.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName=="CINSIYETI")
            {
                if (e.CellValue != null)
                {
                    if (e.CellValue.ToString() == "0") e.DisplayText = "ERKEK";
                    else e.DisplayText = "DİŞİ";
                }
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HAYVAN hayvan = gridView1.GetFocusedRow() as HAYVAN;
            if (hayvan == null) return;


            frmHayvanYem frm = new frmHayvanYem();
            frm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HAYVAN hayvan = gridView1.GetFocusedRow() as HAYVAN;
            if (hayvan == null) return;

            frmMuayene frm = new frmMuayene(null, hayvan);
            frm.ShowDialog();
        }
    }
}