namespace FluentProgramming_Demo
{
    public class Car
    {
        string Make = "Maruti";
        string Model = "Zen";

        private Car()
        {
        }

        public static Car BasicCar()
        {
            //Default values.
            return new Car();
        }

        public Car SetMake(string make)
        {
            this.Make = make;
            return this;
        }

        public Car SetModel(string model)
        {
            this.Model = model;
            return this;
        }

        public override string ToString()
        {
            return string.Join(' ', this.Make, this.Model);
        }

    }
}
