using System.Reflection.Metadata;

namespace homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Product product = new Product();

            product.Name = "Pizza";
            product.Price = 25;
            product.Spiciness = 4;
            product.Nuts = false;


            

            product.ImgSize();

            




        }


}



     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal _price;
        public decimal Price { get => _price;
            set { if (value >= 0) { 
                    _price = value;
                } 
            } 
        }
        public bool Nuts { get; set; }

        private string _image;
        public string Image { get => _image;
            set {  _image = value; }
        }
        public bool Vegeterian { get; set; }
        public int Spiciness { get; set; }
        public string Category { get; set; }




        public void ImgSize()
        {
            if (Image == null)
            {
                Console.WriteLine("can't open image");

            }

        }




     

     


    }


}
















//შექმენით პროდუქტის კლასი ქვემოთ მოცემული მახასიათებლების შესაბამისად. ასევე მოუფიქრეთ მეთოდები რომლებიც დაგვეხმარება პროდუქტთან სამუშაოდ.

//{
//    "id": 0,
//    "name": "string",
//    "price": 0,
//    "nuts": true,
//    "image": "string",
//    "vegeterian": true,
//    "spiciness": 0,
//    "category": "string"
//  }
