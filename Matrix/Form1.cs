
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
        int[,] A;   //массив значений
        int[] F;    //массив максимальных значений по строкам
        void StartButton() {
            A = MakeMatrix();
            dataGridView1.RowCount    = A.GetLength(0);
            dataGridView1.ColumnCount = A.GetLength(1);
            for (int i=0; i < A.GetLength(0); i++) {
                for (int j=0; j<A.GetLength(1); j++) {
                    dataGridView1.Rows[i].Cells[j].Value = A[i,j];
                }
            }
        }

        int[,] MakeMatrix() {
            int N = (int)numericUpDown1.Value;
            int M = (int)numericUpDown2.Value;
            Random rnd = new Random();
            int [,] array = new int[N, M];
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    array[i, j] = rnd.Next(1,101);
                }
            }
            return array;
        }

        int[] MakeMax() {
            int N = (int)numericUpDown1.Value;
            int M = (int)numericUpDown2.Value;
            int[] array = new int[N];
            int max;
            for (int i=0; i<N; i++) {
                max = 0;
                for (int j = 0; j < M; j++) {
                    if (max < A[i, j])
                        max = A[i, j];
                }
                array[i] = max;
            }
            return array;
        }

        void ChangeSize() {
            Form2 f2_ChangeSize = new Form2();
            f2_ChangeSize.Owner = this;
            f2_ChangeSize.ShowDialog();
        }

        void PrepareMax() {
            dataGridView2.RowCount = A.GetLength(0);
            dataGridView2.ColumnCount = 1;
            for (int i = 0; i < A.GetLength(0); i++) {
                dataGridView2.Rows[i].Cells[0].Value = "";
            }
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

        private void button1_Click(object sender, EventArgs e) {
            StartButton();
            PrepareMax();
        }

        private void стартToolStripMenuItem1_Click(object sender, EventArgs e) {
            StartButton();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            ChangeSize();
        }

        private void button2_Click(object sender, EventArgs e) {
            ChangeSize();
        }

        private void buttonMax_Click(object sender, EventArgs e) {
            F = MakeMax();
            dataGridView2.RowCount = F.GetLength(0);
            dataGridView2.ColumnCount = 1;
            for (int i = 0; i < F.GetLength(0); i++) {
                dataGridView2.Rows[i].Cells[0].Value = F[i];
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

