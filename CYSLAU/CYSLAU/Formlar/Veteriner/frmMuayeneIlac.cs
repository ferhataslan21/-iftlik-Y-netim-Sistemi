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
    public partial class frmMuayeneIlac : DevExpress.XtraEditors.XtraForm
    {
        SAGLIK muayene;
        SAGLIK_ILAC muayeneIlac;
        public frmMuayeneIlac(SAGLIK muayene=null)
        {
            InitializeComponent();
            this.muayene = muayene;
            txtMuayene.Text ="Muayene No:"+muayene.SIRANO.ToString()+" Hayvan:"+ muayene.HAYVAN.ToString();
            MuayeneIlaclariniGetir();
            IlaclariGetir();
        }

        private void IlaclariGetir()
        {
            cmbIlac.Properties.Items.Clear();
            cmbIlac.Properties.Items.AddRange(CYS.model.ILAC_TURU.Select(x => x).ToList());
        }
        private void MuayeneIlaclariniGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.SAGLIK_ILAC.Where(u=>u.SAGLIK_IRANO==muayene.SIRANO).Select(x => x).ToList();
        }

        private void EkraniTemizle()
        {
            txtAciklama.Text = string.Empty;
            cmbIlac.EditValue = null;
            muayeneIlac = null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EkraniTemizle();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            if (muayeneIlac==null)
            {
                muayeneIlac = new SAGLIK_ILAC();
                muayeneIlac.SAGLIK_IRANO = muayene.SIRANO;
                muayeneIlac.ILACTURU_SIRANO = (cmbIlac.EditValue as ILAC_TURU).SIRANO;
                muayeneIlac.ACIKLAMA = txtAciklama.Text;
                CYS.model.SAGLIK_ILAC.Add(muayeneIlac);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene ilaç kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                muayeneIlac.SAGLIK_IRANO = muayene.SIRANO;
                muayeneIlac.ILACTURU_SIRANO = (cmbIlac.EditValue as ILAC_TURU).SIRANO;
                muayeneIlac.ACIKLAMA = txtAciklama.Text;              
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene ilaç kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            EkraniTemizle();
            MuayeneIlaclariniGetir();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (muayeneIlac == null) return;
            if (XtraMessageBox.Show("İlaç kaydı silinsin mi?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CYS.model.SAGLIK_ILAC.Remove(muayeneIlac);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Muayene ilaç kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkraniTemizle();
                MuayeneIlaclariniGetir();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}