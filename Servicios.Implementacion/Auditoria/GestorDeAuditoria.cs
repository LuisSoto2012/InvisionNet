using AutoMapper;
using Dominio.Contexto;
using Servicios.Interfaces.Auditoria;
using Servicios.Interfaces.Auditoria.Peticiones;
using System.Linq;

namespace Servicios.Implementacion.Auditoria
{
    public class GestorDeAuditoria : IGestorDeAuditoria
    {
        public void AgregarAuditoria(AuditoriaGeneral auditoriaGeneral)
        {
            using (InoBD db = new InoBD())
            {
                Dominio.Entidades.Auditoria auditoria = Mapper.Map<Dominio.Entidades.Auditoria>(auditoriaGeneral);
                auditoria.IpLogueo = db.Empleados.Where(x => x.IdEmpleado == auditoriaGeneral.IdUsuario).FirstOrDefault().LoginIp;
                db.Auditoria.Add(auditoria);
                db.SaveChanges();
            }
        }
    }
}
