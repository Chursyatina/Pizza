using DAL.Entities;
using System.Data.Entity;


namespace DAL.Context
{
    public class BaseContext: DbContext
    {
        private const string BaseName = "PIZZA";

        public BaseContext() : base(BaseName)
        {
            Database.SetInitializer(new PizzaInitializer());
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Cooker> Cooker { get; set; }
        public DbSet<DeliveryMan> DeliveryMan { get; set; }
        public DbSet<DoughType> DoughType { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Sauce> Sauce { get; set; }
        public DbSet<SizeType> SizeType { get; set; }
        public DbSet<Street> Street { get; set; }
        public DbSet<TypeOfIngredient> TypeOfIngredient { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Worker> Worker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Buyer>().ToTable("Buyers");
            modelBuilder.Entity<Cooker>().ToTable("Cookers");
            modelBuilder.Entity<DeliveryMan>().ToTable("DeliveryMen");
            modelBuilder.Entity<Pizza>().ToTable("Pizzas");
            modelBuilder.Entity<Sauce>().ToTable("Sauces");
            modelBuilder.Entity<Worker>().ToTable("Workers");
        }
    }
}
