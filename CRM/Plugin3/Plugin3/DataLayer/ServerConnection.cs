using Microsoft.Xrm.Sdk;
using System;

namespace Plugin3.DataLayer
{
    public class ServerConnection : IDisposable
    {
        #region propiedades

        public IPluginExecutionContext Context;
        public IOrganizationServiceFactory Factory;
        public IOrganizationService Service;
        public ITracingService Trace;
        public IOrganizationService ServiceImpersonate;
        //public XrmContext xrmContext;

        #endregion

        bool _disposed = false;

        public ServerConnection(IServiceProvider serviceProvider)
        {
            Context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            Factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            Service = Factory.CreateOrganizationService(Context.UserId);
            Trace = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            //xrmContext = new XrmContext(service);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                //xrmContext.Dispose();
                Context = null;
                Service = null;
                Trace = null;
                Factory = null;
            }
            _disposed = true;
        }
    }
}
