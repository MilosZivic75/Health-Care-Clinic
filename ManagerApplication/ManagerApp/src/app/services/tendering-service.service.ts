import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ITender } from '../model/tender';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ITenderDTO } from '../dto/TenderDTO';

@Injectable({
  providedIn: 'root'
})
export class TenderingServiceService {
  private serverUrl: string = 'https://localhost:44360';

  constructor(private _http: HttpClient) { }

  getAllTenders(): Observable<ITender[]> {
    return this._http.get<ITender[]>("https://localhost:44360/api/tender");
  }

  createTender(tender: ITenderDTO) {
    let headers = new HttpHeaders();
    headers.append('Content-Type', 'application/json');
    return this._http.post<any>(this.serverUrl + "/api/tender", tender, {headers: headers});
  }

  getPharmacyNames(): Observable<string[]> {
    return this._http.get<string[]>("http://localhost:5000/api/tender/pharmacyNames");
  }

  getNumberOfWins(): Observable<number[]> {
    return this._http.get<number[]>("http://localhost:5000/api/tender/numberOfWins");
  }

  getNumberOfOffers(): Observable<number[]> {
    return this._http.get<number[]>("http://localhost:5000/api/tender/numberOfOffers");
  }

  getBestOffers(): Observable<number[]> {
    return this._http.get<number[]>("http://localhost:5000/api/tender/bestOffers");
  }
}
