using _1012_Muhammad_Irvan_Akbar_UTS.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1012_Muhammad_Irvan_Akbar_UTS.Views
{
    public partial class halDasboardAdmin : Form
    {
        List<M_Barang> m_Barangs = new List<M_Barang>();
        public halDasboardAdmin()
        {
            InitializeComponent();

            M_Barang m_Barang = new M_Barang();
            m_Barang.namaBarang = "Cangkul";
            m_Barang.kategori = "Pertanian";
            m_Barang.jumlah = "6";
            m_Barang.harga = "50000";

            m_Barangs.Add(m_Barang);
            dataGridView1 = new DataGridView();
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambahBarang_Click_1(object sender, EventArgs e)
        {
            btnTambahBarang.Click += new EventHandler(this.btnTambahBarang_Click);

            tambahBarang tambahBarang = new tambahBarang();
            tambahBarang.ShowDialog();
        }
    }
}
 