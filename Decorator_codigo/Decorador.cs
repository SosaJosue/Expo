public abstract class Decorador : Bebida{
    protected Bebida _bebida;

    public Decorador (Bebida bebida){
        _bebida = bebida;
    }
}