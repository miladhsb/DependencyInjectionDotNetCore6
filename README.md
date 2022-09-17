روشهای تزریق وابستگی در دات نت کور 5 و 6 

روش های اضافه کردن سرویس به کانتینر دات نت کور
 //add generic class
 services.AddScoped(typeof(IList<>), typeof(List<>));
 //Scoped
 services.AddScoped(p => new HttpClient() { BaseAddress = new Uri("//") });
 //Singleton
 services.AddSingleton(p => new HttpClient() { BaseAddress = new Uri("//") });
 services.AddSingleton(new HttpClient() { BaseAddress = new Uri("//") });

 //add
 services.Add(new ServiceDescriptor(typeof(HttpClient),p=> new HttpClient() { BaseAddress = new Uri("//") }, ServiceLifetime.Scoped));
