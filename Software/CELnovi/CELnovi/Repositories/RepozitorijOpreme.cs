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
    public class RepozitorijOpreme
    {
        public static Oprema GetOprema(int id)
        {
            Oprema oprema = null;
            string sql = $"SELECT * FROM Opreme WHERE Id = {id}";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
             var reader = DB.GetDataReader(sql);
             if (reader.HasRows)
             {
                 reader.Read();
                 oprema = KreirajObjekt(reader);
                 reader.Close();
             }
             DB.CloseConnection();
            return oprema;
        }
        
        public static List<Oprema> GetOpremas(){
            
            var opreme = new List<Oprema>();

            string sql = "SELECT * FROM Oprema";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Oprema oprema = KreirajObjekt(reader);
                opreme.Add(oprema);
            }

            reader.Close();
            DB.CloseConnection();

            return opreme;
        }


        public static List<Oprema> GetOpremasSearch(string ime)
        {
            var opreme = new List<Oprema>();

            string sql = $"SELECT * FROM Oprema WHERE Naziv LIKE '%{ime}%'"; 
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4"); 
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Oprema oprema = KreirajObjekt(reader);
                opreme.Add(oprema);
            }

            reader.Close();
            DB.CloseConnection();

            return opreme;
        }

        private static Oprema KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string naziv = reader["Naziv"].ToString();
            string vrsta = reader["Vrsta"].ToString();
            string datVrPrimke = reader["DatVrPrimke"].ToString(); 
            string nazivProjekta = reader["NazivProjekta"].ToString();
            IzvorFinanciranjaKlasa IzvorFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(int.Parse(reader["IzvorFinanciranja"].ToString()));

            string opisOpreme = reader["OpisOpreme"].ToString();
            string osobaNabave = reader["OsobaNabave"].ToString();
            string osobaPrimke = reader["OsobaPrimke"].ToString();

            var oprema = new Oprema
            {
                Id = id,
                Naziv = naziv,
                Vrsta = vrsta,
                DatVrPrimke = datVrPrimke,
                OpisOpreme = opisOpreme,
                NazivProjekta = nazivProjekta,
                IzvorFinanciranja = IzvorFinanciranja, 
                OsobaNabave = osobaNabave,
                OsobaPrimke = osobaPrimke
            };

            return oprema;
        }

        public static void UmetniOpremu(Oprema oprema)
        {
            string sql = $"INSERT INTO Oprema ( Id, Naziv, Vrsta, DatVrPrimke, OpisOpreme, NazivProjekta, IzvorFinanciranja, OsobaNabave, OsobaPrimke) VALUES" +
                $"( '{oprema.Id}', '{oprema.Naziv}', '{oprema.Vrsta}', '{oprema.DatVrPrimke}', '{oprema.OpisOpreme}', '{oprema.NazivProjekta}', '{oprema.IzvorFinanciranja.Id}',  '{oprema.OsobaNabave}', '{oprema.OsobaPrimke}')";
            
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateOpreme(Oprema oprema)
        {
            // string sql = $"UPDATE Opreme SET Id = '{oprema.Id}', Naziv = '{ oprema.Naziv}', Vrsta = '{ oprema.Naziv}', DatVrPrimke = '{ oprema.Naziv}', OpisOpreme = '{ oprema.Naziv}', NazivProjekta = '{ oprema.Naziv}', IzvorFinanciranja = '{ oprema.Naziv}', OsobaNabave = '{ oprema.Naziv}', OsobaPrimke = '{ oprema.Naziv}' WHERE Id = {evaluation.Activity.Id};

            // string sql = $"UPDATE Opreme SET Id = '{oprema.Id}', Naziv = '{oprema.Naziv}' WHERE Id = '{oprema.Id}";
            string sql = $"UPDATE Oprema SET Id = '{oprema.Id}', Naziv = '{ oprema.Naziv}', IzvorFinanciranja = '{oprema.IzvorFinanciranja.Id}',  Vrsta = '{ oprema.Vrsta}', DatVrPrimke = '{ oprema.DatVrPrimke}', OpisOpreme = '{ oprema.OpisOpreme}', NazivProjekta = '{ oprema.NazivProjekta}',  OsobaNabave = '{ oprema.OsobaNabave}', OsobaPrimke = '{ oprema.OsobaPrimke}' WHERE Id = '{oprema.Id}'";

            DB.OpenConnection();
            DB.ExecuteCommand(sql); 
            DB.CloseConnection();

        }

        public static void IzbrisiOpremu(int id)
        {
            //string sql = $"UPDATE Oprema SET Id = '{oprema.Id}', Naziv = '{ oprema.Naziv}', Vrsta = '{ oprema.Vrsta}', DatVrPrimke = '{ oprema.DatVrPrimke}', OpisOpreme = '{ oprema.OpisOpreme}', NazivProjekta = '{ oprema.NazivProjekta}',  OsobaNabave = '{ oprema.Naziv}', OsobaPrimke = '{ oprema.OsobaPrimke}' WHERE Id = '{oprema.Id}'";
            string sql = $"DELETE FROM Oprema WHERE Id='{id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
