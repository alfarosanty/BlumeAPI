using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RemitoIngresoServices
    {    
        public void  crear(RemitoIngreso remito, Npgsql.NpgsqlConnection npgsqlConnection)
        {
            //guardar RemitoIngreso
            string sqlInsert = "INSERT INTO " + RemitoIngreso.TABLA + "(FECHA, ID_FABICANTE, DESCRIPCION) VALUES(@FECHA,@FABRICANTE,@DESCRIPCION)";

            NpgsqlCommand cmd = new NpgsqlCommand(sqlInsert, npgsqlConnection);
            {
                cmd.Parameters.AddWithValue("FECHA",remito.Fecha);
                cmd.Parameters.AddWithValue("FABRICANTE",remito.Taller.Id);
                cmd.Parameters.AddWithValue("DESCRIPCION",remito.Descripcion);
                 cmd.ExecuteNonQueryAsync();
            }
            //Guardar ArticuloIngreso
            //Guardar
        }

        public void modificar(RemitoIngreso remito){
            


            //Actualizar RemitoIngreso
            //Actualziar ArticuloIngreso
            //Guardar
        }


    }

