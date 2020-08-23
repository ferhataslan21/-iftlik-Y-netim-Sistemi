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

namespace CYSLAU.Formlar.Veteriner
{
    public partial class frmMuayeneAsi : DevExpress.XtraEditors.XtraForm
    {
        SAGLIK muayene;
        SAGLIK_ASI_TURU muayeneAsi;
        public frmMuayeneAsi(SAGLIK muayene=null)
        {
            InitializeComponent();
            this.muayene = muayene;
            txtMuayene.Text ="Muayene No:"+muayene.SIRANO.ToString()+" Hayvan:"+ muayene.HAYVAN.ToString();
            muayeneAsilariniGetir();
            AsilariGetir();
        }

        private void AsilariGetir()
        {
            cmbIlac.Properties.Items.Clear();
            cmbIlac.Properties.Items.AddRange(CYS.model.ASI_TURU.Select(x => x).ToList());
        }
        private void muayeneAsilariniGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.SAGLIK_ASI_TURU.Where(u=>u.SAGLIK_SIRANO==muayene.SIRANO).Select(x => x).ToList();
        }

        private void EkraniTemizle()
        {
            txtAciklama.Text = string.Empty;
            cmbIlac.EditValue = null;
            muayeneAsi = null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkraniTemizle();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            if (muayeneAsi==null)
            {
                muayeneAsi = new SAGLIK_ASI_TURU();
                muayeneAsi.SAGLIK_SIRANO = muayene.SIRANO;
                muayeneAsi.ASITURU_SIRANO = (cmbIlac.EditValue as ASI_TURU).SIRANO;
                muayeneAsi.ACIKLAMA = txtAciklama.Text;
                CYS.model.SAGLIK_ASI_TURU.Add(muayeneAsi);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene aşı kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                muayeneAsi.SAGLIK_SIRANO = muayene.SIRANO;
                muayeneAsi.ASITURU_SIRANO = (cmbIlac.EditValue as ASI_TURU).SIRANO;
                muayeneAsi.ACIKLAMA = txtAciklama.Text;              
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene aşı kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            EkraniTemizle();
            muayeneAsilariniGetir();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (muayeneAsi == null) return;
            if (XtraMessageBox.Show("Aşı kaydı silinsin mi?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CYS.model.SAGLIK_ASI_TURU.Remove(muayeneAsi);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene aşı kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkraniTemizle();
                muayeneAsilariniGetir();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}