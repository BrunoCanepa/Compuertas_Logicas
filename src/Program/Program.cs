using System;
using Library;
/// <summary>
/// Programa principal
/// </summary>
public class Program
{
    /// <summary>
    /// Programa de un circuito lógico que imprime en consola en valor final
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        LogicInput True = new LogicInput(true);
        LogicInput False = new LogicInput(false);
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A", True);
        and1.AgregarEntrada("B", True);

        CompuertaOR or2 = new CompuertaOR("OR-2");
        or2.AgregarEntrada("C", False);
        or2.AgregarEntrada(and1.Nombre, and1);

        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2);
        Console.WriteLine(not3.Calcular());
    }
}