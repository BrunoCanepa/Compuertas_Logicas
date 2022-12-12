namespace Library;
/// <summary>
/// Interface de entradas para que el diccionario pueda tomar un bool o una compuerta
/// </summary>
public interface IInput
{
    /// <summary>
    /// Devuelve el valor de la entrada
    /// </summary>
    /// <returns></returns>
    public bool Calcular();
}