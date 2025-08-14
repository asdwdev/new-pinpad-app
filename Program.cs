var builder = WebApplication.CreateBuilder(args);

// Cache buat session
builder.Services.AddDistributedMemoryCache();

// Konfigurasi session cookie (HttpOnly, Secure)
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".NewPinpad.Session";
    options.Cookie.HttpOnly = true;
    // options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // wajib HTTPS di prod
    options.Cookie.SameSite = SameSiteMode.Lax;              // aman untuk form login
    options.IdleTimeout = TimeSpan.FromMinutes(60);          // auto-expire kalau idle
    options.Cookie.IsEssential = true;                       // biar gak keblokir consent
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseSession(); // harus sebelum app.MapControllers()

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
