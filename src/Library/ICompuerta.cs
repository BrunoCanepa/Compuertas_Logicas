namespace Library;
/// <summary>
/// Interface de compuertas
/// </summary>
public interface ICompuerta
{
    /// <summary>
    /// Método para agregar entradas o cambiar el valor a una ya existente
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="valor"></param>
    public void AgregarEntrada(string nombre, IInput valor);
    /// <summary>
    /// Calcula el valor de la compuerta en base a su/s entradas
    /// </summary>
    /// <returns></returns>
    public bool Calcular();
}