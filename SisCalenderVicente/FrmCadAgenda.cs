using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoCalendario
{
    public partial class FrmCadAgenda : Form
    {
        public FrmCadAgenda()
        {
            InitializeComponent();
        }

        public FrmCadAgenda(DateTime dataSelecionda)
        {
            InitializeComponent();
            this.dateTimePickerSelecionado.Value = dataSelecionda;
        }
    }
}
