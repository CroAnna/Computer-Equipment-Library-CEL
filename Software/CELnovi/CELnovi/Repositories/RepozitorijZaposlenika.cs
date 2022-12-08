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
    public class RepozitorijZaposlenika
    {
        public static Zaposlenik GetZaposlenik(string korisnickoIme) 
        {
            string sql = $"SELECT * FROM Zaposlenici WHERE KorisnickoIme = '{korisnickoIme}'"; 
            return FetchZaposlenik(sql);
        } 

        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenici WHERE Id = {id}";
            return FetchZaposlenik(sql);
        }

        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.SetConfiguration("askarica20_DB", "askarica20", "']Sk{MEC4'");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;
            if(reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = KreirajObjekt(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Lozinka = lozinka,
                KorisnickoIme = korisnickoIme
            };
            return zaposlenik;   
        }    
    }
}
