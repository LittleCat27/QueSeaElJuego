using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueSeaElJuego.Forms
{
    public partial class FormJuego : Form
    {
        private FormPrincipal FPrincipal;
        public FormJuego(FormPrincipal FPrincipal)
        {
            InitializeComponent();
            this.FPrincipal = FPrincipal;
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
