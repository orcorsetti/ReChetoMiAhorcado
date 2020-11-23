using Business_Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class UserAdapter : Adapter
    {

        public Usuario GetUser(string username) 
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from Usuarios where UserName = @username", SqlConn);
                cmdUsuario.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
                {
                    usr.UserId = (int)drUsuario["UserId"];
                    usr.UserName = (string)drUsuario["UserName"];
                    usr.Wins = (int)drUsuario["Wins"];
                    usr.Losses = (int)drUsuario["Losses"];

                    drUsuario.Close();
                }

                return usr;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el usuario", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void CreateUser(Usuario usr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("insert into Usuarios(UserName, Wins, Losses) " +
                                                                "values (@username, @wins, @losses) select @@identity", SqlConn);
                cmdUsuario.Parameters.Add("@userid", SqlDbType.Int).Value = usr.UserId;
                cmdUsuario.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = usr.UserName;
                cmdUsuario.Parameters.Add("@wins", SqlDbType.Int).Value = usr.Wins;
                cmdUsuario.Parameters.Add("@losses", SqlDbType.Int).Value = usr.Losses;

                usr.UserId = Decimal.ToInt32((decimal)cmdUsuario.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception exception = new Exception("Error al insertar el usuario " + usr.UserName, Ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<Usuario> GetTopTen()
        {
            List<Usuario> Users = new List<Usuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsers = new SqlCommand("SELECT TOP(10) * FROM Usuarios ORDER BY Wins DESC", SqlConn);
                SqlDataReader drUsers = cmdUsers.ExecuteReader();

                while (drUsers.Read())
                {
                    Usuario usr = new Usuario();

                    usr.UserName = (string)drUsers["UserName"];
                    usr.Wins = (int)drUsers["Wins"];

                    Users.Add(usr);
                }

                drUsers.Close();
            } catch (Exception ex)
            {
                Exception exception = new Exception("Error al recuperar el ranking de usuarios", ex);
                throw exception;
            } finally
            {
                this.CloseConnection();
            }

            return Users;
        }

        public void UpdateUser(Usuario usr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("update Usuarios set UserName = @username, Wins = @win, Losses = @lost where UserId = @id", SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = usr.UserId;
                cmdUsuario.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = usr.UserName;
                cmdUsuario.Parameters.Add("@win", SqlDbType.Int).Value = usr.Wins;
                cmdUsuario.Parameters.Add("@lost", SqlDbType.Int).Value = usr.Losses;

                cmdUsuario.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception exception = new Exception("Error al actualizar el usuario " + usr.UserName, Ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
