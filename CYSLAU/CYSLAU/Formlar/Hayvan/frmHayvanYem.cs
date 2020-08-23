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
    public partial class frmHayvanYem : DevExpress.XtraEditors.XtraForm
    {
        HAYVAN hayvan;
        HAYVAN_YEM_KARISIM_YEM_TURU hayvanYem;
        public frmHayvanYem(HAYVAN hayvan = null)
        {
            InitializeComponent();
            this.hayvan = hayvan;
            txtHayvan.Text = hayvan.ToString();
            HayvanYemListesiniGetir();
            YemKarisimlariniGetir();
        }

        private void HayvanYemListesiniGetir()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = CYS.model.HAYVAN_YEM_KARISIM_YEM_TURU.Where(x => x.HAYVAN_KAYITNO == hayvan.KAYITNO).Select(u => u).ToList();
        }

        private void YemKarisimlariniGetir()
        {
            cmbYemKarisim.Properties.Items.Clear();
            cmbYemKarisim.Properties.Items.AddRange(CYS.model.YEM_KARISIM.Select(x => x).ToList());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;
            try
            {
                if (hayvanYem==null)
                {
                    hayvanYem = new HAYVAN_YEM_KARISIM_YEM_TURU();
                    hayvanYem.HAYVAN_KAYITNO = hayvan.KAYITNO;
                    hayvanYem.KARISIM_SIRANO = (cmbYemKarisim.EditValue as YEM_KARISIM).KARISIM_SIRANO;
                    hayvanYem.YEM_SAATI = (DateTime)deYemSaati.EditValue;
                    hayvanYem.ACIKLAMA = txtAciklama.Text;
                    CYS.model.HAYVAN_YEM_KARISIM_YEM_TURU.Add(hayvanYem);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Hayvan yem kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    hayvanYem = new HAYVAN_YEM_KARISIM_YEM_TURU();
                    hayvanYem.HAYVAN_KAYITNO = hayvan.KAYITNO;
                    hayvanYem.KARISIM_SIRANO = (cmbYemKarisim.EditValue as YEM_KARISIM).KARISIM_SIRANO;
                    hayvanYem.YEM_SAATI = (DateTime)deYemSaati.EditValue;
                    hayvanYem.ACIKLAMA = txtAciklama.Text;
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Hayvan yem kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                hayvanYem = null;
                HayvanYemListesiniGetir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hayvanYem == null) return;
            if (XtraMessageBox.Show("Hayvan yem kaydını silmek istediğinizden emin misinz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CYS.model.HAYVAN_YEM_KARISIM_YEM_TURU.Remove(hayvanYem);
                CYS.model.SaveChanges();
                XtraMessageBox.Show("Hayvan yem kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hayvanYem = null;
                HayvanYemListesiniGetir();
            }
        }
    }
}