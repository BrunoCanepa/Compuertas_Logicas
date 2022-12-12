namespace LibraryTests;
/// <summary>
/// Clase de tests
/// </summary>
public class Tests
{
    LogicInput True = new LogicInput(true);
    LogicInput False = new LogicInput(false);
    /// <summary>
    /// Testea la clase CompuertaAND
    /// </summary>
    [Test]
    public void CompuertaAndTest()
    {        
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A", True);
        and1.AgregarEntrada("B", True);
        Assert.True(and1.Calcular());
        and1.AgregarEntrada("A", False);
        Assert.False(and1.Calcular());
        try
        {
            and1.AgregarEntrada("C", True);
            and1.Calcular();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
    }
    /// <summary>
    /// Testea la clase CompuertaO
    /// </summary>
    [Test]
    public void CompuertaOrTest()
    {
        CompuertaOR or1 = new CompuertaOR("OR-1");
        or1.AgregarEntrada("A", False);
        try
        {
            or1.Calcular();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
        or1.AgregarEntrada("B", True);
        Assert.True(or1.Calcular());

        or1.AgregarEntrada("B", False);
        Assert.False(or1.Calcular());        
    }
    /// <summary>
    /// Testea la clase CompuertaNOT
    /// </summary>
    [Test]
    public void CompuertaNotTest()
    {
        CompuertaNOT not1 = new CompuertaNOT("NOT-1");
        not1.AgregarEntrada("A", False);
        Assert.True(not1.Calcular());
        try
        {
            not1.AgregarEntrada("C", False);
            not1.Calcular();
            Assert.Fail();
        }
        catch(System.IndexOutOfRangeException)
        {
            Assert.Pass();
        }
    }
    /// <summary>
    /// Testea un circuito de AND, OR, NOT
    /// </summary>
    [Test]
    public void CircuitoTest()
    {
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A", True);
        and1.AgregarEntrada("B", True);
        Assert.True(and1.Calcular());

        CompuertaOR or2 = new CompuertaOR("OR-2");
        or2.AgregarEntrada("C", False);
        or2.AgregarEntrada(and1.Nombre, and1);
        Assert.True(or2.Calcular());

        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2);
        Assert.False(not3.Calcular());
    }    
}