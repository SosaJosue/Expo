class Leche : Decorador
{
    public Leche (Bebida bebida): base(bebida){}

    public override double Costo => _bebida.Costo + 2;
    public override string descripcion => string.Format($"{_bebida.descripcion}, con leche");
}