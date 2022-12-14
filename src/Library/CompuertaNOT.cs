using System;
using System.Linq;
namespace Library;
/// <summary>
/// Compuerta NOT
/// </summary>
public class CompuertaNOT : Compuerta
{
    /// <summary>
    /// Constructor con un nombre para la compuerta
    /// </summary>
    /// <param name="nombre"></param>
    /// <returns></returns>
    public CompuertaNOT(string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta NOT y tira una excepción si no tiene una entrada
    /// </summary>
    /// <returns></returns>
    public override bool Calcular()
    {
        if (Entradas.Count != 1)
        {
            throw new CantidadDeEntradasException("La compuerta no tiene 1 entrada");
        }
        return !Entradas.First().Value.Calcular();
    }
}