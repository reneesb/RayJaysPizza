using PizzaStore.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

List<PizzaDB> pizzas = new List<PizzaDB>
{
    new PizzaDB()
    {
        Id = 1,
        Name = "Montemagno, Pizza shaped like a great mountain",
    },

    new PizzaDB()
    {
        Id = 2,
        Name = "The Galloway, Pizza shaped like a submarine, silent but deadly",
    },

    new PizzaDB()
    {
        Id = 3,
        Name = "The Noring, Pizza shaped like a Viking helmet, where's the mead"
    }
};

app.UseHttpsRedirection();



app.Run();

