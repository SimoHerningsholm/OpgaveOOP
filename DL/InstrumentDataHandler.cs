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
    class InstrumentDataHandler
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Data Source=D0208;Initial Catalog=MusikButikDB;User ID=Sa;Password=Test142536"].ConnectionString;
        private SqlConnection conn;
        private List<Instrument> instrumenter;
        public InstrumentDataHandler()
        {
            //instanciere sqlconnection og passer den ovenstående connectionstring som argument
            conn = new SqlConnection(connectionString);
            //instanciere listen over instrument grupper
            instrumenter = new List<Instrument>();
        }

        public async Task<bool> OpretInstrumentAsync(Instrument instrument)
        {
            //Sætter returvariabel der fortæller om metode er eksekveret uden problemer, til som udgangspunkt at være true
            bool executeSuccess;
            string query = "INSERT INTO Instrumenter(Navn, Beskrivelse, IndkøbsPris, Fortjeneste, LagerDato, Anatal, Producent, VareGruppe) VALUES (@Navn, @Beskrivelse, @IndkøbsPris, @Fortjeneste, @LagerDato, @Antal, @Producent, @VareGruppe);";
            //Instanciere et SqlCommand objekt som anvender query samt connection variabel
            SqlCommand cmd = new SqlCommand(query, conn);
            //værdier associeres med parametre for den ovenstående query
            cmd.Parameters.AddWithValue("@Navn", instrument.Navn);
            cmd.Parameters.AddWithValue("@Beskrivelse", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@IndkøbsPris", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@Fortjeneste", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@LagerDato", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@Antal", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@Producent", instrument.Beskrivelse);
            cmd.Parameters.AddWithValue("@VareGruppe", instrument.Beskrivelse);
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
        public async Task<List<InstrumentGruppe>> HentAlleInstrumentGrupperAsync()
        {
            //Instanciere en sqlcommand som tager en query der vælger alt fra instrumentgruppe tabellen, og som anvender den conn der er instancieret i constructoren
            SqlCommand cmd = new SqlCommand("SELECT * FROM InstrumentGrupper;", conn);
            //Sætter en sqldatareader variabel der modtager en sqldatareader med executereaderasync metoden på sqlcommand objektet.
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            //I tilfælde af der opstår fejl under oprettelse af forbindelse til database sættes kode associeret med forbindelsen i en trycatch
            try
            {
                //Åbner forbindelse til databasen
                await conn.OpenAsync();
                //Kalder readasync metoden på sqldatareaderen som returner true så længde den læser, som betingelse for fortsat iterering i en whileløkke.
                while (await reader.ReadAsync())
                {
                    //For hver iteration tilføjes et instrumentgruppeobjekt til instrumentgrupperlisten med properties for den række readeren er nået til. Der castes til de rigtige datatyper.
                    instrumentGrupper.Add(new InstrumentGruppe
                    {
                        Id = (int)reader["Id"],
                        Navn = (string)reader["Navn"],
                        Beskrivelse = (string)reader["Beskrivelse"],
                    });
                }
                //lukker for forbindelsen
                conn.Close();
            }
            catch
            {
                //Såfremt der er opstået en fejl i ovenstående kode, sættes listen til null
                instrumentGrupper = null;
            }
            //returnere resultatet af listen
            return instrumentGrupper;
        }
        public async Task<InstrumentGruppe> HentInstrumentGruppeAsync(int id)
        {
            //Instanciere en ny instrumentgruppe hvis properties skal sættes til at være lig data hentet fra database
            InstrumentGruppe grp = new InstrumentGruppe();
            //Instanciere en sqlcommand som tager en query der vælger alle data fra InstrumenterGruppe på basis af det modtagne Id. Derudover anvender den den conn sqlconnection variablen som connection 
            SqlCommand cmd = new SqlCommand("SELECT * FROM InstrumentGrupper WHERE Id = @Id;", conn);
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
                    grp.Id = (int)reader["Id"];
                    grp.Navn = (string)reader["Navn"];
                    grp.Navn = (string)reader["Beskrivelse"];
                }
                else
                {
                    grp = null;
                }
                //lukker læsning og connection
                reader.Close();
                conn.Close();
            }
            catch
            {
                //hvis der er opstået en fejl under ovenstående eksekvering sættes objektet til at være null
                grp = null;
            }
            //returnere objektet
            return grp;
        }
    }
}
