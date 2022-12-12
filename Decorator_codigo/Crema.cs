class Crema : Decorador
{
    public Crema (Bebida bebida): base(bebida){}

    public override double Costo => _bebida.Costo + 1.25;
    public override string descripcion => string.Format($"{_bebida.descripcion}, con crema");
}