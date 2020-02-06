using System;
using System.Collections.Generic;
using Library;
//using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
//using Newtonsoft.Json;


namespace Collect_Day4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var test = new HelloWorld();
            //var helloLagi = new HelloLagi();
            //var helloWorldAgain = new HelloWorldAgain();

            //Console.WriteLine(test.SayName());
            //Console.WriteLine(helloLagi.sayNameLagi());
            //Console.WriteLine(helloWorldAgain.SayNameAgain());


            //var hello = new List<User>();
            //hello.Add(new User { email = "hello@hello.com", name = "myname" });
            //hello.Add(new User { email = "hello2@hello.com", name = "myname2" });
            //hello.ForEach(item =>
            //{
            //    Console.WriteLine(item);
            //});


            //var user1 = new User {
            //    name = "mia",
            //    username = "miahljnh"};
            //var user2 = JsonSerializer.Serialize(user1);
            //Console.WriteLine(user1.name);
            //Console.WriteLine(user1.username);

            //string json = File.ReadAllText(@"/Users/user/Projects/Collect_Day4/hello.json");
            //var beb = JsonConvert.DeserializeObject<User>(json);
            //Console.WriteLine(beb.email); //untuk 1 aja

            string json = File.ReadAllText(@"/Users/user/Projects/Collect_Day4/hello.json");
            var beb = JsonConvert.DeserializeObject<List<User>>(json);
            Console.WriteLine(beb[2].email);
        }
    }

    class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
    }
}
