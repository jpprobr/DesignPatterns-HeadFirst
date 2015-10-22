
namespace AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new DoughThinCrust();
        }

        public Sauce CreateSauce()
        {
            return new SauceMarinara();
        }

        public Cheese CreateCheese()
        {
            return new CheeseReggiano();
        }

        public Veggie[] CreateVeggies()
        {
            Veggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new PepperoniSliced();
        }

        public Clam CreateClam()
        {
            return new ClamFresh();
        }
    }
}
