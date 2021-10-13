
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Week6ind.Data{

    public class SampleData {
  public static void Initialize(IApplicationBuilder app) { 
    using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope()) {
      var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
      context.Database.EnsureCreated();

      // Look for any Provinces.
      if (context.Provinces.Any()) {
          return;   // DB has already been seeded
      }

      var provinces = GetProvinces().ToArray();
      context.Provinces.AddRange(provinces);
      context.SaveChanges();

      var cities = GetCities(context).ToArray();
      context.Cities.AddRange(cities);
      context.SaveChanges();
    }
  }

    public static List<Province> GetProvinces() {
        List<Province> Provinces = new List<Province>() {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {
                ProvinceCode="CA",
                ProvinceName="California"
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario"
            },
        };

        return Provinces;
    }

    public static List<City> GetCities(ApplicationDbContext context) {


        List<City> Cities = new List<City>() {
            new City {
                CityName = "Langley",
                Population = 132300,
                ProvinceCode = context.Provinces.Find("BC").ProvinceCode,
            },
            new City {
                CityName = "Abbotsford",
                Population = 913423,
                ProvinceCode = context.Provinces.Find("BC").ProvinceCode,
            },
            new City {
                CityName = "Burnaby",
                Population = 214323,
                ProvinceCode = context.Provinces.Find("BC").ProvinceCode,
            },
            new City {
                CityName = "LosAngles",
                Population = 324129,
                ProvinceCode = context.Provinces.Find("CA").ProvinceCode,
            },new City {
                CityName = "SanJose",
                Population = 73100,
                ProvinceCode = context.Provinces.Find("CA").ProvinceCode,
            },new City {
                CityName = "Toronto",
                Population = 352134,
                ProvinceCode = context.Provinces.Find("ON").ProvinceCode,
            },new City {
                CityName = "SanFransisco",
                Population = 424141,
                ProvinceCode = context.Provinces.Find("CA").ProvinceCode,
            },new City {
                CityName = "Hamilton",
                Population = 413221,
                ProvinceCode = context.Provinces.Find("ON").ProvinceCode,
            },
            new City {
                CityName = "ThunderBay",
                Population = 892138,
                ProvinceCode = context.Provinces.Find("ON").ProvinceCode,
            },
        };

        return Cities;
    }
}
}