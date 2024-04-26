using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MCFireWorksGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_click(object sender, EventArgs e)
        {
            string Command = "/summon firework_rocket " + textBox1.Text + (" ") + textBox2.Text + (" ") + textBox3.Text + (" ");
            string Color = "Colors:[I;";//色選択
            int Multi = 0;//色の複数選択を認識用
            string Type = "Type:" + textBox5.Text;//タイプを選択
            string LifeTime = "LifeTime:" + textBox4.Text;//高さを設定
            string Flicker;//ぱらぱら
            string Trail;
            int AfterMulti = 0;//爆発後の色の複数選択を認識用
            string FadeColor = "FadeColors:[I;";//色選択
            if (checkBox22.Checked == true)
            {
                Flicker = "1b";
            }
            else
            {
                Flicker = "0b";
            }
            if (checkBox25.Checked == true)
            {
                Trail = "1b";
            }
            else
            {
                Trail = "0b";
            }
            if (checkBox1.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "14602026";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",14602026";
                }
            }
            if (checkBox2.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11743532";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11743532";
                }
            }
            if (checkBox3.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "12801229";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",12801229";
                }
            }
            if (checkBox4.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "2437522";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",2437522";
                }
            }
            if (checkBox5.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "3887386";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",3887386";
                }
            }
            if (checkBox6.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "2651799";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",2651799";
                }
            }
            if (checkBox7.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "15790320";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",15790320";
                }
            }
            if (checkBox8.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "4408131";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",4408131";
                }
            }
            if (checkBox9.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "15435844";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",15435844";
                }
            }
            if (checkBox10.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "14188952";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",14188952";
                }
            }
            if (checkBox11.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "8073150";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",8073150";
                }
            }
            if (checkBox12.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "6719955";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",6719955";
                }
            }
            if (checkBox13.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "4312372";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",4312372";
                }
            }
            if (checkBox14.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "5320730";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",5320730";
                }
            }
            if (checkBox15.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "1973019";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",1973019";
                }
            }
            if (checkBox16.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11250603";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11250603";
                }
            }
            if (checkBox17.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16776960";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16776960";
                }
            }
            if (checkBox21.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11596438";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11596438";
                }
            }
            if (checkBox23.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16711680";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16711680";
                }
            }
            if (checkBox24.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16711832";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16711832";
                }
            }
            if (checkBox18.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16744318";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16744318";
                }
            }
            if (checkBox19.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "65535";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",65535";
                }
            }
            if (checkBox20.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "10346495";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",10346495";
                }
                if (checkBox48.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "14602026";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",14602026";
                    }
                }
                if (checkBox47.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11743532";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11743532";
                    }
                }
                if (checkBox46.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "12801229";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",12801229";
                    }
                }
                if (checkBox45.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "2437522";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",2437522";
                    }
                }
                if (checkBox44.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "3887386";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",3887386";
                    }
                }
                if (checkBox43.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "2651799";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",2651799";
                    }
                }
                if (checkBox42.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "15790320";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",15790320";
                    }
                }
                if (checkBox41.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "4408131";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",4408131";
                    }
                }
                if (checkBox40.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "15435844";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",15435844";
                    }
                }
                if (checkBox39.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "14188952";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",14188952";
                    }
                }
                if (checkBox38.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "8073150";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",8073150";
                    }
                }
                if (checkBox37.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "6719955";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",6719955";
                    }
                }
                if (checkBox36.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "4312372";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",4312372";
                    }
                }
                if (checkBox35.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "5320730";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",5320730";
                    }
                }
                if (checkBox34.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "1973019";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",1973019";
                    }
                }
                if (checkBox33.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11250603";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11250603";
                    }
                }
                if (checkBox32.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16776960";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16776960";
                    }
                }
                if (checkBox31.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11596438";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11596438";
                    }
                }
                if (checkBox30.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16711680";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16711680";
                    }
                }
                if (checkBox29.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16711832";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16711832";
                    }
                }
                if (checkBox28.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16744318";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16744318";
                    }
                }
                if (checkBox27.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "65535";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",65535";
                    }
                }
                if (checkBox26.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "10346495";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",10346495";
                    }
                }
                Color = Color
                      + "]";//かっこを閉じる
                FadeColor = FadeColor
                      + "]";//かっこを閉じる
                Command = Command
                        + "{" + LifeTime + ",FireworksItem:{id:firework_rocket,Count:1,tag:{Fireworks:{Explosions:[{"
                        + Type + Flicker + "," + Trail + "," + Color + "," + FadeColor + "," + "}],Flight:1}}}}";
                MessageBox.Show(Command);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Command = "/summon firework_rocket " + textBox1.Text + (" ") + textBox2.Text + (" ") + textBox3.Text + (" ");
            string Color = "Colors:[I;";//色選択
            int Multi = 0;//色の複数選択を認識用
            string Type = "Type:" + textBox5.Text;//タイプを選択
            string LifeTime = "LifeTime:" + textBox4.Text;//高さを設定
            string Flicker;//ぱらぱら
            string Trail;
            int AfterMulti = 0;//爆発後の色の複数選択を認識用
            string FadeColor = "FadeColors:[I;";//色選択
            if (checkBox22.Checked == true)
            {
                Flicker = "Flicker:1b";
            }
            else
            {
                Flicker = "Flicker:0b";
            }
            if (checkBox25.Checked == true)
            {
                Trail = "Trail:1b";
            }
            else
            {
                Trail = "Trail:0b";
            }
            if (checkBox1.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "14602026";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",14602026";
                }
            }
            if (checkBox2.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11743532";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11743532";
                }
            }
            if (checkBox3.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "12801229";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",12801229";
                }
            }
            if (checkBox4.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "2437522";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",2437522";
                }
            }
            if (checkBox5.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "3887386";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",3887386";
                }
            }
            if (checkBox6.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "2651799";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",2651799";
                }
            }
            if (checkBox7.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "15790320";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",15790320";
                }
            }
            if (checkBox8.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "4408131";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",4408131";
                }
            }
            if (checkBox9.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "15435844";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",15435844";
                }
            }
            if (checkBox10.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "14188952";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",14188952";
                }
            }
            if (checkBox11.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "8073150";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",8073150";
                }
            }
            if (checkBox12.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "6719955";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",6719955";
                }
            }
            if (checkBox13.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "4312372";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",4312372";
                }
            }
            if (checkBox14.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "5320730";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",5320730";
                }
            }
            if (checkBox15.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "1973019";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",1973019";
                }
            }
            if (checkBox16.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11250603";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11250603";
                }
            }
            if (checkBox17.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16776960";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16776960";
                }
            }
            if (checkBox21.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "11596438";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",11596438";
                }
            }
            if (checkBox23.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16711680";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16711680";
                }
            }
            if (checkBox24.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16711832";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16711832";
                }
            }
            if (checkBox18.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "16744318";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",16744318";
                }
            }
            if (checkBox19.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "65535";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",65535";
                }
            }
            if (checkBox20.Checked == true)
            {
                if (Multi == 0)
                {
                    Color = Color
                          + "10346495";
                    Multi = 1;
                }
                else
                {
                    Color = Color
      + ",10346495";
                }
            }
            if (checkBox48.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "14602026";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",14602026";
                    }
                }
                if (checkBox47.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11743532";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11743532";
                    }
                }
                if (checkBox46.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "12801229";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",12801229";
                    }
                }
                if (checkBox45.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "2437522";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",2437522";
                    }
                }
                if (checkBox44.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "3887386";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",3887386";
                    }
                }
                if (checkBox43.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "2651799";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",2651799";
                    }
                }
                if (checkBox42.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "15790320";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",15790320";
                    }
                }
                if (checkBox41.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "4408131";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",4408131";
                    }
                }
                if (checkBox40.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "15435844";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",15435844";
                    }
                }
                if (checkBox39.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "14188952";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",14188952";
                    }
                }
                if (checkBox38.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "8073150";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",8073150";
                    }
                }
                if (checkBox37.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "6719955";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",6719955";
                    }
                }
                if (checkBox36.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "4312372";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",4312372";
                    }
                }
                if (checkBox35.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "5320730";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",5320730";
                    }
                }
                if (checkBox34.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "1973019";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",1973019";
                    }
                }
                if (checkBox33.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11250603";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11250603";
                    }
                }
                if (checkBox32.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16776960";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16776960";
                    }
                }
                if (checkBox31.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "11596438";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",11596438";
                    }
                }
                if (checkBox30.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16711680";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16711680";
                    }
                }
                if (checkBox29.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16711832";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16711832";
                    }
                }
                if (checkBox28.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "16744318";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",16744318";
                    }
                }
                if (checkBox27.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "65535";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",65535";
                    }
                }
                if (checkBox26.Checked == true)
                {
                    if (AfterMulti == 0)
                    {
                        FadeColor = FadeColor
                              + "10346495";
                        AfterMulti = 1;
                    }
                    else
                    {
                        FadeColor = FadeColor
          + ",10346495";
                    }
                }
            string Motion = "Motion:[" + textBox8.Text + "d," + textBox7.Text + "d," + textBox6.Text + "d" + "]";
            Color = Color
                      + "]";//かっこを閉じる
                FadeColor = FadeColor
                      + "]";//かっこを閉じる
                Command = Command
                        + "{" + LifeTime + "," + Motion + ",FireworksItem:{id:firework_rocket,Count:1,tag:{Fireworks:{Explosions:[{"
                        + Type + "," + Flicker + "," + Trail + "," + Color + "," + FadeColor + "}],Flight:1}}}}";
            Clipboard.SetText(Command);
            MessageBox.Show("コマンドをクリップボードに保存しました。");
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }