﻿using Hospital.Mapper;
using Hospital.Rooms_and_equipment.Repository;
using Hospital.Rooms_and_equipment.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace HospitalIntegrationTests.Graphical_editor
{
    public class SearchBuildingsTests
    {

        [Fact]
        public void Search_buildings_by_name()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<HospitalDbContext>();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("HospitalDbConnectionString"));
            var _context = new HospitalDbContext(optionsBuilder.Options);
            BuildingRepository buildingRepository = new BuildingRepository(_context);
            BuildingService buildingService = new BuildingService(buildingRepository);

            int numberOfSearchedBuildings = buildingService.GetSearchedBuildings("building2").Count;

            Assert.True(numberOfSearchedBuildings > 0);
        }
    }
}
