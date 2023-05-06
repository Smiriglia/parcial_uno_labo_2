﻿using parcialUno.essentials.abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Usuario : Transformable
    {
        private int _id;
        private string _nombre;
        private string _username;
        private string _password;
        private float _dinero;
        private string _sector;


        public override int Id { get { return _id; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public float Dinero { get { return _dinero; } }
        public string Nombre { get { return _nombre; } }

        public string Sector { get { return _sector; } set { _sector = value; } }

        public Usuario(Dictionary<string, object> usuarioDict) :
            this((int)(long)usuarioDict["id"],
                (string) usuarioDict["nombre"],
                (string)usuarioDict["username"],
                (string) usuarioDict["password"],
                (string) usuarioDict["sector"])
        {
            
        }

        public Usuario(int id, string nombre, string username, string password, string sector)
        {
            _id = id;
            _nombre = nombre;
            _username = username;
            _password = password;
            _sector = sector;
        }

        public Usuario(int id, string nombre, string username, string password) : this(id, nombre, username, password, "comprador")
        {
            
        }

        public static bool ValidarUsuario(List<Usuario> usuarios, string username, string password)
        {

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.login(username, password))
                    return true;
            }
            return false;
        }

        public static Usuario? BuscarUsuario(List<Usuario> usuarios, string username, string password)
        {

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.login(username, password))
                    return usuario;
            }
            return null;
        }

        public bool login(string username, string password)
        {
            return username == _username && password == _password;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Username: {Username}");
            sb.AppendLine($"Contraseña: {Password}");
            sb.AppendLine($"Dinero: {Dinero}");
            return sb.ToString();
        }

        public override Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> usuarioDict = new()
            {
                {"id", Id},
                {"username", Username},
                {"password", Password},
                {"dinero", Dinero },
                {"nombre", Nombre },
                {"sector", Sector }
            };

            return usuarioDict;
        }
    }
}
