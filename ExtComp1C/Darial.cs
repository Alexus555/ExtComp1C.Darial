using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime;
using ExtComp1C.AddIn;

namespace ExtComp1C
{


    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Darial : IInitDone
    {
        #region "Init"

        /// <summary>
        /// Инициализация компонента
        /// </summary>
        /// <param name="connection">reference to IDispatch</param>
        public void Init(
            [MarshalAs(UnmanagedType.IDispatch)] object connection)
        {
            //asyncEvent = (IAsyncEvent)connection;
            //statusLine = (IStatusLine)connection;
        }

        /// <summary>
        /// Возвращается информация о компоненте
        /// </summary>
        /// <param name="info">Component information</param>
        public void GetInfo(
            [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] info)
        {
            info[0] = 2000;
        }

        public void Done()
        {
        }

        #endregion


        /// <summary>
        /// Return component's name
        /// </summary>
        public string GetComponentName()
        {
            return "Darial";
        }



        
    }
}
