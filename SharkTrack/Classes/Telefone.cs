using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkTrack.Classes
{
    internal class Telefone
    {
        public int Id { get; set; }
        public string Telefones { get; set; }
        public int Id_cliente { get; set; }

        public bool Modificar()
        {
            string comando = "UPDATE telefone SET telefone = @fone WHERE id_cliente = @id ";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@fone", Telefones);
            cmd.Parameters.AddWithValue("@id", Id_cliente);

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
