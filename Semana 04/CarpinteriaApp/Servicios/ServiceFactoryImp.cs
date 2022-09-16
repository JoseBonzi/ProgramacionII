using CarpinteriaApp.Servicios.Implementaciones;
using CarpinteriaApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Servicios
{
    internal class ServiceFactoryImp :AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new PresupuestoService();
        }
    }  
}
