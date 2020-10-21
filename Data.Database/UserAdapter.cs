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

        public Usuario GetUser(string userName) 
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from Users where userName = @username", SqlConn);
                cmdUsuario.Parameters.Add("@username", SqlDbType.Int).Value = userName;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
                {
                    usr.UserId = (int)drUsuario["userId"];
                    usr.UserName = (string)drUsuario["userName"];
                    usr.Wins = (int)drUsuario["winGames"];
                    usr.Losses = (int)drUsuario["lostGames"];

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

        public void InsertUser(Usuario usr) 
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("insert into Users(userName, winGames, lostGames) " +
                                                                "values (@userName, 0, 0)", SqlConn);
                cmdUsuario.Parameters.Add("@userName", SqlDbType.VarChar,50).Value = usr.UserName;

                usr.UserId = Decimal.ToInt32((decimal)cmdUsuario.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception exception = new Exception("Error al insertar el usuario "+usr.UserName, Ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void UpdateUser(Usuario usr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("update Users set userName=@userName, winGames=@win, lostGames=@lost" +
                                                                "where userId=@Id", SqlConn);
                cmdUsuario.Parameters.Add("@Id", SqlDbType.Int).Value = usr.UserId;
                cmdUsuario.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = usr.UserName;
                cmdUsuario.Parameters.Add("@win", SqlDbType.Int).Value = usr.Wins;
                cmdUsuario.Parameters.Add("@losses", SqlDbType.Int).Value = usr.Losses;

                cmdUsuario.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception exception = new Exception("Error al actualizar el usuario "+usr.UserName, Ex);
                throw exception;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }


}
