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
            this._currentSession = session;
        }

        #region metodos
        private HttpSessionState CurrentSession
        {
            get { return this._currentSession; }
        }

        public string UserSessionId
        {
            set { CurrentSession["UserSessionId"] = value; }
            get { return (string)CurrentSession["UserSessionId"]; }
        }


        public Cliente UserSessionCliente
        {
            set { CurrentSession["UserSessionCliente"] = value; }
            get { return (Cliente)CurrentSession["UserSessionCliente"]; }
        }
        
        public Usuario UserSessionUsuario
        {
            set { CurrentSession["UserSessionUsuario"] = value; }
            get { return (Usuario)CurrentSession["UserSessionUsuario"]; }
        }

        #endregion
    }
}
