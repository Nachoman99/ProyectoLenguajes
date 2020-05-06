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
            string fichero = (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rutaJuanca.txt"));
            string server = "";
            StreamReader reader = new StreamReader(fichero);
            string[] line;

            if (File.Exists(fichero))
            {
                server = reader.ReadToEnd();
            }
            return server;
        }
    }
}
