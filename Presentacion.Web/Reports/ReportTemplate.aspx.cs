using Microsoft.Reporting.WebForms;
using Presentacion.Web.Models;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace Presentacion.Web.Reports
{
    public partial class ReportTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String reportFolder = System.Configuration.ConfigurationManager.AppSettings["SSRSReportFolder"].ToString();
                    String reportServerUrl = System.Configuration.ConfigurationManager.AppSettings["SSRSReportServerUrl"].ToString();

                    // Credenciales para el acceso al SSRS
                    String credentialUser = System.Configuration.ConfigurationManager.AppSettings["CredentialUser"].ToString();
                    String credentialPassword = System.Configuration.ConfigurationManager.AppSettings["CredentialPassword"].ToString();
                    String credentialDomain = System.Configuration.ConfigurationManager.AppSettings["CredentialDomain"].ToString();

                    IReportServerCredentials irsc = new CustomReportCredentials(credentialUser, credentialPassword, credentialDomain);
                    rvSiteMapping.ServerReport.ReportServerCredentials = irsc;

                    rvSiteMapping.Height = Unit.Pixel(Convert.ToInt32(Request["Height"]) - 58);
                    rvSiteMapping.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;

                    rvSiteMapping.ServerReport.ReportServerUrl = new Uri(reportServerUrl); // Add the Reporting Server URL
                    rvSiteMapping.ServerReport.ReportPath = String.Format("/{0}/{1}", reportFolder, Request["ReportName"].ToString());

                    //Deshabilitar botones de descarga
                    DeshabilitarBotonesDescarga("PPTX");
                    DeshabilitarBotonesDescarga("MHTML");
                    DeshabilitarBotonesDescarga("XML");
                    DeshabilitarBotonesDescarga("ATOM");
                    DeshabilitarBotonesDescarga("RGDI");
                    DeshabilitarBotonesDescarga("HTML4.0");
                    DeshabilitarBotonesDescarga("RPL");
                    CambiarNombreBotonDescarga("IMAGE", "Imagen");

                    //Pasando Parametros:
                    if (Request["ReportParameters"] != "undefined")
                    {
                        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                        dynamic parametros = jsonSerializer.Deserialize<dynamic>(Request["ReportParameters"]);
                        int numberParameters = parametros.Count;
                        ReportParameter[] parameters = new ReportParameter[numberParameters];

                        int i = 0;
                        if(numberParameters > 0)
                        {
                            foreach (var parametro in parametros)
                            {
                                parameters[i] = new ReportParameter(parametro.Key, parametro.Value.ToString());
                                i++;
                            }

                            rvSiteMapping.ShowParameterPrompts = false;
                            rvSiteMapping.ServerReport.SetParameters(parameters);
                        }
                    }

                    rvSiteMapping.ServerReport.Refresh();
                }
                catch (Exception ex)
                {
                    Regex reg = new Regex("Parameter (.*) does not exist on this report");
                    Match match = reg.Match(ex.Message.ToString());
                    if (match.Success)
                    {
                        var valor = match.Groups[1].Value;
                        ReportErrorMessage.Text = "Ocurrió un problema: El parámetro " + valor + " no existe en este reporte";
                    }
                    else
                    {
                        ReportErrorMessage.Text = "Ocurrió un problema: " + ex.Message.ToString();
                    }
                    ReportErrorMessage.Visible = true;
                }
            }
        }

        public void DeshabilitarBotonesDescarga(string nombreBoton)
        {
            FieldInfo visible;
            foreach (RenderingExtension extension in rvSiteMapping.ServerReport.ListRenderingExtensions())
            {
                if (extension.Name == nombreBoton)
                {
                    visible = extension.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
                    visible.SetValue(extension, false);
                }
            }
        }

        public void CambiarNombreBotonDescarga(string nombreBoton, string nuevoNombre)
        {
            FieldInfo nombre;
            foreach (RenderingExtension extension in rvSiteMapping.ServerReport.ListRenderingExtensions())
            {
                if (extension.Name == nombreBoton)
                {
                    nombre = extension.GetType().GetField("m_localizedName", BindingFlags.Instance | BindingFlags.NonPublic);
                    nombre.SetValue(extension, nuevoNombre);
                }
            }
        }
    }
}