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
using CYSLAU.Formlar.Hayvan;

namespace CYSLAU.Formlar
{
    public partial class frmHayvanKayitTur : DevExpress.XtraEditors.XtraForm
    {
        HAYVAN_KAYIT_TURU kayitTuru;
        object caller;
        public frmHayvanKayitTur(object caller=null)
        {
            InitializeComponent();
            this.caller = caller;
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
            gc.DataSource= CYS.model.HAYVAN_KAYIT_TURU.Select(x => x).ToList();
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
                kayitTuru = new HAYVAN_KAYIT_TURU();
                kayitTuru.KAYIT_TURU_ADU = txtAsiAdi.Text;
                CYS.model.HAYVAN_KAYIT_TURU.Add(kayitTuru);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Kayıt türü kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /* Var olan bir kayıt */
                kayitTuru.KAYIT_TURU_ADU = txtAsiAdi.Text;
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Kayıt türü kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Guncelle();
            Listele();
            EkraniTemizle();
          
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Seçilen kaydı sil */
            if (kayitTuru == null) return;
            CYS.model.HAYVAN_KAYIT_TURU.Remove(kayitTuru);
            CYS.model.SaveChanges();
            XtraMessageBox.Show("Kayıt türü kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Guncelle();
            Listele();
            EkraniTemizle();
        }

        private void gvkayitTuru_Click(object sender, EventArgs e)
        {
            kayitTuru = gv.GetFocusedRow() as HAYVAN_KAYIT_TURU;
            if (kayitTuru != null)
            {
                txtAsiAdi.Text = kayitTuru.KAYIT_TURU_ADU;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void Guncelle()
        {
            /* Diğer formları güncellemek için kullanılır */
            if (caller == null) return;

            frmHayvan frm = caller as frmHayvan;
            if (frm != null) frm.HayvanKayitTurleriniGetir();
        }
    }
}