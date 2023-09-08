using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        private MPPCliente mpp;
        public BLLCliente()
        {
            mpp = new MPPCliente();
        }

        public List<BECliente> Traer()
        {
            try
            {
                return mpp.Traer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alta(BECliente c)
        {
            try
            {
                mpp.Alta(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Baja(BECliente c)
        {
            try
            {
                mpp.Baja(c);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(BECliente c)
        {
            try
            {
                mpp.Modificar(c);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
