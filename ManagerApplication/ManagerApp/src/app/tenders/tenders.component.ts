import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Medicine } from '../model/medicine';
import { ITender } from '../model/tender';
import { TenderingServiceService } from '../services/tendering-service.service';

@Component({
  selector: 'app-tenders',
  templateUrl: './tenders.component.html',
  styleUrls: ['./tenders.component.css']
})
export class TendersComponent implements OnInit {

  public tenders: ITender[] = [];

  constructor(private _router: Router, private _tenderService: TenderingServiceService) { }

  ngOnInit(): void {
    this.getAllTenders();
  }

  getAllTenders(): void {
    this._tenderService.getAllTenders().subscribe(
      tenders => {
        this.tenders = tenders;
        this.tenders[0].offersNumber = 3;
      });
  }

  openCreateTenderComponent(): void {
    this._router.navigate(['create-tender']);
  }

}
