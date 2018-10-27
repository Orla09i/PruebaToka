using Autos_ABC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Autos_ABC.Repository
{
    public class AutosRepository
    {
        private SqlConnection con;
        //Manejo de conexiones   
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        //Agregar Auto    
        public bool AgregarAuto(AutoModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AgregarAuto", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Marca", obj.Marca);
            com.Parameters.AddWithValue("@Modelo", obj.Modelo);
            com.Parameters.AddWithValue("@Folio", obj.Folio);
            com.Parameters.AddWithValue("@Color", obj.Color);
            com.Parameters.AddWithValue("@Transmision", obj.Transmision);
            com.Parameters.AddWithValue("@Descripcion", obj.Descripcion);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
        //Obtener Lista de autos    
        public List<AutoModel> ObtenerAuto()
        {
            connection();
            List<AutoModel> AutosList = new List<AutoModel>();


            SqlCommand com = new SqlCommand("ObtenerAutos", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
  
            foreach (DataRow dr in dt.Rows)
            {

                AutosList.Add(

                    new AutoModel
                    {

                        IdAuto = Convert.ToInt32(dr["IdAuto"]),
                        Marca = Convert.ToString(dr["Marca"]),
                        Modelo = Convert.ToString(dr["Modelo"]),
                        Folio = Convert.ToString(dr["Folio"]),
                        Color = Convert.ToString(dr["Color"]),
                        Transmision = Convert.ToBoolean(dr["Transmision"]),
                        Descripcion = Convert.ToString(dr["Descripcion"])


                    }


                    );


            }

            return AutosList;

        }

        //Actualizar Auto   
        public bool ActualizarAuto(AutoModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("ActualizarAuto", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdAuto", obj.IdAuto);
            com.Parameters.AddWithValue("@Marca", obj.Marca);
            com.Parameters.AddWithValue("@Modelo", obj.Modelo);
            com.Parameters.AddWithValue("@Folio", obj.Folio);
            com.Parameters.AddWithValue("@Color", obj.Color);
            com.Parameters.AddWithValue("@Transmision", obj.Transmision);
            com.Parameters.AddWithValue("@Descripcion", obj.Descripcion);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        //Borrar Auto  
        public bool BorrarAuto(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("BorrarAuto", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdAuto", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
    }
}