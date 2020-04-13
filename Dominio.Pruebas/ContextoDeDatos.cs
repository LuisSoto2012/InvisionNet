using System;
using System.Globalization;
using System.Linq;
using Dominio.Contexto;
using Dominio.Entidades;
using Dominio.Entidades.Compartido;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Implementacion.Adicional;
using Servicios.Implementacion.Comunes;
using Servicios.Implementacion.Laboratorio;
using Servicios.Implementacion.Medico;
using Servicios.Implementacion.Paciente;
using Servicios.Implementacion.Seguridad;
using Servicios.Implementacion.Servicios;
using Servicios.Implementacion.SubModulo;
using Servicios.Interfaces.Adicional;
using Servicios.Interfaces.Adicional.Peticiones;
using Servicios.Interfaces.Comunes;
using Servicios.Interfaces.Laboratorio;
using Servicios.Interfaces.Laboratorio.Respuestas;
using Servicios.Interfaces.Medico;
using Servicios.Interfaces.Medico.Respuestas;
using Servicios.Interfaces.Paciente;
using Servicios.Interfaces.Paciente.Peticiones;
using Servicios.Interfaces.Paciente.Respuesta;
using Servicios.Interfaces.Seguridad.Rol;
using Servicios.Interfaces.Seguridad.Rol.Peticiones;
using Servicios.Interfaces.Servicios;
using Servicios.Interfaces.SubModulo;
using Servicios.Interfaces.SubModulo.Peticiones;
using Servicios.Interfaces.Usuario;
using Servicios.Interfaces.Usuario.Peticiones;

namespace Dominio.Pruebas
{
    [TestClass]
    public class ContextoDeDatos
    {
        IGestorDeUsuarios _gestorDeUsuarios = new GestorDeUsuarios();
        IGestorDeMedicos _gestorDeMedicos = new GestorDeMedicos();
        IGestorDeServicios _gestorDeServicios = new GestorDeServicios();
        IGestorDePacientes _gestorDePacientes = new GestorDePacientes();
        IGestorDeAdicionales _gestorDeAdicionales = new GestorDeAdicionales();
        IGestorDeTomaMuestra _gestorDeLaboratorio = new GestorDeTomaMuestra();
        IGestorDeRoles _gestorDeRoles = new GestorDeRoles();
        IGestorDeComunes _gestorDeComunes = new GestorDeComunes();
        IGestorDeSubModulos _gestorDeSubModulos = new GestorDeSubModulos();

        //[TestMethod]
        //public void Creacion()
        //{
        //    using (InoBD db = new InoBD())
        //    {
        //        db.Database.Create();
        //    }
        //}

        //[TestMethod]
        //public void IngresarUsuario()
        //{
        //    using (InoBD db = new InoBD())
        //    {
        //        var rol = new Rol
        //        {
        //            Descripcion = "Administrador",
        //            IdUsuarioCreacion = 1

        //        };
        //        db.Roles.Add(rol);
        //        db.SaveChanges();

        //        var usuario = new Usuario
        //        {
        //            NombreUsuario = "Admin",
        //            Contrasena = Security.HashSHA1("Passw0rd00"),
        //            Nombres = "Admin",
        //            ApellidoPaterno = "Ino",
        //            ApellidoMaterno = "Web",
        //            IdEmpleado = 1,
        //            IdUsuarioCreacion = 1
        //        };
        //        db.Usuarios.Add(usuario);
        //        usuario.Rol.Add(rol);
        //        db.SaveChanges();
        //    }
        //}

        [TestMethod]
        public void InicializarMapas()
        {
            Infraestructura.Transformacion.Configuracion.InicializarMapas();
        }

        [TestMethod]
        public void ListarCombo()
        {
            string fullMonthName = new DateTime(2020, 2, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            var combo = _gestorDeComunes.ListarAreaLaboratorio(12);
            Assert.IsNotNull(combo);
        }

        //[TestMethod]
        //public void AsignarRolSubModulo()
        //{
        //    RolSubModuloDto rolSubModuloDto = new RolSubModuloDto
        //    {
        //        IdRolSubModulo = 1,
        //        IdRol = 1,
        //        IdSubModulo = 3,
        //        Ver = true,
        //        Agregar = true,
        //        Editar = false,
        //        Eliminar = false,
        //        EsActivo = true,
        //        IdUsuarioRegistra = 1,
        //    };
        //    var result = _gestorDeSubModulos.AsignarRolSubModulo(rolSubModuloDto);
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void CrearRoles()
        //{
        //    NuevoRol peticionDeCreacion = new NuevoRol
        //    {
        //        Nombre = "Nuevo2",
        //        IdUsuarioCreacion = 1
        //    };
        //    var rol = _gestorDeRoles.Crear(peticionDeCreacion);
        //    Assert.IsNotNull(rol);
        //}

        //[TestMethod]
        //public void ActualizarRoles()
        //{
        //    ActualizarRol peticionDeActualizacion = new ActualizarRol
        //    {
        //        IdRol = 4,
        //        Nombre = "Medico",
        //        IdUsuarioModificacion = 2,
        //        EsActivo = false
        //    };
        //    var rol = _gestorDeRoles.Actualizar(peticionDeActualizacion);
        //    Assert.IsNotNull(rol);
        //}

        //[TestMethod]
        //public void ListarRoles()
        //{
        //    var rol = _gestorDeRoles.Listar();
        //    Assert.IsNotNull(rol);
        //}

        //[TestMethod]
        //public void CrearEmpleado()
        //{
        //    NuevoEmpleado peticionDeCreacion = new NuevoEmpleado
        //    {
        //        ApellidoPaterno = "Informatica",
        //        ApellidoMaterno = "Informatica",
        //        Nombres = "Informatica",
        //        Correo = "Informatica@gmail.com",
        //        IdCondicionTrabajo = 1,
        //        IdTipoEmpleado = 1,
        //        IdTipoDocumento = 1,
        //        NumeroDocumento = "654321",
        //        CodigoPlanilla = "654321",
        //        Usuario = "admin",
        //        Contrasena = "Passw0rd00",
        //        FechaNacimiento = DateTime.Now,
        //        IdUsuarioCreacion = 1,
        //        IdRoles = "2",
        //        UsuarioGaleno = false
        //    };
        //    var empleado = _gestorDeUsuarios.Crear(peticionDeCreacion);
        //    Assert.IsNotNull(empleado);
        //}

        //[TestMethod]
        //public void ActualizarEmpleado()
        //{
        //    ActualizarEmpleado peticionDeActualizacion = new ActualizarEmpleado
        //    {
        //        IdEmpleado = 1,
        //        ApellidoPaterno = "Zevallos2",
        //        ApellidoMaterno = "Lecca2",
        //        Nombres = "Giancarlo2",
        //        Correo = "giancarlo@gmail.com2",
        //        IdCondicionTrabajo = 1,
        //        IdTipoEmpleado = 1,
        //        IdTipoDocumento = 1,
        //        NumeroDocumento = "47551036",
        //        CodigoPlanilla = "123456",
        //        Contrasena = "123456",
        //        FechaNacimiento = DateTime.Now,
        //        IdRoles = "2,3,5",
        //        EsActivo = true,
        //        IdUsuarioModificacion = 1,
        //        UsuarioGaleno = false
        //    };
        //    var empleado = _gestorDeUsuarios.Actualizar(peticionDeActualizacion);
        //    Assert.IsNotNull(empleado);
        //}

        //[TestMethod]
        //public void Login()
        //{
        //    string Usuario = "Admin";
        //    string Clave = Security.HashSHA1("Passw0rd00");
        //    var usuarioLogin = _gestorDeUsuarios.Login(Usuario, Clave);
        //    var roles = usuarioLogin.Rol.FirstOrDefault();
        //    Assert.AreEqual("Informatica", usuarioLogin.Nombres);
        //}

        //[TestMethod]
        //public void ListarCombo()
        //{
        //    var combo = _gestorDeComunes.ListarCondicionTrabajo();
        //    Assert.IsNotNull(combo);
        //}

        //[TestMethod]
        //public void ListarMedicos()
        //{
        //    MedicoListar medico = new MedicoListar
        //    {
        //        IdEmpleado = 1880
        //    };
        //    var medicos = _gestorDeMedicos.ListarMedicos(medico);
        //    Assert.AreEqual(273, medicos[1].IdMedico);
        //}

        //[TestMethod]
        //public void ListarEspecialidadPorMedico()
        //{
        //    MedicoListar medico = new MedicoListar
        //    {
        //        IdMedico = 1
        //    };
        //    var especialidad = _gestorDeMedicos.ListarEspecialidadPorMedico(medico);
        //    Assert.AreEqual(310, especialidad[1].IdEspecialidad);
        //}

        //[TestMethod]
        //public void ListarServicioPorEspecialidad()
        //{
        //    MedicoPorEspecialidad especialidad = new MedicoPorEspecialidad
        //    {
        //        IdEspecialidad = 310
        //    };
        //    var servicio = _gestorDeServicios.ListarServicioPorEspecialidad(especialidad);
        //    Assert.AreEqual(622, servicio[0].IdServicio);
        //}

        //[TestMethod]
        //public void ListarPacientePorHcDni()
        //{
        //    PacientePorHcDni paciente = new PacientePorHcDni
        //    {
        //        NroHistoriaClinica = 158871
        //    };
        //    var pacienteHcDni = _gestorDePacientes.ListarPacientePorHcDni(paciente);
        //    Assert.AreEqual("ALVARADO VASQUEZ, HERMAN", pacienteHcDni.Paciente.Trim());
        //}

        //[TestMethod]
        //public void ListarPacientesCitadosPorEspecialidadMedicoFecha()
        //{
        //    BuscarPaciente paciente = new BuscarPaciente
        //    {
        //        Fecha = new DateTime(2019, 3, 18),
        //        IdMedico = 121,
        //        IdEspecialidad = 305
        //    };
        //    var pacientesCitados = _gestorDePacientes.ListarPacientesCitadosPorEspecialidadMedicoFecha(paciente);
        //    Assert.AreEqual(65885, pacientesCitados[0].NroHistoriaClinica);
        //}

        //[TestMethod]
        //public void ConsultaExternaAdicionalesPorMedicoListar()
        //{
        //    BuscarPaciente paciente = new BuscarPaciente
        //    {
        //        Fecha = new DateTime(2019, 2, 25),
        //        IdMedico = 60,
        //        IdEspecialidad = 311
        //    };
        //    var adicionales = _gestorDeAdicionales.ConsultaExternaAdicionalesPorMedicoListar(paciente);
        //    Assert.AreEqual("798937", adicionales[0].Hc);
        //}

        //[TestMethod]
        //public void ConsultaExternaAdicionalesPorMedicoRegistrar()
        //{
        //    NuevaAdicional nuevaAdicional = new NuevaAdicional
        //    {
        //        Hc = "798937",
        //        Paciente = "REBATTA TRILLO, JORGE SANTOS",
        //        IdEspecialidad = 311,
        //        IdServicio = 10,
        //        IdMedico = 60,
        //        FechaAdicional = new DateTime(2019, 3, 19),
        //        FechaRegistro = new DateTime(2019, 2, 19),
        //        IdUsuario = 1
        //    };
        //    var adicionales = _gestorDeAdicionales.ConsultaExternaAdicionalesPorMedicoRegistrar(nuevaAdicional);
        //    Assert.IsNotNull(nuevaAdicional);
        //}

        //[TestMethod]
        //public void AgregarIncidentesPacientes()
        //{
        //    IncidentesPacientesGeneral incidentesPacientesGeneral = new IncidentesPacientesGeneral
        //    {
        //        HistoriaClinica = "798937",
        //        NumeroDocumento = "47551036",
        //        Paciente = "JuanCarlos Gomez",
        //        Incidentes = "Problemas con la historia clinica"
        //    };
        //    var NuevoIncidentesPacientes = _gestorDeLaboratorio.AgregarIncidentesPacientes(incidentesPacientesGeneral);
        //    Assert.IsNotNull(NuevoIncidentesPacientes);
        //}

        //[TestMethod]
        //public void ListaIncidentesPacientes()
        //{
        //    var listaIncidentesPacientes = _gestorDeLaboratorio.ListaIncidentesPacientes();
        //    Assert.IsNotNull(listaIncidentesPacientes);
        //}

        //[TestMethod]
        //public void Listar()
        //{
        //    var listaUsuarios = _gestorDeUsuarios.Listar();
        //    Assert.IsNotNull(listaUsuarios);
        //}

        //[TestMethod]
        //public void Crear()
        //{
        //    NuevoUsuario usuario = new NuevoUsuario
        //    {
        //        NombreUsuario = "g10n22",
        //        Contrasena = "1234",
        //        Nombres = "Giancarlo",
        //        ApellidoPaterno = "Zevallos",
        //        ApellidoMaterno = "Lecca",
        //        IdEmpleado = 1,
        //        IdRol = 1,
        //        IdUsuarioCreacion = 1,
        //        EsActivo = true,
        //    };

        //    var listaIncidentesPacientes = _gestorDeUsuarios.Crear(usuario);
        //    Assert.IsNotNull(listaIncidentesPacientes);
        //}

        //[TestMethod]
        //public void Borrar()
        //{
        //    var usuarioEliminado = _gestorDeUsuarios.Borrar(1408);
        //    Assert.IsNotNull(usuarioEliminado);
        //}

        //[TestMethod]
        //public void Actualizar()
        //{
        //    ActualizarUsuario usuario = new ActualizarUsuario
        //    {
        //        IdUsuario = 1408,
        //        Contrasena = "1234",
        //        Nombres = "Giancarlo2",
        //        ApellidoPaterno = "Zevallos2",
        //        ApellidoMaterno = "Lecca2",
        //        IdEmpleado = 4,
        //        IdRoles = "1,2,3",
        //        IdUsuarioModificacion = 2,
        //        EsActivo = true,
        //    };

        //    var listaIncidentesPacientes = _gestorDeUsuarios.Actualizar(usuario);
        //    Assert.IsNotNull(listaIncidentesPacientes);
        //}
    }
}
