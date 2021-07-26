namespace CarWorld.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;

    using static GlobalConstants.GlobalConstants;

    public static class ApplicationDbContextExtension
    {
        private const string AdminId = "3dd43897-b531-464b-a3d4-b50b8c12ce0f";

        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            SeedAdministrator(services);
            SeedContextData(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<ApplicationDbContext>();

            data.Database.Migrate();
        }

        public static void SeedContextData(IServiceProvider services)
        {
            var context = services.GetRequiredService<ApplicationDbContext>();

            // Seeding car body types:
            if (!context.BodyTypes.Any())
            {
                context.BodyTypes.AddRange(
                new BodyType { Name = "Sedan", PictureUrl = "https://www.goodcarbadcar.net/wp-content/uploads/2020/10/gallery_cadenza_2020_exterior_1-scaled.jpg" },
                new BodyType { Name = "Coupe", PictureUrl = "https://images.hgmsites.net/lrg/alfa-romeo-giulia_100738410_l.jpg" },
                new BodyType { Name = "Sports car", PictureUrl = "https://www.telegraph.co.uk/content/dam/cars/2017/05/10/TELEMMGLPICT000128237971_trans_NvBQzQNjv4Bq6jM21ZOxtqmiTTuysRJN3xJbpU9egoStfMiMKpmBAs0.jpeg" },
                new BodyType { Name = "Station wagon", PictureUrl = "https://i.ytimg.com/vi/O9Msj2pdw_w/maxresdefault.jpg" },
                new BodyType { Name = "Hatchback", PictureUrl = "https://www.gannett-cdn.com/-mm-/38b2e6935d2caa4e96e963348fcbb385c228e98b/c=6-0-2994-1688/local/-/media/2017/05/28/USATODAY/USATODAY/636315278501076031-ChevroletCruzeHatch17.jpg?width=2988&height=1688&fit=crop&format=pjpg&auto=webp" },
                new BodyType { Name = "Convertible", PictureUrl = "https://media.ed.edmunds-media.com/maserati/granturismo-convertible/2018/oem/2018_maserati_granturismo-convertible_convertible_mc_fq_oem_1_1600.jpg" },
                new BodyType { Name = "SUV", PictureUrl = "https://autobild.bg/wp-content/uploads/2018/11/Die-besten-SUVs-gebraucht-TueV-Report-2019-1200x800-830e5afcc54c25ab.jpg" },
                new BodyType { Name = "Pickup truck", PictureUrl = "https://stmaaprodfwsite.blob.core.windows.net/assets/sites/1/2020/08/Nissan-Navara-Off-Roader-AT32-01.jpg" },
                new BodyType { Name = "Muscle car", PictureUrl = "https://automedia.investor.bg/media/files/resized/article/640x/281/8d1d2a9b8d5e6ab3fd99c1582a8b4281-2012-07-kndhdlvdqsfsmgr89xvf.jpg" }
                );
            }

            // Seeding cars:
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                // 5 sedans:
                new Car
                {
                    Make = new() { Name = "BMW" },
                    Model = new() { Name = "5 Series" },
                    BodyTypeId = 1,
                    Year = 2020,
                    Price = 53900,
                    AddedByUserId = AdminId,
                    Description = "The BMW 5 Series is an executive car manufactured by BMW since 1972. It is the successor to the New Class Sedans and is currently in its seventh generation. ... Since 1982, diesel engines have been included in the 5 Series range. The 5 Series is BMW's second best-selling model after the 3 Series.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://static.jutarnji.hr/images/live-multimedia/binary/2016/10/13/11/2017-BMW-5-Series-47.jpg" },
                        new Picture {Url = "https://www.carpixel.net/w/47cdb1da6d13238c99c8747f02172b9b/bmw-5-series-plug-in-hybrid-m-sport-car-wallpaper-99277.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Mercedes" },
                    Model = new() { Name = "C class" },
                    BodyTypeId = 1,
                    Year = 2020,
                    Price = 50000,
                    AddedByUserId = AdminId,
                    Description = "Highs Cabin is home to chic design and deluxe materials, base models come with a robust array of standard features. Lows Sedans offer a lot less cargo space than some rivals, base engine sounds coarse when pushed, certain rivals offer better fuel economy.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://carsguide-res.cloudinary.com/image/upload/f_auto%2Cfl_lossy%2Cq_auto%2Ct_default/v1/editorial/story/hero_image/Mercedes_CClass_2020_silver_1.jpg" },
                        new Picture {Url = "https://www.e-vesti.co.uk/media/2020/05/mercedes-c-class-saloon-blue.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Jaguar" },
                    Model = new() { Name = "xf" },
                    BodyTypeId = 1,
                    Year = 2021,
                    Price = 60000,
                    AddedByUserId = AdminId,
                    Description = "The facelifted XF has grown up substantially, with dynamics taking a back seat to comfort.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://cdni.autocarindia.com/ExtraImages/20201008062027_Jaguar-XF-2021-front-2.jpg" },
                        new Picture {Url = "https://www.stratstone.com/-/media/stratstone/jaguar/models/inline-images/xf/new-xf/jaguar-xf-saloon-rear-720x405px.ashx?mh=1440&la=en&h=405&w=720&mw=2560&hash=29EC3335C1F4536E261C0815D26FC9CE" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Toyota" },
                    Model = new() { Name = "Avensis" },
                    BodyTypeId = 1,
                    Year = 2018,
                    Price = 38000,
                    AddedByUserId = AdminId,
                    Description = "Thanks to its competitive price, low running costs, comfort, efficiency and reliability, the Avensis remains a favourite of company car owners and taxi drivers alike. It's certainly an accomplished machine, but it's one you buy with your head rather than your heart.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://i0.shbdn.com/photos/27/98/21/79427982154v.jpg" },
                        new Picture {Url = "https://www.cars-data.com/pictures/toyota/toyota-avensis_3535_2.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Volkswagen " },
                    Model = new() { Name = "Passat" },
                    BodyTypeId = 1,
                    Year = 2021,
                    Price = 35000,
                    AddedByUserId = AdminId,
                    Description = "The BMW 5 Series is an executive car manufactured by BMW since 1972. It is the successor to the New Class Sedans and is currently in its seventh generation. ... Since 1982, diesel engines have been included in the 5 Series range. The 5 Series is BMW's second best-selling model after the 3 Series.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.carpixel.net/w/8713d9162a2bfe1819b3c79921761247/volkswagen-passat-variant-r-line-car-wallpaper-104065.jpg" },
                        new Picture {Url = "https://media.ed.edmunds-media.com/volkswagen/passat/2021/oem/2021_volkswagen_passat_sedan_r-line_rq_oem_4_815.jpg" },
                    }
                },
                // 5 coupes:
                new Car
                {
                    Make = new() { Name = "Porshe" },
                    Model = new() { Name = "turbo s" },
                    BodyTypeId = 8,
                    Year = 2021,
                    Price = 67000,
                    AddedByUserId = AdminId,
                    Description = "Our engineers like to talk about the most perfect sports car ever. Incredible performance, whilst being comfortable and fully suitable for everyday use. The 911 Turbo models continue this philosophy.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-porsche-911-turbo-s-coupe-101-1586288365.jpg?crop=0.788xw:0.591xh;0.107xw,0.255xh&resize=1200:*" },
                        new Picture {Url = "https://autobild.bg/wp-content/uploads/2020/07/Porsche-911-Turbo-S-2020-PS-0-100-Beschleunigung-644x363-5c2e6f310227e6c4-1.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Mercedes" },
                    Model = new() { Name = "Cls" },
                    BodyTypeId = 8,
                    Year = 2008,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "The Mercedes-Benz CLS-Class is a series of executive cars produced by Mercedes-Benz since 2004. The original model was a four-door fastback sedan based on the Mercedes E-Class platform, marketed as a four door coupé. An estate (Shooting Brake) model was later added to the model range with the second generation CLS.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://images.squarespace-cdn.com/content/v1/5650b367e4b033f56d1fc966/1546460340923-AEQTEQ5PWLV1IJCCHX78/IMG_4623.JPG?format=1000w" },
                        new Picture {Url = "http://www.hongliyangzhi.com/manufacturers/mercedes-benz/mercedes-benz-cls/mercedes-benz-cls-2008/mercedes-benz-cls-2008-3.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "BMW" },
                    Model = new() { Name = "6 series" },
                    BodyTypeId = 8,
                    Year = 2016,
                    Price = 30000,
                    AddedByUserId = AdminId,
                    Description = "The BMW 6 Series is a range of grand tourers produced by BMW since 1976. It is the successor to the E9 Coupé and is currently in its fourth generation. ... The third generation F06/F12/F13 6 Series debuted in 2011 as a coupé and convertible, and added a four-door coupé body style (known as the Gran Coupé) in 2012.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://upload.wikimedia.org/wikipedia/commons/c/c5/2018_BMW_6er_Gran_Coupe_M_Sport%2C_F06.jpg" },
                        new Picture {Url = "https://static.cargurus.com/images/site/2015/07/20/16/43/2016_bmw_6_series-pic-3220892444914273125-1600x1200.jpeg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Ford" },
                    Model = new() { Name = "Mustang" },
                    BodyTypeId = 8,
                    Year = 2021,
                    Price = 45000,
                    AddedByUserId = AdminId,
                    Description = "For 2021, Ford has announced that it is resurrecting the Mach 1. The limited-edition model packs a 480-hp version of Ford's 5.0-liter V-8 that pairs with a six-speed manual or a 10-speed automatic transmission.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.focus2move.com/wp-content/uploads/2020/09/Ford-Mustang_Mach_1_EU-Version-2021-1024-05.jpg" },
                        new Picture {Url = "https://automedia.investor.bg/media/files/resized/article/640x/889/5128c65187b7b2cbdb8e54219c526889-1514961150-03-1.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Dodge" },
                    Model = new() { Name = "Challenger" },
                    BodyTypeId = 8,
                    Year = 2021,
                    Price = 500000,
                    AddedByUserId = AdminId,
                    Description = "The Dodge Challenger is the name of three different generations of automobiles (two of those being pony cars) produced by American automobile manufacturer Dodge. ... The second generation, from model years 1978 to 1983, was a badge engineered Mitsubishi Galant Lambda, a coupe version of an economical compact car.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://assets.flowfound.com/cars/2020/2020%20Dodge%20Challenger.jpg" },
                        new Picture {Url = "https://overtake-images.sfo2.digitaloceanspaces.com/2021/Dodge/Challenger/2021-dodge-challenger_1100x400.jpg" },
                    }
                },
                // 5 sports cars:
                new Car
                {
                    Make = new() { Name = "Mclaren" },
                    Model = new() { Name = "p1" },
                    BodyTypeId = 7,
                    Year = 2013,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "The McLaren P1 is a limited-production mid-engine plug-in hybrid sports car produced by British automobile manufacturer McLaren Automotive.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://motoluz.pl/wp-content/uploads/2021/05/first-customer-mclaren-p1-photo-by-silverstone-auctions_100790936_h.jpg" },
                        new Picture {Url = "https://dizzyriders.bg/uploads/avtomobili/04_2021/mclaren-p1-first-example-2.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Ferrari" },
                    Model = new() { Name = "Enzo" },
                    BodyTypeId = 7,
                    Year = 2002,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "Launched in 2002 for the 2003 model year, the Enzo had no such hurdles. The clean-sheet, pointy Formula 1-inspired design was an instant success, as was the naturally aspirated 6.0-liter V-12 mounted amidships",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://automedia.investor.bg/media/files/resized/uploadedfiles/640x0/a71/de988b05075acde3e7f45d6d5312ba71-fer-1.jpg" },
                        new Picture {Url = "https://www.carscoops.com/wp-content/uploads/2020/03/Ferrari-Enzo-For-Sale-2.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Buggati" },
                    Model = new() { Name = "Chiron" },
                    BodyTypeId = 7,
                    Year = 2016,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "The CHIRON is the fastest, most powerful, and exclusive production super sports car in BUGATTI's history. Its sophisticated design, innovative technology, and iconic, performance-oriented form make it a unique masterpiece of art, form and technique, that pushes boundaries beyond imagination.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://motor.ru/imgs/2017/01/19/15/207659/d4aaca7de983afc9967efb5520ea67da93cb7c7f.jpg" },
                        new Picture {Url = "https://auto.ironhorse.ru/wp-content/uploads/2016/11/Chiron-rear.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Lamborghini" },
                    Model = new() { Name = "Veneno" },
                    BodyTypeId = 7,
                    Year = 2013,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "The Lamborghini Veneno Roadster takes the aerodynamic efficiency of a racing prototype onto everyday roads. This super sports car is characterized by optimal aerodynamics in order to guarantee stability in fast curves and a behavior like a racing prototype. All of this on a car devised for the road.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/images/13q1/494260/lamborghini-veneno-photos-and-info-news-car-and-driver-photo-503364-s-original.jpg" },
                        new Picture {Url = "https://cdn.aquelamaquina.pt/images/2020-01/img_944x629$2020_01_21_19_29_29_176724.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Aston Martin" },
                    Model = new() { Name = "Vulcan" },
                    BodyTypeId = 7,
                    Year = 2015,
                    Price = 25000,
                    AddedByUserId = AdminId,
                    Description = "The Aston Martin Vulcan is a two-door, two-seat, high-performance lightweight track-only car launched in 2015 by British luxury automobile manufacturer Aston Martin at the 2015 Geneva Motor Show.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.carpixel.net/w/bd6e01d12692a37bd42996056518f204/aston-martin-vulcan-wallpaper-hd-33531.jpg" },
                        new Picture {Url = "https://i.iplsc.com/aston-martin-vulcan/0005414D0QTUTMM8-C122-F4.jpg" },
                    }
                },
                // 5 station wagons
                new Car
                {
                    Make = new() { Name = "Mercedes" },
                    Model = new() { Name = "E-Class Wagon" },
                    BodyTypeId = 6,
                    Year = 2020,
                    Price = 19000,
                    AddedByUserId = AdminId,
                    Description = "The 2020 E-class wagon combines elegance and practicality in a way that few luxury SUVs can match.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-mercedes-benz-e-class-wagon-mmp-1-1572027211.jpg?crop=0.609xw:0.541xh;0.196xw,0.269xh&resize=980:*" },
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/images/16q2/667719/2017-mercedes-benz-e-class-wagon-news-car-and-driver-photo-668790-s-original.jpg?fill=2:1&resize=1200:*" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Volvo" },
                    Model = new() { Name = "V60" },
                    BodyTypeId = 6,
                    Year = 2010,
                    Price = 21000,
                    AddedByUserId = AdminId,
                    Description = "The Volvo V60 is a compact luxury wagon produced by Volvo Cars related to the S60. The vehicle was first released in Autumn 2010, facelifted in 2014, and is in its second generation since 2018. ",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://media.caradvice.com.au/image/private/q_auto/v1619599274/yevj9lskklkxgxy6ut3b.jpg" },
                        new Picture {Url = "https://www.motortrend.com/uploads/sites/5/2019/11/2020-Volvo-V60-T5-AWD-Cross-Country-front-three-quarter-in-motion-1.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Audi" },
                    Model = new() { Name = "A4 Allroad" },
                    BodyTypeId = 6,
                    Year = 2013,
                    Price = 15000,
                    AddedByUserId = AdminId,
                    Description = "All 2013 Audi Allroad models are powered by a turbocharged 2.0-liter four-cylinder making 211 horsepower and 258 pound-feet of torque. The engine is coupled with an eight-speed automatic transmission with manual shift control and standard all-wheel drive.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.carpixel.net/w/53eee36218dc0096e5b7a3100acbf854/audi-a4-allroad-wallpaper-hd-86834.jpg" },
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTeqxgPbrlIkOlRUxnD5uKdb-ldjvGUDv0QA&usqp=CAU" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Porsche Panamera" },
                    Model = new() { Name = "Sport Turismo" },
                    BodyTypeId = 6,
                    Year = 2021,
                    Price = 30000,
                    AddedByUserId = AdminId,
                    Description = "To be more precise, the Sport Turismo is the long-roof version of the Porsche Panamera sedan. Both of these four-door hatchbacks boast an array of powerful powertrains, including plug-in-hybrid variants (called E-Hybrid) that prioritize performance over fuel savings.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://autobild.bg/wp-content/uploads/2020/02/h-r-porsche-panamera-granturismo-1.jpg" },
                        new Picture {Url = "http://i.auto-bild.de/ir_img/1/4/7/0/8/9/7/Porsche-Panamera-Sport-Turismo-2017-Alle-Infos-1200x800-9c42792eb787b046.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Buick" },
                    Model = new() { Name = "Regal TourX" },
                    BodyTypeId = 6,
                    Year = 2018,
                    Price = 18000,
                    AddedByUserId = AdminId,
                    Description = "The Buick Regal TourX is part of the sixth generation Regal that released in 2018. Following suit with others like the Subaru Outback or the Volkswagen Golf Alltrack, the Regal TourX has some rugged additions to its body and a suspension that lends a few inches more ground clearance than a sedan.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://static.cargurus.com/images/site/2018/07/11/21/02/2018_buick_regal_tourx_essence_awd-pic-3547104824963945030-1600x1200.jpeg" },
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTuurm1hMHEFmHJwJuEI33LSrikKGC2q6KMbtSPjGlQ8JuTDE0BXHyHAdGlbjdZ5z-ZFA&usqp=CAU" },
                    }
                },
                // 5 Hatchbacks
                new Car
                {
                    Make = new() { Name = "Volkswagen" },
                    Model = new() { Name = "Golf 8" },
                    BodyTypeId = 9,
                    Year = 2019,
                    Price = 15000,
                    AddedByUserId = AdminId,
                    Description = "The Volkswagen Golf (Mk8) (also known as the Golf VIII) is a compact car, the eighth generation of the Volkswagen Golf and the successor to the Volkswagen Golf Mk7. It was launched in Wolfsburg on 24 October 2019, and arrived in German showrooms in December 2019.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://automedia.investor.bg/media/files/resized/article/640x/0ca/34c57063fddbecfcecee01b904dff0ca-01-1.jpg" },
                        new Picture {Url = "https://cdn4.focus.bg/fakti/photos/original/360/volkswagen-golf-8-testvahme-go-parvi-3.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Honda" },
                    Model = new() { Name = "Civic Type R" },
                    BodyTypeId = 9,
                    Year = 2021,
                    Price = 16000,
                    AddedByUserId = AdminId,
                    Description = "The turbocharged and intercooled 2.0-liter VTEC® engine kicks out an exhilarating 306 horsepower* and 295 pound-feet of torque. * Wrapped in an iconic red cover, it's 70 years of Honda engineering for the track distilled into one Civic: the Type R.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-honda-civic-type-r-limited-edition-102-1582139131.jpg" },
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4FslwgLF0pS2EyjpanwJrwLXm4jVn-Zar3M8HkSGqya4DSiUNMRLJ4syqGa52CXR_cG4&usqp=CAU" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Toyota" },
                    Model = new() { Name = "Yaris SE" },
                    BodyTypeId = 9,
                    Year = 2021,
                    Price = 12000,
                    AddedByUserId = AdminId,
                    Description = "Yes, the Toyota Yaris is a good subcompact car. It is available in sedan and hatchback body styles. It boasts a stylish cabin, decent seating space, and lots of standard features, including a 7-inch touch screen, Apple CarPlay, and forward collision warning.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://t1-cms-4.images.toyota-europe.com/toyotaone/bgbg/Header_Cover_tcm-3039-1887120.jpg" },
                        new Picture {Url = "https://www.monitor.bg/web/files/richeditor/avtomobili/Toyota%20Yaris%20Cross%202.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Subaru" },
                    Model = new() { Name = "Impreza 5-Door" },
                    BodyTypeId = 9,
                    Year = 2021,
                    Price = 19500,
                    AddedByUserId = AdminId,
                    Description = "Includes these key features: Symmetrical All-Wheel Drive. SUBARU STARLINK® Multimedia with Apple CarPlay® and Android Auto™ Integration. Standard EyeSight® Driver Assist Technology.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.subaru.com/content/dam/subaru/vehicles/2021/IMP/vsp/features/1920/21_IMP_feature_02.jpg" },
                        new Picture {Url = "https://media.ed.edmunds-media.com/subaru/impreza/2020/oem/2020_subaru_impreza_4dr-hatchback_sport_fq_oem_1_1600.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Mazda" },
                    Model = new() { Name = "3 5-Door" },
                    BodyTypeId = 9,
                    Year = 2018,
                    Price = 13000,
                    AddedByUserId = AdminId,
                    Description = "Front-engine, front-wheel-drive or four-wheel-drive",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://cdn.carbuzz.com/gallery-images/2018-mazda-3-hatchback-carbuzz-348268.jpg" },
                        new Picture {Url = "https://media.ed.edmunds-media.com/mazda/3/2018/oem/2018_mazda_3_4dr-hatchback_grand-touring_fq_oem_8_500.jpg" },
                    }
                },
                // 5 convertibles
                new Car
                {
                    Make = new() { Name = "Porsche" },
                    Model = new() { Name = "718 Boxster" },
                    BodyTypeId = 4,
                    Year = 2021,
                    Price = 34000,
                    AddedByUserId = AdminId,
                    Description = "Step up to the naturally aspirated 3.0L boxer 6-cylinder producing either 394 horsepower (718 Boxster GTS 4.0) or 414 horsepower (718 Spyder). ... Porsche Torque Vectoring (PTV) is an optional system for enhancing driving dynamics and stability, helping to inspire confidence behind the wheel.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://images.hgmsites.net/hug/2021-porsche-718_100776543_h.jpg" },
                        new Picture {Url = "https://cdcssl.ibsrv.net/autodata/images/?IMG=USD10PRC021A01309.JPG&WIDTH=736" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "BMW" },
                    Model = new() { Name = "Z4" },
                    BodyTypeId = 4,
                    Year = 2020,
                    Price = 32000,
                    AddedByUserId = AdminId,
                    Description = "The first generation of the BMW Z4 consists of the BMW E85 (roadster version) and BMW E86 (coupe version) sports cars.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://mediapool.bmwgroup.com/cache/P9/201810/P90328289/P90328289-the-new-bmw-z4-m40i-roadster-in-color-frozen-grey-ii-metallic-and-19-m-light-alloy-wheels-double-spo-600px.jpg" },
                        new Picture {Url = "https://images.hgmsites.net/med/2019-bmw-z4-series_100693775_m.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Chevy" },
                    Model = new() { Name = "Camaro ZL1" },
                    BodyTypeId = 4,
                    Year = 2021,
                    Price = 35000,
                    AddedByUserId = AdminId,
                    Description = "With a fire-breathing 650-hp supercharged V-8 and ferocious track capabilities, the 2021 Chevy Camaro ZL1 is the king of monster muscle cars. ... Regardless, the Camaro perfects the front-engine, rear-drive formula inherent to muscle cars.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/images/17q1/674167/2017-chevrolet-camaro-zl1-convertible-first-drive-review-car-and-driver-photo-677704-s-original.jpg" },
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod/amv-prod-cad-assets/images/media/51/2017-chevrolet-camaro-zl1-convertible-inline1-photo-677733-s-original.jpg?resize=480:*" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Porsche" },
                    Model = new() { Name = "911" },
                    BodyTypeId = 4,
                    Year = 2019,
                    Price = 45000,
                    AddedByUserId = AdminId,
                    Description = "The Porsche 911 (pronounced Nine Eleven or in German: Neunelfer) is a two-door 2+2 high performance rear-engined sports car introduced in September 1964 by Porsche AG of Stuttgart, Germany. It has a rear-mounted flat-six engine and a torsion bar suspension.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-porsche-911-carrera-s-cabriolet-101-1551984630.jpg" },
                        new Picture {Url = "https://f7432d8eadcf865aa9d9-9c672a3a4ecaaacdf2fee3b3e6fd2716.ssl.cf3.rackcdn.com/C3423/U17/IMG_1606-large.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Mazda" },
                    Model = new() { Name = "MX-5 Miata" },
                    BodyTypeId = 4,
                    Year = 2021,
                    Price = 13000,
                    AddedByUserId = AdminId,
                    Description = "The Mazda MX-5 is a lightweight two-passenger roadster sports car manufactured and marketed by Mazda with a front mid-engine, rear-wheel-drive layout. ... The name miata derives from Old High German for reward.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://cdn.carbuzz.com/gallery-images/840x560/786000/400/786477.jpg" },
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQVfzeBzFYQdKRXK1f1fczv8CYIRpnBw-PpnFAx89gMsi9O7AWuOPkHxCcnRkZ82TZzvJM&usqp=CAU" },
                    }
                },
                // 5 SUVs
                new Car
                {
                    Make = new() { Name = "Mercedes" },
                    Model = new() { Name = "Gl" },
                    BodyTypeId = 3,
                    Year = 2021,
                    Price = 14000,
                    AddedByUserId = AdminId,
                    Description = "The Mercedes-Benz GLS-Class, formerly Mercedes-Benz GL-Class, is a full-size luxury SUV produced by Mercedes-Benz since 2006. ... It is a three-row, seven-passenger vehicle positioned above the GLE-Class (formerly Mercedes-Benz M-Class before 2016), and is the flagship of the Mercedes-Benz SUV line.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://i.pinimg.com/736x/3b/8b/fe/3b8bfede6a2e2c0b38e1264ae92d0bee.jpg" },
                        new Picture {Url = "https://cdn.carbuzz.com/gallery-images/840x560/715000/900/715959.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Toyota" },
                    Model = new() { Name = "Rav 4" },
                    BodyTypeId = 3,
                    Year = 2021,
                    Price = 13000,
                    AddedByUserId = AdminId,
                    Description = "The 2021 RAV4 uses a 203-hp 2.5-liter four-cylinder engine paired with an eight-speed automatic transmission. Front-wheel drive remains standard, but Toyota now offers a choice of all-wheel-drive systems, dependent on trim.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1CgMaPYCA1St6sSYCAtO1CsbddrMia2HQEg&usqp=CAU" },
                        new Picture {Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQm5Ki2_9hhJo8PTwvLqcxExHAzQX2yn6XSyQ&usqp=CAU" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "BMW" },
                    Model = new() { Name = "X5" },
                    BodyTypeId = 3,
                    Year = 2021,
                    Price = 45000,
                    AddedByUserId = AdminId,
                    Description = "The 2021 BMW X5 is a five- or seven-seat luxury crossover SUV that stands out even in BMW's family of exceptional vehicles. It's a utility wagon, a high-performance machine, a plug-in electric vehicle with 30 miles of range, and a luxury vehicle with a beautiful interior.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://suvwars.com/wp-content/uploads/2021/03/2021-Bmw-X5-review-midsize-luxury-suv-750x470.jpg" },
                        new Picture {Url = "https://media.ed.edmunds-media.com/bmw/x5/2021/oem/2021_bmw_x5_4dr-suv_xdrive45e_fq_oem_4_815.jpg" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Honda" },
                    Model = new() { Name = "CRV" },
                    BodyTypeId = 3,
                    Year = 2021,
                    Price = 35000,
                    AddedByUserId = AdminId,
                    Description = "The 2021 Honda CR-V comes in four trims: LX, EX, EX-L, and Touring. All models come standard with a turbocharged four-cylinder engine, a continuously variable automatic transmission (CVT), and front-wheel drive. All-wheel drive is optional in every trim for $1,500. We review the hybrid version of the CR-V separately.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://www.motortrend.com/uploads/sites/5/2020/08/2021-honda-cr-v-02.jpg" },
                        new Picture {Url = "https://pictures.dealer.com/h/highcountryhondaglenwoodsprings/1355/374517e4053f6831c7680e455c70a4a4x.jpg?impolicy=downsize&w=568" },
                    }
                },
                new Car
                {
                    Make = new() { Name = "Range Rover" },
                    Model = new() { Name = "Velar" },
                    BodyTypeId = 3,
                    Year = 2021,
                    Price = 23000,
                    AddedByUserId = AdminId,
                    Description = "New for 2021, Land Rover offers the Velar with two mild-hybrid optional turbocharged inline-six-cylinder engines, rated at 340 and 395 horsepower. These engines replace the 340- and 380-horsepower supercharged V6s that were discontinued. ... With the 395-horsepower engine, the Velar goes from zero to 60 mph in 5.2 seconds.",
                    Pictures = new HashSet<Picture>(){
                        new Picture {Url = "https://cdn-ds.com/stock/2021-Land-Rover-Range-Rover-Velar-P400-R-Dynamic-HSE-Redwood-City-CA/seo/VAMP8332JLRLR-SALYM2FUXMA311778/sz_63734/e47908f306a093808546653a713dd201.jpg" },
                        new Picture {Url = "https://content.homenetiol.com/2000292/2106293/0x0/bb188e33f54c4480aa9bbd27fd9a29f3.jpg" },
                    }
                }
                    );
            }

            // Seeding car shows:
            if (!context.Shows.Any())
            {
                context.Shows.AddRange(
                //3 shows:
                new Show
                {
                    AddedByUserId = AdminId,
                    Title = "Top Gear",
                    Description = "Top Gear is a British motoring magazine and factual television programme, designed as a relaunched version of the original 1977 show of the same name by Jeremy Clarkson and Andy Wilman for the BBC, and premiered on 20 October 2002. The programme focuses on the examination and reviewing of motor vehicles, primarily cars, though this was expanded upon after the broadcast of its earlier series to incorporate films featuring motoring-based challenges, special races, timed laps of notable cars, and celebrity timed laps on a course specially-designed for the relaunched programme. The programme drew acclaim for its visual and presentation style since its launch, which focused on being entertaining to viewers, as well as criticism over the controversial nature of its content. The programme was aired on BBC Two until it was moved to BBC One for its twenty-ninth series in 2020.",
                    CreatedOn = DateTime.Now,
                    ShowPictures = new HashSet<ShowPicture>()
                    {
                        new ShowPicture{Url ="https://static.wikia.nocookie.net/topgear/images/6/62/TG_S22_Promo_Image.jpg/revision/latest?cb=20200116225107"},
                        new ShowPicture{Url ="https://cdn.images.express.co.uk/img/dynamic/24/590x/jeremy-clarkson-top-gear-1395903.jpg?r=1613039285752"},
                        new ShowPicture{Url ="https://i.insider.com/5536a77feab8ea4f39678684?width=1000&format=jpeg&auto=webp"},
                        new ShowPicture{Url ="https://static.independent.co.uk/s3fs-public/thumbnails/image/2014/02/03/14/topgear1.jpg?width=1200&auto=webp&quality=75"},
                        new ShowPicture{Url ="https://images-na.ssl-images-amazon.com/images/I/81shAZiOuaL._RI_.jpg"},
                        new ShowPicture{Url ="https://i.insider.com/5536b78269bedd7b6b0b40e5?width=1200&format=jpeg"},
                    },
                    Videos = new HashSet<Video>()
                    {
                        new Video{UrlPath ="https://www.youtube.com/watch?v=lYg6yE5Q5VU&t=88s&ab_channel=VanInhalin"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=xsofZq2pxVA&t=302s&ab_channel=TopGear"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=Msb1cFuXoc0&t=339s&ab_channel=HellTor%C3%A9er2"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=tHqjmSTCw88&ab_channel=HellTor%C3%A9er2"},
                    }
                },
                new Show
                {
                    AddedByUserId = AdminId,
                    Title = "Roadkill",
                    Description = "Roadkill is an automotive-themed internet show produced by the MotorTrend Group. It is hosted by former Hot Rod Magazine editor-in-chief David Freiburger and former staff editor Mike Finnegan. The show was described as ... guys behaving badly with cars,",
                    CreatedOn = DateTime.Now,
                    ShowPictures = new HashSet<ShowPicture>()
                    {
                        new ShowPicture{Url ="https://cdn.hipwallpaper.com/i/96/4/hDAu5i.jpg"},
                        new ShowPicture{Url ="https://static1.hotcarsimages.com/wordpress/wp-content/uploads/2020/09/Roadkill-real-fake.jpg"},
                        new ShowPicture{Url ="https://images-na.ssl-images-amazon.com/images/I/91n+wHZi6OL._RI_.jpg"},
                        new ShowPicture{Url ="https://www.motortrend.com/uploads/sites/5/2020/07/038-Top-10-Roadkill-Cars-Blasphemi.jpg"},
                        new ShowPicture{Url ="https://external-preview.redd.it/BMNFQBe-Cfv5Kb1fGfZEFjvKj_0dZliLlHzCaqRmnDQ.jpg?auto=webp&s=fcdebb945b4523915b0a4aa72f5f3cbe37768ea7"},
                        new ShowPicture{Url ="https://www.legendarylist.com/wp-content/uploads/2015/05/watch-roadkill-guys-do-an-offroad-using-a-lowrider-monte-carlo.jpg"},
                    },
                    Videos = new HashSet<Video>()
                    {
                        new Video{UrlPath ="https://www.youtube.com/watch?v=0JXDcJQqZrA&ab_channel=MotorTrendChannel"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=PVs_xZ46Cxw&t=1200s&ab_channel=MotorTrendChannel"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=RKsGGBNMhFs&ab_channel=MotorTrendChannel"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=z0ish567ZgU&ab_channel=MotorTrendChannel"},
                    }

                },
                new Show
                {
                    AddedByUserId = AdminId,
                    Title = "Fast N' Loud",
                    Description = "Fast N' Loud was a reality-styled Discovery Channel TV show featuring Richard Rawlings and his crew from the Dallas, Texas-based Gas Monkey Garage as they search for tired and run-down cars, and restore them for profit.",
                    CreatedOn = DateTime.Now,
                    ShowPictures = new HashSet<ShowPicture>()
                    {
                        new ShowPicture{Url ="https://i.pinimg.com/originals/32/72/46/327246988cb3bd058a6803b9444e0632.jpg"},
                        new ShowPicture{Url ="https://static0.hotcarsimages.com/wordpress/wp-content/uploads/2021/02/fast-n-loud.jpg"},
                        new ShowPicture{Url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwG_Q2g6rxgHABw0izuOuJJILaWiS6OZ_FkQ&usqp=CAU"},
                        new ShowPicture{Url ="https://gasmonkeygarage.com/wp-content/themes/gasmonkeygarage/images/ShowPageheader.JPG"},
                        new ShowPicture{Url ="https://www.tvovermind.com/wp-content/uploads/2019/07/Fast-N-Loud.jpg"},
                        new ShowPicture{Url ="https://lh3.googleusercontent.com/proxy/JLZ-k0QqsoWs3w3tYWDfCcx8Zze7a5CNDXv7G44I5mwl-NcqlRRY4tLJ58ZmiVyesg6rK233I-T5ETV_X_v0RkfpXQ7dIDrrHJ0haLX6AskG"},
                    },
                    Videos = new HashSet<Video>()
                    {
                        new Video{UrlPath ="https://www.youtube.com/watch?v=3HUAIX2mD-U&ab_channel=DiscoveryUK"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=6IY55hUnQeI&ab_channel=GasMonkeyGarage%26RichardRawlings"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=484LXrhY1ZM&ab_channel=GasMonkeyGarage%26RichardRawlings"},
                        new Video{UrlPath ="https://www.youtube.com/watch?v=nNWflqXgQ4Q&ab_channel=Discovery"},
                    }
                }
                );
            }

            context.SaveChanges();
        }

        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministratorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@app.com";
                    const string adminPassword = "admin12app";

                    var user = new ApplicationUser
                    {
                        Id = AdminId,
                        Email = adminEmail,
                        UserName = adminEmail,
                        FirstName = "Admin",
                        LastName = "Admin"
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}
