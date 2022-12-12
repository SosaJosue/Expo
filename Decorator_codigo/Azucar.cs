class Azucar : Decorador
{
    public Azucar (Bebida bebida): base(bebida){}

    public override double Costo => _bebida.Costo + 0.25;
    public override string descripcion => string.Format($"{_bebida.descripcion}, con azucar");
}




