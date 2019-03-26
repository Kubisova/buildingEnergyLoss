using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VypocetTepelnychStratApp
{
    public partial class FrmMain : Form
    {
        private FrmMainModel _frmMainModel;

        public FrmMain(FrmMainModel frmMainModel)
        {
            _frmMainModel = frmMainModel;
            InitializeComponent();
            Init();
           
        }

        private void Init()
        {
            IMaterialsRepository materials = new MaterialsRepository();
            cmbFloorsMaterials1.DataSource = materials.GetMaterials();
            cmbFloorsMaterials1.DisplayMember = nameof(Material.Name);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
