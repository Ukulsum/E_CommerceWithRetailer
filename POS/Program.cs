namespace POS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();


            //builder.Services.AddWebOptimizer(pipeline =>
            //{
            //    // CSS BUNDLE (MVC5: ~/Bundles/css)
            //    pipeline.AddCssBundle("/bundles/css",
            //        "Content/css/bootstrap.min.css",
            //        "Content/css/bootstrap-select.css",
            //        "Content/css/bootstrap-datepicker3.min.css",
            //        "Content/css/font-awesome.min.css",
            //        "Content/css/icheck/blue.min.css",
            //        "Content/css/AdminLTE.css",
            //        "Content/css/skins/skin-blue.css",
            //        "Content/css/jquery-ui.css"
            //    );

            //    // JS BUNDLE (MVC5: ~/Bundles/js)
            //    pipeline.AddJavaScriptBundle("/bundles/js",
            //        "Content/js/plugins/jquery/jquery-3.3.1.js",
            //        "Content/js/plugins/jquery/jquery-ui.js",
            //        "Content/js/plugins/bootstrap/bootstrap.js",
            //        "Content/jquery-ui.js",
            //        "Content/js/plugins/fastclick/fastclick.js",
            //        "Content/js/plugins/slimscroll/jquery.slimscroll.js",
            //        "Content/js/plugins/bootstrap-select/bootstrap-select.js",
            //        "Content/js/plugins/moment/moment.js",
            //        "Content/js/plugins/datepicker/bootstrap-datepicker.js",
            //        "Content/js/plugins/icheck/icheck.js",
            //        "Content/js/plugins/validator/validator.js",
            //        "Content/js/adminlte.js",
            //        "Content/js/init.js"
            //    );

            //    // THIRD PARTY CSS
            //    pipeline.AddCssBundle("/bundles/thirdPartyCss",
            //        "Content/DataTables/css/jquery.dataTables.min.css",
            //        "Content/DataTables/css/rowReorder.dataTables.css",
            //        "Content/DataTables/css/responsive.dataTables.css",
            //        "Content/jquery.fancybox.css",
            //        "Content/jquery-ui.css",
            //        "Content/toastr.css"
            //    );

            //    // THIRD PARTY JS
            //    pipeline.AddJavaScriptBundle("/bundles/thirdPartyjs",
            //        "Scripts/DataTables/jquery.dataTables.min.js",
            //        "Scripts/DataTables/dataTables.rowReorder.js",
            //        "Scripts/DataTables/dataTables.responsive.js",
            //        "Scripts/select2.js",
            //        "Scripts/toastr.js",
            //        "Scripts/bootbox.js",
            //        "Scripts/Site.js"
            //    );
            //});



            // HttpContext
            builder.Services.AddHttpContextAccessor();

            // Session services
            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession(); // 🔴 MUST

            app.UseAuthorization();


            app.MapControllers();

            //app.MapGet("/", () => "POS API Running...");
            app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
