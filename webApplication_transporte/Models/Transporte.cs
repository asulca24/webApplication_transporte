using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApplication_transporte.Models
{
    public class Transporte
    {
        public string num_guia { get; set; }
        public DateTime fecha_guia { get; set; }
        public string cliente {  get; set; }
        public string carga {  get; set; }
        public double TM { get; set; }
        public double tarifa { get; set; }

        public Transporte () {
            num_guia = "";
            fecha_guia= DateTime.Today;
            cliente = "";
            carga = "";
            TM = 0;
            tarifa = 150;
        
        }
        public double Costo()
        {
            return tarifa * TM;
        }
        public double Seguro()
        {
            return 0.02 * Costo();
        }
        public double Monto()
        {
            return Costo() + Seguro();
        }
        public double IGV()
        {
            return 0.18 * Monto();
        
        }
        public double MontoTotal()
        {
            return Monto() + IGV();        
        }

    }
}