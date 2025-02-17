using System;
using System.Windows.Forms;

namespace Druggie
{
    public partial class FormInstruction : Form
    {
        string instructionText;

        public FormInstruction(string instructionText)
        {
            InitializeComponent();
            this.instructionText = instructionText;
        }
        private void FormInstruction_Load(object sender, EventArgs e)
        {
            textBoxInstruction.Text = instructionText;
            textBoxInstruction.Select(0, 0);
        }
    }
}
