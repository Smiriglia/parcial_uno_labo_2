using parcialUno.essentials.utilidades;
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
    /// <summary>
    /// Clase base abstracta para interactuar con Firebase Firestore.
    /// </summary>
    public abstract class FireBase
    {
        protected FirestoreDb _db;
        protected CollectionReference _colRef;

        /// <summary>
        /// Constructor de la clase FireBase. Crea la conexion con la base que estamos trabajando
        /// y la conexion en la coleccion en la que estamos trabajando
        /// </summary>
        /// <param name="coleccion">Nombre de la colección en Firestore.</param>
        public FireBase(string coleccion) 
        {
            _db = FirestoreDb.Create(Constantes.projectId);
            _colRef = _db.Collection(coleccion);
        }

        /// <summary>
        /// Obtiene una lista de documentos en la colección.
        /// </summary>
        /// <returns>Lista de diccionarios que representan los documentos.</returns>
        public async virtual Task<List<Dictionary<string, object>>> GetAsync()
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

        /// <summary>
        /// Obtiene una lista de documentos en la colección que cumplan con la condicion
        /// de que en el campo con el nombre de la clave dada sea igual al valor dado
        /// </summary>
        /// <param name="clave">Clave del campo a comparar.</param>
        /// <param name="valor">Valor a comparar.</param>
        /// <returns>Lista de diccionarios que representan los documentos que cumplen la condición.</returns>
        public async virtual Task<List<Dictionary<string, object>>> GetAsync(string clave, object valor)
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


        /// <summary>
        /// Obtiene un documento en la colección que cumpla con umplan con la condicion
        /// de que en el campo con el nombre de la clave dada sea igual al valor dado
        /// </summary>
        /// <param name="clave">Clave del campo a comparar.</param>
        /// <param name="valor">Valor a comparar.</param>
        /// <returns>Diccionario que representa el documento que cumple la condición.</returns>
        public async virtual Task<Dictionary<string, object>> GetOneAsync(string clave, object valor)
        {

            var query = _colRef.WhereEqualTo(clave, valor);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return docs[0].ToDictionary();

            throw new ElementoNoEncontradoExeption();
        }

        /// <summary>
        /// Verifica si la colección contiene un elemento que cumpla con cumplan con la condicion
        /// de que en el campo con el nombre de la clave dada sea igual al valor que contiene el
        /// elemento en el campo dado
        /// </summary>
        /// <param name="elemento">Elemento a buscar la coincidencia.</param>
        /// <param name="clave">Clave del campo a comparar.</param>
        /// <returns>true si la colección contiene un elemento que cumple la condición, de lo contrario false.</returns>
        public async virtual Task<bool> ContieneAsync(ITransformable elemento, string clave)
        {
            var elementoDict = elemento.ToDict();
            return await ContieneAsync(elementoDict[clave], clave);
        }

        /// <summary>
        /// Verifica si la colección contiene un elemento que cumpla con cumplan con la condicion
        /// de que en el campo con el nombre de la clave dada sea igual al valor dado
        /// </summary>
        /// <param name="elemento">Elemento a buscar la coincidencia.</param>
        /// <param name="clave">Clave del campo a comparar.</param>
        /// <returns>true si la colección contiene un elemento que cumple la condición, de lo contrario false.</returns>
        public async virtual Task<bool> ContieneAsync(object elemento, string clave)
        {
            var query = _colRef.WhereEqualTo(clave, elemento);

            var resultado = await query.GetSnapshotAsync();

            var docs = resultado.Documents;

            if (docs.Count > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Agrega un nuevo elemento a la colección. Si alguno el elemento no coincide con
        /// un elemento ya creado en el valor de la clave dada
        /// </summary>
        /// <param name="elemento">El elemento a agregar. Debe implementar la interfaz ITransformable.</param>
        /// <param name="clave_validar">La clave utilizada para validar la existencia del elemento en la colección.</param>
        /// <returns>
        /// true si se agregó exitosamente el elemento.
        /// false si el elemento ya existe en la colección.
        /// </returns>
        public async virtual Task<bool> AddAsync(ITransformable elemento, string clave_validar)
        {
            if (await ContieneAsync(elemento, clave_validar))
                return false;

            return await AddAsync(elemento);
        }

        /// <summary>
        /// Agrega un nuevo elemento a la colección. Si la id no coincide con un elemento ya creado
        /// </summary>
        /// <param name="elemento">El elemento a agregar. Debe implementar la interfaz ITransformable.</param>
        /// <returns>
        /// true si se agregó exitosamente el elemento.
        /// false si el elemento ya existe en la colección.
        /// </returns>
        public async virtual Task<bool> AddAsync(ITransformable elemento)
        {
            if (await ContieneAsync(elemento, "id"))
                return false;

            string id = elemento.Id.ToString();
            DocumentReference docRef = _colRef.Document(id);
            await docRef.SetAsync(elemento.ToDict());

            return true;

        }

        /// <summary>
        /// Actualiza un elemento existente en la colección.
        /// </summary>
        /// <param name="elemento">El elemento a actualizar. Debe implementar la interfaz ITransformable.</param>
        public async virtual Task Update(ITransformable elemento)
        {
            await ModAsync(elemento, elemento.ToDict());
        }

        /// <summary>
        /// Modifica un elemento existente en la colección con una lista de modificaciones.
        /// </summary>
        /// <param name="elemento">El elemento a modificar. Debe implementar la interfaz ITransformable.</param>
        /// <param name="modificacion">La lista de modificaciones representada como un diccionario de pares clave-valor.</param>
        /// <returns>Una tarea que representa la operación de modificación.</returns>
        public async virtual Task ModAsync(ITransformable elemento, Dictionary<string, object> modificacion)
        {
            await ModAsync(elemento.Id, modificacion);
        }

        /// <summary>
        /// Modifica un elemento existente en la colección con una lista de modificaciones.
        /// </summary>
        /// <param name="id">El ID del elemento a modificar.</param>
        /// <param name="modificacion">Las modificaciones representadas como un diccionario.</param>
        /// <returns>Una tarea que representa la operación de modificación.</returns>
        public async virtual Task ModAsync(int id, Dictionary<string, object> modificacion)
        {
            var docRef = _colRef.Document(id.ToString());
            var a = await docRef.UpdateAsync(modificacion);
        }

        /// <summary>
        /// Obtiene el último ID de la colección.
        /// </summary>
        /// <returns>El último ID de la colección.</returns>
        public async virtual Task<int> GetUltimoIdAsync()
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

    /// <summary>
    /// Clase que representa la colección de Productos en Firestore.
    /// </summary>
    public class ProductoFire : FireBase
    {
        public ProductoFire() : base(Constantes.ColeccionProducto) {}
    }

    /// <summary>
    /// Clase que representa la colección de Usuarios en Firestore.
    /// </summary>
    public class UsuarioFire : FireBase
    {
        public UsuarioFire() : base(Constantes.ColeccionUsuarios) {}
    }

    /// <summary>
    /// Clase que representa la colección de VistaProductos en Firestore.
    /// </summary>
    public class VistaProductoFire : FireBase
    {
        public VistaProductoFire() : base(Constantes.ColeccionVistaProductos) {}
    }

    /// <summary>
    /// Clase que representa la colección de Ventas en Firestore.
    /// </summary>
    public class VentaFire : FireBase
    {
        public VentaFire() : base(Constantes.ColeccionVentas) { }
    }

    public class ClickFire : FireBase
    {
        public ClickFire() : base(Constantes.ColeccionClicks) { }
    }
}
