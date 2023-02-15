using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_الكاشير
{
    public partial class الكاشير : Form
    {
        public الكاشير()
        {
            InitializeComponent();
        }
        int print_num_fatora = 1;
        private void الكاشير_Load(object sender, EventArgs e)
        {
            textBoxdate.Text = DateTime.Now.ToString("dd / MMMM / yyyy");

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1550,"لاب توب dell ");
            dic.Add(2500, "لاب توب hp");
            dic.Add(3500, "لاب توب lenovo");
            dic.Add(200, "كيبورد عادي");
            dic.Add(300, "كيبورد dell");
            dic.Add(400, "كيبورد hp");
            dic.Add(600, "كيبورد lenovo");
            dic.Add(500, "ماوس dell");
            dic.Add(70, "ماوس hp");
            dic.Add(80, "ماوس lenovo");
            dic.Add(90, "ماوس عادي");
            dic.Add(30, "طابعه عاديه");
            dic.Add(75, "طابعه dell");
            dic.Add(67, "طابعه hp");
            dic.Add(234, "طابعه lenovo");

            comboBoxitem.DataSource = new BindingSource(dic,null);
            comboBoxitem.DisplayMember = "Value";
            comboBoxitem.ValueMember = "Key";
            textBoxprice.Text = comboBoxitem.SelectedValue.ToString();
            foreach (DataGridViewColumn c in dataGridViewfatora.Columns)
            {
                c.DefaultCellStyle.ForeColor = Color.Navy;
            }
            dataGridViewfatora.Columns[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridViewfatora.Columns[1].DefaultCellStyle.BackColor = Color.Red;
            dataGridViewfatora.Columns[3].DefaultCellStyle.ForeColor = Color.White;
            dataGridViewfatora.Columns[3].DefaultCellStyle.BackColor = Color.Green;

            textBoxname.Select();
            textBoxfato_num.Text = print_num_fatora + "";
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http:\\www.google.com");

        }

        private void textBoxfato_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

       

        private void textBoxdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                textBoxdate.ContextMenu = new ContextMenu();
            }
        }

        private void textBoxfato_num_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                textBoxfato_num.ContextMenu = new ContextMenu();
            }
        }

        private void textBoxprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void textBoxprice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                textBoxprice.ContextMenu = new ContextMenu();
            }
        }

        private void textBoxtotal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                textBoxtotal.ContextMenu = new ContextMenu();
            }
        }

        private void textBoxtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

       

        private void buttonadd_MouseDown(object sender, MouseEventArgs e)
        {
            buttonadd.BackColor = Color.Blue;
        }

        private void buttonadd_MouseUp(object sender, MouseEventArgs e)
        {
            buttonadd.BackColor = Color.DarkCyan;

        }

        private void buttonprint_MouseDown(object sender, MouseEventArgs e)
        {
            buttonprint.BackColor = Color.Blue;

        }

        private void buttonprint_MouseUp(object sender, MouseEventArgs e)
        {
            buttonprint.BackColor = Color.DarkCyan;

        }

        private void comboBoxitem_KeyDown(object sender, KeyEventArgs e)
        {
            buttonadd.BackColor = Color.DarkCyan;
            errorProviderForName.Clear();
            if (e.KeyData == Keys.Enter)
            {
                if (comboBoxitem.Text.Trim() == "")
                {
                    errorProviderForName.SetError(comboBoxitem, "من فضلك لا تترك حقل الصنف فارغ ");
                    comboBoxitem.Focus();
                }
                else
                {
                    textBoxquantity.Focus();
                    textBoxquantity.SelectAll();

                        }
            }
        }

        private void textBoxquantity_KeyDown(object sender, KeyEventArgs e)
        {
            errorProviderForName.Clear();
            if (e.KeyData == Keys.Enter)
            {
                if (textBoxquantity.Text.Trim() == "")
                {
                    errorProviderForName.SetError(textBoxquantity, "من فضلك لا تترك حقل الكميه فارغ ");
                    textBoxquantity.Focus();
                }
                else
                    buttonadd.Focus();
            }
        }

        
        private void textBoxname_KeyDown(object sender, KeyEventArgs e)
        {
            errorProviderForName.Clear();
            if (e.KeyData == Keys.Enter)
            {
                if (textBoxname.Text.Trim() == "")
                {
                    errorProviderForName.SetError(textBoxname, "من فضلك لا تترك حقل الاسم فارغ ");
                    textBoxname.Focus();
                }
                else
                    comboBoxitem.Focus();

            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (comboBoxitem.SelectedIndex <= -1)
            {
               DialogResult dr= MessageBox.Show("من فضلك قم باختيار عنصر من العناصر الموجوده بالكمبوبوكس","تنبيه !!!",
                    MessageBoxButtons.OK,MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                if (dr == DialogResult.OK)
                {
                    comboBoxitem.Focus();
                }
                return;
            }
            buttonadd.BackColor = Color.Blue;
            string sitem = comboBoxitem.Text;
            int quntity = Convert.ToInt32(textBoxquantity.Text.Replace(" ", ""));
            int price = Convert.ToInt32(textBoxprice.Text);
            int subtotal = quntity * price;
            object[] row = {sitem,quntity,price,subtotal};
            dataGridViewfatora.Rows.Add(row);
            textBoxtotal.Text = Convert.ToInt32(textBoxtotal.Text) + subtotal + "";

            comboBoxitem.Focus();


        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            print_num_fatora++;

            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
            textBoxfato_num.Text = print_num_fatora + "";
        }

        private void comboBoxitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxprice.Text = comboBoxitem.SelectedValue.ToString();

        }

        private void textBoxquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            
            }
        }
        
        private void textBoxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;

            }
        }
        string old_value_cell = "1";
        private void dataGridViewfatora_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewfatora.CurrentRow != null)
                old_value_cell= dataGridViewfatora.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridViewfatora_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewfatora.CurrentRow != null)
            {
                string new_value_cell = dataGridViewfatora.CurrentRow.Cells[1].Value.ToString();
                if (old_value_cell == new_value_cell)
                    return;
                if (!Regex.IsMatch(new_value_cell, "^\\d+$"))
                {
                    dataGridViewfatora.CurrentRow.Cells[1].Value = old_value_cell;

                }
                else
                {
                    int p = (int)dataGridViewfatora.CurrentRow.Cells[2].Value;
                    int q = Convert.ToInt32(new_value_cell);
                    dataGridViewfatora.CurrentRow.Cells[3].Value = p * q;
                    int new_total = 0;
                    foreach (DataGridViewRow r in dataGridViewfatora.Rows)
                    {

                        new_total += (int)r.Cells[3].Value;
                    
                    }
                    textBoxtotal.Text = new_total + "";
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.ttt, 5, 5,250,200);

            float page_width = e.PageBounds.Width;
            float page_hight = e.PageBounds.Height;
            float h = 100;
            float w = page_width - 300;
            Font f = new Font("Arial",20,FontStyle.Bold);
            Font ff = new Font("Traditional Arabic", 30, FontStyle.Bold);

            e.Graphics.DrawString("#NO : "+textBoxfato_num.Text,f,Brushes.Red,page_width/2,5);
            e.Graphics.DrawString("التاريخ :"+textBoxdate.Text,f,Brushes.Black,w,h);
            e.Graphics.DrawString("          / مطلوب من السيد " +" "+ "\n"+textBoxname.Text, f, Brushes.Blue,w, h+=50);
            e.Graphics.DrawRectangle(Pens.Black, 50, 240, page_width - 100, page_hight-300);
            e.Graphics.DrawLine(Pens.Black,50,290,50+page_width - 100, 290);

            e.Graphics.DrawLine(Pens.Black, page_width - 250, 240,  page_width - 250, 240+page_hight - 300);
            e.Graphics.DrawLine(Pens.Black,  page_width - 500, 240, page_width - 500, 240 + page_hight - 300);
            e.Graphics.DrawLine(Pens.Black, page_width - 620, 240, page_width - 620, 240 + page_hight - 300);
            e.Graphics.DrawString(" الصنف ", f, Brushes.Black, page_width - 200, 255);
            e.Graphics.DrawString(" الكميه ", f, Brushes.Black, page_width - 450, 255);
            e.Graphics.DrawString(" السعر ", f, Brushes.Black, page_width - 590, 255);
            e.Graphics.DrawString(" الاجمالي ف  ", f, Brushes.Black, page_width - 750, 255);

            float hi = 60;
            for (int i=0;i<dataGridViewfatora.Rows.Count;i++)
            {
            e.Graphics.DrawString(dataGridViewfatora.Rows[i].Cells[0].Value.ToString(), f, Brushes.Blue, page_width - 240, 255+hi);
            e.Graphics.DrawString(dataGridViewfatora.Rows[i].Cells[1].Value.ToString(), f, Brushes.DarkOrange, page_width - 450, 255 + hi);
            e.Graphics.DrawString(dataGridViewfatora.Rows[i].Cells[2].Value.ToString(), f, Brushes.Red, page_width - 590, 255 + hi);
            e.Graphics.DrawString(dataGridViewfatora.Rows[i].Cells[3].Value.ToString(), f, Brushes.Blue, page_width - 750, 255 + hi);
            e.Graphics.DrawLine(Pens.Black, 50, 290+hi, 50 + page_width - 100, 290+hi);
            hi += 60;
            }

            e.Graphics.DrawString(textBoxtotal.Text+"  : ** الاجمالي ** ", ff, Brushes.DarkRed, page_width - 590, page_hight-50);

        }
    }
}
