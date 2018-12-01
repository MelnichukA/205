using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8Lib;

namespace LAB8
{
    public partial class fMain : Form
    {
        private BindingList<Pass> pas = new BindingList<Pass>();
        public fMain()
        {
            InitializeComponent();
            lbPassInfo.DataSource = pas;
            lbPassInfo.DisplayMember = "PassSer";
            lbPassInfo.ValueMember = "PassNum";
            lbPassInfo.SelectedIndexChanged += new EventHandler(lbPassInfo_SelectedIndexChanged);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            PassForm ft = new PassForm(pass);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                pas.Add(pass);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть?", "Завершить работу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();

        }

        private void lbPassInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
           Pass pass = (Pass)lbPassInfo.SelectedItem;
            MessageBox.Show("Имя: " + pass.Name + "|Страна:" +
                pass.Country + " | Город: " +
                pass.Region + " | Место выдачи: " +
                pass.Place + " | Место прописки: " +
                pass.Prop + "| Номер паспорта: " +
                pass.PassNum + " | Серия паспорта: " +
                pass.PassSer);
        }
    }
}
