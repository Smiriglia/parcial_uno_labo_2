using Google.Cloud.Firestore;
using System.Text.Json;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using System.Collections;

namespace parcialUno.essentials.utilidades
{
    public class Serializador
    {
        private string _path;
        private string _formato;
        public Serializador(string path, string formato)
        {
            _path = path;
            _formato = formato;
        }

        public void Serializar(object elemento)
        {
            if (!string.IsNullOrEmpty(_formato))
            {
                if (_formato == "json")
                {
                    SerializarJson(elemento);
                }
                else if(_formato == "csv")
                { 
                    SerializarCsv((IEnumerable)elemento);
                }
                else
                {
                    throw new NotImplementedException("Formato no implementado");
                }
            }
            
        }
        
        private void SerializarJson(object elemento)
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };
                string jsonSer = JsonSerializer.Serialize(elemento, options);
                writer.Write(jsonSer);
            }
        }

        private void SerializarCsv(IEnumerable elemento)
        {

            var configuration = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            // Serializar el diccionario a un archivo CSV
            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, configuration))
            {
                csv.WriteRecords(elemento);
            }
        }
    }
}
