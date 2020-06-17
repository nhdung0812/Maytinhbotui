using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Maytinhbotui
{
    public partial class Form1 : Form
    {
        Double giaTri = 0;
        String phepTinh = "";
        double temp = 0;
        bool even = false;
        bool even_2 = true;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
         
            if(txt_ketqua.Text == "0")
            {
                txt_ketqua.Text = "";
                
            }
            Button button = (Button)sender;
            if(even)
                txt_ketqua.Text = "";
            txt_ketqua.Text = txt_ketqua.Text + button.Text;
            /*if (even_2)
            {
                temp = double.Parse(txt_ketqua.Text);
                even_2 = false;
            }*/
                even = false;
        }

        private void phep_tinh(object sender, EventArgs e)
        {
           
            txt_pheptinh.Text += txt_ketqua.Text;
            Button button = (Button)sender;
            phepTinh = button.Text;
            giaTri = Double.Parse(txt_ketqua.Text);
            txt_pheptinh.Text += phepTinh;
            switch (phepTinh)
            {
                case "+":
                   
                    temp += giaTri;
                    break;
                case "-":
                    temp = giaTri - temp;
                    
                    break;
            }
            
            txt_ketqua.Text = temp.ToString();
            even = true;
        }

        private void Ketqua(object sender, EventArgs e)
        {
            switch (phepTinh)
            {
                case "+":
                    txt_ketqua.Text = (giaTri + Double.Parse(txt_ketqua.Text)).ToString();
                    break;
            }
            if(txt_ketqua.Text.Contains("^"))
            {
                double _temp = 0;
                string[] arrListStr = txt_ketqua.Text.Split(new char[] { '^' });
                _temp = Math.Pow(double.Parse(arrListStr[0]), float.Parse(arrListStr[1]));
                txt_ketqua.Text = _temp.ToString();
            }    

        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = "0";
            txt_pheptinh.Text = "";
            giaTri = 0;
        }

        private void txt_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xbinhphuong_Click(object sender, EventArgs e)
        {
            float _temp = float.Parse(txt_ketqua.Text);
            _temp = _temp * _temp;
            txt_ketqua.Text = _temp.ToString();
        }

        private void btn_canbac_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txt_ketqua.Text);

            //Nếu căn bậc 2 số âm thì lỗi NaN
            _temp = Math.Sqrt(_temp);
            txt_ketqua.Text = _temp.ToString();
        }

        private void btn_giaithua_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txt_ketqua.Text);
            double giaithua = 1;
            for(int i = 2; i<= _temp;i++)
            {
                giaithua *= i;
            }
            txt_ketqua.Text = giaithua.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txt_ketqua.Text);
            txt_ketqua.Text += "^";
            //Nếu căn bậc 2 số âm thì lỗi NaN
            

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txt_ketqua.Text);
            _temp = Math.Sin(_temp);
            txt_ketqua.Text = _temp.ToString();
        }

        private void btn_Cos_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txt_ketqua.Text);
            _temp = Math.Cos(_temp);
            txt_ketqua.Text = _temp.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int _temp;
            string str = txt_ketqua.Text;
            if (str != "")
            {
                _temp = int.Parse(txt_ketqua.Text);
                int num = _temp.ToString().Length;
                str = _temp.ToString().Remove(num - 1);
                if (str == "")
                    str = "0";
            }     
            txt_ketqua.Text = str;
            

        }
    }

}
