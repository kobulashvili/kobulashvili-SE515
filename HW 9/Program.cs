namespace HW_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            CarsModel car = new ();

            string path = @"../../../carData.txt";

            string[] lines = File.ReadAllLines(path);


            CarsModel[] cModel = new CarsModel[lines.Length];


            int index = 0;


            foreach(string line in lines)
            {
               

                string[] parts = line.Split(",");


                CarsModel carsModel = new CarsModel();

                carsModel.Brand = parts[0];
                carsModel.Model = parts[1];
                carsModel.Year = int.Parse(parts[2]);
                carsModel.Mile = int.Parse(parts[3]);

                cModel[index] = carsModel;
                index++;
            }



            foreach(var item in cModel)
            {
                 
                Console.WriteLine (item);
            }

        }
    }





    class CarsModel
    {


        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private int mile;

        public int Mile
        {
            get { return mile; }
            set { mile = value; }
        }

        public void Show()
        {
            if (Mile == 0)
            {
                Console.WriteLine("It is new car");
            }
            else
            {
                Console.WriteLine("It is used car");
            }
        }

        public override string? ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Mile: {Mile}";
        }



    }





}
