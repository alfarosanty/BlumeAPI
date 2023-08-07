using Microsoft.AspNetCore.Mvc;

namespace BlumeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RemitoIngresoController : ControllerBase
{

    private readonly ILogger<ClienteController> _logger;

    public RemitoIngresoController(ILogger<ClienteController> logger)
    {
        _logger = logger;
    }
/*
    [HttpGet(Name = "GetRemitoIngreso")]
    public IEnumerable<RemitoIngreso> Get()
    {
        CConexion con =  new CConexion();
        Npgsql.NpgsqlConnection npgsqlConnection = con.establecerConexion();
        //List<Cliente> articulos = new ClienteServices().listarClientes(npgsqlConnection);
        con.cerrarConexion(npgsqlConnection);
        return null;
    }
*/
 
    [HttpPost(Name = "CrearRemitoIngreso")]
    public void Crear(string idTaller, string descripcion, string fecha,IEnumerable<ArticuloCantidad> ri){
        CConexion con =  new CConexion();
        Npgsql.NpgsqlConnection npgsqlConnection = con.establecerConexion();

        //obtener taller
        //obtener fecha
        //obtener descripcion
        //listar articulos y cantidades
        //
       // TallerServices tallerServices = new TallerServices();
        RemitoIngreso remitoIngreso = new RemitoIngreso();
      //  string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
    //    TallerServices ts = new TallerServices();
    
     //   TallerServices tallerServices = new TallerServices();
        // ts = new Tallerservices();
        //Taller taller = ts.Get("1");
        //remitoIngreso.taller = taller;
        //remitoIngreso.fecha = DateTime.UtcNow





        con.cerrarConexion(npgsqlConnection);
    }

}
