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
using Google.Protobuf;

namespace parcialUno.essentials.utilidades
{
    public class Serializador
    {
        private string _path;
        private string _extension;
        public Serializador(string path)
        {
            _path = path;
            _extension = Path.GetExtension(path);
        }

        public void Serializar(object elemento)
        {
            if (!string.IsNullOrEmpty(_extension))
            {
                if (_extension == ".json")
                {
                    SerializarJson(elemento);
                }
                else if(_extension == ".csv" && elemento is IEnumerable)
                { 
                    SerializarCsv((IEnumerable)elemento);
                }
                else
                {
                    throw new NotImplementedException("Extension no implementada");
                }
            }
            
        }
        
        private void SerializarJson(object elemento)
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
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

            using (var writer = new StreamWriter(_path))
            using (var csv = new CsvWriter(writer, configuration))
            {
                csv.WriteRecords(elemento);
            }
        }
    }
}
