using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.SessionState;
using CapaEntidades;

namespace CapaPresentacion.Custom
{
    public class SessionManager
    {
        #region variables

        private HttpSessionState _currentSession;

        #endregion

        public SessionManager(HttpSessionState session)
        {
            _currentSession = session;
        }

        #region metodos

        private HttpSessionState CurrentSession => _currentSession;

        public string UserSessionId
        {
            set => CurrentSession["UserSessionId"] = value;
            get => (string) CurrentSession["UserSessionId"];
        }


        public Cliente UserSessionCliente
        {
            set => CurrentSession["UserSessionCliente"] = value;
            get => (Cliente) CurrentSession["UserSessionCliente"];
        }

        public Usuario UserSessionUsuario
        {
            set => CurrentSession["UserSessionUsuario"] = value;
            get => (Usuario) CurrentSession["UserSessionUsuario"];
        }

        #endregion
    }
}