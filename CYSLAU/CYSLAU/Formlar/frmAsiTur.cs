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
    public partial class frmAsiTur : DevExpress.XtraEditors.XtraForm
    {
        ASI_TURU asiTuru;
      
        public frmAsiTur()
        {
            InitializeComponent();
           
            Listele();
        }
        private void EkraniTemizle()
        {
            /* Ekranı Temizlemek için kullanılacak fonksiyon */
            txtAsiAdi.Text = string.Empty;
            asiTuru = null;   /* Yeni kayıt için asiTuru nesnesini null yapar */
        }

        private void Listele()
        {
            /* Veritabanından kayıtları okur ve listeler */
            gcAsiTuru.DataSource= CYS.model.ASI_TURU.Select(x => x).ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkraniTemizle();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Eğer yeni bir kayıt ise, kayıt işlemi yap
            * var olan bir kayıt ise güncelleme yap */
            if (asiTuru == null)
            {
                /* Yeni Kayıt */
                asiTuru = new ASI_TURU();
                asiTuru.ASI_ADI = txtAsiAdi.Text;
                CYS.model.ASI_TURU.Add(asiTuru);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Aşı türü kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /* Var olan bir kayıt */
                asiTuru.ASI_ADI = txtAsiAdi.Text;
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Aşı türü kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
            EkraniTemizle();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Seçilen kaydı sil */
            if (asiTuru == null) return;
            CYS.model.ASI_TURU.Remove(asiTuru);
            CYS.model.SaveChanges();
            XtraMessageBox.Show("Aşı türü kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            EkraniTemizle();
        }

        private void gvAsiTuru_Click(object sender, EventArgs e)
        {
            asiTuru = gvAsiTuru.GetFocusedRow() as ASI_TURU;
            if (asiTuru != null)
            {
                txtAsiAdi.Text = asiTuru.ASI_ADI;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}