using System;
namespace Library;
/// <summary>
/// Compuerta AND 
/// </summary>
public class CompuertaAND : Compuerta
{
    /// <summary>
    /// Constructor con un nombre para la compuerta
    /// </summary>
    /// <param name="nombre"></param>
    /// <returns></returns>
    public CompuertaAND(string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta AND, y tira una excepció si no tiene dos entradas.
    /// </summary>
    /// <returns></returns>
    public override bool Calcular()
    {
        if (Entradas.Count != 2)
        {
            throw new IndexOutOfRangeException("La compuerta no tiene 2 entradas");
        }
            foreach (var element in Entradas)
            {
                if (!element.Value.Calcular())
                {
                    return false;
                }
            }
            return true;
    }
}
