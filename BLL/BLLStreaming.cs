using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BLLStreaming
    {
        private MPPStreaming  mpp;
        public BLLStreaming()
        {
            mpp = new MPPStreaming();
        }

        public List<BEStreaming> Traer()
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

        public void Alta(BEStreaming s)
        {
            try
            {
                mpp.Alta(s); 
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public abstract decimal Calcular(int duracion, string categoria);
    }
}
