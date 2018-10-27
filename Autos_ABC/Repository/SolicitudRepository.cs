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
    public class SolicitudRepository
    {
        private SqlConnection con;
        //Manejo de conexiones   
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        //Agregar Solicitud    
        public bool AgregarSolicitud(SolicitudModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AgregarSolicitud", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Fecha", obj.Fecha);
            com.Parameters.AddWithValue("@NumeroLote", obj.NumeroLote);
            com.Parameters.AddWithValue("@IdAuto", obj.Auto);


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
        //Obtener Lista de Solicitud
        public List<SolicitudModel> ObtenerSolicitud()
        {
            connection();
            List<SolicitudModel> SolicitudList = new List<SolicitudModel>();


            SqlCommand com = new SqlCommand("ObtenerSolicitudList", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {

                SolicitudList.Add(

                    new SolicitudModel
                    {
                       IdSolicitud = Convert.ToInt32(dr["IdSolicitud"]),
                        Fecha = Convert.ToString(dr["Fecha"]),
                        NumeroLote = Convert.ToString(dr["NumeroLote"]),
                        ModeloAuto = Convert.ToString(dr["Modelo"]),
                        MarcaAuto = Convert.ToString(dr["Marca"]),
                        FolioAuto = Convert.ToString(dr["Folio"])

                    }


                    );


            }

            return SolicitudList;

        }

        //Actualizar Solicitud 
        public bool ActualizarSolicitud(SolicitudModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("ActualizarSolicitud", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdSolicitud", obj.IdSolicitud);
            com.Parameters.AddWithValue("@Fecha", obj.Fecha);
            com.Parameters.AddWithValue("@NumeroLote", obj.NumeroLote);
            com.Parameters.AddWithValue("@IdAuto", obj.Auto);

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

        //Borrar Solicitud 
        public bool BorrarSolicitud(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("BorrarSolicitud", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@IdSolicitud", Id);

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

        //Obtener Lista de Solicitud
        public List<SolicitudModel> ObtenerAutosList()
        {
            connection();
            List<SolicitudModel> AutosList = new List<SolicitudModel>();


            SqlCommand com = new SqlCommand("ObtenerAutosList", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {

                AutosList.Add(

                    new SolicitudModel
                    {
                        Auto = Convert.ToInt32(dr["IdAuto"]),
                        FolioAuto = Convert.ToString(dr["Folio"]),
                    }


                    );


            }

            return AutosList;

        }
    }
}