using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class InstrumentDataHandler
    {
        private string connectionString;
        private SqlConnection conn;
        private List<Instrument> instrumenter;
        public InstrumentDataHandler()
        {
            connectionString = "Data Source=D0208;Initial Catalog=MusikButikDB;User ID=Sa;Password=Test142536";
            //instanciere sqlconnection og passer den ovenstående connectionstring som argument
            conn = new SqlConnection(connectionString);
            //instanciere listen over instrument grupper
            instrumenter = new List<Instrument>();
        }

        public async Task<bool> OpretInstrumentAsync(Instrument instrument)
        {
            //Sætter returvariabel der fortæller om metode er eksekveret uden problemer, til som udgangspunkt at være true
            bool executeSuccess;
            //Skriver insert query;
            string query = "INSERT INTO Instrumenter(Navn, Beskrivelse, IndkøbsPris, Fortjeneste, LagerDato, Antal, Producent, VareGruppe) VALUES (@Navn, @Beskrivelse, @IndkøbsPris, @Fortjeneste, @LagerDato, @Antal, @Producent, @VareGruppe);";
            //Instanciere et SqlCommand objekt som anvender query samt connection variabel
            SqlCommand cmd = new SqlCommand(query, conn);
            //værdier associeres med parametre for den ovenstående query
            cmd.Parameters.AddWithValue("@Navn", instrument.Navn);
            cmd.Parameters.AddWithValue("@Beskrivelse", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@IndkøbsPris", instrument.IndkøbsPris);
            cmd.Parameters.AddWithValue("@Fortjeneste", instrument.Fortjeneste);
            cmd.Parameters.AddWithValue("@LagerDato", instrument.LagerDato);
            cmd.Parameters.AddWithValue("@Antal", instrument.Antal);
            cmd.Parameters.AddWithValue("@Producent", instrument.Producent);
            cmd.Parameters.AddWithValue("@VareGruppe", instrument.VareGruppe);
            try
            {
                //åbner forbindelse til databasen
                await conn.OpenAsync();
                //Eksekvere SQL op imod databasen
                if (await cmd.ExecuteNonQueryAsync() == 1)
                {
                    executeSuccess = true;
                }
                else
                {
                    executeSuccess = false;
                }
                //Lukker forbindelsne
                conn.Close();
            }
            catch(Exception e)
            {
                //Er der opstået en fejl er executeSuccess false
                executeSuccess = false;
            }
            //returnere hvorvidt metoden er kørt successfuldt eller ej
            return executeSuccess;
        }
        public async Task<List<Instrument>> HentInstrumenterAsync(int VareGruppe)
        {
            //Instanciere en sqlcommand som tager en query der vælger alt fra instrumenter tabellen, og som anvender den conn der er instancieret i constructoren
            SqlCommand cmd = new SqlCommand("SELECT * FROM Instrumenter WHERE VareGruppe = @VareGruppe;", conn);
            cmd.Parameters.AddWithValue("@VareGruppe", VareGruppe);
            //I tilfælde af der opstår fejl under oprettelse af forbindelse til database sættes kode associeret med forbindelsen i en trycatch
            try
            {
                //Åbner forbindelse til databasen
                await conn.OpenAsync();
                //Sætter en sqldatareader variabel der modtager en sqldatareader med executereaderasync metoden på sqlcommand objektet som skal køre efter forbindelsen er åbnet
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                //Kalder readasync metoden på sqldatareaderen som returner true så længde den læser, som betingelse for fortsat iterering i en whileløkke.
                while (await reader.ReadAsync())
                {
                    //For hver iteration tilføjes et instrumentobjekt til instrumentlisten med properties for den række readeren er nået til. Der castes til de rigtige datatyper.
                    instrumenter.Add(new Instrument
                    {
                        VareNummer = (int)reader["VareNummer"],
                        Navn = (string)reader["Navn"],
                        Beskrivelse = (string)reader["Beskrivelse"],
                        IndkøbsPris = (double)reader["IndkøbsPris"],
                        Fortjeneste = (double)reader["Fortjeneste"],
                        LagerDato = (DateTime)reader["LagerDato"],
                        Antal = (int)reader["Antal"],
                        Producent = (string)reader["Producent"],
                        VareGruppe = (int)reader["VareGruppe"],
                    });
                }
                //lukker for forbindelsen
                conn.Close();
            }
            catch(Exception e)
            {
                //Såfremt der er opstået en fejl i ovenstående kode, sættes listen til null
                instrumenter = null;
            }
            //returnere resultatet af listen
            return instrumenter;
        }
        public async Task<Instrument> HentInstrumentAsync(int vareNummer)
        {
            //Instanciere et ny instrument hvis properties skal sættes til at være lig data hentet fra database
            Instrument inst = new Instrument();
            //Instanciere en sqlcommand som tager en query der vælger alle data fra Instrumenter på basis af det modtagne Id. Derudover anvender den den conn sqlconnection variablen som connection 
            SqlCommand cmd = new SqlCommand("SELECT * FROM Instrumenter WHERE VareNummer = @VareNummer;", conn);
            cmd.Parameters.AddWithValue("@VareNummer", vareNummer);
            //I tilfælde af der opstår fejl under oprettelse af forbindelse til database sættes kode associeret med forbindelsen i en trycatch
            try
            {
                //Åbner forbindelse til databasen
                await conn.OpenAsync();
                //Sætter en sqldatareader variabel der modtager en sqldatareader med executereaderasync metoden på sqlcommand objektet.
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                //Sætter readeren til at læse. Læser den succesfuldt returnere den true. Derfor sættes den i en condition
                //i tilfælde af læsning ikke lykkedes. Udenfor en vil den bare læse den første række der falder indenfor de kriterier der er sat i select query
                if (await reader.ReadAsync())
                {
                    //Sætter properties ud fra den række der er læst
                    inst.VareNummer = (int)reader["VareNummer"];
                    inst.Navn = (string)reader["Navn"];
                    inst.Beskrivelse = (string)reader["Beskrivelse"];
                    inst.IndkøbsPris = (double)reader["IndkøbsPris"];
                    inst.Fortjeneste = (double)reader["Fortjeneste"];
                    inst.LagerDato = (DateTime)reader["LagerDato"];
                    inst.Antal = (int)reader["Antal"];
                    inst.Producent = (string)reader["Producent"];
                    inst.VareGruppe = (int)reader["VareGruppe"];
                }
                else
                {
                    inst = null;
                }
                //lukker læsning og connection
                reader.Close();
                conn.Close();
            }
            catch
            {
                //hvis der er opstået en fejl under ovenstående eksekvering sættes objektet til at være null
                inst = null;
            }
            //returnere objektet
            return inst;
        }
        public async Task<bool> OpdaterInstrumentAsync(Instrument instrument)
        {
            //Sætter returvariabel der fortæller om metode er eksekveret uden problemer, til som udgangspunkt at være true
            bool executeSuccess;
            //Skriver update query
            string query = "UPDATE Instrumenter SET Navn = @Navn, Beskrivelse=@Beskrivelse, IndkøbsPris=@IndkøbsPris, Fortjeneste=@Fortjeneste, LagerDato=@LagerDato, Antal=@Antal, Producent=@Producent, VareGruppe=@VareGruppe WHERE VareNummer = @VareNummer;";
            //Instanciere et SqlCommand objekt som anvender query samt connection variabel
            SqlCommand cmd = new SqlCommand(query, conn);
            //værdier associeres med parametre for den ovenstående query
            cmd.Parameters.AddWithValue("@VareNummer", instrument.VareNummer);
            cmd.Parameters.AddWithValue("@Navn", instrument.Navn);
            cmd.Parameters.AddWithValue("@Beskrivelse", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@IndkøbsPris", instrument.IndkøbsPris);
            cmd.Parameters.AddWithValue("@Fortjeneste", instrument.Fortjeneste);
            cmd.Parameters.AddWithValue("@LagerDato", instrument.LagerDato);
            cmd.Parameters.AddWithValue("@Antal", instrument.Antal);
            cmd.Parameters.AddWithValue("@Producent", instrument.Producent);
            cmd.Parameters.AddWithValue("@VareGruppe", instrument.VareGruppe);
            try
            {
                //åbner forbindelse til databasen
                await conn.OpenAsync();
                //Eksekvere SQL op imod databasen
                if (await cmd.ExecuteNonQueryAsync() == 1)
                {
                    executeSuccess = true;
                }
                else
                {
                    executeSuccess = false;
                }
                //Lukker forbindelsne
                conn.Close();
            }
            catch(Exception e)
            {
                //Er der opstået en fejl er executeSuccess false
                executeSuccess = false;
            }
            //returnere hvorvidt metoden er kørt successfuldt eller ej
            return executeSuccess;
        }
        public async Task<bool> SletInstrumentAsync(int vareNummer)
        {
            //Sætter returvariabel der fortæller om metode er eksekveret uden problemer, til som udgangspunkt at være true
            bool executeSuccess;
            //skriver delete query
            string query = "DELETE FROM Instrumenter WHERE VareNummer=@VareNummer;";
            //Instanciere et SqlCommand objekt som anvender query samt connection variabel
            SqlCommand cmd = new SqlCommand(query, conn);
            //værdier associeres med parametre for den ovenstående query
            cmd.Parameters.AddWithValue("@VareNummer", vareNummer);

            try
            {
                //åbner forbindelse til databasen
                await conn.OpenAsync();
                //Eksekvere SQL op imod databasen
                if (await cmd.ExecuteNonQueryAsync() == 1)
                {
                    executeSuccess = true;
                }
                else
                {
                    executeSuccess = false;
                }
                //Lukker forbindelsne
                conn.Close();
            }
            catch
            {
                //Er der opstået en fejl er executeSuccess false
                executeSuccess = false;
            }
            //returnere hvorvidt metoden er kørt successfuldt eller ej
            return executeSuccess;
        }
    }
}
