using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoArray_Heinsonn
{
  public partial class Form1 : Form
  {
    Random rnd;
    int[] y = new int[6];
    public Form1()
    {
      InitializeComponent();
      rnd = new Random();
    }

    private void btnZahlenGenerieren_Click(object sender, EventArgs e)
    {
      int[] y = new int[6];
      int zufall, i= 0;
      // Eine Zahl zwischen 1 und 49
      y[0] = rnd.Next(1,49);
      txtAusgabe.Text = y[0].ToString();
     
      for (i=1;i<6;i++)
      {
        zufall= rnd.Next(1,49);
        if(zufall==y[0]||zufall==y[1]||zufall==y[2]||zufall==y[3]||zufall==y[4]||zufall==y[5])
        {
         
          i--;
        }
        else
        {
          y[i] = zufall;
          txtAusgabe.Text += " , "+y[i];
          
        }
      }

    }
  }
}
