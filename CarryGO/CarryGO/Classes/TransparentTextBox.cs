using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


namespace CarryGO
{
    class TransparentTextBox : TextBox
    {
        public TransparentTextBox()
        {

            this.BorderStyle = BorderStyle.None;
            this.Font = new Font("Arial", 16);
            

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.StandardClick |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.ContainerControl |
                     ControlStyles.UserPaint, true);


            this.BackColor = Color.Transparent;

            
        }

       
    }
}
