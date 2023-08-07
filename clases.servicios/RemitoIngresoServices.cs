using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RemitoIngresoServices
    {    

        public RemitoIngreso GetRemitosIngreso(int id, NpgsqlConnection conex ){
            string commandText = $"SELECT * FROM \" "+ RemitoIngreso.TABLA + "\"WHERE \"ID_"+ Cliente.TABLA + "\" = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conex))
                {
                    Console.WriteLine("Consulta: "+ commandText);
                    cmd.Parameters.AddWithValue("id", id);
                     using (NpgsqlDataReader reader =  cmd.ExecuteReader()){
                            RemitoIngreso remitoIngreso = new RemitoIngreso{};
                            while (reader.Read())
                            {
                                remitoIngreso.Articulos.Add(ReadArticulos(reader));
                                
                            }
                        }
                }
                return null;
                }

        public List<ArticuloIngreso> listarArticulos(NpgsqlConnection conex )
    {
        
        string commandText = getSelect() +  GetFromText();

        List<ArticuloIngreso> articulos = new List<ArticuloIngreso>();
        using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conex))
        {

            Console.WriteLine("Consulta: " + commandText);
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    articulos.Add(ReadArticulos(reader));

                }

        }
        return articulos;

        static string getSelect()
        {
            return  $"SELECT CL.* ,CF.\"CODIGO\" AS CF_CODIGO, CF.\"DESCRIPCION\" AS CF_DESCRIPCION ";
            
        }
    }

    private static string GetFromText()
    {
        return "FROM \"CLIENTE\" CL,\"CONDICION_AFIP\" CF ";
    }




    private static ArticuloIngreso ReadArticulos(NpgsqlDataReader reader)
        {
            int? id = reader["ID_" + Cliente.TABLA] as int?;
            string rs = reader["CODIGO"] as string;
            string tel = reader["DESCRIPCION"] as string;
            
            
            
            //string contacto = reader["CONTACTO"] as string;
            

            Color color =new Color{};
            Medida medida = new Medida{};
            Familia familia = new Familia{};

             int? cfId = reader["ID_CONDICION_AFIP"] as int?;            
            string cfCodigo = reader["CF_CODIGO"] as string;   
            string cfDescripcion = reader["CF_DESCRIPCION"] as string;   
            
            int? cantidad = reader["CANTIDAD"] as int?;            


            CondicionFiscal cf = new CondicionFiscal
            {
                Id = cfId.Value,
                Codigo =    cfCodigo,
                Descripcion = cfDescripcion
            };     
            Articulo articulo = new Articulo
            {
                Id = id.Value,
                Codigo = cfCodigo,
                Descripcion = cfDescripcion,
                Color = color,
                Medida = medida,
                Familia = familia

            };
            ArticuloIngreso artIng = new ArticuloIngreso();
            artIng.articulo = articulo;
            artIng.cantidad = (int)cantidad;
            return artIng;

            

            
        }


        public void crear(RemitoIngreso remito, Npgsql.NpgsqlConnection npgsqlConnection){
            //guardar RemitoIngreso
            //Guardar ArticuloIngreso
            //Guardar
        }

        public void modificar(RemitoIngreso remito){
            //Actualizar RemitoIngreso
            //Actualziar ArticuloIngreso
            //Guardar
        }


    }

