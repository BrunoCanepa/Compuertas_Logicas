using System;
using System.Collections.Generic;
namespace Library;
/// <summary>
/// Clase madre de compuertas
/// </summary>
public abstract class Compuerta : IInput, ICompuerta
{
    /// <summary>
    /// Constructor de compuerta que recibe como parametro un nombre
    /// </summary>
    /// <param name="nombre"></param>
    public Compuerta(string nombre)
    {
        if (nombre == "" | nombre == null)
        {
            throw new ArgumentException("El nombre no debe estar vacío");
        }
        this.Nombre = nombre;
        this.Entradas = new Dictionary<string, IInput>();
    }
    
    /// <summary>
    /// Nombre de la compuerta
    /// </summary>
    /// <value></value>
    public string Nombre { get; set; }
    /// <summary>
    /// Diccionario que guarda cada nombre de compuerta con su valor
    /// </summary>
    /// <value></value>
    public Dictionary<string, IInput> Entradas { get; set; }
    /// <summary>
    /// Agrega una entrada con un nombre y un valor. Si el nombre ya existe, le cambia el valor a esa entrada.
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="valor"></param>
    public void AgregarEntrada(string nombre, IInput valor)
    {

        if (!Entradas.ContainsKey(nombre))
        {
            Entradas.Add(nombre, valor);
        }
        else 
        {
            Entradas[nombre] = valor;             
        }        
    }
    /// <summary>
    /// Método para conocer el valor de una compuerta
    /// </summary>
    /// <returns></returns>
    public abstract bool Calcular();
}