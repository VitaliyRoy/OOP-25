using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                if (string.IsNullOrEmpty(txt_search.Text))
                {
                    this.gamesTableAdapter.Fill(this.appData.Games);
                    gamesBindingSource.DataSource = this.appData.Games;
                    //dataGridView.DataSource = gamesBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Games
                                where o.Назва_гри.Contains(txt_search.Text) || o.Розробник == txt_search.Text || o.Дата_виходу.Contains(txt_search.Text)
                                select o;
                    gamesBindingSource.DataSource = query.ToList();
                    gamesBindingSource.ResetBindings(false);
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (MessageBox.Show("Ви справді хочете видалити цей запис?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                gamesBindingSource.RemoveCurrent(); 
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd= new OpenFileDialog() {Filter="JPEG|*.jpg",ValidateNames=true,Multiselect=false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txt_name.Focus();
                this.appData.Games.AddGamesRow(this.appData.Games.NewGamesRow());
                gamesBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gamesBindingSource.ResetBindings(false);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txt_name.Focus();
        }

        private void btb_cancel_Click(object sender, EventArgs e)
        {
            panel.Enabled=false;
            gamesBindingSource.ResetBindings(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                gamesBindingSource.EndEdit();
                gamesTableAdapter.Update(this.appData.Games);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gamesBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter.Fill(this.appData.Games);
            gamesBindingSource.DataSource = this.appData.Games;
        }
    }
}
