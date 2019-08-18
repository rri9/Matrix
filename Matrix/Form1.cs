using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void StartButton() {
            int[,] array = MakeMatrix();
            dataGridView1.RowCount    = array.GetLength(0);
            dataGridView1.ColumnCount = array.GetLength(1);
            for (int i=0; i < array.GetLength(0); i++) {
                for (int j=0; j<array.GetLength(1); j++) {
                    dataGridView1.Rows[i].Cells[j].Value = array[i,j];
                }
            }
        }

        int[,] MakeMatrix() {
            int N = (int)numericUpDown1.Value;
            int M = (int)numericUpDown2.Value;
            Random rnd = new Random();
            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    array[i, j] = rnd.Next(1,101);
                }
            }
            return array;
        }
            
        private void стартToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Зачет\nРакушов Р.И.\nГруппа ПБВ-82","О программе");
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            StartButton();
        }
    }
}
