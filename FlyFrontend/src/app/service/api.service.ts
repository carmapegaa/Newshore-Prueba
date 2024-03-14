import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private PORT = '7228';
  private urlAPI = `https://localhost:${this.PORT}/api/Journey/Buscar`;


  constructor(private http: HttpClient) { }

  public getData(origen : string, destino: string): Observable<any> {
    var urlCompleta = `${this.urlAPI}?Origin=${origen}&Destination=${destino}`
    return this.http.get<any>(urlCompleta);
  }

 
}