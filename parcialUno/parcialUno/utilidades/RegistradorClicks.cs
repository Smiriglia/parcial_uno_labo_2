﻿using parcialUno.essentials.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace parcialUno.utilidades
{
    public class RegistradorClicks
    {
        int _idUsuario;
        public bool Activo { get; set; }
        public RegistradorClicks(int idUsuario, ControlCollection controls)
        {
            _idUsuario = idUsuario;
            Activo = true;
            agregarEventoControls(controls);


        }
        
        private void agregarEventoControls(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Controls != null)
                {
                    agregarEventoControls(control.Controls);
                }
                control.Click += Registrar;
            }
        }

        private async void Registrar(object sender, EventArgs e)
        {
            if (Activo)
            {
                var senderCasteado = (Control)sender;
                var click = await ClickFactory.CrearAsync(_idUsuario, senderCasteado.Name);
                if (click != null)
                    await click.AddFireAsync();
            }
        }
    }
}
