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

namespace CYSLAU.Formlar.Hayvan
{
    public partial class frmHayvan : DevExpress.XtraEditors.XtraForm
    {
        private HAYVAN hayvan;
        private object caller;
        public frmHayvan(HAYVAN hayvan=null,object caller=null)
        {
            InitializeComponent();
            this.hayvan = hayvan;
            this.caller = caller;
            AnneBilgileriniGetir();
            BabaBilgileriniGetir();
            HayvanCinsleriniGetir();
            HayvanKayitTurleriniGetir();
            if (hayvan == null) FormuTemizle();
            else BilgileriGoster();
        }

        public void AnneBilgileriniGetir()
        {
            List<HAYVAN> AnneListesi= CYS.model.HAYVAN.Where(x => x.CINSIYETI.Value==1).ToList();
            cmbAnneKayitNo.Properties.Items.Clear();
            cmbAnneKayitNo.Properties.Items.AddRange(AnneListesi.ToArray());
        }

        public void BabaBilgileriniGetir()
        {
            List<HAYVAN> BabaListesi = CYS.model.HAYVAN.Where(x => x.CINSIYETI.Value == 0).ToList();
            cmbBabaKayitNo.Properties.Items.Clear();
            cmbBabaKayitNo.Properties.Items.AddRange(BabaListesi.ToArray());
        }

        public void HayvanCinsleriniGetir()
        {
            cmbHayvanCinsi.Properties.Items.Clear();
            cmbHayvanCinsi.Properties.Items.AddRange(CYS.model.HAYVAN_CINSI.Select(x => x).ToArray());
        }

        public void HayvanKayitTurleriniGetir()
        {
            cmbHayvanKayitTuru.Properties.Items.Clear();
            cmbHayvanKayitTuru.Properties.Items.AddRange(CYS.model.HAYVAN_KAYIT_TURU.Select(x => x).ToArray());
        }
        private void FormuTemizle()
        {
            hayvan = null;
            txtBoyunNo.Text = string.Empty;
            txtDevletNo.Text = string.Empty;
            txtKulakNo.Text = string.Empty;
            cmbAnneKayitNo.EditValue = null;
            cmbBabaKayitNo.EditValue = null;
            cmbCinsiyeti.SelectedIndex = -1;
            cmbHayvanCinsi.EditValue = null;
            cmbHayvanKayitTuru.EditValue = null;
            deKayitTarihi.EditValue = DateTime.Now;

        }

        private void BilgileriGoster()
        {
            txtBoyunNo.Text = hayvan.BOYUN_NO;
            txtDevletNo.Text = hayvan.DEVLET_NO;
            txtKulakNo.Text = hayvan.KULAK_NO;
            deDogumTarihi.EditValue = hayvan.DOGUM_TARIHI;
            deKayitTarihi.EditValue = hayvan.KAYIT_TARIHI;
            cmbCinsiyeti.SelectedIndex = hayvan.CINSIYETI.Value;
            if (hayvan.ANNE_KAYITNO.HasValue)
            {
                cmbAnneKayitNo.EditValue = CYS.model.HAYVAN.Where(x => x.KAYITNO == hayvan.ANNE_KAYITNO.Value).FirstOrDefault();
            }

            if (hayvan.BABA_KAYITNO.HasValue)
            {
                cmbBabaKayitNo.EditValue = CYS.model.HAYVAN.Where(x => x.KAYITNO == hayvan.BABA_KAYITNO.Value).FirstOrDefault();

            }
            cmbHayvanCinsi.EditValue = hayvan.HAYVAN_CINSI;
            cmbHayvanKayitTuru.EditValue = hayvan.HAYVAN_KAYIT_TURU;
        }

        private void cmbAnneKayitNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)
            {
                cmbAnneKayitNo.EditValue = null;
            }
        }

        private void cmbBabaKayitNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)
            {
                cmbBabaKayitNo.EditValue = null;
            }
        }

        private void cmbHayvanCinsi_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)
            {
                cmbHayvanCinsi.EditValue = null;
            }
            else if (e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmHayvanCins frm = new frmHayvanCins(this);
                frm.ShowDialog();
            }
        }

        private void cmbHayvanKayitTuru_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)
            {
                cmbHayvanKayitTuru.EditValue = null;
            }
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmHayvanKayitTur frm = new frmHayvanKayitTur(this);
                frm.ShowDialog();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormuTemizle();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate()) return;
                if (hayvan==null)
                {
                    hayvan = new HAYVAN();
                    HayvanBilgisiniDoldur();
                    CYS.model.HAYVAN.Add(hayvan);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Hayvan kartı açıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    HayvanBilgisiniDoldur();                   
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Hayvan kartı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Guncelle();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Guncelle()
        {
            if (caller == null) return;

            frmHayvanListesi frm = caller as frmHayvanListesi;
            if (frm != null) frm.HayvanlariGetir();
        }
        private void HayvanBilgisiniDoldur()
        {
            hayvan.KAYIT_TARIHI = (DateTime)deKayitTarihi.EditValue;
            hayvan.DOGUM_TARIHI = (DateTime)deDogumTarihi.EditValue;
            hayvan.DEVLET_NO = txtDevletNo.Text;
            hayvan.BOYUN_NO = txtBoyunNo.Text;
            hayvan.KULAK_NO = txtKulakNo.Text;
            hayvan.CINSIYETI = cmbCinsiyeti.SelectedIndex;
            hayvan.ANNE_KAYITNO = cmbAnneKayitNo.EditValue != null ? (cmbAnneKayitNo.EditValue as HAYVAN).KAYITNO : (int?)null;
            hayvan.BABA_KAYITNO = cmbBabaKayitNo.EditValue != null ? (cmbBabaKayitNo.EditValue as HAYVAN).KAYITNO : (int?)null;
            hayvan.HAYVANCINSI_SIRANO = (cmbHayvanCinsi.EditValue as HAYVAN_CINSI).SIRANO;
            hayvan.HAYVANKAYITTURU_SIRANO = (cmbHayvanKayitTuru.EditValue as HAYVAN_KAYIT_TURU).SIRANO;
        }
    }
}