using CSTSDataAccess.DBAccess;

using CSTSWebAPI;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); //***********Original line. Commented for swagger***************

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISQLDataAccess, SQLDataAccess>();
builder.Services.AddSingleton<ITopicData, TopicData>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
 
  app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{ 
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseStaticFiles(); ***********Original line. Commented for swagger***************

//app.UseRouting(); ***********Original line. Commented for swagger***************

//app.UseAuthorization(); ***********Original line. Commented for swagger***************

app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.ConfigureApi();

app.Run();
