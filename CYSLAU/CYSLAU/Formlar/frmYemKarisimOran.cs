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
    public partial class frmYemKarisimOran : DevExpress.XtraEditors.XtraForm
    {
        YEM_KARISIM_YEM_TURU kayitTuru;     
        YEM_KARISIM karisim;
        public frmYemKarisimOran(YEM_KARISIM karisim=null)
        {
            InitializeComponent();          
            YemTurleriniGetir();
            this.karisim = karisim;
            txtKarisimAdi.Text = karisim.ACIKLAMA;
            Listele();
        }
        private void EkraniTemizle()
        {
            /* Ekranı Temizlemek için kullanılacak fonksiyon */
            txtKarisimAdi.Text = karisim.ACIKLAMA;
            seOran.Value = 0;
            cmbYemTuru.ReadOnly = false;
            cmbYemTuru.EditValue = null;
            kayitTuru = null;   /* Yeni kayıt için kayitTuru nesnesini null yapar */
        }

        private void Listele()
        {
            /* Veritabanından kayıtları okur ve listeler */
            gc.DataSource = CYS.model.YEM_KARISIM_YEM_TURU.Select(x => x).ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkraniTemizle();
        }

        private void YemTurleriniGetir()
        {
             List<YEM_TURU> YemTurleri = CYS.model.YEM_TURU.Select(x => x).ToList();
            cmbYemTuru.Properties.Items.Clear();
            cmbYemTuru.Properties.Items.AddRange(YemTurleri.ToArray());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Eğer yeni bir kayıt ise, kayıt işlemi yap
            * var olan bir kayıt ise güncelleme yap */
            if (kayitTuru == null)
            {
                /* Yeni Kayıt */
                kayitTuru = new YEM_KARISIM_YEM_TURU();
                kayitTuru.KARISIM_SIRANO = karisim.KARISIM_SIRANO;
                kayitTuru.ORAN = seOran.Value;
                kayitTuru.YEMTURU_SIRANO = (cmbYemTuru.SelectedItem as YEM_TURU).SIRANO;
               // kayitTuru.ACIKLAMA = txtAsiAdi.Text;
                CYS.model.YEM_KARISIM_YEM_TURU.Add(kayitTuru);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Oran kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /* Var olan bir kayıt */                
                kayitTuru.ORAN = seOran.Value;               
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Yem Oran kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
            EkraniTemizle();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Seçilen kaydı sil */
            if (kayitTuru == null) return;
            CYS.model.YEM_KARISIM_YEM_TURU.Remove(kayitTuru);
            CYS.model.SaveChanges();
            XtraMessageBox.Show("Yem Oran kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            EkraniTemizle();
        }

        private void gvkayitTuru_Click(object sender, EventArgs e)
        {
            kayitTuru = gv.GetFocusedRow() as YEM_KARISIM_YEM_TURU;
            if (kayitTuru != null)
            {
                cmbYemTuru.EditValue = kayitTuru.YEM_TURU;
                seOran.Value = kayitTuru.ORAN;
                cmbYemTuru.ReadOnly = true;
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