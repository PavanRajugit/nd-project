using System;
using System.Windows.Forms;

namespace CodingTest.UI
{
    public partial class CellValueForm : Form
    {
        public CellValueForm(string value)
        {
            InitializeComponent();
            labelValue.Text = value;
        }
    }
}

