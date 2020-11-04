using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriangleLibrary;

namespace TriangleAssesment
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TriangleModel model = new TriangleModel(txtnumber1.Text, txtnumber2.Text, txtnumber3.Text);
                TriangleType ts = model.GetTriangleType(model);
                lblResult.Text = ts.ToString();
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Error with Form data";
                lblResult.ForeColor = Color.Red;
            }
        }
        private bool ValidateForm()
        {
            int side1 = 0;
            bool side1Validnum = int.TryParse(txtnumber1.Text, out side1);
            int side2 = 0;
            bool side2Validnum = int.TryParse(txtnumber2.Text, out side2);
            int side3 = 0;
            bool side3Validnum = int.TryParse(txtnumber3.Text, out side3);

            #region Validation - side 1
            ///#region Validate side 1 of triangle to be number and greater than 1
            if (!side1Validnum)
            {
                return false;
            }
            if (side1 < 1)
            {
                return false;
            }
            #endregion

            #region Validation - side 2
            ///#region Validate side 2 of triangle to be number and greater than 1
            if (!side2Validnum)
            {
                return false;
            }
            if (side2 < 1)
            {
                return false;
            }
            #endregion

            #region Validation - side 3
            ///#region Validate side 3 of triangle to be number and greater than 1
            if (!side3Validnum)
            {
                return false;
            }
            if (side3 < 1)
            {
                return false;
            }
            #endregion
            return true;
        }
    }
}
