using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DXSample;
using DevExpress.XtraLayout.Customization;

namespace S132265 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            layoutControl1.RegisterCustomPropertyGridWrapper(typeof(LayoutControlItem),
                typeof(MyLayoutControlItemPropertyWrapper));
        }
    }
}