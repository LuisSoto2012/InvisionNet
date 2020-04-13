using Servicios.Interfaces.Auditoria.Peticiones;

namespace Servicios.Interfaces.Auditoria
{
    public interface IGestorDeAuditoria
    {
        void AgregarAuditoria(AuditoriaGeneral auditoria);
    }
}
