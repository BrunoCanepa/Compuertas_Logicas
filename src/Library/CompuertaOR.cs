using System;
namespace Library;
/// <summary>
/// Compuerta OR
/// </summary>
public class CompuertaOR : Compuerta
{
    /// <summary>
    /// Constructor con un nombre para la compuerta
    /// </summary>
    /// <param name="nombre"></param>
    /// <returns></returns>
    public CompuertaOR(string nombre) : base(nombre)
    {

    }
    /// <summary>
    /// Devuelve el resultado de la compuerta OR y tira una excepción si no tiene dos entradas
    /// </summary>
    /// <returns></returns>
    public override bool Calcular()
    {
        if (Entradas.Count != 2)
        {
            throw new CantidadDeEntradasException("La compuerta no tiene 2 entradas");
        }
        foreach (var element in Entradas)
        {   
            if (element.Value.Calcular())
            {
                return true;
            }
        }
        return false;
    }
}