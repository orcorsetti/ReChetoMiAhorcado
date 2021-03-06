﻿using Business_Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Logic
{
    public class UsuarioLogic
    {
        private UserAdapter _usrData;

        public UserAdapter UsrData { get => _usrData; set => _usrData = value; }

        public UsuarioLogic()
        {
            UsrData = new UserAdapter();
        }

        public UsuarioLogic(UserAdapter usrAdp)
        {
            UsrData = usrAdp;
        }

        public Usuario ActualizaCantidadesWL(Usuario usr,bool Gano)
        {
            if (Gano)
            {
                usr.Wins += 1;
            }
            else
            {
                usr.Losses += 1;
            }
            UsrData.UpdateUser(usr);

            return usr;
        }

        public List<Usuario> getTopTen()
        {
            List<Usuario> Users = UsrData.GetTopTen();

            return Users;
        }
        public Usuario getOne(string username) 
        {
            //trae usr
            return UsrData.GetUser(username);
        }

        public void CreateUser(Usuario usr)
        {
            UsrData.CreateUser(usr);
        }
    }
}
