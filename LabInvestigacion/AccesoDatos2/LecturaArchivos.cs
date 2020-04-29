using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    class LecturaArchivos
    {

        public string leerServer()
        {
            string fichero = Application.StartupPath + @"\ruta\ruta.txt";
            string server = "";
            
            StreamReader reader = new StreamReader(fichero);
            string[] line;

            if (File.Exists(fichero))
            {
                server = reader.ReadLine();
                line = server.Split('=');
                server = line[1];
            }
            return server;
        }

        public string leerDatabase()
        {
            string fichero = @"C: \rutaBaseDatos.txt";
            string dataBase = "";
            StreamReader reader = new StreamReader(fichero);
            string[] line;

            if (File.Exists(fichero))
            {
                reader.ReadLine();
                dataBase = reader.ReadLine();
                line = dataBase.Split('=');
                dataBase = line[1];
            }
            return dataBase;
        }

        public string leerSecurity()
        {
            string fichero = @"C: \rutaBaseDatos.txt";
            string security = "";
            StreamReader reader = new StreamReader(fichero);
            string[] line;

            if (File.Exists(fichero))
            {
                reader.ReadLine();
                reader.ReadLine();
                security = reader.ReadLine();
                line = security.Split('=');
                security = line[1];
            }
            return security;
        }
    }
}
