 "ConnectionStrings": {
    "DefaultConnection": "Data Source=LEQUANGHAO\\SQLEXPRESS;Initial Catalog=DB_Test; Integrated Security=True"
  },

  builder.Services.AddDbContext<FashionShopDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
