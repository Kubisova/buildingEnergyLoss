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
            numUpDBuildingWidth.Controls[0].Visible = false;
            numUpDBuildingLength.Controls[0].Visible = false;
            numUpDBuildingHeight.Controls[0].Visible = false;
            numUpDMinOuterTemperature.Controls[0].Visible = false;
            numUpDInnerTemperature.Controls[0].Visible = false;
            Init();
        }

        private void Init()
        {
            IMaterialsRepository materials = new MaterialsRepository();
            cmbFloorsMaterials1.DataSource = materials.GetMaterials();
            cmbFloorsMaterials1.DisplayMember = nameof(Material.Name);
            cmbFloorsMaterials1.ValueMember = nameof(Material.Name);


            cmbFloorsMaterials2.BindingContext = new BindingContext();
            cmbFloorsMaterials2.DataSource = materials.GetMaterials();
            cmbFloorsMaterials2.DisplayMember = nameof(Material.Name);
            cmbFloorsMaterials2.ValueMember = nameof(Material.Name);

            cmbRoofMaterials1.BindingContext = new BindingContext();
            cmbRoofMaterials1.DataSource = materials.GetMaterials();
            cmbRoofMaterials1.DisplayMember = nameof(Material.Name);
            cmbRoofMaterials1.ValueMember = nameof(Material.Name);

            cmbWallsMaterials1.BindingContext = new BindingContext();
            cmbWallsMaterials1.DataSource = materials.GetMaterials();
            cmbWallsMaterials1.DisplayMember = nameof(Material.Name);
            cmbWallsMaterials1.ValueMember = nameof(Material.Name);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _frmMainModel.Name = txtName.Text;
            _frmMainModel.NameAndSurname = txtNameAndSurname.Text;
           
            _frmMainModel.Width = (double)numUpDBuildingWidth.Value;
            _frmMainModel.Length = (double)numUpDBuildingLength.Value;
            _frmMainModel.Height = (double)numUpDBuildingHeight.Value;

            _frmMainModel.MinOuterTemperature = (int)numUpDMinOuterTemperature.Value;
            _frmMainModel.InnerTemperature = (int)numUpDInnerTemperature.Value;

            _frmMainModel.Surface.Add("Floor");
            _frmMainModel.MaterialNames.Add((string)cmbFloorsMaterials1.SelectedValue);
            _frmMainModel.MaterialThickness.Add(double.Parse(txtFloorThickness1.Text));

            _frmMainModel.Surface.Add("Floor");
            _frmMainModel.MaterialNames.Add((string)cmbFloorsMaterials2.SelectedValue);
            _frmMainModel.MaterialThickness.Add(double.Parse(txtFloorThickness2.Text));

            _frmMainModel.Surface.Add("Roof");
            _frmMainModel.MaterialNames.Add((string)cmbRoofMaterials1.SelectedValue);
            _frmMainModel.MaterialThickness.Add(double.Parse(txtRoofThickness1.Text));

            _frmMainModel.Surface.Add("Wall");
            _frmMainModel.MaterialNames.Add((string)cmbWallsMaterials1.SelectedValue);
            _frmMainModel.MaterialThickness.Add(double.Parse(txtWallsThickness1.Text));

            double result = _frmMainModel.Calculate();
            //lblResult.Text = result.ToString();
            txtResult.Text = result.ToString();

        }
    }
}
