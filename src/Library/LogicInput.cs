namespace Library;
/// <summary>
/// Clase para simular un bool, dandole el tipo IInput
/// </summary>
public class LogicInput : IInput
{
    /// <summary>
    /// Constructor que asigna un valor a el LogicInput
    /// </summary>
    /// <param name="value"></param>
    public LogicInput(bool value)
    {
        this.Value = value;
    }
    /// <summary>
    /// Variable que guarda el valor true o false
    /// </summary>
    /// <value></value>
    public bool Value { get; set; }
    /// <summary>
    /// Retorna el v de la variable Value
    /// </summary>
    /// <returns></returns>
    public bool Calcular()
    {
        return this.Value;
    }
}