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
    public partial class frmMuayene : DevExpress.XtraEditors.XtraForm
    {
        VETERINER veteriner;
        HAYVAN hayvan;
        SAGLIK muayene;
        object caller;

        public frmMuayene(VETERINER veterine=null,HAYVAN hayvan=null,SAGLIK muayene=null,object caller=null)
        {
            InitializeComponent();
            this.veteriner = veterine;
            this.hayvan = hayvan;
            this.muayene = muayene;
            this.caller = caller;
            HayvanlariGetir();
            VeterinerleriGetir();
            if (muayene==null)
            {
                btnAsi.Enabled = false;
                btnIlac.Enabled = false;
                btnPrint.Enabled = false;


            }
            else
            {
                btnAsi.Enabled = true;
                btnIlac.Enabled = true;
                btnPrint.Enabled = true;

                cmbHayvan.EditValue = muayene.HAYVAN;
                cmbVeteriner.EditValue = muayene.VETERINER;

                txtAciklama.Text = muayene.ISLEM_ACIKLAMA;
                txtNotlar.Text = muayene.NOTLAR;

            }
        }

        private void HayvanlariGetir()
        {
            cmbHayvan.Properties.Items.Clear();
            cmbHayvan.Properties.Items.AddRange(CYS.model.HAYVAN.Select(x => x).ToList());

            if (hayvan!=null)
            {
                cmbHayvan.EditValue = CYS.model.HAYVAN.Where(x => x.KAYITNO == hayvan.KAYITNO).Select(x => x).FirstOrDefault();
            }
        }

        private void VeterinerleriGetir()
        {
            cmbVeteriner.Properties.Items.Clear();
            cmbVeteriner.Properties.Items.AddRange(CYS.model.VETERINER.Select(x => x).ToList());
            if (veteriner != null)
            {
                cmbVeteriner.EditValue = CYS.model.VETERINER.Where(x => x.SIRANO == veteriner.SIRANO).Select(x => x).FirstOrDefault();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            try
            {
                if (muayene == null)
                {
                    muayene = new SAGLIK();
                    muayene.VETERINER = cmbVeteriner.EditValue as VETERINER;
                    muayene.HAYVAN = cmbHayvan.EditValue as HAYVAN;
                    muayene.ISLEM_TARIHI = (DateTime)deMuayeneTarihi.DateTime;
                    muayene.ISLEM_ACIKLAMA = txtAciklama.Text;
                    muayene.NOTLAR = txtNotlar.Text;

                    CYS.model.SAGLIK.Add(muayene);
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Muayene kaydı yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAsi.Enabled = true;
                    btnIlac.Enabled = true;
                    btnPrint.Enabled = true;
                }
                else
                {
                    muayene.ISLEM_TARIHI = (DateTime)deMuayeneTarihi.DateTime;
                    muayene.ISLEM_ACIKLAMA = txtAciklama.Text;
                    muayene.NOTLAR = txtNotlar.Text;
                    CYS.model.SaveChanges();
                    XtraMessageBox.Show("Muayene kaydı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnIlac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (muayene == null) return;
            frmMuayeneIlac frm = new frmMuayeneIlac(muayene);
            frm.ShowDialog();
        }

        private void btnAsi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (muayene == null) return;
            frmMuayeneAsi frm = new frmMuayeneAsi(muayene);
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}