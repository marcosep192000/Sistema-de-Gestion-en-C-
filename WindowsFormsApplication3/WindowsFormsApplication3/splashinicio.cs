using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class splashinicio : Form
    {
        public splashinicio()
        {
            InitializeComponent();
        }
 int contador = 0;
       public void splashinicio_Load(object sender, EventArgs e)
        {
           
           
            
        }

        public  void tiempo_Tick(object sender, EventArgs e)
        {
          if (progressBar1.Value < 100)
          {
              
              contador = contador + 1 ;
 label9.Text = contador.ToString();
              progressBar1.Value=contador ;
          }
          else
          {
              Form1 For = new Form1();
              For.Show();
              tiempo.Enabled = false;
              this.Hide();
          }
        }
    }
}
