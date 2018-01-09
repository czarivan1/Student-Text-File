using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3StudyGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantMenuDataSetDessert2.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter7.Fill(this.restaurantMenuDataSetDessert2.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetMainCourse2.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter6.Fill(this.restaurantMenuDataSetMainCourse2.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetAppetizer2.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter5.Fill(this.restaurantMenuDataSetAppetizer2.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetDessert.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter4.Fill(this.restaurantMenuDataSetDessert.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetMainCourse.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter3.Fill(this.restaurantMenuDataSetMainCourse.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetAppetizer.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter2.Fill(this.restaurantMenuDataSetAppetizer.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSetBeverages.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter1.Fill(this.restaurantMenuDataSetBeverages.Menu);
            // TODO: This line of code loads data into the 'restaurantMenuDataSet1.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantMenuDataSet1.Menu);

            try
            {
                this.menuTableAdapter.FillBy(this.restaurantMenuDataSet1.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.menuTableAdapter5.FillBy(this.restaurantMenuDataSetAppetizer2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.menuTableAdapter6.FillBy(this.restaurantMenuDataSetMainCourse2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.menuTableAdapter7.FillBy(this.restaurantMenuDataSetDessert2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

try
            {
                this.menuTableAdapter.FillBy1(this.restaurantMenuDataSet1.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

try
            {
                this.menuTableAdapter.FillBy2(this.restaurantMenuDataSet1.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.menuTableAdapter5.FillBy1(this.restaurantMenuDataSetAppetizer2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
try
            {
                this.menuTableAdapter6.FillBy1(this.restaurantMenuDataSetMainCourse2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

try
            {
                this.menuTableAdapter7.FillBy1(this.restaurantMenuDataSetDessert2.Menu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

txtParty.Focus();
lbMenuItems.Items.Clear();
lbMenuItemsPrice.Items.Clear();


        }

        private void lbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBeverage.SelectedItem != null)
            {
                lbMenuItems.Items.Add(lbBeverage.SelectedValue);
            }
        }

        private void lbAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAppetizer.SelectedItem != null)
            {
                lbMenuItems.Items.Add(lbAppetizer.SelectedValue);
            }
        }

        private void lbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMainCourse.SelectedItem != null)
            {
                lbMenuItems.Items.Add(lbMainCourse.SelectedValue);
            }
        }

        private void lbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDessert.SelectedItem != null)
            {
                lbMenuItems.Items.Add(lbDessert.SelectedValue);
            }

        }

        private void cbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBeverage.SelectedItem != null)
            {
                lbMenuItemsPrice.Items.Add(cbBeverage.SelectedValue);        
            }

            int i = 0;
            double subTotal = 0.0;

            while (i < lbMenuItemsPrice.Items.Count)
            {
                subTotal = subTotal + Convert.ToDouble(lbMenuItemsPrice.Items[i++]);
            }

            lblSubTotal.Text = Convert.ToString(subTotal);
        }

        private void cbAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppetizer.SelectedItem != null)
            {
                lbMenuItemsPrice.Items.Add(cbAppetizer.SelectedValue);
            }

            int i = 0;
            double subTotal = 0.0;

            while (i < lbMenuItemsPrice.Items.Count)
            {
                subTotal = subTotal + Convert.ToDouble(lbMenuItemsPrice.Items[i++]);
            }

            lblSubTotal.Text = Convert.ToString(subTotal);
        }

        private void cbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMainCourse.SelectedItem != null)
            {
                lbMenuItemsPrice.Items.Add(cbMainCourse.SelectedValue);
            }

            int i = 0;
            double subTotal = 0.0;

            while (i < lbMenuItemsPrice.Items.Count)
            {
                subTotal = subTotal + Convert.ToDouble(lbMenuItemsPrice.Items[i++]);
            }

            lblSubTotal.Text = Convert.ToString(subTotal);
        }

        private void cbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDessert.SelectedItem != null)
            {
                lbMenuItemsPrice.Items.Add(cbDessert.SelectedValue);
            }

            int i = 0;
            double subTotal = 0.0;

            while (i < lbMenuItemsPrice.Items.Count)
            {
                subTotal = subTotal + Convert.ToDouble(lbMenuItemsPrice.Items[i++]);
            }

            lblSubTotal.Text = Convert.ToString(subTotal);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double subTotal = 0.0;
            double total = 0.0;
            double texasTaxes = .0825;
            double taxes = 0.0;

            subTotal = Convert.ToDouble(lblSubTotal.Text);
            taxes = subTotal * texasTaxes;
            total = subTotal + taxes;

            lblTax.Text = Convert.ToString(taxes);
            lblTotal.Text = Convert.ToString(total);

            lblTotal.Visible = true;
            lblTax.Visible = true;

            double tips = 0.0;

            if (Convert.ToDouble(txtParty.Text) <= 6)
            {
                txtTip.Visible = true;
                lblTip.Text = Convert.ToString(txtTip.Text);
                lblTip.Visible = true;
                lblTotalTip.Text = txtTip.Text;
                lblTotalTip.Visible = true;
                txtTip.Focus();
            }

            else if (Convert.ToDouble(txtParty.Text) > 6)
            {
                tips = Convert.ToDouble(lblTotal.Text) * 1.15;
                lblTip.Text = Convert.ToString(tips);
                lblTip.Visible = true;
                lblTotalTip.Text = lblTip.Text;
                lblTotalTip.Visible = true;
            }

        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            double tips = 0.0;

            if (Convert.ToDouble(txtParty.Text) <= 6)
            {
                txtTip.Visible = true;
                lblTip.Text = Convert.ToString(txtTip.Text);
                lblTip.Visible = true;
                tips = Convert.ToDouble(txtTip.Text) + Convert.ToDouble(lblTotal.Text);
                lblTotalTip.Text = Convert.ToString(tips);
                lblTotalTip.Visible = true;
            }

            else if (Convert.ToDouble(txtParty.Text) > 6)
            {
                tips = Convert.ToDouble(lblTotal.Text) * 1.15;
                lblTip.Text = Convert.ToString(tips);
                lblTip.Visible = true;
                lblTotalTip.Text = lblTip.Text;
                lblTotalTip.Visible = true;
            }
        }

        private void txtParty_TextChanged(object sender, EventArgs e)
        {
            if (txtParty.Text != null)
            {
                cbAppetizer.Visible = true;
                cbBeverage.Visible = true;
                cbDessert.Visible = true;
                cbMainCourse.Visible = true;

                lbAppetizer.Visible = true;
                lbBeverage.Visible = true;
                lbDessert.Visible = true;
                lbMainCourse.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtParty.Text = "";
            txtTip.Text = "";
            lbMenuItems.Items.Clear();
            lbMenuItemsPrice.Items.Clear();
            txtTip.Visible = false;
            txtTip.Text = "";
            lblTip.Text = "";
            lblTotalTip.Text = "";

        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            lbMenuItems.Items.Remove(lbMenuItems.SelectedItem);
            lbMenuItemsPrice.Items.Remove(lbMenuItemsPrice.SelectedItem);

            int i = 0;
            double subTotal = 0.0;

            while (i < lbMenuItemsPrice.Items.Count)
            {
                subTotal = subTotal + Convert.ToDouble(lbMenuItemsPrice.Items[i++]);
            }

            lblSubTotal.Text = Convert.ToString(subTotal);

        }

        private void txtClearItem_TextChanged(object sender, EventArgs e)
        {
            btnClearItem.Visible = true;
        }

    }
}
