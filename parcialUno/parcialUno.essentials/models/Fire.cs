using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Fire
    {
        public static async Task<string> Add()
        {
            //parcialuno-b8508
            string projectId = "parcialuno-b8508";
            FirestoreDb db = FirestoreDb.Create(projectId);

            var docref = db.Document("usuarios/1");

            var doc = await docref.GetSnapshotAsync();

            return doc.GetValue<string>("nombre");

        }
    }
}
