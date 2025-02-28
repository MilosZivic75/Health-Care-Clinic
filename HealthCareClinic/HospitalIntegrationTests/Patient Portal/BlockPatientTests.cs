﻿using Hospital.Mapper;
using Hospital.Medical_records.Repository;
using Hospital.Medical_records.Service;
using Hospital.Schedule.Model;
using Hospital.Shared_model.Model;
using Hospital.Shared_model.Repository;
using Hospital.Shared_model.Service;
using Hospital_API.Controller;
using Hospital_API.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HospitalIntegrationTests.Patient_portal
{
    public class BlockPatientTests
    {
        [Fact]
        public void Block_patient_by_id()
        {
            var options = CreateStubDatabase();

            using (var context = new HospitalDbContext(options))
            {
                DoctorRepository doctorRepository = new DoctorRepository(context);
                DoctorService doctorService = new DoctorService(doctorRepository);

                AllergenRepository allergenRepository = new AllergenRepository(context);
                AllergenService alergenService = new AllergenService(allergenRepository);

                PatientRepository patientRepository = new PatientRepository(context);
                PatientService patientService = new PatientService(patientRepository);

                PatientController patientController = new PatientController(alergenService, doctorService, patientService);

                OkObjectResult result = patientController.BlockPatientById(1) as OkObjectResult;
                PatientDTO blockedPatient = result.Value as PatientDTO;

                foreach (Doctor doctor in context.Doctors)
                {
                    context.Doctors.Remove(doctor);
                    context.SaveChanges();
                }

                foreach (Patient patient in context.Patients)
                {
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                }

                Assert.Equal(1, blockedPatient.Id);
                Assert.IsType<PatientDTO>(blockedPatient);
                Assert.True(blockedPatient.IsBlocked);
            }
        }


        [Fact]
        public void Get_all_suspicious_patients_which_are_not_blocked()
        {
            var options = CreateStubDatabase();

            using (var context = new HospitalDbContext(options))
            {
                DoctorRepository doctorRepository = new DoctorRepository(context);
                DoctorService doctorService = new DoctorService(doctorRepository);

                AllergenRepository allergenRepository = new AllergenRepository(context);
                AllergenService alergenService = new AllergenService(allergenRepository);

                PatientRepository patientRepository = new PatientRepository(context);
                PatientService patientService = new PatientService(patientRepository);

                PatientController patientController = new PatientController(alergenService, doctorService, patientService);

                OkObjectResult result = patientController.GetAllSuspiciousPatients() as OkObjectResult;
                List<PatientDTO> suspiciousPatients = result.Value as List<PatientDTO>;

                foreach (Doctor doctor in context.Doctors)
                {
                    context.Doctors.Remove(doctor);
                    context.SaveChanges();
                }

                foreach (Patient patient in context.Patients)
                {
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                }

                Assert.Single(suspiciousPatients);
                Assert.IsType<List<PatientDTO>>(suspiciousPatients);
            }
        }

        private DbContextOptions<HospitalDbContext> CreateStubDatabase()
        {
            var options = new DbContextOptionsBuilder<HospitalDbContext>()
             .UseInMemoryDatabase(databaseName: "Patients")
             .Options;

            using (var context = new HospitalDbContext(options))
            {

                List<Patient> doctors = new List<Patient>();

                Patient patient1 = new Patient(1, "Petar", "Petrovic", "male", "A", new System.DateTime(2005, 09, 11), "Bogoboja Atanackovica 15", "0634556665", "petar@gmail.com", "petar", "petar", "miki", null, "Employed", true)
                { DoctorId = 1 };
                Patient patient2 = new Patient(2, "Jovan", "Zoric", "male", "A", new System.DateTime(1985, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 2 };
                Patient patient3 = new Patient(3, "Zorana", "Bilic", "male", "A", new System.DateTime(1978, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 2 };
                Patient patient4 = new Patient(4, "Milica", "Maric", "male", "A", new System.DateTime(1969, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 3 };
                Patient patient5 = new Patient(5, "Igor", "Caric", "male", "A", new System.DateTime(1936, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 3 };
                Patient patient6 = new Patient(6, "Predrag", "Zaric", "male", "A", new System.DateTime(1975, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 3 };
                Patient patient7 = new Patient(7, "Miki", "Nikolic", "male", "A", new System.DateTime(1960, 07, 11), "Voje Rodica 19", "0697856665", "miki@gmail.com", "miki", "miki", "miki", null, "Employed", true)
                { DoctorId = 3 };
                //Patient patient8 = new Patient(8, "Zorka", "Djokic", "female", "B", new System.DateTime(1987, 07, 01), "Kralja Petra 19", "0697856665", "zorka@gmail.com", "zorka", "zorka", "zorka", null, "Unemployed", true)
                //{ DoctorId = 5 };

                Doctor doctor1 = new Doctor(1, "Nikola", "Nikolic", "male", new System.DateTime(1981, 05, 06), 80000.0, "Brace Radica 15", "0697856665", "nikolanikolic@gmail.com", "nikola", "nikola",
                     new System.DateTime(2021, 06, 10), null, "General medicine", 1);

                Doctor doctor2 = new Doctor(2, "Marko", "Radic", "male", new System.DateTime(1986, 04, 06), 80000.0, "Bogoboja Atanackovica 5", "0697856665", "markoradic@gmail.com", "marko", "marko",
                     new System.DateTime(2020, 06, 07), null, "General medicine", 2);

                Doctor doctor3 = new Doctor(3, "Jozef", "Sivc", "male", new System.DateTime(1971, 06, 09), 80000.0, "Bulevar Oslobodjenja 45", "0697856665", "jozika@gmail.com", "jozef", "jozef",
                     new System.DateTime(2011, 03, 10), null, "General medicine", 3);

                Doctor doctor4 = new Doctor(4, "Dragana", "Zoric", "female", new System.DateTime(1968, 01, 08), 80000.0, "Mike Antice 5", "0697856665", "dragana@gmail.com", "dragana", "dragana",
                     new System.DateTime(2015, 09, 11), null, "Surgery", 4);

                Doctor doctor5 = new Doctor(5, "Mile", "Grandic", "male", new System.DateTime(1978, 11, 07), 80000.0, "Pariske Komune 35", "0697856665", "mile@gmail.com", "mile", "mile",
                     new System.DateTime(2017, 08, 12), null, "Surgery", 4);


                context.Doctors.Add(doctor1);
                context.Doctors.Add(doctor2);
                context.Doctors.Add(doctor3);
                context.Doctors.Add(doctor4);
                context.Doctors.Add(doctor5);
                context.Patients.Add(patient1);
                context.Patients.Add(patient2);
                context.Patients.Add(patient3);
                context.Patients.Add(patient4);
                context.Patients.Add(patient5);
                context.Patients.Add(patient6);
                context.Patients.Add(patient7);
                context.CanceledAppointments.Add(new CanceledAppointment(new System.DateTime(2021, 12, 1), 1, 123));
                context.CanceledAppointments.Add(new CanceledAppointment(new System.DateTime(2021, 12, 3), 1, 124));
                context.CanceledAppointments.Add(new CanceledAppointment(new System.DateTime(2021, 12, 4), 1, 125));
                context.CanceledAppointments.Add(new CanceledAppointment(new System.DateTime(2021, 12, 1), 1, 126));
                //context.Patients.Add(patient8);
                context.SaveChanges();
            }

            return options;
        }    
    }
}
