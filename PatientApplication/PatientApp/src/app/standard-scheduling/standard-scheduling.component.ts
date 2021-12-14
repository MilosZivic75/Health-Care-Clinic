import { invalid } from '@angular/compiler/src/render3/view/util';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Doctor } from '../registration-form/doctor';
import { AppointmentService } from '../service/appointment.service';
import { IAppointment } from '../service/IAppointment';

@Component({
  selector: 'app-standard-scheduling',
  templateUrl: './standard-scheduling.component.html',
  styleUrls: ['./standard-scheduling.component.css']
})
export class StandardSchedulingComponent implements OnInit {
  
  

  appointmentModel : IAppointment = {
        id : 0,
        patientId : 0,
        doctorId : 0,
        roomId : 0,
        isCancelled : false,
        isDone : false,
        date: new Date(),
        surveyId : 0
  }

  patientId : number = 1;
  specializations : Array<string> = [];
  selectedSpecialty : string = '';
  doctors : Doctor[] = [];
  selectedDoctor : Doctor = {id: 0, name: "", surname: ""};
  selectedDate : Date = new Date();
  terms : string[] = [];
  selectedTerm : string = '';
  errorMessage : string  = '';
  today : Date;
  nextDisabled : boolean;

  firstFormGroup : FormGroup = this._formBuilder.group({
    firstCtrl: ['', Validators.required], });
  secondFormGroup: FormGroup = this._formBuilder.group({
    secondCtrl: ['', Validators.required], });
  thirdFormGroup : FormGroup = this._formBuilder.group({
    thirdCtrl: ['', Validators.required], });
  fourthFormGroup : FormGroup = this._formBuilder.group({
    fourthCtrl: ['', Validators.required], });

  constructor(private _formBuilder: FormBuilder, public _appointmentService : AppointmentService, private _snackBar: MatSnackBar) {
    this.today = new Date();
    this.nextDisabled = true;
   }

  ngOnInit(): void {
    
  }

  getAllSpecialties() {
    this._appointmentService.getAllSpecialties()
        .subscribe(specializations => this.specializations = specializations,
                    error => this.errorMessage = <any>error);
  }

  getDoctorsBySpecialty() {
    this._appointmentService.getDoctorsBySpecialty(this.selectedSpecialty)
        .subscribe(data => this.doctors = data,
                    error => this.errorMessage = <any>error);
  }

  getTermsForSelectedDoctor() {
    this._appointmentService.getTermsForSelectedDoctor(this.selectedDoctor.id, this.selectedDate)
        .subscribe(terms => this.terms = terms,
                    error => this.errorMessage = <any>error);
  }

  constructAppointment() {
    this.appointmentModel.patientId = this.patientId;
    this.appointmentModel.doctorId = this.selectedDoctor.id;
    this.appointmentModel.roomId = 3;
    this.appointmentModel.date = new Date(this.selectedTerm);
  }

  confirm() {
    this.constructAppointment();
    
    this._appointmentService.createAppointment(this.appointmentModel)
        .subscribe(
            data => console.log('Success!', data),
            error => console.log('Error!', error)
        )

    console.log(this.appointmentModel);    
    this._snackBar.open('Appointment successfully created!', 'Close', {duration: 3000});
  }

  enableNext() {
    this.nextDisabled = false;
  }
}
