// See https://aka.ms/new-console-template for more information
using Balta.ContentContext;
using Balta.SubscriptionContext;

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .Net", "dotnet"));

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspdotnet");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");

var carrerItem2 = new CarrerItem(2, "Aprenda OOP", "", null);
var carrerItem = new CarrerItem(1, "Comece por aqui", "", courseCsharp);
var carrerItem3 = new CarrerItem(3, "Aprenda .NET", "", courseAspNet);


careerDotNet.Items.Add(carrerItem2);
careerDotNet.Items.Add(carrerItem3);
careerDotNet.Items.Add(carrerItem);

careers.Add(careerDotNet);

var payPalSubscription = new PayPalSubscription();
var student = new Student();

student.CreateSubscription(payPalSubscription);

//------------------------------------------------------------------------------------------------

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
    Console.WriteLine("-------------------------");
}

Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.ELevel);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

