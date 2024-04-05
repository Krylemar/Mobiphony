namespace Mobiphony.Database
{
    using Mobiphony.Models;
    #region
    using System.IO.Pipelines;
    #endregion

    /// <summary></summary>
    public class DbInitializer
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------

        //-------------------------
        //Methods:
        //-------------------------
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            DatabaseContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();

            if (!context.Phones.Any())
            {
                context.AddRange
                (
                    new Phones() { Model = "huawei-p30-pro" }
                ); 
            }

            context.SaveChanges();
        }

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
