﻿using parcialUno.essentials.utilidades;
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
using System.ComponentModel;
using parcialUno.essentials.excepciones;

namespace parcialUno.essentials.models
{
    public abstract class FireBase
    {
        protected FirestoreDb _db;
        protected CollectionReference _colRef;
        public FireBase(string coleccion) 
        {
            _db = FirestoreDb.Create(Constantes.projectId);
            _colRef = _db.Collection(coleccion);
        }
        public async Task<List<Dictionary<string, object>>> GetAsync()
        {
            QuerySnapshot snapshot = await _colRef.GetSnapshotAsync();
            var docs = snapshot.Documents;
            List<Dictionary<string, object>> documentosDict = new List<Dictionary<string, object>>();

            foreach (var doc in docs)
            {
                documentosDict.Add(doc.ToDictionary());
            }

            return documentosDict;
        }

        public async Task<List<Dictionary<string, object>>> GetAsync(string clave, object valor)
        {
            List<Dictionary<string, object>> documentosDict = new List<Dictionary<string, object>>();

            var query = _colRef.WhereEqualTo(clave, valor);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            foreach (var doc in docs)
            {
                documentosDict.Add(doc.ToDictionary());
            }
            return documentosDict;
        }

        public async Task<Dictionary<string, object>> GetOneAsync(string clave, object valor)
        {

            var query = _colRef.WhereEqualTo(clave, valor);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return docs[0].ToDictionary();

            throw new ElementoNoEncontradoExeption();
        }
        public async Task<bool> ContieneAsync(ITransformable elemento, string clave)
        {
            var elementoDict = elemento.ToDict();
            return await ContieneAsync(elementoDict[clave], clave);
        }
        public  async Task<bool> ContieneAsync(object elemento, string clave)
        {
            var query = _colRef.WhereEqualTo(clave, elemento);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return true;

            return false;
        }

        public async Task<bool> AddAsync(ITransformable elemento, string clave_validar)
        {
            if (await ContieneAsync(elemento, clave_validar))
                return false;

            return await AddAsync(elemento);
        }

        public async Task<bool> AddAsync(ITransformable elemento)
        {
            if (await ContieneAsync(elemento, "id"))
                return false;

            string id = elemento.Id.ToString();
            DocumentReference docRef = _colRef.Document(id);
            await docRef.SetAsync(elemento.ToDict());

            return true;

        }

        public async Task Update(ITransformable elemento)
        {
            await ModAsync(elemento, elemento.ToDict());
        }
        public async Task ModAsync(ITransformable elemento, Dictionary<string, object> modificacion)
        {
            await ModAsync(elemento.Id, modificacion);
        }

        public async Task ModAsync(int id, Dictionary<string, object> modificacion)
        {
            var docRef = _colRef.Document(id.ToString());
            var a = await docRef.UpdateAsync(modificacion);
        }

        public async Task<int> GetUltimoIdAsync()
        {
            int ultimoId = 0;

            var query = _colRef.OrderByDescending("id").Limit(1);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
            {
                ultimoId = docs[0].GetValue<int>("id");
            }

            return ultimoId;

        }
    }
    public class ProductoFire : FireBase
    {
        public ProductoFire() : base(Constantes.ColeccionProducto) {}
    }
    public class UsuarioFire : FireBase
    {
        public UsuarioFire() : base(Constantes.ColeccionUsuarios) {}
    }
    public class VistaProductoFire : FireBase
    {
        public VistaProductoFire() : base(Constantes.ColeccionVistaProductos) {}
    }

    public class VentaFire : FireBase
    {
        public VentaFire() : base(Constantes.ColeccionVentas) { }
    }
}
