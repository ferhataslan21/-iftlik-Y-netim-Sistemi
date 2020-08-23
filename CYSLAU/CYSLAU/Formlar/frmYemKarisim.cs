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
using CYSLAU.DB;
using CYSLAU.Genel;

namespace CYSLAU.Formlar
{
    public partial class frmYemKarisim : DevExpress.XtraEditors.XtraForm
    {
        YEM_KARISIM kayitTuru;
         public frmYemKarisim()
        {
            InitializeComponent();           
            Listele();
        }
        private void EkraniTemizle()
        {
            /* Ekranı Temizlemek için kullanılacak fonksiyon */
            txtAsiAdi.Text = string.Empty;
            kayitTuru = null;   /* Yeni kayıt için kayitTuru nesnesini null yapar */
        }

        private void Listele()
        {
            /* Veritabanından kayıtları okur ve listeler */
            gc.DataSource = CYS.model.YEM_KARISIM.Select(x => x).ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkraniTemizle();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Eğer yeni bir kayıt ise, kayıt işlemi yap
            * var olan bir kayıt ise güncelleme yap */
            if (kayitTuru == null)
            {
                /* Yeni Kayıt */
                kayitTuru = new YEM_KARISIM();
                kayitTuru.ACIKLAMA = txtAsiAdi.Text;
                CYS.model.YEM_KARISIM.Add(kayitTuru);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Karışım kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /* Var olan bir kayıt */
                kayitTuru.ACIKLAMA = txtAsiAdi.Text;
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Karışım kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
            EkraniTemizle();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Seçilen kaydı sil */
            if (kayitTuru == null) return;
            CYS.model.YEM_KARISIM.Remove(kayitTuru);
            CYS.model.SaveChanges();
            XtraMessageBox.Show("Yem Karışım kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            EkraniTemizle();
        }

        private void gvkayitTuru_Click(object sender, EventArgs e)
        {
            kayitTuru = gv.GetFocusedRow() as YEM_KARISIM;
            if (kayitTuru != null)
            {
                txtAsiAdi.Text = kayitTuru.ACIKLAMA;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gc_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kayitTuru = gv.GetFocusedRow() as YEM_KARISIM;
            if (kayitTuru != null)
            {
                frmYemKarisimOran frm = new frmYemKarisimOran(kayitTuru);
                frm.ShowDialog();
            }
        }
    }
}