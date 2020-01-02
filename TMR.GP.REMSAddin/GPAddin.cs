using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Dexterity.Bridge;
using Microsoft.Dexterity.Applications;

using System.Net;
using System.ComponentModel;

namespace TMR.GP.REMSAddin
{
    public class GPAddin : IDexterityAddIn
    {
        DashBoard mainRems;
        public void Initialize()
        {
            MetalineAddin.Forms.IgpLinker.OpenBeforeOriginal += IrnLinker_OpenBeforeOriginal;
            //Dynamics.Forms.RmCustomerMaintenance.AddMenuHandler(OpenMainForm,"Hello");
        }
        void IrnLinker_OpenBeforeOriginal(object sender, CancelEventArgs e)
        {

            if (mainRems == null || mainRems.IsDisposed)
            {
                mainRems = new DashBoard();
                mainRems.Show();
            }

            mainRems.BringToFront();
            MetalineAddin.Forms.IgpLinker.Close();
        }

        private void OpenMainForm(object sender, EventArgs e)
        {
            DashBoard mainForm = new DashBoard();
            mainForm.Show();
        }
    }
}
