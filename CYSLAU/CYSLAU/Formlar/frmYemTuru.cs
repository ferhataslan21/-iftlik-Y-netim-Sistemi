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
    public partial class frmYemTuru : DevExpress.XtraEditors.XtraForm
    {
        YEM_TURU kayitTuru;
       
        public frmYemTuru()
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
            gc.DataSource = CYS.model.YEM_TURU.Select(x => x).ToList();
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
                kayitTuru = new YEM_TURU();
                kayitTuru.YEM_TURU_ACIKLAMA = txtAsiAdi.Text;
                CYS.model.YEM_TURU.Add(kayitTuru);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Türü kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /* Var olan bir kayıt */
                kayitTuru.YEM_TURU_ACIKLAMA = txtAsiAdi.Text;
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Türü kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
            EkraniTemizle();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Seçilen kaydı sil */
            if (kayitTuru == null) return;
            CYS.model.YEM_TURU.Remove(kayitTuru);
            CYS.model.SaveChanges();
            XtraMessageBox.Show("Yem Türü kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            EkraniTemizle();
        }

        private void gvkayitTuru_Click(object sender, EventArgs e)
        {
            kayitTuru = gv.GetFocusedRow() as YEM_TURU;
            if (kayitTuru != null)
            {
                txtAsiAdi.Text = kayitTuru.YEM_TURU_ACIKLAMA;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gc_Click(object sender, EventArgs e)
        {

        }
    }
}