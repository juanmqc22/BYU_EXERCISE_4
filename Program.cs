
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
/// Author: Juan Quezada
/// Project of BYU
/// EXERCISE 4
/// *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
using System;
namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Street = new List<string>() { "Abbeville", "Birchbrook", "Candlebrook", "Chamberlain", "Dearborn" };
            List<string> City = new List<string>() { "Lehi", "West mort", "Hios", "Conect", "Salt lake" };
            List<string> State = new List<string>() { "Utah", "New york", "Illinois", "Las vegas", "Toronto" };
            List<string> Country = new List<string>() { "USA", "Brazil", "Bolivia", "Costa Rica", "Colombia", "Paraguay" };
            List<string> Description = new List<string>() { "This is an especial day!", "The most important day for me!", "We will eat a lot and sing!", "It's time to dance!" };
            List<string> Tittle = new List<string>() { "My birthday", "My wedding ", "A random day!", "The best day of my life" };
            List<string> Names = new List<string>() { "Miguel", "Bia", "Julia", "Jose", "Quezada", "Pedro", "Juan", "Manuel" };
            List<string> Emails = new List<string>() { "juanmsnufd@gmail.com", "Biamamama@gmail.com", "Julia@gmail.com", "Jose@gmail.com" };
            List<string> Weathers = new List<string>() { "Cold", "Sunny", "Windy", "rainy", "Stormy" };
            List<int> Capacities = new List<int>() { 50, 60, 70, 200, 500, 50, 150 };


            Lectures lecture_1 = new Lectures();
            Console.WriteLine("XXXXXXXXXX LECTURE EVENT XXXXXXXXXXXXXXX");
            lecture_1.Set_address(get_Address(Street, City, State, Country));
            lecture_1.Set_description(get_random(Description));
            lecture_1.Set_tittle(get_random(Tittle));
            lecture_1.Set_date();
            lecture_1.Set_speaker(get_random(Names));
            lecture_1.Set_capacity(get_random_capacity(Capacities));
            lecture_1.Standard_Messages();
            lecture_1.FullDetail_Messages();
            lecture_1.Short_Message();
            Receptions reception_1 = new Receptions();
            Console.WriteLine("XXXXXXXXXX RECEPTIONS EVENT XXXXXXXXXXXXXXX");
            reception_1.Set_address(get_Address(Street, City, State, Country));
            reception_1.Set_description(get_random(Description));
            reception_1.Set_tittle(get_random(Tittle));
            reception_1.Set_date();
            reception_1.Set_email(get_random(Emails));
            reception_1.Standard_Messages();
            reception_1.FullDetail_Messages();
            reception_1.Short_Message();
            Outdoors outdoor_1 = new Outdoors();
            Console.WriteLine("XXXXXXXXXX OUTDOORS EVENT XXXXXXXXXXXXXXX");
            outdoor_1.Set_address(get_Address(Street, City, State, Country));
            outdoor_1.Set_description(get_random(Description));
            outdoor_1.Set_tittle(get_random(Tittle));
            outdoor_1.Set_date();
            outdoor_1.Set_weather(get_random(Weathers));
            outdoor_1.Standard_Messages();
            outdoor_1.FullDetail_Messages();
            outdoor_1.Short_Message();



            string get_random(List<string> array)
            {
                var random = new Random();
                int randIndex = random.Next(array.Count);
                return array[randIndex];
            }
            int get_random_capacity(List<int> array)
            {
                var random = new Random();
                int randIndex = random.Next(array.Count);
                return array[randIndex];

            }
        }
    }
    class Activity
    {
        public int lenght = 0;
        public int minutes = 0;
        public DateTime date = new DateTime();
        string get_random(List<string> array)
        {
            var random = new Random();
            int randIndex = random.Next(array.Count);
            return array[randIndex];
        }
        int get_random_number()
        {
            var random = new Random();
            return random.Next(1000);
        }
        public void Set_length()
        {
            lenght = get_random_number();
        }
        public void Set_date()
        {
            date = RandomDay();
        }
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

    }

    class Running : Activity
    {
        public int distance = 0;
        public override void FullDetail_Messages()
        {
            base.FullDetail_Messages();
            Console.WriteLine($"\n -**-*-*-*-*-*-*- LECTURES EVENT *-*-*-*-*-*-*-*- ");
            Console.WriteLine($" Speaker: {speaker} ");
            Console.WriteLine($" Capacity: {capacity} ");
        }
        public override void Short_Message()
        {
            base.Short_Message();
            Console.WriteLine($"Type: LECTURE");
        }
        public void Set_speaker(string _speaker)
        {
            speaker = _speaker;
        }
        public void Set_capacity(int _capacity)
        {
            capacity = _capacity;
        }

    }
    class Cycling : Activity
    {
        private int speed = 0;
        public override void FullDetail_Messages()
        {
            base.FullDetail_Messages();
            Console.WriteLine($"\n *-*-*-*-*-*-*- RECEPTIONS EVENT *-*-*-*-*-*-*-*-");
            Console.WriteLine($" Email RSVP: {email} ");
        }
        public override void Short_Message()
        {
            base.Short_Message();
            Console.WriteLine($"Type: RECEPTIONS");
        }
        public void Set_email(string _email)
        {
            email = _email;
        }
    }
    class Swimming : Activity
    {
        private int numb_Laps = 0;
        public override void FullDetail_Messages()
        {
            base.FullDetail_Messages();
            Console.WriteLine($"\n *-*-*-*-*-*- OUTDOORS EVENT *-*-*-*-*-*-*-*-");
            Console.WriteLine($" Weather: {weather} ");
        }
        public override void Short_Message()
        {
            base.Short_Message();
            Console.WriteLine($"Type: OUTDOORS");
        }
        public void Set_weather(string _weather)
        {
            weather = _weather;
        }
    }
    class Address
    {
        private string street = "";
        private string city = "";
        private string state_province = "";
        private string country = "";

        public void Set_street(string _street)
        {
            street = _street;
        }
        public void Set_city(string _city)
        {
            city = _city;
        }
        public void Set_country(string _country)
        {
            country = _country;
        }
        public void Set_state(string _state)
        {
            state_province = _state;
        }
        public string Get_state()
        {
            string state_1 = state_province;
            return state_1;
        }
        public string Get_country()
        {
            string country_ = country;
            return country_;
        }
        public string Get_street()
        {
            string street_1 = street;
            return street_1;
        }
        public string Get_city()
        {
            string city_1 = city;
            return city_1;
        }
        public void display_address(Address address)
        {
            Console.WriteLine($"ADDRESS: ");
            Console.WriteLine($"   Country: {address.country}");
            Console.WriteLine($"   City: {address.city}");
            Console.WriteLine($"   State: {address.state_province}");
            Console.WriteLine($"   Street: {address.street}");
        }
    }
}
