using System;
using System.Runtime.InteropServices;

namespace ExtComp1C.AddIn
{
    [Guid("AB634001-F13D-11d0-A459-004095E1DAEA")]// стандартный GUID для IInitDone ссылка http://soaron.fromru.com/vkhints.htm
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInitDone
    {
        /// <summary>
        /// Инициализация компонента
        /// </summary>
        /// <param name="connection">reference to IDispatch</param>
        void Init(
            [MarshalAs(UnmanagedType.IDispatch)] object connection);

        /// <summary>
        /// Вызывается перед уничтожением компонента
        /// </summary>
        void Done();

        /// <summary>
        /// Возвращается инициализационная информация
        /// </summary>
        /// <param name="info">Component information</param>
        void GetInfo(
            [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] ref object[] info);
    }
}
