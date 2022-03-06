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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form8 form8)
        {
           
            this.form8 = form8;
        }
      
        private Form8 form8;
       private void Form4_Load(object sender, EventArgs e)
       {
         
       }
       public void aceptar_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {

                form8.numerolibro.Enabled = true;
                
            }
            
            
        }

      
    }
}
