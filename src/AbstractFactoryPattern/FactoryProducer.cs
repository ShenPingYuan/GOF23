namespace AbstractFactoryPattern
{
    internal class FactoryProducer
    {
        public static AbstractFactory GetFactory<T>() where T : AbstractFactory
        {
            switch (typeof(T).Name)
            {
                case nameof(IColor):
                    return new ColorFactory();
                case nameof(IShape):
                    return new ShapeFactory();
                default:
                    break;
            }
            return null;
        }
    }
}
