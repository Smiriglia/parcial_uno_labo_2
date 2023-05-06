using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Type;
using parcialUno.essentials.abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace parcialUno.essentials.models
{
    public class Fire
    {
        public static async Task<Dictionary<string, object>>? GetAsync(string coleccion, string clave, object valor)
        {
            string projectId = "parcialuno-b8508";
            FirestoreDb db = FirestoreDb.Create(projectId);

            var colref = db.Collection(coleccion);

            var query = colref.WhereEqualTo(clave, valor);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return docs[0].ToDictionary();

            return null;
        }
        public static async Task<bool> AddAsync(string coleccion, Transformable elemento, string clave_validar)
        {
            if (await ContieneAsync(coleccion, elemento, clave_validar))
                return false;

            return await AddAsync(coleccion, elemento);
        }
        public static async Task<bool> AddAsync(string coleccion, Transformable elemento)
        {
            string projectId = "parcialuno-b8508";
            FirestoreDb db = FirestoreDb.Create(projectId);

            if (await ContieneAsync(coleccion, elemento, "id"))
                return false;

            //var rta = await colref.AddAsync(usuarioDict);
            string id = elemento.Id.ToString();
            DocumentReference docRef = db.Collection(coleccion).Document(id);
            await docRef.SetAsync(elemento.ToDict());
            
            return true;

        }

        public static async Task<bool> ContieneAsync(string coleccion, Transformable elemento, string clave )
        {
            var elementoDict = elemento.ToDict();
            return await ContieneAsync(coleccion, elementoDict[clave], clave);
        }

        public static async Task<bool> ContieneAsync(string coleccion, object elemento, string clave)
        {
            string projectId = "parcialuno-b8508";
            FirestoreDb db = FirestoreDb.Create(projectId);

            var colref = db.Collection(coleccion);

            var query = colref.WhereEqualTo(clave, elemento);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return true;

            return false;
        }

        public static async Task<int> GetUltimoIdAsync(string coleccion)
        {
            int ultimoId = 0;

            string projectId = "parcialuno-b8508";
            FirestoreDb db = FirestoreDb.Create(projectId);

            var colref = db.Collection(coleccion);

            var query = colref.OrderByDescending("id").Limit(1);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
            {
                ultimoId = docs[0].GetValue<int>("id");
            }

            return ultimoId;

        }

}
}
