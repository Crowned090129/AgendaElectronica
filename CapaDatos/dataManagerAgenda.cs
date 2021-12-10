using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class DataManager
    {
        string connString = "Data Source=LP-RCORONADO;Initial Catalog=DB_AGENDA_APP;User Id=sa;Password=12345678;Integrated Security=True;";

        public List<Agenda> GetFromDb(Agenda agenda = default)
        {
            List<Agenda> listadoDeAgendas = new List<Agenda>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SPC_AGENDA_GET", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id_Agenda", agenda.Id_Agenda);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listadoDeAgendas.Add(new Agenda()
                        {
                            Id_Agenda = int.Parse(dr["Id_Agenda"].ToString().Trim()),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Apellido = dr["Apellido"].ToString().Trim(),
                            Fecha_de_nacimiento = (dr["Fecha_de_nacimiento"].ToString().Trim()),
                            Direccion = dr["Direccion"].ToString().Trim(),
                            Genero = dr["Genero"].ToString().Trim(),
                            Estado_civil = dr["Estado_civil"].ToString().Trim(),
                            Movil = dr["Movil"].ToString().Trim(),
                            Telefono = dr["Telefono"].ToString().Trim(),
                            Correo_Electronico = dr["Correo_Electronico"].ToString().Trim()
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }

            return listadoDeAgendas;
        }

        public void PutToDB(Agenda agendaList, int opt)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SPC_AGENDA_PUT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id_Agenda", agendaList.Id_Agenda);
                    cmd.Parameters.AddWithValue("@Nombre", agendaList.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", agendaList.Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_de_nacimiento", agendaList.Fecha_de_nacimiento);
                    cmd.Parameters.AddWithValue("@Direccion", agendaList.Direccion);
                    cmd.Parameters.AddWithValue("@Genero", agendaList.Genero);
                    cmd.Parameters.AddWithValue("@Estado_civil", agendaList.Estado_civil);
                    cmd.Parameters.AddWithValue("@Movil", agendaList.Movil);
                    cmd.Parameters.AddWithValue("@Telefono", agendaList.Telefono);
                    cmd.Parameters.AddWithValue("@Correo_Electronico", agendaList.Correo_Electronico);
                    cmd.Parameters.AddWithValue("@OPT", opt);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }
        }

        public List<Agenda> LookAgenda(string param)
        {

            List<Agenda> listadoDeAgendas = new List<Agenda>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SPC_BUSCAR_GET", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@PARAM",param);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listadoDeAgendas.Add(new Agenda()
                        {
                            Id_Agenda = int.Parse(dr["Id_Agenda"].ToString().Trim()),
                            Nombre = dr["Nombre"].ToString().Trim(),
                            Apellido = dr["Apellido"].ToString().Trim(),
                            Fecha_de_nacimiento = (dr["Fecha_de_nacimiento"].ToString().Trim()),
                            Direccion = dr["Direccion"].ToString().Trim(),
                            Genero = dr["Genero"].ToString().Trim(),
                            Estado_civil = dr["Estado_civil"].ToString().Trim(),
                            Movil = dr["Movil"].ToString().Trim(),
                            Telefono = dr["Telefono"].ToString().Trim(),
                            Correo_Electronico = dr["Correo_Electronico"].ToString().Trim()
                        });
                    }
                    cmd.Dispose();
                }
                conn.Close();
            }

            return listadoDeAgendas;
        }
    }
}
