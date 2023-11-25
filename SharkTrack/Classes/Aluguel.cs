using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharkTrack.Classes
{
    public class Aluguel
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public int id_carro { get; set; }
        public DateTimePicker data_retirada { get; set; }
        public DateTimePicker data_devolucao { get; set; }

    }
}
