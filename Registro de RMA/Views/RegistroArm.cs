﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_RMA.Views
{
    public partial class RegistroArm : Form
    {
        public RegistroArm()
        {
            InitializeComponent();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            CadastrarArm cadastrarArm = new CadastrarArm();
            cadastrarArm.ShowDialog();
        }
    }
}
