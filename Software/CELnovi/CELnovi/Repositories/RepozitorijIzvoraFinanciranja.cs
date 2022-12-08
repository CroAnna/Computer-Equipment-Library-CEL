using CELnovi.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Repositories
{
    public class RepozitorijIzvoraFinanciranja
    {
        
        public static IzvorFinanciranjaKlasa GetIzvorFinanciranja(int id)
        {
            IzvorFinanciranjaKlasa izvorFinanciranjaKlasa = null;
            string sql = $"SELECT * FROM Izvorifinanciranja WHERE Id = {id}";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                izvorFinanciranjaKlasa = KreirajObjekt(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return izvorFinanciranjaKlasa;
        }

        public static List<IzvorFinanciranjaKlasa> GetIzvoreFinanciranja()
        {
            var izvorFinanciranjaKlasa = new List<IzvorFinanciranjaKlasa>();
            string sql = "SELECT * FROM Izvorifinanciranja"; 
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4"); 
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                IzvorFinanciranjaKlasa izvorFinanciranja = KreirajObjekt(reader);
                izvorFinanciranjaKlasa.Add(izvorFinanciranja);
            }
            reader.Close();
            DB.CloseConnection();
            return izvorFinanciranjaKlasa;
        }
    
        private static IzvorFinanciranjaKlasa KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string iznos = reader["Iznos"].ToString();
            string naziv = reader["Naziv"].ToString();

            var izvorFinanciranjaKlasa = new IzvorFinanciranjaKlasa
            {
                Id = id,
                Iznos = iznos,
                Naziv = naziv
            };
            return izvorFinanciranjaKlasa;
        }
    }
}
