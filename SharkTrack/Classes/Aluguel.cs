using MySqlConnector;
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
        public int Id { get; set; }
        public int Id_usuario { get; set; }
        public int Id_carro { get; set; }
        public DateTime Data_retirada { get; set; }
        public DateTime Data_devolucao { get; set; }

        public bool Cadastrar()
        {
            string comando = "CALL cadastrar_aluguel(@idu, @idc, @dataret, @datadevo)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@idu", Id_usuario);
            cmd.Parameters.AddWithValue("@idc", Id_carro);
            cmd.Parameters.AddWithValue("@dataret", Data_retirada);
            cmd.Parameters.AddWithValue("@datadevo", Data_devolucao);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
