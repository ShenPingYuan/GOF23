namespace AbstractFactoryPattern
{
    internal class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factoryType)
        {
            switch (factoryType.ToUpper())
            {
                case "COLORFACTORY":
                    return new ColorFactory();
                case "SHAPEFACTORY":
                    return new ShapeFactory();
                default:
                    break;
            }
            return null;
        }
    }
}
