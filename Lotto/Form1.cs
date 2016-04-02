using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
           
            //0.4 버전 -  리스트 사용하기+정렬 기능 넣기+구분자 삭제+초기화 버튼 삭제
            List<int> al = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                al.Add(rnd1.Next(1, 45));
            }
            //정렬
            al.Sort();
            //리스트 박스에 넣기
            listBox1.DataSource = al;

            //int[] num = new int[6];
        
            ////0.1 버전 - 단순히 1~45 중 한개씩 골라서 리스트 박스에 표시 함
            //foreach (var ctr in num)
            //{
            //    num[ctr] = rnd1.Next(1, 45);
            //    listBox1.Items.Add(num[ctr]);
                
            //}

            //0.2 버전 - 라벨에 넣기
            label1.Text = rnd1.Next(1, 45).ToString();
            label2.Text = rnd1.Next(1, 45).ToString();
            label3.Text = rnd1.Next(1, 45).ToString();
            label4.Text = rnd1.Next(1, 45).ToString();
            label5.Text = rnd1.Next(1, 45).ToString();
            label6.Text = rnd1.Next(1, 45).ToString();

            //0.3 버전 - 리스트 박스 끝나면 ----- 로 구분하기
            //listBox1.Items.Add("--------------");
        }
    }
}
