using System;
namespace System;
/// <summary>
/// Excepción para detectar una cantidad de entradas inválidas
/// </summary>
public class CantidadDeEntradasException : Exception
{
    /// <summary>
    /// Excepción para detectar una cantidad de entradas inválidas
    /// </summary>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    public CantidadDeEntradasException(string mensaje) : base(mensaje)
    {

    }
}