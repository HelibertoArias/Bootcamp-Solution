using GenericsConsoleApp;
using GenericsConsoleApp.Entities;
using GenericsConsoleApp.Repositories;
using GenericsConsoleApp.SimpleStacks;

//var sss = new SimpleStackString();
//sss.Push("Hey");
//var last = sss.Pop();

//var sssint = new SimpleStackInt();
//sssint.Push(1);

//var ssso = new SimpleStackObject();
//ssso.Push("A");
//ssso.Push(1);
//ssso.Push(new DateTime());

//string l =(string) ssso.Pop();
//int number =(int) ssso.Pop();


//var gs = new GenericStack<string>();
//gs.Push("A");

//var gsint = new GenericStack<int>();
//gsint.Push(112);


//var pr = new ProductRepository();
//pr.Add(new Product { Id = 1, Name = "A" });
//pr.Save();

//var cr = new GenericRepository<Category>();
//cr.Add(new Category { Id = 2, Name = "Category" });
//cr.Save();

//var personRepository = new GenericRepository<Person>();
//personRepository.Add(new Person { Id = 2, Name = "Person" });
//personRepository.Save();

var cr = new CategoryRepository();
cr.Add(new Category { Name = "New repo", Id = 1 });
var category = cr.GetById(1);
cr.Save();



Console.ReadLine();
