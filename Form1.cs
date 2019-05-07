using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //상수 선언
            const double PI = 3.14;

            //반지름 입력
            double iRadius = int.Parse(txtBox1.Text);

            //면적 계산
            double area = PI * iRadius * iRadius;

            //결과 표시
            lblResult.Text = area.ToString();
        }
    }
}
