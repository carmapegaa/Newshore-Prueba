import { Component, OnInit } from '@angular/core';
import { ApiService } from '../service/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  ngOnInit(): void {

  }

  campoOrigen: string = '';
  campoDestino: string = '';
  camposIguales: boolean = false;
  data: object = {};
  dataFlight: any[] = [];
  origin: string = '';
  destination: string = '';
  price: number = 0;
  moneda: string = 'USD';

  constructor(private apiService: ApiService) { }


  llenarDatos(origen: string, destino: string) {
    this.apiService.getData(origen, destino).subscribe(data => {
      this.data = data;
      this.origin = data.origin;
      this.destination = data.destination;
      this.price = data.price;
      this.dataFlight = data.flights;
      console.log(this.data);
    })
  }

  compararCampo() {
    if (this.campoOrigen === this.campoDestino) {
      this.camposIguales = true;
    } else {
      this.camposIguales = false;
      this.llenarDatos(this.campoOrigen, this.campoDestino);
    }
  }

  OriMayus(valor: string) {
    this.campoOrigen = valor.toUpperCase().substring(0, 3);
  }

  DesMayus(valor: string) {
    this.campoDestino = valor.toUpperCase().substring(0, 3);
  }

  cambioMoneda(): number {
    switch (this.moneda) {
      case 'COP':
        return (this.price * 3901);
      case 'EUR':
        return this.price * 0.9132;
      default:
        return this.price;
    }
    
  }

  calcularPrecio(event: Event): void {
    const selectElement = event.target as HTMLSelectElement;
    if (selectElement && selectElement.value) {
      const divisaSeleccionada = selectElement.value;
      this.moneda = divisaSeleccionada;
    }
  }

}